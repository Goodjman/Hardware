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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
           dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           dataGridView1.AllowUserToAddRows = false;

           
            dataGridView1.Rows.Add("172.20.10.14", 800, "Intel Core i5-10500", "GeForce RTX 3060 Ti", "HP 24f");
            dataGridView1.Rows.Add("172.20.10.15", 500, "", "GeForce GTX 1050 Ti", "Xiaomi Mi Surface Display 34");
            dataGridView1.Rows.Add("172.20.10.16", 410, "Intel Pentium Gold G6400", "", "HP 24f");
            dataGridView1.Rows.Add("172.20.10.17", 340, "AMD Ryzen 5 5600X", "GeForce RTX 3060 Ti", "LG 27MP59G-P");
            dataGridView1.Rows.Add("172.20.10.18", 1550, "AMD Ryzen Threadripper 1900X", "FirePro S9150", "BenQ BL2420PT");
            dataGridView1.Rows.Add("172.20.10.19", 270, "", "", "HP 24f");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main page = new Main();
            page.Show();
        }
    }
}
