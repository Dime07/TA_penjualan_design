using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desain_TA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string pesan(string msg)
        {
            string msg_klr;
            msg_klr= (message.Text = msg);
            return msg_klr;
        }

        private void button_beli_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
