using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Lab_2
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        

     

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            
          

            // read data from file
            List<string> parcelInfo = new List<string>();

            using (StreamReader reader = new StreamReader("D:\\Student\\Lab_2\\INFO.TXT"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    parcelInfo.Add(line);
                }
            }

            // Sorted data by date come
            List<string> sortedStudentInfo = parcelInfo.OrderBy(s =>
            {
                string[] parts = s.Split(',');
                if (parts.Length >= 3 && parts.Length < 4)
                {
                    return DateTime.ParseExact(parts[2].Trim(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                }
                else
                {
                    return DateTime.MaxValue;
                }
            }).ToList();

            string sortedInfo = string.Join(Environment.NewLine, sortedStudentInfo);

            MessageBox.Show("Parcels list:\n\n" + sortedInfo, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            //get data from field
            int weight = int.Parse(materialSingleLineTextField1.Text);
            DateTime dateSend = DateTime.Parse(materialSingleLineTextField2.Text);
            DateTime dateCome = DateTime.Parse(materialSingleLineTextField3.Text);
            decimal price = decimal.Parse(materialSingleLineTextField4.Text);






            //get data for writing
            string weightW = materialSingleLineTextField1.Text;
            string dateSendW = materialSingleLineTextField2.Text;
            string dateComeW = materialSingleLineTextField3.Text;
            string priceW = materialSingleLineTextField4.Text;

            //write inside text file
            using (StreamWriter writer = new StreamWriter("D:\\Student\\Lab_2\\INFO.TXT", true))
            {
                writer.WriteLine($" {weightW}, {dateSendW}, {dateComeW}, {priceW}");
            }
            
            // clear text boxes
            materialSingleLineTextField1.Clear();
            materialSingleLineTextField2.Clear();
            materialSingleLineTextField3.Clear();
            materialSingleLineTextField4.Clear();

            MessageBox.Show("Horay, parcel sended!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);




            //Create new object parcel
            Parcel parcel = new Parcel(weight, dateSend, dateCome, price);
            //Add parcel to office
            //PostOfifce.AddParcel(parcel);
            
           


        }
    }
}


