using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



            //Create array pointers on objects Створюємо масив вказівників на об'єкти класів
            object[] objects = new object[3];

            //Create objects Створюємо об'єкти класів
            Parcel parcel = new Parcel(10, DateTime.Now, DateTime.Now.AddDays(3), 100);
            PostOffice postOffice = new PostOffice();
            Client client = new Client("Іван", "Петров");

            //Add pointers to array Додаємо вказівники на об'єкти до масиву
            objects[0] = parcel;
            objects[1] = postOffice;
            objects[2] = client;


        }
    }


    //public class ServiceObject
    //{
    //    public int Id { get; set; }
    //    public DateTime CreatedAt { get; set; }
    //    public string CreatedBy { get; set; }

    //    // constructor ServiceObject
    //    public ServiceObject()
    //    {
    //        // Inicialize defalt data  Ініціалізуємо значення за замовчуванням
    //        CreatedAt = DateTime.Now;
    //        CreatedBy = Environment.UserName;
    //    }
    //}

     //public class Parcel : ServiceObject
     //{
     //   public int Weight { get; set; }
     //   public DateTime DateSend { get; set; }
     //   public DateTime DateCome { get; set; }
     //   public decimal Price { get; set; }
     //   // parcel constructor

     //   public Parcel(int weight, DateTime dateSend, DateTime dateCome, decimal price)
     //   {
     //       Weight = weight;
     //       DateSend = dateSend;
     //       DateCome = dateCome;
     //       Price = price;
     //   }
     //   // method for sending parcel
     //   public void Send()
     //   {

     //   }
     //}
    //public class City : ServiceObject
    //{
    //    public string Name { get; set; }
    //    public List<PostOffice> PostOffices { get; set; }

    //    public City(string name)
    //    {
    //        Name = name;
    //        PostOffices = new List<PostOffice>();
    //    }

    //    public void AddPostOffice(PostOffice postOffice)
    //    {
    //        PostOffices.Add(postOffice);
    //    }
    //}


    //public class PostOffice : ServiceObject
    //{
    //        public List<Parcel> Parcels { get; set; }
    //        // constructor
    //        public PostOffice()
    //        {
    //            Parcels = new List<Parcel>();
    //        }
    //        // add parcel to office
    //        public void AddParcel(Parcel parcel)
    //        {
    //            Parcels.Add(parcel);
    //        }

    //    }
//    public class Client : ServiceObject
//    {
//            public string Name { get; set; }
//            public string Surname { get; set; }

//            //constructor
//            public Client(string name, string surname)
//            {
//                Name = name;
//                Surname = surname;
//            }

//        public void SendParcel(Parcel parcel, PostOffice postOfifce  )
//        {
//            postOfifce.Parcels.Add(parcel);
//            parcel.Send();

//        }



//        }
    
}
    