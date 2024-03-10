using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Client : ServiceObject
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        //constructor
        public Client(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void SendParcel(Parcel parcel, PostOffice postOfifce)
        {
            postOfifce.Parcels.Add(parcel);
            parcel.Send();

        }



    }

}
   
    
