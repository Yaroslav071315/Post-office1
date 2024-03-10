using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Parcel : ServiceObject
    {
        public int Weight { get; set; }
        public DateTime DateSend { get; set; }
        public DateTime DateCome { get; set; }
        public decimal Price { get; set; }
        // parcel constructor

        public Parcel(int weight, DateTime dateSend, DateTime dateCome, decimal price)
        {
            Weight = weight;
            DateSend = dateSend;
            DateCome = dateCome;
            Price = price;
        }
        // method for sending parcel
        public void Send()
        {

        }

    }
}
