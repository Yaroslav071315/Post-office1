using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_2
{
    public class ServiceObject
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        // constructor ServiceObject
        public ServiceObject()
        {
            // Inicialize defalt data  Ініціалізуємо значення за замовчуванням
            CreatedAt = DateTime.Now;
            CreatedBy = Environment.UserName;
        }


        //use varius type of parameters

        public void ProcessData(int value, ref string message, params string[] additionalInfo)
        {
            //Creation instructions Реалізація методу
        }
    }
}
