
namespace LineChartApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button_connect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.label_profilograph = new System.Windows.Forms.Label();
            this.groupBox_comport = new System.Windows.Forms.GroupBox();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.comboBox_portlists = new System.Windows.Forms.ComboBox();
            this.label_baudrate = new System.Windows.Forms.Label();
            this.label_comport = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_profilograph_show = new System.Windows.Forms.Label();
            this.groupBox_status = new System.Windows.Forms.GroupBox();
            this.textBox_timer = new System.Windows.Forms.TextBox();
            this.label_timer = new System.Windows.Forms.Label();
            this.label_reading_show = new System.Windows.Forms.Label();
            this.label_reading = new System.Windows.Forms.Label();
            this.button_calibration = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_ic0 = new System.Windows.Forms.Button();
            this.button_ic1 = new System.Windows.Forms.Button();
            this.button_ic2 = new System.Windows.Forms.Button();
            this.button_ic3 = new System.Windows.Forms.Button();
            this.button_ic4 = new System.Windows.Forms.Button();
            this.button_ic5 = new System.Windows.Forms.Button();
            this.button_ic6 = new System.Windows.Forms.Button();
            this.button_ic7 = new System.Windows.Forms.Button();
            this.panel_ic = new System.Windows.Forms.Panel();
            this.panel_ic_button = new System.Windows.Forms.Panel();
            this.panel_start_stop = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_chart = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_control = new System.Windows.Forms.Panel();
            this.groupBox_fnumbers = new System.Windows.Forms.GroupBox();
            this.label_fmin_show = new System.Windows.Forms.Label();
            this.label_dx_show = new System.Windows.Forms.Label();
            this.label_dz_show = new System.Windows.Forms.Label();
            this.label_z_slope = new System.Windows.Forms.Label();
            this.label_dx = new System.Windows.Forms.Label();
            this.label_dz = new System.Windows.Forms.Label();
            this.groupBox_comport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox_status.SuspendLayout();
            this.panel_ic.SuspendLayout();
            this.panel_ic_button.SuspendLayout();
            this.panel_start_stop.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panel_control.SuspendLayout();
            this.groupBox_fnumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button_connect
            // 
            this.button_connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_connect.FlatAppearance.BorderSize = 0;
            this.button_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connect.Location = new System.Drawing.Point(310, 15);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(170, 80);
            this.button_connect.TabIndex = 4;
            this.button_connect.TabStop = false;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_disconnect.Enabled = false;
            this.button_disconnect.FlatAppearance.BorderSize = 0;
            this.button_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_disconnect.Location = new System.Drawing.Point(310, 98);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(170, 80);
            this.button_disconnect.TabIndex = 5;
            this.button_disconnect.TabStop = false;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // label_profilograph
            // 
            this.label_profilograph.AutoSize = true;
            this.label_profilograph.BackColor = System.Drawing.SystemColors.Control;
            this.label_profilograph.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profilograph.Location = new System.Drawing.Point(7, 36);
            this.label_profilograph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_profilograph.Name = "label_profilograph";
            this.label_profilograph.Size = new System.Drawing.Size(131, 28);
            this.label_profilograph.TabIndex = 6;
            this.label_profilograph.Text = "Profilograph :";
            this.label_profilograph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_comport
            // 
            this.groupBox_comport.Controls.Add(this.comboBox_baudrate);
            this.groupBox_comport.Controls.Add(this.comboBox_portlists);
            this.groupBox_comport.Controls.Add(this.label_baudrate);
            this.groupBox_comport.Controls.Add(this.label_comport);
            this.groupBox_comport.Location = new System.Drawing.Point(6, 3);
            this.groupBox_comport.Name = "groupBox_comport";
            this.groupBox_comport.Size = new System.Drawing.Size(297, 175);
            this.groupBox_comport.TabIndex = 8;
            this.groupBox_comport.TabStop = false;
            this.groupBox_comport.Text = "COM PORT SETTING";
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBox_baudrate.Location = new System.Drawing.Point(141, 110);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(121, 36);
            this.comboBox_baudrate.TabIndex = 3;
            this.comboBox_baudrate.Text = "115200";
            // 
            // comboBox_portlists
            // 
            this.comboBox_portlists.FormattingEnabled = true;
            this.comboBox_portlists.Location = new System.Drawing.Point(141, 55);
            this.comboBox_portlists.Name = "comboBox_portlists";
            this.comboBox_portlists.Size = new System.Drawing.Size(121, 36);
            this.comboBox_portlists.TabIndex = 2;
            this.comboBox_portlists.DropDown += new System.EventHandler(this.comboBox_portlists_DropDown);
            this.comboBox_portlists.SelectedIndexChanged += new System.EventHandler(this.comboBox_portlists_SelectedIndexChanged);
            // 
            // label_baudrate
            // 
            this.label_baudrate.AutoSize = true;
            this.label_baudrate.Location = new System.Drawing.Point(6, 113);
            this.label_baudrate.Name = "label_baudrate";
            this.label_baudrate.Size = new System.Drawing.Size(113, 28);
            this.label_baudrate.TabIndex = 1;
            this.label_baudrate.Text = "BAUD RATE";
            // 
            // label_comport
            // 
            this.label_comport.AutoSize = true;
            this.label_comport.Location = new System.Drawing.Point(6, 58);
            this.label_comport.Name = "label_comport";
            this.label_comport.Size = new System.Drawing.Size(108, 28);
            this.label_comport.TabIndex = 0;
            this.label_comport.Text = "COM PORT";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(180, 70);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "IC0";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "IC1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "IC2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "IC3";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "IC4";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "IC5";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "IC6";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "IC7";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(1200, 480);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "LINE CHART PROFILE";
            this.chart1.Titles.Add(title1);
            // 
            // label_profilograph_show
            // 
            this.label_profilograph_show.AutoSize = true;
            this.label_profilograph_show.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profilograph_show.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_profilograph_show.Location = new System.Drawing.Point(141, 41);
            this.label_profilograph_show.Name = "label_profilograph_show";
            this.label_profilograph_show.Size = new System.Drawing.Size(208, 23);
            this.label_profilograph_show.TabIndex = 11;
            this.label_profilograph_show.Text = "Calibrating MPU Sensor ...";
            // 
            // groupBox_status
            // 
            this.groupBox_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_status.AutoSize = true;
            this.groupBox_status.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_status.Controls.Add(this.textBox_timer);
            this.groupBox_status.Controls.Add(this.label_timer);
            this.groupBox_status.Controls.Add(this.label_reading_show);
            this.groupBox_status.Controls.Add(this.label_reading);
            this.groupBox_status.Controls.Add(this.label_profilograph);
            this.groupBox_status.Controls.Add(this.label_profilograph_show);
            this.groupBox_status.Location = new System.Drawing.Point(485, 3);
            this.groupBox_status.Name = "groupBox_status";
            this.groupBox_status.Size = new System.Drawing.Size(355, 184);
            this.groupBox_status.TabIndex = 12;
            this.groupBox_status.TabStop = false;
            this.groupBox_status.Text = "STATUS";
            // 
            // textBox_timer
            // 
            this.textBox_timer.Location = new System.Drawing.Point(140, 75);
            this.textBox_timer.Name = "textBox_timer";
            this.textBox_timer.Size = new System.Drawing.Size(100, 34);
            this.textBox_timer.TabIndex = 17;
            this.textBox_timer.Text = "51710";
            this.textBox_timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Location = new System.Drawing.Point(7, 78);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(131, 28);
            this.label_timer.TabIndex = 16;
            this.label_timer.Text = "Motor Timer :";
            // 
            // label_reading_show
            // 
            this.label_reading_show.AutoSize = true;
            this.label_reading_show.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reading_show.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_reading_show.Location = new System.Drawing.Point(141, 125);
            this.label_reading_show.Name = "label_reading_show";
            this.label_reading_show.Size = new System.Drawing.Size(41, 23);
            this.label_reading_show.TabIndex = 15;
            this.label_reading_show.Text = "N/A";
            // 
            // label_reading
            // 
            this.label_reading.AutoSize = true;
            this.label_reading.Location = new System.Drawing.Point(7, 120);
            this.label_reading.Name = "label_reading";
            this.label_reading.Size = new System.Drawing.Size(92, 28);
            this.label_reading.TabIndex = 13;
            this.label_reading.Text = "Reading :";
            // 
            // button_calibration
            // 
            this.button_calibration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_calibration.Enabled = false;
            this.button_calibration.FlatAppearance.BorderSize = 0;
            this.button_calibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calibration.Location = new System.Drawing.Point(1027, 15);
            this.button_calibration.Name = "button_calibration";
            this.button_calibration.Size = new System.Drawing.Size(170, 80);
            this.button_calibration.TabIndex = 13;
            this.button_calibration.TabStop = false;
            this.button_calibration.Text = "Calibrate";
            this.button_calibration.UseVisualStyleBackColor = true;
            this.button_calibration.Click += new System.EventHandler(this.button_calibration_Click);
            // 
            // button_upload
            // 
            this.button_upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_upload.Enabled = false;
            this.button_upload.FlatAppearance.BorderSize = 0;
            this.button_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.Location = new System.Drawing.Point(1027, 98);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(170, 80);
            this.button_upload.TabIndex = 14;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // button_stop
            // 
            this.button_stop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_stop.Enabled = false;
            this.button_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stop.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_stop.Location = new System.Drawing.Point(0, 0);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(180, 90);
            this.button_stop.TabIndex = 15;
            this.button_stop.TabStop = false;
            this.button_stop.Text = "STOP";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_start
            // 
            this.button_start.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_start.Enabled = false;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_start.Location = new System.Drawing.Point(0, 90);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(180, 90);
            this.button_start.TabIndex = 16;
            this.button_start.TabStop = false;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_ic0
            // 
            this.button_ic0.Enabled = false;
            this.button_ic0.FlatAppearance.BorderSize = 0;
            this.button_ic0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ic0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ic0.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_ic0.Location = new System.Drawing.Point(0, 0);
            this.button_ic0.Name = "button_ic0";
            this.button_ic0.Size = new System.Drawing.Size(180, 60);
            this.button_ic0.TabIndex = 17;
            this.button_ic0.TabStop = false;
            this.button_ic0.Text = "IC0";
            this.button_ic0.UseVisualStyleBackColor = true;
            this.button_ic0.Click += new System.EventHandler(this.button_ic0_Click);
            // 
            // button_ic1
            // 
            this.button_ic1.Enabled = false;
            this.button_ic1.FlatAppearance.BorderSize = 0;
            this.button_ic1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ic1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_ic1.Location = new System.Drawing.Point(0, 60);
            this.button_ic1.Name = "button_ic1";
            this.button_ic1.Size = new System.Drawing.Size(180, 60);
            this.button_ic1.TabIndex = 18;
            this.button_ic1.TabStop = false;
            this.button_ic1.Text = "IC1";
            this.button_ic1.UseVisualStyleBackColor = true;
            this.button_ic1.Click += new System.EventHandler(this.button_ic1_Click);
            // 
            // button_ic2
            // 
            this.button_ic2.Enabled = false;
            this.button_ic2.FlatAppearance.BorderSize = 0;
            this.button_ic2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ic2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_ic2.Location = new System.Drawing.Point(0, 120);
            this.button_ic2.Name = "button_ic2";
            this.button_ic2.Size = new System.Drawing.Size(180, 60);
            this.button_ic2.TabIndex = 19;
            this.button_ic2.TabStop = false;
            this.button_ic2.Text = "IC2";
            this.button_ic2.UseVisualStyleBackColor = true;
            this.button_ic2.Click += new System.EventHandler(this.button_ic2_Click);
            // 
            // button_ic3
            // 
            this.button_ic3.Enabled = false;
            this.button_ic3.FlatAppearance.BorderSize = 0;
            this.button_ic3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ic3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ic3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_ic3.Location = new System.Drawing.Point(0, 180);
            this.button_ic3.Name = "button_ic3";
            this.button_ic3.Size = new System.Drawing.Size(180, 60);
            this.button_ic3.TabIndex = 20;
            this.button_ic3.TabStop = false;
            this.button_ic3.Text = "IC3";
            this.button_ic3.UseVisualStyleBackColor = true;
            this.button_ic3.Click += new System.EventHandler(this.button_ic3_Click);
            // 
            // button_ic4
            // 
            this.button_ic4.Enabled = false;
            this.button_ic4.FlatAppearance.BorderSize = 0;
            this.button_ic4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ic4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ic4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_ic4.Location = new System.Drawing.Point(0, 240);
            this.button_ic4.Name = "button_ic4";
            this.button_ic4.Size = new System.Drawing.Size(180, 60);
            this.button_ic4.TabIndex = 21;
            this.button_ic4.TabStop = false;
            this.button_ic4.Text = "IC4";
            this.button_ic4.UseVisualStyleBackColor = true;
            this.button_ic4.Click += new System.EventHandler(this.button_ic4_Click);
            // 
            // button_ic5
            // 
            this.button_ic5.Enabled = false;
            this.button_ic5.FlatAppearance.BorderSize = 0;
            this.button_ic5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ic5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ic5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_ic5.Location = new System.Drawing.Point(0, 300);
            this.button_ic5.Name = "button_ic5";
            this.button_ic5.Size = new System.Drawing.Size(180, 60);
            this.button_ic5.TabIndex = 22;
            this.button_ic5.TabStop = false;
            this.button_ic5.Text = "IC5";
            this.button_ic5.UseVisualStyleBackColor = true;
            this.button_ic5.Click += new System.EventHandler(this.button_ic5_Click);
            // 
            // button_ic6
            // 
            this.button_ic6.Enabled = false;
            this.button_ic6.FlatAppearance.BorderSize = 0;
            this.button_ic6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ic6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ic6.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_ic6.Location = new System.Drawing.Point(0, 360);
            this.button_ic6.Name = "button_ic6";
            this.button_ic6.Size = new System.Drawing.Size(180, 60);
            this.button_ic6.TabIndex = 23;
            this.button_ic6.TabStop = false;
            this.button_ic6.Text = "IC6";
            this.button_ic6.UseVisualStyleBackColor = true;
            this.button_ic6.Click += new System.EventHandler(this.button_ic6_Click);
            // 
            // button_ic7
            // 
            this.button_ic7.Enabled = false;
            this.button_ic7.FlatAppearance.BorderSize = 0;
            this.button_ic7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ic7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ic7.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_ic7.Location = new System.Drawing.Point(0, 420);
            this.button_ic7.Name = "button_ic7";
            this.button_ic7.Size = new System.Drawing.Size(180, 60);
            this.button_ic7.TabIndex = 24;
            this.button_ic7.TabStop = false;
            this.button_ic7.Text = "IC7";
            this.button_ic7.UseVisualStyleBackColor = true;
            this.button_ic7.Click += new System.EventHandler(this.button_ic7_Click);
            // 
            // panel_ic
            // 
            this.panel_ic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_ic.Controls.Add(this.panel_ic_button);
            this.panel_ic.Controls.Add(this.panel_start_stop);
            this.panel_ic.Controls.Add(this.panel_logo);
            this.panel_ic.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ic.Location = new System.Drawing.Point(0, 0);
            this.panel_ic.Name = "panel_ic";
            this.panel_ic.Size = new System.Drawing.Size(180, 730);
            this.panel_ic.TabIndex = 25;
            // 
            // panel_ic_button
            // 
            this.panel_ic_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_ic_button.BackColor = System.Drawing.Color.Transparent;
            this.panel_ic_button.Controls.Add(this.button_ic0);
            this.panel_ic_button.Controls.Add(this.button_ic7);
            this.panel_ic_button.Controls.Add(this.button_ic1);
            this.panel_ic_button.Controls.Add(this.button_ic2);
            this.panel_ic_button.Controls.Add(this.button_ic6);
            this.panel_ic_button.Controls.Add(this.button_ic3);
            this.panel_ic_button.Controls.Add(this.button_ic5);
            this.panel_ic_button.Controls.Add(this.button_ic4);
            this.panel_ic_button.Location = new System.Drawing.Point(0, 70);
            this.panel_ic_button.Name = "panel_ic_button";
            this.panel_ic_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel_ic_button.Size = new System.Drawing.Size(180, 480);
            this.panel_ic_button.TabIndex = 29;
            // 
            // panel_start_stop
            // 
            this.panel_start_stop.Controls.Add(this.button_stop);
            this.panel_start_stop.Controls.Add(this.button_start);
            this.panel_start_stop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_start_stop.Location = new System.Drawing.Point(0, 550);
            this.panel_start_stop.Name = "panel_start_stop";
            this.panel_start_stop.Size = new System.Drawing.Size(180, 180);
            this.panel_start_stop.TabIndex = 26;
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel_logo.Controls.Add(this.panel_chart);
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(180, 70);
            this.panel_logo.TabIndex = 25;
            // 
            // panel_chart
            // 
            this.panel_chart.Location = new System.Drawing.Point(180, 70);
            this.panel_chart.Name = "panel_chart";
            this.panel_chart.Size = new System.Drawing.Size(1200, 480);
            this.panel_chart.TabIndex = 27;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(180, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1200, 70);
            this.panel_header.TabIndex = 26;
            // 
            // panel_control
            // 
            this.panel_control.Controls.Add(this.groupBox_fnumbers);
            this.panel_control.Controls.Add(this.button_upload);
            this.panel_control.Controls.Add(this.groupBox_status);
            this.panel_control.Controls.Add(this.groupBox_comport);
            this.panel_control.Controls.Add(this.button_calibration);
            this.panel_control.Controls.Add(this.button_disconnect);
            this.panel_control.Controls.Add(this.button_connect);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_control.Location = new System.Drawing.Point(180, 550);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(1200, 180);
            this.panel_control.TabIndex = 28;
            // 
            // groupBox_fnumbers
            // 
            this.groupBox_fnumbers.Controls.Add(this.label_fmin_show);
            this.groupBox_fnumbers.Controls.Add(this.label_dx_show);
            this.groupBox_fnumbers.Controls.Add(this.label_dz_show);
            this.groupBox_fnumbers.Controls.Add(this.label_z_slope);
            this.groupBox_fnumbers.Controls.Add(this.label_dx);
            this.groupBox_fnumbers.Controls.Add(this.label_dz);
            this.groupBox_fnumbers.Location = new System.Drawing.Point(846, 3);
            this.groupBox_fnumbers.Name = "groupBox_fnumbers";
            this.groupBox_fnumbers.Size = new System.Drawing.Size(175, 178);
            this.groupBox_fnumbers.TabIndex = 15;
            this.groupBox_fnumbers.TabStop = false;
            this.groupBox_fnumbers.Text = "TR-34 DM2";
            // 
            // label_fmin_show
            // 
            this.label_fmin_show.AutoSize = true;
            this.label_fmin_show.Location = new System.Drawing.Point(84, 120);
            this.label_fmin_show.Name = "label_fmin_show";
            this.label_fmin_show.Size = new System.Drawing.Size(0, 28);
            this.label_fmin_show.TabIndex = 5;
            // 
            // label_dx_show
            // 
            this.label_dx_show.AutoSize = true;
            this.label_dx_show.Location = new System.Drawing.Point(84, 78);
            this.label_dx_show.Name = "label_dx_show";
            this.label_dx_show.Size = new System.Drawing.Size(65, 28);
            this.label_dx_show.TabIndex = 4;
            this.label_dx_show.Text = "0.00%";
            // 
            // label_dz_show
            // 
            this.label_dz_show.AutoSize = true;
            this.label_dz_show.Location = new System.Drawing.Point(84, 36);
            this.label_dz_show.Name = "label_dz_show";
            this.label_dz_show.Size = new System.Drawing.Size(65, 28);
            this.label_dz_show.TabIndex = 3;
            this.label_dz_show.Text = "0.00%";
            // 
            // label_z_slope
            // 
            this.label_z_slope.AutoSize = true;
            this.label_z_slope.Location = new System.Drawing.Point(6, 120);
            this.label_z_slope.Name = "label_z_slope";
            this.label_z_slope.Size = new System.Drawing.Size(79, 28);
            this.label_z_slope.TabIndex = 2;
            this.label_z_slope.Text = "Zslope :";
            // 
            // label_dx
            // 
            this.label_dx.AutoSize = true;
            this.label_dx.Location = new System.Drawing.Point(6, 78);
            this.label_dx.Name = "label_dx";
            this.label_dx.Size = new System.Drawing.Size(45, 28);
            this.label_dx.TabIndex = 1;
            this.label_dx.Text = "dX :";
            // 
            // label_dz
            // 
            this.label_dz.AutoSize = true;
            this.label_dz.Location = new System.Drawing.Point(6, 36);
            this.label_dz.Name = "label_dz";
            this.label_dz.Size = new System.Drawing.Size(44, 28);
            this.label_dz.TabIndex = 0;
            this.label_dz.Text = "dZ :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1380, 730);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel_control);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_ic);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profilograph Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox_comport.ResumeLayout(false);
            this.groupBox_comport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox_status.ResumeLayout(false);
            this.groupBox_status.PerformLayout();
            this.panel_ic.ResumeLayout(false);
            this.panel_ic_button.ResumeLayout(false);
            this.panel_start_stop.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            this.groupBox_fnumbers.ResumeLayout(false);
            this.groupBox_fnumbers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Label label_profilograph;
        private System.Windows.Forms.GroupBox groupBox_comport;
        private System.Windows.Forms.ComboBox comboBox_portlists;
        private System.Windows.Forms.Label label_baudrate;
        private System.Windows.Forms.Label label_comport;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label_profilograph_show;
        private System.Windows.Forms.GroupBox groupBox_status;
        private System.Windows.Forms.Label label_reading;
        private System.Windows.Forms.Label label_reading_show;
        private System.Windows.Forms.Button button_calibration;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_ic0;
        private System.Windows.Forms.Button button_ic1;
        private System.Windows.Forms.Button button_ic2;
        private System.Windows.Forms.Button button_ic3;
        private System.Windows.Forms.Button button_ic4;
        private System.Windows.Forms.Button button_ic5;
        private System.Windows.Forms.Button button_ic6;
        private System.Windows.Forms.Button button_ic7;
        private System.Windows.Forms.Panel panel_ic;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_chart;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Panel panel_start_stop;
        private System.Windows.Forms.Panel panel_ic_button;
        private System.Windows.Forms.GroupBox groupBox_fnumbers;
        private System.Windows.Forms.Label label_z_slope;
        private System.Windows.Forms.Label label_dx;
        private System.Windows.Forms.Label label_dz;
        private System.Windows.Forms.Label label_fmin_show;
        private System.Windows.Forms.Label label_dx_show;
        private System.Windows.Forms.Label label_dz_show;
        private System.Windows.Forms.TextBox textBox_timer;
        private System.Windows.Forms.Label label_timer;
    }
}

