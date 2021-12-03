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
    public partial class intervalo : Form
    {
        public intervalo()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int v = Convert.ToInt32(nvointervalo.Value) * 60000;
            Form1.intervalo = v;
            this.Close();
        }

        private void Intervalo_Load(object sender, EventArgs e)
        {
            int val = Form1.intervalo / 60000;
            nvointervalo.Value = val;
        }

        private void Nvointervalo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
