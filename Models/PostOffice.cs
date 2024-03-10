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

    }
}
