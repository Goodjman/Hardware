using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("172.20.10.14", 800, "Intel Core i5-10500", "GeForce RTX 3060 Ti", "HP 24f");
            dataGridView1.Rows.Add("172.20.10.15", 500, "", "GeForce GTX 1050 Ti", "Xiaomi Mi Surface Display 34");
            dataGridView1.Rows.Add("172.20.10.16", 410, "Intel Pentium Gold G6400", "", "HP 24f");
            dataGridView1.Rows.Add("172.20.10.17", 340, "AMD Ryzen 5 5600X", "GeForce RTX 3060 Ti", "LG 27MP59G-P");//computers
            dataGridView1.Rows.Add("172.20.10.18", 1550, "AMD Ryzen Threadripper 1900X", "FirePro S9150", "BenQ BL2420PT");
            dataGridView1.Rows.Add("172.20.10.19", 270, "", "", "HP 24f");

            dataGridView3.Rows.Add("Intel Z490", "8pin", "LGA1200", 300);  //cpu
            dataGridView3.Rows.Add("AMD B550", "6pin", "AM4", 200);
            dataGridView3.Rows.Add("AMD X399", "8pin", "TR4", 100);
            dataGridView3.Rows.Add("AMD A78", "6pin", "AM3", 500);

            dataGridView5.Rows.Add("Radeon 9000 S-Media", "8pin",65, "Yes", "No", "No");
            dataGridView5.Rows.Add("GeForce RTX 3060 Ti", "8pin", 700, "No", "Yes", "Yes");
            dataGridView5.Rows.Add("GeForce GTX 1650 Super", "6pin", 200, "Yes", "No", "No");
            dataGridView5.Rows.Add("Radeon RX 470", "6pin", 150, "No", "Yes", "Yes");
            dataGridView5.Rows.Add("GeForce 9800 GT", "8pin", 15, "Yes", "Yes", "No");
            dataGridView5.Rows.Add("FirePro S9150", "6+8pin", 1500, "Yes", "Yes", "Yes");  // gpu
            dataGridView5.Rows.Add("GeForce 310M", "8pin", 150, "Yes", "No", "No");
            dataGridView5.Rows.Add("Radeon HD 5000", "Soldered", 60, "Yes", "Yes", "No");
            dataGridView5.Rows.Add("GeForce GTX 1050 Ti", "8pin", 150, "No", "Yes", "Yes");

            dataGridView4.Rows.Add("Intel Core i5-10500", "LGA1200",  200);
            dataGridView4.Rows.Add("Intel Pentium Gold G6400", "LGA1200", 60);
            dataGridView4.Rows.Add("AMD Ryzen 5 5600X", "AM4", 400);
            dataGridView4.Rows.Add("AMD Ryzen Threadripper 1900X", "TR4", 250);


            
            dataGridView6.Rows.Add("HP 24f", "Yes", "Yes", "No", 150);
            dataGridView6.Rows.Add("Xiaomi Mi Surface Display 34", "No", "Yes", "Yes", 500);   // monitors
            dataGridView6.Rows.Add("LG 27MP59G-P", "Yes", "Yes", "Yes", 160);
            dataGridView6.Rows.Add("BenQ BL2420PT", "Yes", "Yes", "Yes", 150);

            dataGridView2.Rows.Add("172.20.10.14", "B450 S2H", "AMD Ryzen 3 3200G with Radeon Vega Graphics", "AMD Radeon(TM) Vega 8 Graphics", "DELL U2413(HDMI)");
            //config







        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main page = new Main();
            page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Успешно Сохранено!");
        }
    }
}
