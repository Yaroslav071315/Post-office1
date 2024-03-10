using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class City : ServiceObject
    {
        public string Name { get; set; }
        public List<PostOffice> PostOffices { get; set; }

        public City(string name)
        {
            Name = name;
            PostOffices = new List<PostOffice>();
        }

        public void AddPostOffice(PostOffice postOffice)
        {
            PostOffices.Add(postOffice);
        }
    }
}
