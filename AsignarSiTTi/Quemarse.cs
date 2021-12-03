using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AsignarSiTTi
{
    public partial class Quemarse : Form
    {
        public Quemarse()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1.intvalquemarse = Convert.ToDouble(intvalquemarse.Value);
            this.Close();
        }

        private void Quemarse_Load(object sender, EventArgs e)
        {
            intvalquemarse.Value = Convert.ToDecimal(Form1.intvalquemarse);
        }

        private void Intvalquemarse_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
