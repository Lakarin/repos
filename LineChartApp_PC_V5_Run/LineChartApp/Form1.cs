using ArduinoUploader;
using ArduinoUploader.Hardware;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace LineChartApp
{
    public partial class Form1 : Form
    {
        /* Rescale Controls */
        private Rectangle originalFormSize;
        private Rectangle panel_logo_size, panel_ic_size, panel_header_size, panel_ic_button_size, panel_start_stop_size, panel_control_size;
        private Rectangle button_stop_size, button_start_size, button_connect_size, button_disconnect_size, button_calibration_size, button_zero_size;
        private Rectangle[] button_ic_size = new Rectangle[8];
        Button[] btnResize;
        private Rectangle groupBox_comport_size, groupBox_status_size, groupBox_fnumbers_size;
        private Rectangle label_comport_size, label_baudrate_size;
        private Rectangle label_profilograph_size, label_timer_size, label_reading_size, label_profilograph_show_size, textBox_timer_size, label_reading_show_size;
        private Rectangle label_ff_size, label_fl_size, label_fmin_size, label_ff_show_size, label_fl_show_size, label_fmin_show_size;
        private Rectangle comboBox_portlists_size, comboBox_baudrate_size;
        /********************/

        string folder;

        readonly double[] Reading = new double[3];
        readonly bool[] Ports_Aval = new bool[8] {false, false, false, false, false, false, false, false};
        readonly double[] scaleFactor = new double[4] { 0.043, 0.030, 0.197, 0.197 };

        double Data, Ax, Ay, D, L;
        ushort Count, cnt, dZ, dX = 0;
        int senNum;
        bool updateData = false;
        bool StartProgram, StartError, Calibration, Runtrack, LattePanda = false;
        delegate void SetTextCallback(string text);
        delegate void SetEnabledCallback(bool enabled);
        unsafe delegate int GetTextCallback();
        FormWindowState LastWindowState = FormWindowState.Minimized;
        readonly List<string> calReading = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ResizeComponents()
        {
            panel_ic.Location = new Point(0, 0); 
            panel_ic.Size = new Size(144, 517);
            panel_header.Location = new Point(144, 0);
            panel_header.Size = new Size(882, 57);
            panel_control.Location = new Point(144, 377);
            panel_control.Size = new Size(882, 140);
            chart1.Location = new Point(144, 57);
            chart1.Size = new Size(882, 376);

            panel_logo.Location = new Point(0, 0);
            panel_logo.Size = new Size(144, 57);
            panel_ic_button.Location = new Point(0, 57);
            panel_ic_button.Size = new Size(144, 320);
            panel_start_stop.Location = new Point(0, 377);
            panel_start_stop.Size = new Size(144, 140);

            if (btnResize == null)
                btnResize = new Button[8] { button_ic0, button_ic1, button_ic2, button_ic3, button_ic4, button_ic5, button_ic6, button_ic7 };
            for (int i = 0; i < 8; i++)
            {
                btnResize[i].Location = new Point(0, i*40);
                btnResize[i].Size = new Size(144, 40);
                btnResize[i].Font = new Font("Microsoft Sans Serif", 10);
            }

            button_stop.Location = new Point(0, 0);
            button_stop.Size = new Size(144, 70);
            button_stop.Font = new Font("Microsoft Sans Serif", 10);
            button_start.Location = new Point(0, 70);
            button_start.Size = new Size(144, 70);
            button_start.Font = new Font("Microsoft Sans Serif", 10);

            button_connect.Location = new Point(238, 10);
            button_connect.Size = new Size(130, 60);
            button_connect.Font = new Font("Microsoft Sans Serif", 10);
            button_disconnect.Location = new Point(238, 76);
            button_disconnect.Size = new Size(130, 60);
            button_disconnect.Font = new Font("Microsoft Sans Serif", 10);
            button_calibration.Location = new Point(749, 10);
            button_calibration.Size = new Size(130, 60);
            button_calibration.Font = new Font("Microsoft Sans Serif", 10);
            button_upload.Location = new Point(749, 76);
            button_upload.Size = new Size(130, 60);
            button_upload.Font = new Font("Microsoft Sans Serif", 10);

            groupBox_comport.Location = new Point(1, 1);
            groupBox_comport.Size = new Size(231, 136);
            groupBox_comport.Font = new Font("Segoe UI", 9);
            groupBox_status.Location = new Point(374, 1);
            groupBox_status.Size = new Size(278, 136);
            groupBox_status.Font = new Font("Segoe UI", 9);
            groupBox_fnumbers.Location = new Point(658, 1);
            groupBox_fnumbers.Size = new Size(85, 136);
            groupBox_fnumbers.Font = new Font("Segoe UI", 9);

            label_comport.Location = new Point(6, 41);
            label_comport.Size = new Size(81, 20);
            label_comport.Font = new Font("Segoe UI", 9);
            label_baudrate.Location = new Point(6, 86);
            label_baudrate.Size = new Size(87, 20);
            label_baudrate.Font = new Font("Segoe UI", 9);
            comboBox_portlists.Location = new Point(103, 38);
            comboBox_portlists.Size = new Size(120, 28);
            comboBox_portlists.Font = new Font("Segoe UI", 9);
            comboBox_baudrate.Location = new Point(103, 83);
            comboBox_baudrate.Size = new Size(120, 28);
            comboBox_baudrate.Font = new Font("Segoe UI", 9);

            label_profilograph.Location = new Point(6, 27);
            label_profilograph.Size = new Size(91, 19);
            label_profilograph.Font = new Font("Segoe UI", 8);
            label_timer.Location = new Point(6, 60);
            label_timer.Size = new Size(78, 19);
            label_timer.Font = new Font("Segoe UI", 8);
            label_reading.Location = new Point(6, 93);
            label_reading.Size = new Size(65, 19);
            label_reading.Font = new Font("Segoe UI", 8);
            label_profilograph_show.Location = new Point(104, 28);
            label_profilograph_show.Size = new Size(168, 19);
            label_profilograph_show.Font = new Font("Segoe UI", 8);
            textBox_timer.Location = new Point(104, 60);
            textBox_timer.Size = new Size(33, 19);
            textBox_timer.Font = new Font("Segoe UI", 8);
            label_reading_show.Location = new Point(104, 93);
            label_reading_show.Size = new Size(33, 19);
            label_reading_show.Font = new Font("Segoe UI", 8);

            label_dz.Location = new Point(6, 27);
            label_dz.Size = new Size(30, 19);
            label_dz.Font = new Font("Segoe UI", 8);
            label_dx.Location = new Point(6, 60);
            label_dx.Size = new Size(30, 19);
            label_dx.Font = new Font("Segoe UI", 8);
            label_z_slope.Location = new Point(6, 93);
            label_z_slope.Size = new Size(46, 19);
            label_z_slope.Font = new Font("Segoe UI", 8);
            label_dz_show.Location = new Point(42, 27);
            label_dz_show.Size = new Size(36, 19);
            label_dz_show.Font = new Font("Segoe UI", 8);
            label_dx_show.Location = new Point(42, 60);
            label_dx_show.Size = new Size(36, 19);
            label_dx_show.Font = new Font("Segoe UI", 8);
            label_fmin_show.Location = new Point(49, 94);
            label_fmin_show.Size = new Size(36, 19);
            label_fmin_show.Font = new Font("Segoe UI", 8);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (originalFormSize.IsEmpty)
            {
                LattePanda = true;
            }
            else
            {
                if (WindowState != LastWindowState)
                {
                    LastWindowState = WindowState;
                    RescaleAll();
                }
            }         
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            RescaleAll();
        }

        private void ResizeControl(Rectangle r, Control c, Rectangle rPanel, Control cPanel)
        {
            //float xRatio = (float)(cPanel.Width) / (float)(rPanel.Width);
            //float yRatio = (float)(cPanel.Height) / (float)(rPanel.Height);
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void ResizePanel(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void RescaleAll()
        {
            ResizePanel(panel_logo_size, panel_logo);
            ResizePanel(panel_ic_size, panel_ic);
            ResizePanel(panel_header_size, panel_header);
            ResizePanel(panel_ic_button_size, panel_ic_button);
            ResizePanel(panel_start_stop_size, panel_start_stop);
            ResizePanel(panel_control_size, panel_control);
            for (int i = 0; i < 8; i++)
            {
                ResizeControl(button_ic_size[i], btnResize[i], panel_ic_button_size, panel_ic_button);
            }
            ResizeControl(button_stop_size, button_stop, panel_start_stop_size, panel_start_stop);
            ResizeControl(button_start_size, button_start, panel_start_stop_size, panel_start_stop);
            ResizeControl(button_connect_size, button_connect, panel_control_size, panel_control);
            ResizeControl(button_disconnect_size, button_disconnect, panel_control_size, panel_control);
            ResizeControl(button_calibration_size, button_calibration, panel_control_size, panel_control);
            ResizeControl(button_zero_size, button_upload, panel_control_size, panel_control);

            ResizeControl(groupBox_comport_size, groupBox_comport, panel_control_size, panel_control);
            ResizeControl(groupBox_status_size, groupBox_status, panel_control_size, panel_control);

            ResizeControl(groupBox_comport_size, groupBox_comport, panel_control_size, panel_control);
            ResizeControl(groupBox_status_size, groupBox_status, panel_control_size, panel_control);
            ResizeControl(groupBox_fnumbers_size, groupBox_fnumbers, panel_control_size, panel_control);

            ResizeControl(label_comport_size, label_comport, groupBox_comport_size, groupBox_comport);
            ResizeControl(label_baudrate_size, label_baudrate, groupBox_comport_size, groupBox_comport);
            ResizeControl(comboBox_portlists_size, comboBox_portlists, groupBox_comport_size, groupBox_comport);
            ResizeControl(comboBox_baudrate_size, comboBox_baudrate, groupBox_comport_size, groupBox_comport);

            ResizeControl(label_profilograph_size, label_profilograph, groupBox_status_size, groupBox_status);
            ResizeControl(label_timer_size, label_timer, groupBox_status_size, groupBox_status);
            ResizeControl(label_reading_size, label_reading, groupBox_status_size, groupBox_status);
            ResizeControl(label_profilograph_show_size, label_profilograph_show, groupBox_status_size, groupBox_status);
            ResizeControl(textBox_timer_size, textBox_timer, groupBox_status_size, groupBox_status);
            ResizeControl(label_reading_show_size, label_reading_show, groupBox_status_size, groupBox_status);
            ResizeControl(label_ff_size, label_dz, groupBox_fnumbers_size, groupBox_fnumbers);
            ResizeControl(label_fl_size, label_dx, groupBox_fnumbers_size, groupBox_fnumbers);
            ResizeControl(label_fmin_size, label_z_slope, groupBox_fnumbers_size, groupBox_fnumbers);
            ResizeControl(label_ff_show_size, label_dz_show, groupBox_fnumbers_size, groupBox_fnumbers);
            ResizeControl(label_fl_show_size, label_dx_show, groupBox_fnumbers_size, groupBox_fnumbers);
            ResizeControl(label_fmin_show_size, label_fmin_show, groupBox_fnumbers_size, groupBox_fnumbers);
        }

        private void comboBox_portlists_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_upload.Enabled = true;
            ColorButtons_panel_control();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            button_upload.Enabled = false;
            ColorButtons_panel_control();

            Task WaitforStop = new Task(() =>
            {
                SetTextLabelProfilo("- - - Uploading - - -");

                ArduinoSketchUploader uploader = new ArduinoSketchUploader(
                new ArduinoSketchUploaderOptions()
                {
                    FileName = folder + "Profile_TT_22_WinAppTest_V2.ino.hex",    
                    PortName = comboBox_portlists.Items[GetTextComboBoxPortlists()].ToString(),//comboBox_portlists.Text,
                    ArduinoModel = ArduinoModel.Mega2560
                }) ;
                uploader.UploadSketch();

                serialPort1.Close();
                MessageBox.Show("Download Complete");
                SetTextLabelProfilo("- - - Rebooting - - -");
                Task.Delay(10000).Wait();
                SetTextLabelProfilo("- - - Ready - - -");

                SetEnabledButtonConnect(true);
                ColorButtons_panel_control();
            });
            WaitforStop.Start();        
        }

        private void RescaleControl()
        {
            panel_logo_size = new Rectangle(panel_logo.Location.X, panel_logo.Location.Y, panel_logo.Size.Width, panel_logo.Size.Height);
            panel_ic_size = new Rectangle(panel_ic.Location.X, panel_ic.Location.Y, panel_ic.Size.Width, panel_ic.Size.Height);
            panel_header_size = new Rectangle(panel_header.Location.X, panel_header.Location.Y, panel_header.Size.Width, panel_header.Size.Height);
            panel_ic_button_size = new Rectangle(panel_ic_button.Location.X, panel_ic_button.Location.Y, panel_ic_button.Size.Width, panel_ic_button.Size.Height);
            panel_start_stop_size = new Rectangle(panel_start_stop.Location.X, panel_start_stop.Location.Y, panel_start_stop.Size.Width, panel_start_stop.Size.Height);
            panel_control_size = new Rectangle(panel_control.Location.X, panel_control.Location.Y, panel_control.Size.Width, panel_control.Size.Height);

            if(btnResize == null)    
                btnResize = new Button[8] { button_ic0, button_ic1, button_ic2, button_ic3, button_ic4, button_ic5, button_ic6, button_ic7 };
            for (int i = 0; i < 8; i++)
            {
                button_ic_size[i] = new Rectangle(btnResize[i].Location.X, btnResize[i].Location.Y, btnResize[i].Size.Width, btnResize[i].Size.Height);
            }
            button_stop_size = new Rectangle(button_stop.Location.X, button_stop.Location.Y, button_stop.Size.Width, button_stop.Size.Height);
            button_start_size = new Rectangle(button_start.Location.X, button_start.Location.Y, button_start.Size.Width, button_start.Size.Height);
            button_connect_size = new Rectangle(button_connect.Location.X, button_connect.Location.Y, button_connect.Size.Width, button_connect.Size.Height);
            button_disconnect_size = new Rectangle(button_disconnect.Location.X, button_disconnect.Location.Y, button_disconnect.Size.Width, button_disconnect.Size.Height);
            button_calibration_size = new Rectangle(button_calibration.Location.X, button_calibration.Location.Y, button_calibration.Size.Width, button_calibration.Size.Height);
            button_zero_size = new Rectangle(button_upload.Location.X, button_upload.Location.Y, button_upload.Size.Width, button_upload.Size.Height);

            groupBox_comport_size = new Rectangle(groupBox_comport.Location.X, groupBox_comport.Location.Y, groupBox_comport.Size.Width, groupBox_comport.Size.Height);
            groupBox_status_size = new Rectangle(groupBox_status.Location.X, groupBox_status.Location.Y, groupBox_status.Size.Width, groupBox_status.Size.Height);
            groupBox_fnumbers_size = new Rectangle(groupBox_fnumbers.Location.X, groupBox_fnumbers.Location.Y, groupBox_fnumbers.Size.Width, groupBox_fnumbers.Size.Height);

            label_comport_size = new Rectangle(label_comport.Location.X, label_comport.Location.Y, label_comport.Size.Width, label_comport.Size.Height);
            label_baudrate_size = new Rectangle(label_baudrate.Location.X, label_baudrate.Location.Y, label_baudrate.Size.Width, label_baudrate.Size.Height);
            comboBox_portlists_size = new Rectangle(comboBox_portlists.Location.X, comboBox_portlists.Location.Y, comboBox_portlists.Size.Width, comboBox_portlists.Size.Height);
            comboBox_baudrate_size = new Rectangle(comboBox_baudrate.Location.X, comboBox_baudrate.Location.Y, comboBox_baudrate.Size.Width, comboBox_baudrate.Size.Height);

            label_profilograph_size = new Rectangle(label_profilograph.Location.X, label_profilograph.Location.Y, label_profilograph.Size.Width, label_profilograph.Size.Height);
            label_timer_size = new Rectangle(label_timer.Location.X, label_timer.Location.Y, label_timer.Size.Width, label_timer.Size.Height);
            label_reading_size = new Rectangle(label_reading.Location.X, label_reading.Location.Y, label_reading.Size.Width, label_reading.Size.Height);
            label_profilograph_show_size = new Rectangle(label_profilograph_show.Location.X, label_profilograph_show.Location.Y, label_profilograph_show.Size.Width, label_profilograph_show.Size.Height);
            textBox_timer_size = new Rectangle(textBox_timer.Location.X, textBox_timer.Location.Y, textBox_timer.Size.Width, textBox_timer.Size.Height);
            label_reading_show_size = new Rectangle(label_reading_show.Location.X, label_reading_show.Location.Y, label_reading_show.Size.Width, label_reading_show.Size.Height);
            label_ff_size = new Rectangle(label_dz.Location.X, label_dz.Location.Y, label_dz.Size.Width, label_dz.Size.Height);
            label_fl_size = new Rectangle(label_dx.Location.X, label_dx.Location.Y, label_dx.Size.Width, label_dx.Size.Height);
            label_fmin_size = new Rectangle(label_z_slope.Location.X, label_z_slope.Location.Y, label_z_slope.Size.Width, label_z_slope.Size.Height);
            label_ff_show_size = new Rectangle(label_dz_show.Location.X, label_dz_show.Location.Y, label_dz_show.Size.Width, label_dz_show.Size.Height);
            label_fl_show_size = new Rectangle(label_dx_show.Location.X, label_dx_show.Location.Y, label_dx_show.Size.Width, label_dx_show.Size.Height);
            label_fmin_show_size = new Rectangle(label_fmin_show.Location.X, label_fmin_show.Location.Y, label_fmin_show.Size.Width, label_fmin_show.Size.Height);

            RescaleAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_profilograph_show.Text = "- - - Disconnected - - -";
            label_reading_show.Text = " - ";

            button_connect.Enabled = true;
            button_disconnect.Enabled = false;
            button_calibration.Enabled = false;
            button_upload.Enabled = false;
            button_start.Enabled = false;
            button_stop.Enabled = false;

            ColorButtons_panel_control();

            if (originalFormSize.IsEmpty)
            {
                if (LattePanda)
                {
                    ResizeComponents();
                    folder = @"C:\Users\LattePanda\Desktop\LineChartApp_V5\";
                }
                else
                {
                    folder = @"C:\Users\ASUS\source\repos\LineChartApp_V5\";
                }
                originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                RescaleControl();
                if (LattePanda) this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                MessageBox.Show("Port closed");
                serialPort1.Close();
            }
        }

        private void Connect()
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    if (!IsPortAvailable(serialPort1.PortName))
                    {
                        MessageBox.Show("Port is not avaiable.");
                        return;
                    }
                    serialPort1.PortName = comboBox_portlists.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox_baudrate.Text);
                    serialPort1.Open();
                    System.Threading.Thread.Sleep(1000);
                    serialPort1.Write("S" + textBox_timer.Text);
                    while (!StartProgram)
                    {
                        if (StartError)
                        {
                            StartError = false;
                            MessageBox.Show("There is no sensor connected.");
                            serialPort1.Close();
                            return;
                        }
                    }
                    button_connect.Enabled = false;
                    button_disconnect.Enabled = true;
                    button_calibration.Enabled = true;
                    button_upload.Enabled = false;
                    button_start.Enabled = true;
                    button_stop.Enabled = false;

                    groupBox_comport.Enabled = false;

                    label_profilograph_show.Text = "- - - Connected - - -";
                    label_profilograph_show.ForeColor = SystemColors.HotTrack;
                    label_reading_show.ForeColor = SystemColors.HotTrack;

                    ColorButtons_panel_control();

                    MessageBox.Show("Connected");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connecting to The Arduino Port " + comboBox_portlists.Text);
            Connect();
            Chart_Load();
            CurrentSeries(0);
        }

        private void Disconnect()
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("E");
                    while (StartProgram) { }

                    groupBox_comport.Enabled = true;

                    button_connect.Enabled = true;
                    button_disconnect.Enabled = false;
                    button_calibration.Enabled = false;
                    button_upload.Enabled = false;
                    button_start.Enabled = false;
                    button_stop.Enabled = false;

                    label_profilograph_show.Text = "- - - Disconnected - - -";
                    label_reading_show.Text = " - ";
                    label_profilograph_show.ForeColor = SystemColors.InactiveCaption;
                    label_reading_show.ForeColor = SystemColors.InactiveCaption;

                    ColorButtons_panel_control();

                    serialPort1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
            MessageBox.Show("Disconnected");
        }

        private bool IsPortAvailable(string portName)
        {
            // Retrieve the list of ports currently mounted by
            // the operating system (sorted by name)
            string[] ports = SerialPort.GetPortNames();
            if (ports != null && ports.Length > 0)
            {
                return ports.Where(new Func<string, bool>((s) =>
                {
                    return s.Equals(portName,
                                    StringComparison.InvariantCultureIgnoreCase);
                })).Count() == 1;
            }
            return false;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serialPort1.BytesToRead >= 4)
            {
                string dataIn = serialPort1.ReadLine();
                Data_Parsing(dataIn);

                if(updateData)
                {
                    senNum = Convert.ToInt32(Reading[2]);
                    Ax = Reading[0];
                    Ay = Reading[1];
                    IC[senNum, 0].Add(Ay);
                    dZ = (ushort)((senNum == 0 && (Math.Abs(D) < Math.Abs(2.61))) ? dZ + 1 : dZ);
                    D = Ay * scaleFactor[senNum];        
                    IC[senNum, 1].Add(D);
                    dX = (ushort)((senNum == 1 && (Math.Abs(D) < Math.Abs(4.4))) ? dX + 1 : dX);
                    L = (cnt > 1) ? IC[senNum, 2][cnt - 2]+D : 0;
                    Data = (senNum > 1) ? L : D;
                    this.BeginInvoke(new EventHandler(Show_Data));
                    IC[senNum, 2].Add(L);
                    if(cnt>1)   IC[senNum, 3].Add(IC[senNum, 1][cnt-1] - IC[senNum, 1][cnt-2]);
                    if(cnt>10)  IC[senNum, 4].Add(IC[senNum, 2][cnt-1] - IC[senNum, 2][cnt-11]);
                    IC[senNum, 5].Add(Ax);

                    SetTextLabelReading(string.Format(Ay.ToString()));
                    SetTextLabelDz(Math.Round((double)(dZ * 100 / cnt), 2).ToString() + "%");
                    SetTextLabelDx(Math.Round((double)(dX * 100 / cnt), 2).ToString() + "%");
                    /*if(IC[senNum, 3].Any()) SetTextLabelFF(Math.Round(F_numbers.FFValue(IC[senNum, 3]), 2).ToString());
                    if(IC[senNum, 4].Any()) SetTextLabelFL(Math.Round(F_numbers.FLValue(IC[senNum, 4]), 2).ToString());
                    if(IC[senNum, 3].Any()) SetTextLabelFmin(Math.Round(F_numbers.Fmin(IC[senNum, 3]), 2).ToString());*/
                    //this.BeginInvoke(new EventHandler(Show_Data));
                    updateData = false;
                }
                else
                {
                    //SetTextLabelReading(string.Format(" - "));
                }
            }
        }

        private void Data_Parsing(string dataIn)
        {
            sbyte indexOfPercent = (sbyte)dataIn.IndexOf("%");
            sbyte indexOfHash = (sbyte)dataIn.IndexOf("#");
            sbyte indexOfDollar = (sbyte)dataIn.IndexOf("$");
            sbyte indexOfExclamation = (sbyte)dataIn.IndexOf("!");
            sbyte indexOfAmpersand = (sbyte)dataIn.IndexOf("&");
            //sbyte indexOfStar = (sbyte)dataIn.IndexOf("*");

            byte Num = 0, j = 0;

            if (indexOfPercent != -1)
            {
                try
                {
                    string str_Reading = dataIn.Substring(0, indexOfPercent);

                    for (byte i = 0; i < indexOfPercent; i++)
                    {
                        if (str_Reading[i] == '@')
                        {
                            byte len = (byte)(i - j);
                            string Sub_Reading = str_Reading.Substring(j, len);
                            Reading[Num] = Convert.ToDouble(Sub_Reading);
                            Num++;
                            j = (byte)(i + 1);
                        }
                    }

                    updateData = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (indexOfHash != -1)
            {     
                try
                {
                    string str_Direction = dataIn.Substring(0, indexOfHash);
                    if (str_Direction == "Start")      StartProgram = true;
                    else if (str_Direction == "End")    StartProgram = false;
                    else if (str_Direction == "Error")  StartError = true;
                    else
                    {
                        for (byte i = 0; i < indexOfHash; i++)
                        {
                            if (str_Direction[i] == ',')
                            {
                                byte len = (byte)(i - j);
                                string Sub_Reading = str_Direction.Substring(j, len);

                                for (byte port = 0; port < Ports_Aval.Length; port++)
                                    Ports_Aval[Convert.ToByte(Sub_Reading)] = true;
                                
                                j = (byte)(i + 1);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (indexOfExclamation != -1)
            {
                try
                {
                    string str_Direction = dataIn.Substring(0, indexOfExclamation);
                    if (str_Direction == "Cal")         Calibration = true;
                    //else if (str_Direction == "Zero")   /*OneRound = true*/;         
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (indexOfAmpersand != -1)
            {
                try
                {
                    string str_Direction = dataIn.Substring(0, indexOfAmpersand);
                    if (str_Direction == "Drive") Runtrack = true;
                    else if (str_Direction == "Park")
                    {
                        MessageBox.Show("MOTOR STOPS");
                        Runtrack = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (indexOfDollar != -1)
            {
                try
                {
                    string str_Direction = dataIn.Substring(0, indexOfDollar);
                    if (str_Direction == "Cal Started")
                    {
                        SetTextLabelProfilo("- - - Calibrating Sensors - - -");
                    }
                    else if (str_Direction == "Cal Done")
                    {
                        SetEnabledButtonStart(true);
                        SetEnabledButtonDisconnect(true);
                        ColorButtons_panel_control();
                        SetTextLabelProfilo("- - - Calibration Finishes - - -");

                        string fileName = "Calibration.txt";
                        string fullPath = folder + fileName;
                        File.WriteAllLines(fullPath, calReading);
                        calReading.Clear();
                    }
                    else if (str_Direction == "Run")
                    {
                        Count++;
                        SetTextLabelProfilo("- - - Wheels Run for 300 mm. " + cnt + " - - -");
                    }
                    else if (str_Direction == "Stop")
                    {
                        cnt++;
                        SetTextLabelProfilo("- - - Stop and Collect Data " + cnt + " - - -");
                    }
                    else
                    {
                        calReading.Add(str_Direction);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                SetTextLabelReading(dataIn);
            }
        }

        private void Show_Data(object sender, EventArgs e)
        {
            chart1.Series["IC" + Convert.ToInt32(Reading[2])].Points.AddXY(0.3 * Count, Data);
            label_profilograph_show.Text = string.Format("Acceleration Y-Axis = {0} (/16384) Gravity ", Ay.ToString());
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            serialPort1.Write("D");
            while (!Runtrack) ;

            button_disconnect.Enabled = false;
            button_calibration.Enabled = false;
            button_upload.Enabled = false;
            button_start.Enabled = false;
            button_stop.Enabled = true;

            ColorButtons_panel_control();

            //CurrentSeries(0);
        }

        private void ColorButtons_panel_control()
        {
            foreach (Control btn in panel_control.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    if (btn.Enabled == true)
                    {
                        btn.BackColor = Color.FromArgb(0, 150, 136);
                        btn.ForeColor = Color.Gainsboro;
                    }
                    else
                    {
                        btn.BackColor = SystemColors.ControlDark;
                    }
                }
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            serialPort1.Write("P");
            Task WaitforStop = new Task(() =>
            {
                while (Runtrack) ;

                for (int i = 0; i < 8; i++)
                {
                    if (Ports_Aval[i])
                    {
                        string fileName = "IC" + i + "_Ay.txt";
                        string fullPath = folder + fileName;
                        List<string> result = IC[i, 0].Select(x => x.ToString()).ToList();
                        File.WriteAllLines(fullPath, result);
                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    if (Ports_Aval[i])
                    {
                        string fileName = "IC" + i + "_Ax.txt";
                        string fullPath = folder + fileName;
                        List<string> result = IC[i, 5].Select(x => x.ToString()).ToList();
                        File.WriteAllLines(fullPath, result);
                    }
                }

                SetEnabledButtonConnect(false);
                SetEnabledButtonDisconnect(true);
                SetEnabledButtonCalibration(!Calibration);
                SetEnabledButtonStart(true);
                SetEnabledButtonStop(false);

                ColorButtons_panel_control();
            });
            WaitforStop.Start();         
        }

        private void button_calibration_Click(object sender, EventArgs e)
        {
            serialPort1.Write("C");
            while (!Calibration) ;

            button_disconnect.Enabled = false;
            button_calibration.Enabled = false;
            button_upload.Enabled = false;
            button_start.Enabled = false;
            button_stop.Enabled = false;

            ColorButtons_panel_control();

            NoSeries();
        }
        
        private void SetEnabledButtonConnect(Boolean Enable)
        {
            if (this.button_connect.InvokeRequired)
            {
                SetEnabledCallback sec = new SetEnabledCallback(SetEnabledButtonConnect);
                this.Invoke(sec, new object[] { Enable });
            }
            else
            {
                this.button_connect.Enabled = Enable;
            }
        }

        private void SetEnabledButtonDisconnect(Boolean Enable)
        {
            if (this.button_disconnect.InvokeRequired)
            {
                SetEnabledCallback sec = new SetEnabledCallback(SetEnabledButtonDisconnect);
                this.Invoke(sec, new object[] { Enable });
            }
            else
            {
                this.button_disconnect.Enabled = Enable;
            }
        }

        private void SetEnabledButtonStart(Boolean Enable)
        {
            if (this.button_start.InvokeRequired)
            {
                SetEnabledCallback sec = new SetEnabledCallback(SetEnabledButtonStart);
                this.Invoke(sec, new object[] { Enable });
            }
            else
            {
                this.button_start.Enabled = Enable;
            }
        }

        private void SetEnabledButtonStop(Boolean Enable)
        {
            if (this.button_stop.InvokeRequired)
            {
                SetEnabledCallback sec = new SetEnabledCallback(SetEnabledButtonStop);
                this.Invoke(sec, new object[] { Enable });
            }
            else
            {
                this.button_stop.Enabled = Enable;
            }
        }

        private void SetEnabledButtonCalibration(Boolean Enable)
        {
            if (this.button_calibration.InvokeRequired)
            {
                SetEnabledCallback sec = new SetEnabledCallback(SetEnabledButtonCalibration);
                this.Invoke(sec, new object[] { Enable });
            }
            else
            {
                this.button_calibration.Enabled = Enable;
            }
        }

        private void SetEnabledButtonZero(Boolean Enable)
        {
            if (this.button_upload.InvokeRequired)
            {
                SetEnabledCallback sec = new SetEnabledCallback(SetEnabledButtonZero);
                this.Invoke(sec, new object[] { Enable });
            }
            else
            {
                this.button_upload.Enabled = Enable;
            }
        }

        private void comboBox_portlists_DropDown(object sender, EventArgs e)
        {
            string[] portlists = SerialPort.GetPortNames();
            comboBox_portlists.Items.Clear();
            comboBox_portlists.Items.AddRange(portlists);
        }

        private int GetTextComboBoxPortlists()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.comboBox_portlists.InvokeRequired)
            {
                GetTextCallback gtc = new GetTextCallback(GetTextComboBoxPortlists);
                return (int)Invoke(gtc);
            }
            else
            {
                return comboBox_portlists.SelectedIndex;
            }
        }

        private void SetTextLabelProfilo(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.label_profilograph_show.InvokeRequired)
            {
                SetTextCallback stc = new SetTextCallback(SetTextLabelProfilo);
                this.Invoke(stc, new object[] { text });
            }
            else
            {
                this.label_profilograph_show.Text = text;
            }
        }

        private void SetTextLabelReading(string text)
        {          
            if (this.label_reading_show.InvokeRequired)
            {
                SetTextCallback stc = new SetTextCallback(SetTextLabelReading);
                this.Invoke(stc, new object[] { text });
            }
            else
            {
                this.label_reading_show.Text = text;
            }
        }

        private void SetTextLabelDz(string text)
        {
            if (this.label_dz_show.InvokeRequired)
            {
                SetTextCallback stc = new SetTextCallback(SetTextLabelDz);
                this.Invoke(stc, new object[] { text });
            }
            else
            {
                this.label_dz_show.Text = text;
            }
        }

        private void SetTextLabelDx(string text)
        {
            if (this.label_dx_show.InvokeRequired)
            {
                SetTextCallback stc = new SetTextCallback(SetTextLabelDx);
                this.Invoke(stc, new object[] { text });
            }
            else
            {
                this.label_dx_show.Text = text;
            }
        }

        private void SetTextLabelFmin(string text)
        {
            if (this.label_fmin_show.InvokeRequired)
            {
                SetTextCallback stc = new SetTextCallback(SetTextLabelFmin);
                this.Invoke(stc, new object[] { text });
            }
            else
            {
                this.label_fmin_show.Text = text;
            }
        }
    }
}
