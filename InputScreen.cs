using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021512001_MTA_SayiYaziCevirme
{
    public partial class InputScreen : Form
    {
        private Form1 mainForm;
        public InputScreen(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.girilenSayi = Convert.ToInt32(textBox1.Text);
            Close();
        }
    }
}
