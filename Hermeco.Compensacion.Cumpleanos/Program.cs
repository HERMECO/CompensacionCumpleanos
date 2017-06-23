using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            
            //Enviar correo
            foreach(var empleado in listEmpleadosCumpleHoy)
            {
                
            }
        }
    }
}
