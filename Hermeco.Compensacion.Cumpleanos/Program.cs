using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;

namespace Hermeco.Compensacion.Cumpleanos
{
    class Program
    {
        static void Main(string[] args)
        {

            EmpleadosSAP.EmpleadosSAPServiceClient client = new EmpleadosSAP.EmpleadosSAPServiceClient();

            Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse empleadosCumple = client.GetBirthdaysOfTheWeek();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-CO");

            var listEmpleadosCumpleHoy = empleadosCumple.EmployeeIntranet.Where(x => x.BirthDay.ToLower().Equals(DateTime.Now.ToString("dd MMMM").TrimStart('0').ToLower())).ToList();

            string fromEmail = ConfigurationManager.AppSettings["FromEmail"].ToString();
            string smtpServer = ConfigurationManager.AppSettings["SMTPServer"].ToString();
            string subject = string.Empty;
            //Enviar correo
            foreach (var empleado in listEmpleadosCumpleHoy)
            {
                try
                {
                    subject = string.Format("¡{0}, Feliz Cumpleaños te desea la familia OFFCORSS!", empleado.FirstName.Trim().Split(' ')[0]);
                    if (!string.IsNullOrEmpty(empleado.EMail))
                    {
                        Utility.sendEmail(smtpServer, subject, AppDomain.CurrentDomain.BaseDirectory + "\\Email\\Cumpleanos.html", "", fromEmail, empleado.EMail, "", true, "", null);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }
    }
}
