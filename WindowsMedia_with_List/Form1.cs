using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace WindowsMedia_with_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] fileNames, filePaths;
        String[] fileNames_1, filePaths_1;
        Stack  input = new Stack() ;
        int [] daphat;

        DataTable Listnhac;
        DateTime day_of_week;
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                list_FileNhac.Items.Clear();
                fileNames = openFileDialog1.SafeFileNames;
                filePaths = openFileDialog1.FileNames;
                foreach (String filename in fileNames)
                {
                    list_FileNhac.Items.Add(filename);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //list_FileNhac.Items.Clear();
            if (CheckStartup())
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }
           // notifyIcon1.Visible = false;
            // Hiện BaloonTip hoặc không
             //notifyIcon1.ShowBalloonTip(10);
            // Chọn ẩn
            //this.Hide();
            // Hoặc
            //this.ShowInTaskbar = false;
           // WindowState = FormWindowState.Normal;
        }
        private void list_FileNhac_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   axWindowsMediaPlayer1.URL = ds.Tables[0].Rows[0][0].ToString();
         //string a =    axWindowsMediaPlayer1.currentPlaylist.name;
        }
        DataSet ds = new DataSet();
        DataSet ds_g = new DataSet();
        private void haiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.OmitXmlDeclaration = true;
            writerSettings.ConformanceLevel = ConformanceLevel.Fragment;
            writerSettings.CloseOutput = false;
            using (XmlWriter writer = XmlWriter.Create(Application.StartupPath + "\\Thu2.xml", writerSettings))
            {
                writer.WriteStartElement("Thu2");
                for (int i = 0; i <= list_FileNhac.Items.Count -1 ; i++)
                {
                    writer.WriteElementString("Ten",  filePaths[i] );
                }
                writer.WriteEndElement();
                writer.Flush();
            }
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(Application.StartupPath + "\\Thu2.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile); 
        }
        int dem = 0;
        Random rd = new Random();
       public static bool is_read = false;
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            //XmlReader xmlFile;
            //xmlFile = XmlReader.Create(Application.StartupPath + "\\Thu2.xml", new XmlReaderSettings());
            //if (is_read == false)
            //{
            //    is_read = true;
            //    if (list_FileNhac.Items.Count == 0 )
            //         {
            //    ds.ReadXml(xmlFile);
            //    if (ds.Tables.Count != 0)
            //    {
            //        for (int i = 0; i <= ds.Tables[0].Rows.Count -1; i++)
            //        {
            //            list_FileNhac.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            //        }

            //        dem = rd.Next(0, ds.Tables[0].Rows.Count - 1);
            //            input.Push(dem);
            //        }
            //    }
            //}

            //if (textBox1.Text == "")
            //{
            //    if (ds.Tables.Count != 0  )
            //    {
            //     // timer1.Enabled = false;
            //        timer2.Enabled = true;
            //        textBox1.Text = "batdau";
            //        axWindowsMediaPlayer1.URL = ds.Tables[0].Rows[dem][0].ToString();
            //        chaytime();
            //    }  
            //}
            try
            {
                if (is_read == false)
                {
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                    {
                        is_read = true;
                        DataSet ds = new DataSet();
                        ds.ReadXml(Environment.CurrentDirectory + @"\day2.xml", XmlReadMode.Auto);
                        Listnhac = ds.Tables[0];
                        day_of_week = DateTime.Now;
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                    {
                        is_read = true;
                        DataSet ds = new DataSet();
                        ds.ReadXml(Environment.CurrentDirectory + @"\day3.xml", XmlReadMode.Auto);
                        Listnhac = ds.Tables[0];
                        day_of_week = DateTime.Now;
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                    {
                        is_read = true;
                        DataSet ds = new DataSet();
                        ds.ReadXml(Environment.CurrentDirectory + @"\day4.xml", XmlReadMode.Auto);
                        Listnhac = ds.Tables[0];
                        day_of_week = DateTime.Now;
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                    {
                        is_read = true;
                        DataSet ds = new DataSet();
                        ds.ReadXml(Environment.CurrentDirectory + @"\day5.xml", XmlReadMode.Auto);
                        Listnhac = ds.Tables[0];
                        day_of_week = DateTime.Now;
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                    {
                        is_read = true;
                        DataSet ds = new DataSet();
                        ds.ReadXml(Environment.CurrentDirectory + @"\day6.xml", XmlReadMode.Auto);
                        Listnhac = ds.Tables[0];
                        day_of_week = DateTime.Now;
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                    {
                        is_read = true;
                        DataSet ds = new DataSet();
                        ds.ReadXml(Environment.CurrentDirectory + @"\day7.xml", XmlReadMode.Auto);
                        Listnhac = ds.Tables[0];
                        day_of_week = DateTime.Now;
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                    {
                        is_read = true;
                        DataSet ds = new DataSet();
                        ds.ReadXml(Environment.CurrentDirectory + @"\day8.xml", XmlReadMode.Auto);
                        Listnhac = ds.Tables[0];
                        day_of_week = DateTime.Now;
                    }
                }
                if (day_of_week.DayOfWeek != DateTime.Now.DayOfWeek)
                {
                    is_read = false;
                }
            }
            catch (Exception)
            {
            }
           
        }
        private bool check(int a) 
        {
            bool ab = false;
            for (int i = 0; i <= input.Count - 1; i++)
            {
                if (Convert.ToInt32(input.ToArray().GetValue(i)) == a)
                {
                    ab = false;
                    return ab;
                }
                else
                {
                    ab = true;
                }    
            }
            return ab;
        }
        async void chaytime()
        {
            await Task.Run( ()=>
            {
                if (dem <= ds.Tables[0].Rows.Count - 1)
                {
                    dem = rd.Next(0, ds.Tables[0].Rows.Count);
                    if (input.Count != 0)
                    {
                        if (input.Count == ds.Tables[0].Rows.Count)
                        {
                            input.Clear();
                            chaytime();
                        }
                        if (check(dem) == false)
                            {
                               chaytime();
                               //dem = rd.Next(0, ds.Tables[0].Rows.Count - 1);
                            }
                            else
                            {
                                input.Push(dem);
                            }
                    }
                    else
                    {
                        input.Push(dem);
                    }
                    Properties.Settings.Default.index = dem;
                    Properties.Settings.Default.Save();
                }
               // Task.Delay(500).Wait();
            });
            try
            {
                label1.Text += dem + " - ";
            }
            catch (Exception)
            {
            }
           // timer1.Enabled = true;
        }
            
        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox1.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.close();
            }
        }
        private void timer_ThoiGian_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                return;
            }
            //bat
            if (DateTime.Now.Hour == 11 & DateTime.Now.Minute == 55)
            {
                checkBox1.Checked = true;
            }
            else if (DateTime.Now.Hour == 8 & DateTime.Now.Minute == 15 & DateTime.Now.Second >= 0 & DateTime.Now.Second < 10 )
            {
                //
                if (lisl_codinh.Items.Count == 0)
                {
                    XmlReader xmlFile;
                    xmlFile = XmlReader.Create(Application.StartupPath + "\\Codinh.xml", new XmlReaderSettings());
                    ds_g.ReadXml(xmlFile);
                    if (ds_g.Tables.Count != 0)
                    {
                        for (int i = 0; i <= ds_g.Tables[0].Rows.Count - 1; i++)
                        {
                            lisl_codinh.Items.Add(ds_g.Tables[0].Rows[i][0].ToString());
                        }
                    }
                }
                if (textBox1.Text == ""  & axWindowsMediaPlayer1.currentPlaylist.count == 0)
                {
                    timer2.Enabled = true;
                    textBox1.Text = "batdau";
                    axWindowsMediaPlayer1.URL = ds_g.Tables[0].Rows[0][0].ToString();
                }
            }
            else if (DateTime.Now.Hour == 7 & DateTime.Now.Minute == 50)
            {
              //  list_FileNhac.Items.Clear();
                checkBox1.Checked = true;
            }
            else if (DateTime.Now.Hour == 10 & DateTime.Now.Minute == 0)
            {
                checkBox1.Checked = true;
            }
            else if (DateTime.Now.Hour == 13 & DateTime.Now.Minute == 0)
            {
                checkBox1.Checked = true;
            }
            else if (DateTime.Now.Hour == 15 & DateTime.Now.Minute == 0)
            {
                checkBox1.Checked = true;
            }
            else if (DateTime.Now.Hour == 16 & DateTime.Now.Minute == 55)
            {
                checkBox1.Checked = true;
            }
            //tat
            if (DateTime.Now.Hour == 12 & DateTime.Now.Minute == 5)
            {
                checkBox1.Checked = false;
                axWindowsMediaPlayer1.currentPlaylist.clear();
            }
            else if(DateTime.Now.Hour == 8 & DateTime.Now.Minute == 15 & DateTime.Now.Second == 30 )
            {
                axWindowsMediaPlayer1.close();
                axWindowsMediaPlayer1.currentPlaylist.clear();
            }
            else if (DateTime.Now.Hour == 8 & DateTime.Now.Minute == 00)
            {
                checkBox1.Checked = false;
                axWindowsMediaPlayer1.currentPlaylist.clear();
            }
            else if (DateTime.Now.Hour == 10 & DateTime.Now.Minute == 15)
            {
                checkBox1.Checked = false;
                axWindowsMediaPlayer1.currentPlaylist.clear();
            }
            else if (DateTime.Now.Hour == 13 & DateTime.Now.Minute == 15)
            {
                checkBox1.Checked = false;
                axWindowsMediaPlayer1.currentPlaylist.clear();
            }
            else if (DateTime.Now.Hour == 15 & DateTime.Now.Minute == 15)
            {
                checkBox1.Checked = false;
                axWindowsMediaPlayer1.currentPlaylist.clear();
            }
            else if (DateTime.Now.Hour == 17 & DateTime.Now.Minute == 15)
            {
                dem = 0;
                input.Clear();
                ds.Clear();
                ds_g.Clear();
                list_FileNhac.Items.Clear();
                lisl_codinh.Items.Clear();
                is_read = false;
                checkBox1.Checked = false;
                label1.Text = "";
                axWindowsMediaPlayer1.currentPlaylist.clear();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.close();
            input.Clear();
           // dem = rd.Next(0,12);
        }

        private void codinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.OmitXmlDeclaration = true;
            writerSettings.ConformanceLevel = ConformanceLevel.Fragment;
            writerSettings.CloseOutput = false;
            using (XmlWriter writer = XmlWriter.Create(Application.StartupPath + "\\Codinh.xml", writerSettings))
            {
                writer.WriteStartElement("Codinh");
                for (int i = 0; i <= lisl_codinh.Items.Count - 1; i++)
                {
                    writer.WriteElementString("Ten", filePaths_1[i]);
                }
                writer.WriteEndElement();
                writer.Flush();
            }
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(Application.StartupPath + "\\Codinh.xml", new XmlReaderSettings());
            ds_g.ReadXml(xmlFile);
        }

        private void openFileCodinhToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lisl_codinh.Items.Clear();
                fileNames_1 = openFileDialog1.SafeFileNames;
                filePaths_1 = openFileDialog1.FileNames;
                foreach (String filename in fileNames_1)
                {
                    lisl_codinh.Items.Add(filename);
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox2.Checked == true)
                {
                    RegisterInStartup(true);
                }else
                {
                    RegisterInStartup(false);
                }    
               
                //CheckStartup();
            }
            catch (Exception)
            {
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void càiĐătToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting st = new Setting();
            st.Show();
           // this.WindowState = FormWindowState.Normal;
           // this.ShowInTaskbar = true;
           // this.StartPosition = FormStartPosition.CenterScreen;
            
           
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                // Ẩn notifyIcon đi
                notifyIcon1.Visible = false;
                // Cách này
                WindowState = FormWindowState.Normal;
               // this.BringToFront();
                this.Show();
                this.ShowInTaskbar = true;
                // Hoặc
                // Hoặc cả 2 miễn là phải tương ứng với lúc ẩn
            }
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                // Cho hiện notifyIcon
                notifyIcon1.Visible = true;
                // Hiện BaloonTip hoặc không
               // notifyIcon1.ShowBalloonTip(10);

                // Chọn ẩn
                this.Hide();
                // Hoặc
                this.ShowInTaskbar = false;
                WindowState = FormWindowState.Minimized;
                // Hoặc cả 2 để ẩn form

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmread frm = new frmread() ;
            frm.Show();
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            Setting st = new Setting();
            st.ShowDialog();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Listnhac != null)
                {
                    for (int i = 0; i <= Listnhac.Rows.Count - 1; i++)
                    {
                        if (Convert.ToDateTime(Listnhac.Rows[i]["TG"]).Hour == DateTime.Now.Hour && Convert.ToDateTime(Listnhac.Rows[i]["TG"]).Minute == DateTime.Now.Minute &&
                            Convert.ToDateTime(Listnhac.Rows[i]["TG"]).Second == DateTime.Now.Second)
                        {
                            axWindowsMediaPlayer1.URL = Listnhac.Rows[i]["dd"].ToString();
                        }
                        else if (Convert.ToDateTime(Listnhac.Rows[i]["TGKT"]).Hour == DateTime.Now.Hour && Convert.ToDateTime(Listnhac.Rows[i]["TGKT"]).Minute == DateTime.Now.Minute &&
                            Convert.ToDateTime(Listnhac.Rows[i]["TGKT"]).Second == DateTime.Now.Second)
                        {
                            axWindowsMediaPlayer1.close();
                        }
                    }
                }
                
            }
            catch (Exception)
            {
            }  
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private bool CheckStartup() 
        {
            bool CheckStartup = false;

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            // Nếu key này tồn tại thì việc đăng ký là thành công
            var rg = registryKey.GetValue("WindowsMedia_with_List");
            if (rg != null)
            {
                CheckStartup = true;
            }

            return CheckStartup;
        }
        private void RegisterInStartup(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (isChecked)
            {
                // Đăng ký stratup cùng Windows
                registryKey.SetValue("WindowsMedia_with_List", Directory.GetCurrentDirectory() + "\\WindowsMedia_with_List.exe");
            }
            else
            {
                // Hủy đăng ký
                registryKey.DeleteValue("WindowsMedia_with_List");
            }
        }
    }
}
