using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_2
{
    public class PostOffice : ServiceObject
    {
        public List<Parcel> Parcels { get; set; }
        // constructor
        public PostOffice()
        {
            Parcels = new List<Parcel>();
        }
        // add parcel to office
        public void AddParcel(Parcel parcel)
        {
            Parcels.Add(parcel);
        }



        // Indecsator for acess to parcel by index Індексатор для доступу до посилок за індексом
        public Parcel this[int index]
        {
            get { return Parcels[index]; }
            set { Parcels[index] = value; }
        }

        //Indecsator for acess to parcel by weight  Індексатор для доступу до посилок за вагою
        public Parcel this[int weight, DateTime dateSend]
        {
            get { return Parcels.FirstOrDefault(p => p.Weight == weight && p.DateSend == dateSend); }
        }



        // Lambda expression
        public void TestMethod()
        {
            Action lambda1 = () => { };
            Action lambda2 = () => { };
            Action lambda3 = () => { };
            Action lambda4 = () => { };
            Action lambda5 = () => { };
            Action lambda6 = () => { };

        }

    }
   
}
