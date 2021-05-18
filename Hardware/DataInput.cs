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
    public partial class DataInput : Form
    {
        Hardlife context;
        public DataInput()
        {
            string[] combo = { "Monitor","Motherboard","CPU","GPU" };
            InitializeComponent();
            comboBox1.Items.AddRange(combo);
            comboBox1.DropDownStyle= ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 3;
            context = new Hardlife();
            label7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = context.CPUs.FirstOrDefault().Name;
            label7.Text = AddToBD(comboBox1.SelectedItem.ToString());
            label7.Visible = true;
        }

        private void display(string type)
        {   
            switch (type)
            {
                case "GPU":
                    displayAll();
                    displayGPU();
                    break;
                case "CPU":
                    displayAll();
                    displayCPU();
                    break;
                case "Monitor":
                    displayAll();
                    displayMn();
                    break;
                case "Motherboard":
                    displayAll();
                    displayMb();
                    break;
            }
        }

        private void displayAll()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
        }

        private void displayGPU()
        {
            label5.Text = "Name";
            label4.Text = "Power";
            label3.Text = "VGA";
            label2.Text = "Price";
            label1.Text = "HDMI";
            label6.Text = "DisplayPort";
        }
        private void displayCPU()
        {
            label5.Text = "Name";
            label4.Text = "Power";
            label3.Text = "Socket";
            label2.Text = "Price";
            label1.Visible = false;
            label6.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }
        private void displayMn()
        {
            label5.Text = "Name";
            label4.Text = "VGA";
            label3.Text = "HDMI";
            label2.Text = "Price";
            label1.Text = "DisplayPort";
            label6.Visible = false;
            textBox5.Visible = false;
        }
        private void displayMb()
        {
            label5.Text = "Name";
            label4.Text = "Power";
            label3.Text = "Socket";
            label2.Text = "Price";
            label1.Visible = false;
            label6.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textClear();
            display(comboBox1.SelectedItem.ToString());
            label7.Visible = false;
        }

        private string AddToBD(string type)
        {
            switch (type)
            {
                case "GPU":
                    return AddGPU();
                case "CPU":
                    return AddCPU();
                case "Monitor":
                    return AddMn();
                case "Motherboard":
                    return AddMb();
            }
            return null;
        }

        private string AddGPU()
        {
            var gpu = new GPUs();
            gpu.Name = textBox1.Text;
            gpu.Power = textBox2.Text;
            gpu.VGA = textBox3.Text;
            gpu.Price = (int)numericUpDown1.Value;
            gpu.HDMI = textBox4.Text;
            gpu.DisplayPort = textBox5.Text;
            try
            {
                context.GPUs.Add(gpu);
                context.SaveChanges();
                return ("Added to database");
            }
            catch
            {
                return ("smth went wrong");
            }
        }
        private string AddCPU()
        {
            var cpu = new CPUs();
            cpu.Name = textBox1.Text;
            cpu.power = textBox2.Text;
            cpu.Socket = textBox3.Text;
            cpu.Price = (int)numericUpDown1.Value;
            try
            {
                context.CPUs.Add(cpu);
                context.SaveChanges();
                return ("Added to database");
            }
            catch
            {
                return ("smth went wrong");
            }
        }
        private string AddMn()
        {
            var mn = new Monitors();
            mn.Name = textBox1.Text;
            mn.VGA = textBox2.Text;
            mn.HDMI = textBox3.Text;
            mn.Price = (int)numericUpDown1.Value;
            mn.DisplayPort = textBox4.Text;
            try
            {
                context.Monitors.Add(mn);
                context.SaveChanges();
                return ("Added to database");
            }
            catch
            {
                return ("smth went wrong");
            }
        }
        private string AddMb()
        {
            var mb = new Motherboards();
            mb.Name = textBox1.Text;
            mb.Power = textBox2.Text;
            mb.Socket = textBox3.Text;
            mb.Price = (int)numericUpDown1.Value;
            try
            {
                context.Motherboards.Add(mb);
                context.SaveChanges();
                return ("Added to database");
            }
            catch
            {
                return ("smth went wrong");
            }
        }

        private void textClear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            numericUpDown1.Value = 0;
        }
    }
}
