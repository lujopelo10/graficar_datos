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
            this.lbl_statedofDATABASE = new System.Windows.Forms.Label();
            this.btn_CloseData = new System.Windows.Forms.Button();
            this.btn_OpenData = new System.Windows.Forms.Button();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.btn_CLEARGRAPH = new System.Windows.Forms.Button();
            this.btn_SAVE = new System.Windows.Forms.Button();
            this.bt_GenerateRandomNum = new System.Windows.Forms.Button();
            this.btn_toConnect = new System.Windows.Forms.Button();
            this.bt_GetSerialPOrts = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cbSerialPortsAva = new System.Windows.Forms.ComboBox();
            this.lblShowingPorts = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_ShowSerialPortData = new System.Windows.Forms.Label();
            this.lbl_ShowRandomValue = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TB_DIRECTION = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_directionFile = new System.Windows.Forms.Label();
            this.dtgv_Consulta = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_Consulta);
            this.groupBox1.Controls.Add(this.btn_CloseData);
            this.groupBox1.Controls.Add(this.btn_OpenData);
            this.groupBox1.Controls.Add(this.lbl_timer);
            this.groupBox1.Controls.Add(this.btn_CLEARGRAPH);
            this.groupBox1.Controls.Add(this.btn_SAVE);
            this.groupBox1.Controls.Add(this.bt_GenerateRandomNum);
            this.groupBox1.Controls.Add(this.btn_toConnect);
            this.groupBox1.Controls.Add(this.bt_GetSerialPOrts);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(708, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 506);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lbl_statedofDATABASE
            // 
            this.lbl_statedofDATABASE.Location = new System.Drawing.Point(830, 0);
            this.lbl_statedofDATABASE.Name = "lbl_statedofDATABASE";
            this.lbl_statedofDATABASE.Size = new System.Drawing.Size(172, 35);
            this.lbl_statedofDATABASE.TabIndex = 8;
            this.lbl_statedofDATABASE.Text = "Esltado de la base de datos";
            // 
            // btn_CloseData
            // 
            this.btn_CloseData.BackColor = System.Drawing.Color.Blue;
            this.btn_CloseData.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseData.Location = new System.Drawing.Point(185, 110);
            this.btn_CloseData.Name = "btn_CloseData";
            this.btn_CloseData.Size = new System.Drawing.Size(109, 50);
            this.btn_CloseData.TabIndex = 7;
            this.btn_CloseData.Text = "CloseDataBase";
            this.btn_CloseData.UseVisualStyleBackColor = false;
            this.btn_CloseData.Click += new System.EventHandler(this.btn_CloseData_Click);
            // 
            // btn_OpenData
            // 
            this.btn_OpenData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_OpenData.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenData.Location = new System.Drawing.Point(185, 45);
            this.btn_OpenData.Name = "btn_OpenData";
            this.btn_OpenData.Size = new System.Drawing.Size(109, 50);
            this.btn_OpenData.TabIndex = 6;
            this.btn_OpenData.Text = "OpenDataBase";
            this.btn_OpenData.UseVisualStyleBackColor = false;
            this.btn_OpenData.Click += new System.EventHandler(this.btn_OpenData_Click);
            // 
            // lbl_timer
            // 
            this.lbl_timer.BackColor = System.Drawing.Color.BlueViolet;
            this.lbl_timer.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(43, 255);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(109, 50);
            this.lbl_timer.TabIndex = 5;
            this.lbl_timer.Text = "label1";
            this.lbl_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CLEARGRAPH
            // 
            this.btn_CLEARGRAPH.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_CLEARGRAPH.Location = new System.Drawing.Point(43, 45);
            this.btn_CLEARGRAPH.Name = "btn_CLEARGRAPH";
            this.btn_CLEARGRAPH.Size = new System.Drawing.Size(109, 50);
            this.btn_CLEARGRAPH.TabIndex = 4;
            this.btn_CLEARGRAPH.Text = "CLEAR GRAPH";
            this.btn_CLEARGRAPH.UseVisualStyleBackColor = false;
            // 
            // btn_SAVE
            // 
            this.btn_SAVE.BackColor = System.Drawing.Color.Yellow;
            this.btn_SAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SAVE.Location = new System.Drawing.Point(185, 255);
            this.btn_SAVE.Name = "btn_SAVE";
            this.btn_SAVE.Size = new System.Drawing.Size(109, 50);
            this.btn_SAVE.TabIndex = 3;
            this.btn_SAVE.Text = "GenerateLog";
            this.btn_SAVE.UseVisualStyleBackColor = false;
            // 
            // bt_GenerateRandomNum
            // 
            this.bt_GenerateRandomNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_GenerateRandomNum.Location = new System.Drawing.Point(43, 112);
            this.bt_GenerateRandomNum.Name = "bt_GenerateRandomNum";
            this.bt_GenerateRandomNum.Size = new System.Drawing.Size(109, 50);
            this.bt_GenerateRandomNum.TabIndex = 2;
            this.bt_GenerateRandomNum.Text = "Send Info Database";
            this.bt_GenerateRandomNum.UseVisualStyleBackColor = false;
            this.bt_GenerateRandomNum.Click += new System.EventHandler(this.bt_GenerateRandomNum_Click);
            // 
            // btn_toConnect
            // 
            this.btn_toConnect.BackColor = System.Drawing.Color.Red;
            this.btn_toConnect.Enabled = false;
            this.btn_toConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_toConnect.Location = new System.Drawing.Point(43, 180);
            this.btn_toConnect.Name = "btn_toConnect";
            this.btn_toConnect.Size = new System.Drawing.Size(109, 50);
            this.btn_toConnect.TabIndex = 0;
            this.btn_toConnect.Text = "Connect";
            this.btn_toConnect.UseVisualStyleBackColor = false;
            this.btn_toConnect.Click += new System.EventHandler(this.btn_toConnect_Click);
            // 
            // bt_GetSerialPOrts
            // 
            this.bt_GetSerialPOrts.BackColor = System.Drawing.Color.Green;
            this.bt_GetSerialPOrts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GetSerialPOrts.Location = new System.Drawing.Point(185, 180);
            this.bt_GetSerialPOrts.Name = "bt_GetSerialPOrts";
            this.bt_GetSerialPOrts.Size = new System.Drawing.Size(109, 50);
            this.bt_GetSerialPOrts.TabIndex = 1;
            this.bt_GetSerialPOrts.Text = "GetSerialPorts";
            this.bt_GetSerialPOrts.UseVisualStyleBackColor = false;
            this.bt_GetSerialPOrts.Click += new System.EventHandler(this.bt_GetSerialPOrts_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker1.Location = new System.Drawing.Point(821, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM2";
            this.serialPort1.RtsEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // cbSerialPortsAva
            // 
            this.cbSerialPortsAva.FormattingEnabled = true;
            this.cbSerialPortsAva.Location = new System.Drawing.Point(12, 37);
            this.cbSerialPortsAva.Name = "cbSerialPortsAva";
            this.cbSerialPortsAva.Size = new System.Drawing.Size(78, 21);
            this.cbSerialPortsAva.TabIndex = 9;
            // 
            // lblShowingPorts
            // 
            this.lblShowingPorts.BackColor = System.Drawing.Color.Teal;
            this.lblShowingPorts.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowingPorts.ForeColor = System.Drawing.Color.Black;
            this.lblShowingPorts.Location = new System.Drawing.Point(52, 9);
            this.lblShowingPorts.Name = "lblShowingPorts";
            this.lblShowingPorts.Size = new System.Drawing.Size(245, 23);
            this.lblShowingPorts.TabIndex = 10;
            this.lblShowingPorts.Text = "Availables Serial Ports ";
            this.lblShowingPorts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.BorderWidth = 5;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.Aqua;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Yellow;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.Fuchsia;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Maroon;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea1.BackSecondaryColor = System.Drawing.Color.Aqua;
            chartArea1.BorderColor = System.Drawing.Color.Gray;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            legend1.HeaderSeparatorColor = System.Drawing.Color.Yellow;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            legend1.ItemColumnSpacing = 1;
            legend1.MaximumAutoSize = 10F;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.Aqua;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 90);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BackImageTransparentColor = System.Drawing.Color.Yellow;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Black;
            series1.CustomProperties = "EmptyPointValue=Zero, PointWidth=1, LineTension=1";
            series1.EmptyPointStyle.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series1.LabelBorderColor = System.Drawing.Color.Black;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.LabelForeColor = System.Drawing.Color.Maroon;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.MarkerColor = System.Drawing.Color.White;
            series1.MarkerSize = 9;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series1.Name = "random";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ShadowColor = System.Drawing.Color.White;
            series1.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.Blue;
            series1.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Round;
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Maroon;
            series1.SmartLabelStyle.MaxMovingDistance = 10D;
            series1.SmartLabelStyle.MinMovingDistance = 100D;
            series1.SmartLabelStyle.MovingDirection = System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top;
            series1.YValuesPerPoint = 10;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(690, 506);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // lbl_ShowSerialPortData
            // 
            this.lbl_ShowSerialPortData.BackColor = System.Drawing.Color.Yellow;
            this.lbl_ShowSerialPortData.Location = new System.Drawing.Point(96, 37);
            this.lbl_ShowSerialPortData.Name = "lbl_ShowSerialPortData";
            this.lbl_ShowSerialPortData.Size = new System.Drawing.Size(218, 21);
            this.lbl_ShowSerialPortData.TabIndex = 12;
            this.lbl_ShowSerialPortData.Text = "Estado y nombre del Puerto";
            this.lbl_ShowSerialPortData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ShowRandomValue
            // 
            this.lbl_ShowRandomValue.BackColor = System.Drawing.Color.Aqua;
            this.lbl_ShowRandomValue.Location = new System.Drawing.Point(341, 20);
            this.lbl_ShowRandomValue.Name = "lbl_ShowRandomValue";
            this.lbl_ShowRandomValue.Size = new System.Drawing.Size(135, 46);
            this.lbl_ShowRandomValue.TabIndex = 13;
            this.lbl_ShowRandomValue.Text = "Random value";
            this.lbl_ShowRandomValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventLog1
            // 
            this.eventLog1.Log = "Application";
            this.eventLog1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TB_DIRECTION
            // 
            this.TB_DIRECTION.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DIRECTION.Location = new System.Drawing.Point(528, 57);
            this.TB_DIRECTION.Name = "TB_DIRECTION";
            this.TB_DIRECTION.Size = new System.Drawing.Size(537, 26);
            this.TB_DIRECTION.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lbl_directionFile
            // 
            this.lbl_directionFile.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lbl_directionFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_directionFile.Location = new System.Drawing.Point(534, 9);
            this.lbl_directionFile.Name = "lbl_directionFile";
            this.lbl_directionFile.Size = new System.Drawing.Size(213, 45);
            this.lbl_directionFile.TabIndex = 15;
            this.lbl_directionFile.Text = "Direccion del documento";
            this.lbl_directionFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgv_Consulta
            // 
            this.dtgv_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Consulta.Location = new System.Drawing.Point(6, 326);
            this.dtgv_Consulta.Name = "dtgv_Consulta";
            this.dtgv_Consulta.Size = new System.Drawing.Size(356, 174);
            this.dtgv_Consulta.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1088, 608);
            this.Controls.Add(this.lbl_statedofDATABASE);
            this.Controls.Add(this.lbl_directionFile);
            this.Controls.Add(this.TB_DIRECTION);
            this.Controls.Add(this.lbl_ShowRandomValue);
            this.Controls.Add(this.lbl_ShowSerialPortData);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblShowingPorts);
            this.Controls.Add(this.cbSerialPortsAva);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_SAVE;
        private System.Windows.Forms.Button bt_GenerateRandomNum;
        private System.Windows.Forms.Button bt_GetSerialPOrts;
        private System.Windows.Forms.Button btn_toConnect;
        private System.Windows.Forms.ComboBox cbSerialPortsAva;
        private System.Windows.Forms.Label lblShowingPorts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_ShowSerialPortData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbl_ShowRandomValue;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_CLEARGRAPH;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox TB_DIRECTION;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label lbl_directionFile;
        private System.Windows.Forms.Button btn_CloseData;
        private System.Windows.Forms.Button btn_OpenData;
        private System.Windows.Forms.Label lbl_statedofDATABASE;
        private System.Windows.Forms.DataGridView dtgv_Consulta;
    }
}

