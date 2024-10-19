using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace WindowsMedia_with_List
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Setting_Load(object sender, EventArgs e)
        {
            var time = DateTime.Now.GetHashCode();
            capnhap();
        }
        private void capnhap()
        {
            try
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml(Application.StartupPath + @"\day2.xml", XmlReadMode.Auto);
                    if (ds.Tables.Count > 0)
                        dataGridView1.DataSource = ds?.Tables[0];
                    else if (dataGridView1.Rows.Count == 1) dataGridView1.Rows.RemoveAt(0);
                }
                else if (tabControl1.SelectedIndex == 1)
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml(Application.StartupPath + @"\day3.xml", XmlReadMode.Auto);
                    if (ds.Tables.Count > 0)
                        dataGridView2.DataSource = ds?.Tables[0];
                    else if (dataGridView2.Rows.Count == 1) dataGridView2.Rows.RemoveAt(0);
                }
                else if (tabControl1.SelectedIndex == 2)
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml(Application.StartupPath + @"\day4.xml", XmlReadMode.Auto);
                    if (ds.Tables.Count > 0)
                        dataGridView3.DataSource = ds?.Tables[0];
                    else if (dataGridView3.Rows.Count == 1) dataGridView3.Rows.RemoveAt(0);
                }
                else if (tabControl1.SelectedIndex == 3)
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml(Application.StartupPath + @"\day5.xml", XmlReadMode.Auto);
                    if (ds.Tables.Count > 0)
                        dataGridView4.DataSource = ds?.Tables[0];
                    else if (dataGridView4.Rows.Count == 1) dataGridView4.Rows.RemoveAt(0);
                }
                else if (tabControl1.SelectedIndex == 4)
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml(Application.StartupPath + @"\day6.xml", XmlReadMode.Auto);
                    if (ds.Tables.Count > 0)
                        dataGridView5.DataSource = ds?.Tables[0];
                    else if (dataGridView5.Rows.Count == 1) dataGridView5.Rows.RemoveAt(0);
                }
                else if (tabControl1.SelectedIndex == 5)
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml(Application.StartupPath + @"\day7.xml", XmlReadMode.Auto);
                    if (ds.Tables.Count > 0)
                        dataGridView6.DataSource = ds?.Tables[0];
                    else if (dataGridView6.Rows.Count == 1) dataGridView6.Rows.RemoveAt(0);
                }
                else if (tabControl1.SelectedIndex == 6)
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml(Application.StartupPath + @"\day8.xml", XmlReadMode.Auto);
                    if (ds.Tables.Count > 0)
                        dataGridView7.DataSource = ds?.Tables[0];
                    else if (dataGridView7.Rows.Count == 1) dataGridView7.Rows.RemoveAt(0);
                }
            }
            catch (Exception)
            {
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            capnhap();
            Form1.is_read = false;
            MessageBox.Show(" Đã cập nhập !");
        }


        private void button1_Click(object sender, EventArgs e)
        {

            String[] fileten;
            String[] filepath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileten = openFileDialog1.SafeFileNames;
                filepath = openFileDialog1.FileNames;
                txtten.Text = fileten[0].ToString();
                txtpath.Text = filepath[0].ToString();
                txtid.Text = dataGridView1.Rows.Count.ToString();
                btsua.Enabled = false;
                btxoa.Enabled = false;
                btluu.Enabled = true;
            }
            Random rd = new Random();
            txtid.Text = rd.Next(1, 100000).ToString();
            // update_ToDocument(1)
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtten.Text = dataGridView1.Rows[e.RowIndex].Cells["ten"].Value.ToString();
                txtid.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtpath.Text = dataGridView1.Rows[e.RowIndex].Cells["dd"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["TG"].Value);
                dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["TGKT"].Value);
            }
        }
        private void reset()
        {
            txtten.Text = "";
            txtid.Text = "";
            txtpath.Text = "";
        }
        private void btxoa_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                //XmlDocument xmldoc = new XmlDocument(); xmldoc.Load(Application.StartupPath + "\\day2.xml");
                //XmlNode xmlnode = xmldoc.DocumentElement.ChildNodes.Item(Convert.ToInt32(txtid.Text));
                //xmlnode.ParentNode.RemoveChild(xmlnode);
                //xmldoc.Save(Application.StartupPath + "\\day2.xml");

                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        xmlhelper.deleteAnElement(Application.StartupPath + "\\day2.xml", txtid.Text);
                        break;
                    case 1:
                        xmlhelper.deleteAnElement(Application.StartupPath + "\\day3.xml", txtid.Text);
                        break;
                    case 2:
                        xmlhelper.deleteAnElement(Application.StartupPath + "\\day4.xml", txtid.Text);
                        break;
                    case 3:
                        xmlhelper.deleteAnElement(Application.StartupPath + "\\day5.xml", txtid.Text);
                        break;
                    case 4:
                        xmlhelper.deleteAnElement(Application.StartupPath + "\\day6.xml", txtid.Text);
                        break;
                    case 5:
                        xmlhelper.deleteAnElement(Application.StartupPath + "\\day7.xml", txtid.Text);
                        break;
                    case 6:
                        xmlhelper.deleteAnElement(Application.StartupPath + "\\day8.xml", txtid.Text);
                        break;
                }
                capnhap();
                reset();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (btthem.Enabled == true)
            {
                Dictionary<string, string> newPhim = new Dictionary<string, string>();
                newPhim.Add("ten", txtten.Text);
                newPhim.Add("TG", dateTimePicker1.Text);
                newPhim.Add("dd", txtpath.Text);
                newPhim.Add("TGKT", dateTimePicker2.Text);
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        xmlhelper.insertToDocument(Application.StartupPath + "\\day2.xml", newPhim);
                        break;
                    case 1:
                        xmlhelper.insertToDocument(Application.StartupPath + "\\day3.xml", newPhim);
                        break;
                    case 2:
                        xmlhelper.insertToDocument(Application.StartupPath + "\\day4.xml", newPhim);
                        break;
                    case 3:
                        xmlhelper.insertToDocument(Application.StartupPath + "\\day5.xml", newPhim);
                        break;
                    case 4:
                        xmlhelper.insertToDocument(Application.StartupPath + "\\day6.xml", newPhim);
                        break;
                    case 5:
                        xmlhelper.insertToDocument(Application.StartupPath + "\\day7.xml", newPhim);
                        break;
                    case 6:
                        xmlhelper.insertToDocument(Application.StartupPath + "\\day8.xml", newPhim);
                        break;
                }
                capnhap();
                reset();
            }
            else if (btsua.Enabled == true)
            {
                Dictionary<string, string> newPhim = new Dictionary<string, string>();
                newPhim.Add("ten", txtten.Text);
                newPhim.Add("TG", dateTimePicker1.Text);
                newPhim.Add("dd", txtpath.Text);
                newPhim.Add("TGKT", dateTimePicker2.Text);
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        xmlhelper.updateAnElement(Application.StartupPath + "\\day2.xml", txtid.Text, newPhim);
                        break;
                    case 1:
                        xmlhelper.updateAnElement(Application.StartupPath + "\\day3.xml", txtid.Text, newPhim);
                        break;
                    case 2:
                        xmlhelper.updateAnElement(Application.StartupPath + "\\day4.xml", txtid.Text, newPhim);
                        break;
                    case 3:
                        xmlhelper.updateAnElement(Application.StartupPath + "\\day5.xml", txtid.Text, newPhim);
                        break;
                    case 4:
                        xmlhelper.updateAnElement(Application.StartupPath + "\\day6.xml", txtid.Text, newPhim);
                        break;
                    case 5:
                        xmlhelper.updateAnElement(Application.StartupPath + "\\day7.xml", txtid.Text, newPhim);
                        break;
                    case 6:
                        xmlhelper.updateAnElement(Application.StartupPath + "\\day8.xml", txtid.Text, newPhim);
                        break;
                }
                capnhap();
                reset();
            }
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btthem.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String[] fileten;
            String[] filepath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileten = openFileDialog1.SafeFileNames;
                filepath = openFileDialog1.FileNames;
                txtten.Text = fileten[0].ToString();
                txtpath.Text = filepath[0].ToString();
                btthem.Enabled = false;
                btxoa.Enabled = false;
                btluu.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            capnhap();
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    txtten.Text = dataGridView2.Rows[e.RowIndex].Cells["ten1"].Value.ToString();
                    txtid.Text = dataGridView2.Rows[e.RowIndex].Cells["id1"].Value.ToString();
                    txtpath.Text = dataGridView2.Rows[e.RowIndex].Cells["dd1"].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["TG1"].Value);
                    dateTimePicker2.Value = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["TGKT3"].Value);
                }
                catch (Exception)
                {
                }
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    txtten.Text = dataGridView3.Rows[e.RowIndex].Cells["ten4"].Value.ToString();
                    txtid.Text = dataGridView3.Rows[e.RowIndex].Cells["id4"].Value.ToString();
                    txtpath.Text = dataGridView3.Rows[e.RowIndex].Cells["dd4"].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView3.Rows[e.RowIndex].Cells["TG4"].Value);
                    dateTimePicker2.Value = Convert.ToDateTime(dataGridView3.Rows[e.RowIndex].Cells["TGKT4"].Value);
                }
                catch (Exception)
                {
                }
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    txtten.Text = dataGridView4.Rows[e.RowIndex].Cells["ten5"].Value.ToString();
                    txtid.Text = dataGridView4.Rows[e.RowIndex].Cells["id5"].Value.ToString();
                    txtpath.Text = dataGridView4.Rows[e.RowIndex].Cells["dd5"].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView4.Rows[e.RowIndex].Cells["TG5"].Value);
                    dateTimePicker2.Value = Convert.ToDateTime(dataGridView4.Rows[e.RowIndex].Cells["TGKT5"].Value);
                }
                catch (Exception)
                {
                }

            }
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    txtten.Text = dataGridView5.Rows[e.RowIndex].Cells["ten6"].Value.ToString();
                    txtid.Text = dataGridView5.Rows[e.RowIndex].Cells["id6"].Value.ToString();
                    txtpath.Text = dataGridView5.Rows[e.RowIndex].Cells["dd6"].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView5.Rows[e.RowIndex].Cells["TG6"].Value);
                    dateTimePicker2.Value = Convert.ToDateTime(dataGridView5.Rows[e.RowIndex].Cells["TGKT6"].Value);
                }
                catch (Exception)
                {
                }
            }
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    txtten.Text = dataGridView6.Rows[e.RowIndex].Cells["ten7"].Value.ToString();
                    txtid.Text = dataGridView6.Rows[e.RowIndex].Cells["id7"].Value.ToString();
                    txtpath.Text = dataGridView6.Rows[e.RowIndex].Cells["dd7"].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView6.Rows[e.RowIndex].Cells["TG7"].Value);
                    dateTimePicker2.Value = Convert.ToDateTime(dataGridView6.Rows[e.RowIndex].Cells["TGKT7"].Value);
                }
                catch (Exception)
                {
                }

            }
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    txtten.Text = dataGridView7.Rows[e.RowIndex].Cells["ten8"].Value.ToString();
                    txtid.Text = dataGridView7.Rows[e.RowIndex].Cells["id8"].Value.ToString();
                    txtpath.Text = dataGridView7.Rows[e.RowIndex].Cells["dd8"].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView7.Rows[e.RowIndex].Cells["TG8"].Value);
                    dateTimePicker2.Value = Convert.ToDateTime(dataGridView7.Rows[e.RowIndex].Cells["TGKT8"].Value);
                }
                catch (Exception)
                {


                }

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
