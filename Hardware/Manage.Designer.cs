
namespace Hardware
{
    partial class Manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeviceIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPUs_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPUs_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monitors_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Device_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotherboardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.MotherBoard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSocket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.GName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_VGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_HDMI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_DisplayPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.M_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_VGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_HDMI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_DisplayPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "<- Выбор режима";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceIP,
            this.TotalPrice,
            this.CPUs_Name,
            this.GPUs_Name,
            this.Monitors_Name});
            this.dataGridView1.GridColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.Location = new System.Drawing.Point(635, 502);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 195);
            this.dataGridView1.TabIndex = 1;
            // 
            // DeviceIP
            // 
            this.DeviceIP.HeaderText = "DeviceIP";
            this.DeviceIP.Name = "DeviceIP";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // CPUs_Name
            // 
            this.CPUs_Name.HeaderText = "CPUs_Name";
            this.CPUs_Name.Name = "CPUs_Name";
            // 
            // GPUs_Name
            // 
            this.GPUs_Name.HeaderText = "GPUs_Name";
            this.GPUs_Name.Name = "GPUs_Name";
            // 
            // Monitors_Name
            // 
            this.Monitors_Name.HeaderText = "Monitors_Name";
            this.Monitors_Name.Name = "Monitors_Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Компьютеры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Добавить конфигурацию";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(546, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Мониторы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Материнские платы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(522, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Видеокарты";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(38, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Процессоры";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Device_IP,
            this.MotherboardName,
            this.CPU,
            this.GPU,
            this.Monitor});
            this.dataGridView2.Location = new System.Drawing.Point(42, 536);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(544, 161);
            this.dataGridView2.TabIndex = 8;
            // 
            // Device_IP
            // 
            this.Device_IP.HeaderText = "Device_IP";
            this.Device_IP.Name = "Device_IP";
            // 
            // MotherboardName
            // 
            this.MotherboardName.HeaderText = "MotherboardName";
            this.MotherboardName.Name = "MotherboardName";
            // 
            // CPU
            // 
            this.CPU.HeaderText = "CPU";
            this.CPU.Name = "CPU";
            // 
            // GPU
            // 
            this.GPU.HeaderText = "GPU";
            this.GPU.Name = "GPU";
            // 
            // Monitor
            // 
            this.Monitor.HeaderText = "Monitor";
            this.Monitor.Name = "Monitor";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MotherBoard,
            this.Power,
            this.Socket,
            this.Price});
            this.dataGridView3.Location = new System.Drawing.Point(42, 124);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(443, 135);
            this.dataGridView3.TabIndex = 9;
            // 
            // MotherBoard
            // 
            this.MotherBoard.HeaderText = "MotherBoard";
            this.MotherBoard.Name = "MotherBoard";
            // 
            // Power
            // 
            this.Power.HeaderText = "Power";
            this.Power.Name = "Power";
            // 
            // Socket
            // 
            this.Socket.HeaderText = "Socket";
            this.Socket.Name = "Socket";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.CSocket,
            this.CPrice});
            this.dataGridView4.Location = new System.Drawing.Point(42, 332);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(343, 126);
            this.dataGridView4.TabIndex = 10;
            // 
            // CName
            // 
            this.CName.HeaderText = "CName";
            this.CName.Name = "CName";
            // 
            // CSocket
            // 
            this.CSocket.HeaderText = "CSocket";
            this.CSocket.Name = "CSocket";
            // 
            // CPrice
            // 
            this.CPrice.HeaderText = "CPrice";
            this.CPrice.Name = "CPrice";
            // 
            // dataGridView5
            // 
            this.dataGridView5.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GName,
            this.GPower,
            this.GPrice,
            this.G_VGA,
            this.G_HDMI,
            this.G_DisplayPort});
            this.dataGridView5.Location = new System.Drawing.Point(526, 65);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(643, 152);
            this.dataGridView5.TabIndex = 11;
            // 
            // GName
            // 
            this.GName.HeaderText = "GName";
            this.GName.Name = "GName";
            // 
            // GPower
            // 
            this.GPower.HeaderText = "GPower";
            this.GPower.Name = "GPower";
            // 
            // GPrice
            // 
            this.GPrice.HeaderText = "GPrice";
            this.GPrice.Name = "GPrice";
            // 
            // G_VGA
            // 
            this.G_VGA.HeaderText = "G_VGA";
            this.G_VGA.Name = "G_VGA";
            // 
            // G_HDMI
            // 
            this.G_HDMI.HeaderText = "G_HDMI";
            this.G_HDMI.Name = "G_HDMI";
            // 
            // G_DisplayPort
            // 
            this.G_DisplayPort.HeaderText = "G_DisplayPort";
            this.G_DisplayPort.Name = "G_DisplayPort";
            // 
            // dataGridView6
            // 
            this.dataGridView6.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M_Name,
            this.M_VGA,
            this.M_HDMI,
            this.M_DisplayPort,
            this.M_Price});
            this.dataGridView6.Location = new System.Drawing.Point(550, 291);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(543, 151);
            this.dataGridView6.TabIndex = 12;
            // 
            // M_Name
            // 
            this.M_Name.HeaderText = "M_Name";
            this.M_Name.Name = "M_Name";
            // 
            // M_VGA
            // 
            this.M_VGA.HeaderText = "M_VGA";
            this.M_VGA.Name = "M_VGA";
            // 
            // M_HDMI
            // 
            this.M_HDMI.HeaderText = "M_HDMI";
            this.M_HDMI.Name = "M_HDMI";
            // 
            // M_DisplayPort
            // 
            this.M_DisplayPort.HeaderText = "M_DisplayPort";
            this.M_DisplayPort.Name = "M_DisplayPort";
            // 
            // M_Price
            // 
            this.M_Price.HeaderText = "M_Price";
            this.M_Price.Name = "M_Price";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(231, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 55);
            this.button2.TabIndex = 13;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPUs_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPUs_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monitors_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device_IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotherboardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monitor;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotherBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSocket;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrice;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn GName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_VGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_HDMI;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_DisplayPort;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_VGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_HDMI;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_DisplayPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Price;
        private System.Windows.Forms.Button button2;
    }
}