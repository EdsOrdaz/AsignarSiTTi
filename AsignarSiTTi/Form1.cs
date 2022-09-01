using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace AsignarSiTTi
{
    public partial class Form1 : Form
    {
        #region BD
        private String versiontext = "1.161";
        private String version = "68855bf330a3df0321798aaef02e4eada27df5c2";
        private String conexionsqllast = "server=148.223.153.37,5314; database=InfEq;User ID=eordazs;Password=Corpame*2013; integrated security = false ; MultipleActiveResultSets=True";
        public static String servivorSirac = "148.223.153.43\\MSSQLSERVER1";
        public static String basededatosSirac = "bd_SiRAc";
        public static String usuariobdSirac = "sa";
        public static String passbdSirac = "At3n4";
        public static string nsqlExSirac = "server=" + servivorSirac + "; database=" + basededatosSirac + " ;User ID=" + usuariobdSirac + ";Password=" + passbdSirac + "; integrated security = false ; MultipleActiveResultSets=True";
        #endregion
        public static int intervalo;
        public static double intvalquemarse;
        public static String nsittis;
        public static int ns = 0;

        public int intvalquemarseejecutar = 60000;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion2 = new SqlConnection(conexionsqllast))
                {
                    conexion2.Open();
                    String sql2 = "SELECT (SELECT valor FROM Configuracion WHERE nombre='Asignar_Version') as version,valor FROM Configuracion WHERE nombre='Asignar_hash'";
                    SqlCommand comm2 = new SqlCommand(sql2, conexion2);
                    SqlDataReader nwReader2 = comm2.ExecuteReader();
                    if (nwReader2.Read())
                    {
                        if (nwReader2["valor"].ToString() != version)
                        {
                            MessageBox.Show("No se puede inciar sesion porque hay una nueva version.\n\nNueva Version: " + nwReader2["version"].ToString() + "\nVersion actual: " + versiontext + "\n\nEl programa se cerrara.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puedo verificar la version del programa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en validar la version del programa\n\nMensaje: " + ex.Message, "Información del Equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            intervalo = 60000;
            intvalquemarse = 10;
            label2.Parent = pictureBox1;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            nsittis = "";
            ns = 0;
            if (porquemarse.Checked == true)
            {
                //Intervalo del tiemer por quemarse (ejecutarse cada min)
                timer1.Interval = intvalquemarseejecutar;
                try
                {
                    SqlConnection conexion;
                    conexion = new SqlConnection(nsqlExSirac);
                    conexion.Open();
                    //String sql = "SELECT top (5) * FROM [bd_SiTTi].[dbo].[ms_ticket]  where id_ms_ticket=95816";
                    String sql = "SELECT * FROM [bd_SiTTi].[dbo].[ms_ticket] where id_area_soporte IS NULL";
                    SqlCommand comm = new SqlCommand(sql, conexion);
                    SqlDataReader nwReader = comm.ExecuteReader();

                    int quemado = 0;
                    while (nwReader.Read())
                    {
                        //obtener fecha pa quemarse
                        DateTime f1 = DateTime.Parse(nwReader["fecha_asigC"].ToString());
                        //obtener fecha actual
                        DateTime f2 = DateTime.Now;
                        //obtener fecha minutos pa quemarse
                        DateTime f3 = f1.AddMinutes(-intvalquemarse);

                        int dif = DateTime.Compare(DateTime.Now, f3);
                        /*
                        Console.WriteLine(dif);
                        Console.WriteLine("actual: " + DateTime.Now);
                        Console.WriteLine("se quema: " + f1);
                        Console.WriteLine("avisar en: " + f3);
                        */

                        if(dif > 0)
                        {
                            int dif2 = DateTime.Compare(DateTime.Now, DateTime.Parse(nwReader["fecha_asigC"].ToString()));
                            if(dif2 > 0)
                            {
                                quemado++;
                            }
                            ns++;
                        }
                    }

                    if (ns > 0)
                    {
                        this.Show();
                        if(quemado > 0)
                        {
                            this.BackColor = Color.Crimson;
                        }
                        else
                        {
                            this.BackColor = Color.DarkOrange;
                        }
                        String plural = (ns > 1) ? "tickets" : "ticket";
                        if (activadasToolStripMenuItem.Checked)
                        {
                            notifyIcon1.ShowBalloonTip(5000, "Nuevo SiTTi", "Tienes " + ns + " " + plural + " por quemarse.", ToolTipIcon.None);
                        }
                        label2.Text = ns.ToString();
                        Console.WriteLine("Sitti por quemarse");
                    }
                    else
                    {
                        this.Hide();
                        this.BackColor = SystemColors.Control;
                        label2.Text = "0";
                        Console.WriteLine("Sin sittis por quemarse.");
                    }
                }
                catch
                {
                    notifyIcon1.ShowBalloonTip(5000, "Error", "Error de conexión", ToolTipIcon.Error);
                    Console.WriteLine("Error de conexión");
                }
            }
            else
            {
                //Intervalo del tiemer por crearse (definido en inertvalo form)
                timer1.Interval = intervalo;
                ns = 0;
                try
                {
                    SqlConnection conexion;
                    conexion = new SqlConnection(nsqlExSirac);
                    conexion.Open();
                    String sql = "SELECT * FROM [bd_SiTTi].[dbo].[ms_ticket] where id_asigno IS NULL";
                    //String sql = "SELECT top (1) * FROM [bd_SiTTi].[dbo].[ms_ticket]";
                    SqlCommand comm = new SqlCommand(sql, conexion);
                    SqlDataReader nwReader = comm.ExecuteReader();
                    int quemado = 0;
                    while (nwReader.Read())
                    {
                        ns++;
                        int dif = DateTime.Compare(DateTime.Now, DateTime.Parse(nwReader["fecha_asigC"].ToString()));
                        if(dif>0)
                        {
                            quemado++;
                        }
                    }
                    if (ns > 0)
                    {
                        this.Show();
                        if(quemado>0)
                        {
                            this.BackColor = Color.Crimson;
                        }
                        else
                        {
                            this.BackColor = Color.DarkOrange;
                        }
                        String plural = (ns > 1) ? "tickets" : "ticket";
                        if (activadasToolStripMenuItem.Checked)
                        {
                            notifyIcon1.ShowBalloonTip(5000, "Nuevo SiTTi", "Tienes " + ns + " " + plural + " por asignar.", ToolTipIcon.None);
                        }
                        label2.Text = ns.ToString();

                        Console.WriteLine("Sitti por asignar");
                    }
                    else
                    {
                        this.Hide();
                        this.BackColor = SystemColors.Control;
                        label2.Text = "0";
                        Console.WriteLine("Sin sittis por asignar.");
                    }
                }
                catch
                {
                    notifyIcon1.ShowBalloonTip(5000, "Error", "Error de conexión", ToolTipIcon.Error);
                    Console.WriteLine("Error de conexión");
                }
            }
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void RevisarAhoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer1_Tick(sender, e);
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Timer1_Tick(sender, e);
            //this.Hide();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
             this.Hide();
        }

        private void Alcrearse_CheckedChanged(object sender, EventArgs e)
        {
            if(alcrearse.Checked)
            {
                porquemarse.Checked = false;
                intervalo intervalo = new intervalo();
                intervalo.ShowDialog();
                this.Text = "Tickets por asignar";
                Timer1_Tick(sender, e);
            }
            else
            {
                if(porquemarse.Checked==false)
                {
                    alcrearse.Checked = true;
                }
            }
        }

        private void Porquemarse_CheckedChanged(object sender, EventArgs e)
        {
            if (porquemarse.Checked)
            {
                alcrearse.Checked = false;
                Quemarse quemarse = new Quemarse();
                timer1.Interval = intvalquemarseejecutar;
                quemarse.ShowDialog();
                this.Text = "Tickets por quemarse";
                Timer1_Tick(sender, e);
            }
            else
            {
                if (alcrearse.Checked == false)
                {
                    porquemarse.Checked = true;
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Timer1_Tick(sender, e);
        }

        private void activadasToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (activadasToolStripMenuItem.Checked)
            {
                desactivadasToolStripMenuItem.Checked = false;
            }
            else
            {
                if (desactivadasToolStripMenuItem.Checked == false)
                {
                    activadasToolStripMenuItem.Checked = true;
                }
            }
        }

        private void desactivadasToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (desactivadasToolStripMenuItem.Checked)
            {
                activadasToolStripMenuItem.Checked = false;
            }
            else
            {
                if (activadasToolStripMenuItem.Checked == false)
                {
                    desactivadasToolStripMenuItem.Checked = true;
                }
            }
        }
    }
}
