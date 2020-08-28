namespace graficar_datos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {   
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_GetSerialPOrts = new System.Windows.Forms.Button();
            this.btn_toConnect = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cbSerialPortsAva = new System.Windows.Forms.ComboBox();
            this.lblShowingPorts = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_ShowSerialPortData = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(568, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 308);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(68, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(68, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // bt_GetSerialPOrts
            // 
            this.bt_GetSerialPOrts.BackColor = System.Drawing.Color.Green;
            this.bt_GetSerialPOrts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GetSerialPOrts.Location = new System.Drawing.Point(273, 12);
            this.bt_GetSerialPOrts.Name = "bt_GetSerialPOrts";
            this.bt_GetSerialPOrts.Size = new System.Drawing.Size(109, 46);
            this.bt_GetSerialPOrts.TabIndex = 1;
            this.bt_GetSerialPOrts.Text = "GetSerialPorts";
            this.bt_GetSerialPOrts.UseVisualStyleBackColor = false;
            this.bt_GetSerialPOrts.Click += new System.EventHandler(this.bt_GetSerialPOrts_Click);
            // 
            // btn_toConnect
            // 
            this.btn_toConnect.BackColor = System.Drawing.Color.Red;
            this.btn_toConnect.Enabled = false;
            this.btn_toConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_toConnect.Location = new System.Drawing.Point(388, 12);
            this.btn_toConnect.Name = "btn_toConnect";
            this.btn_toConnect.Size = new System.Drawing.Size(109, 46);
            this.btn_toConnect.TabIndex = 0;
            this.btn_toConnect.Text = "Connect";
            this.btn_toConnect.UseVisualStyleBackColor = false;
            this.btn_toConnect.Click += new System.EventHandler(this.btn_toConnect_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 399);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(734, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker1.Location = new System.Drawing.Point(568, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM2";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // cbSerialPortsAva
            // 
            this.cbSerialPortsAva.FormattingEnabled = true;
            this.cbSerialPortsAva.Location = new System.Drawing.Point(12, 37);
            this.cbSerialPortsAva.Name = "cbSerialPortsAva";
            this.cbSerialPortsAva.Size = new System.Drawing.Size(187, 21);
            this.cbSerialPortsAva.TabIndex = 9;
            // 
            // lblShowingPorts
            // 
            this.lblShowingPorts.AutoSize = true;
            this.lblShowingPorts.BackColor = System.Drawing.Color.Teal;
            this.lblShowingPorts.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowingPorts.ForeColor = System.Drawing.Color.Black;
            this.lblShowingPorts.Location = new System.Drawing.Point(12, 12);
            this.lblShowingPorts.Name = "lblShowingPorts";
            this.lblShowingPorts.Size = new System.Drawing.Size(187, 23);
            this.lblShowingPorts.TabIndex = 10;
            this.lblShowingPorts.Text = "Availables Serial Ports ";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(34, 77);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.CustomProperties = "PointWidth=0.9";
            series1.Font = new System.Drawing.Font("Marlett", 8F);
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 6;
            series1.MarkerSize = 9;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(309, 300);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // lbl_ShowSerialPortData
            // 
            this.lbl_ShowSerialPortData.BackColor = System.Drawing.Color.Yellow;
            this.lbl_ShowSerialPortData.Location = new System.Drawing.Point(373, 100);
            this.lbl_ShowSerialPortData.Name = "lbl_ShowSerialPortData";
            this.lbl_ShowSerialPortData.Size = new System.Drawing.Size(162, 36);
            this.lbl_ShowSerialPortData.TabIndex = 12;
            this.lbl_ShowSerialPortData.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ShowSerialPortData);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblShowingPorts);
            this.Controls.Add(this.cbSerialPortsAva);
            this.Controls.Add(this.bt_GetSerialPOrts);
            this.Controls.Add(this.btn_toConnect);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafica";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_GetSerialPOrts;
        private System.Windows.Forms.Button btn_toConnect;
        private System.Windows.Forms.ComboBox cbSerialPortsAva;
        private System.Windows.Forms.Label lblShowingPorts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_ShowSerialPortData;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

