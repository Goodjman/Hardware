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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            var page = new DataInput();
            page.Show();
            Hardlife context = new Hardlife();
            //context.CPUs.Add(new CPUs { Name = "Intel Z490", Socket = "LGA1200", Price = 300, power = "8pin" });
            //context.CPUs.Add(new CPUs { Name = "name", Socket = "socket", Price = 123 });
            ///// ...
            //context.CPUs.Add(new CPUs { Name = "name", Socket = "socket", Price = 123 });
            //context.SaveChanges();

           // dataGridView3.Rows.Add("Intel Z490", "8pin", "LGA1200", 300);
           // dataGridView3.Rows.Add("AMD B550", "6pin", "AM4", 200);
           // dataGridView3.Rows.Add("AMD X399", "8pin", "TR4", 100);
           // dataGridView3.Rows.Add("AMD A78", "6pin", "AM3", 500);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Info page = new Info();
            page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            View page = new View();
            page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage page = new Manage();
            page.Show();
        }
    }
}
