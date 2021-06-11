using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace WindowsMedia_with_List
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        Thread th;

        [Obsolete]
        private void Start_Load(object sender, EventArgs e)
        {
            a();
            //th = new Thread(a);
            //th.ApartmentState = ApartmentState.STA;
            //th.Start();
        }
         void a()
        {
            Form1 fm = new Form1();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
