using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace WindowsMedia_with_List
{
    public partial class frmread : Form
    {
        const string _apiURL = "http://translate.google.com/translate_tts?tl={0}&q={1}";
        public frmread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            //speechSynthesizer.Rate = 1;
            //speechSynthesizer.Speak(textBox1.Text);
            axWindowsMediaPlayer1.URL = string.Format(_apiURL,comboBox1.Text ,System.Net.WebUtility.UrlEncode(textBox1.Text));
        }
    }
}
