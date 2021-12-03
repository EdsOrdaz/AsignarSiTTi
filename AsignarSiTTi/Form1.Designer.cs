namespace AsignarSiTTi
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.revisarAhoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónDeTiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alcrearse = new System.Windows.Forms.ToolStripMenuItem();
            this.porquemarse = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.activadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desactivadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Asignar SiTTi";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisarAhoraToolStripMenuItem,
            this.configuraciónDeTiempoToolStripMenuItem,
            this.notificacionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 114);
            // 
            // revisarAhoraToolStripMenuItem
            // 
            this.revisarAhoraToolStripMenuItem.Image = global::AsignarSiTTi.Properties.Resources.ver1;
            this.revisarAhoraToolStripMenuItem.Name = "revisarAhoraToolStripMenuItem";
            this.revisarAhoraToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.revisarAhoraToolStripMenuItem.Text = "Revisar Ahora";
            this.revisarAhoraToolStripMenuItem.Click += new System.EventHandler(this.RevisarAhoraToolStripMenuItem_Click);
            // 
            // configuraciónDeTiempoToolStripMenuItem
            // 
            this.configuraciónDeTiempoToolStripMenuItem.DropDown = this.contextMenuStrip2;
            this.configuraciónDeTiempoToolStripMenuItem.Image = global::AsignarSiTTi.Properties.Resources.aviso;
            this.configuraciónDeTiempoToolStripMenuItem.Name = "configuraciónDeTiempoToolStripMenuItem";
            this.configuraciónDeTiempoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.configuraciónDeTiempoToolStripMenuItem.Text = "Configuración de Aviso";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alcrearse,
            this.porquemarse});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.OwnerItem = this.configuraciónDeTiempoToolStripMenuItem;
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 70);
            // 
            // alcrearse
            // 
            this.alcrearse.Checked = true;
            this.alcrearse.CheckOnClick = true;
            this.alcrearse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alcrearse.Name = "alcrearse";
            this.alcrearse.Size = new System.Drawing.Size(180, 22);
            this.alcrearse.Text = "Al Crearse";
            this.alcrearse.CheckedChanged += new System.EventHandler(this.Alcrearse_CheckedChanged);
            // 
            // porquemarse
            // 
            this.porquemarse.CheckOnClick = true;
            this.porquemarse.Name = "porquemarse";
            this.porquemarse.Size = new System.Drawing.Size(180, 22);
            this.porquemarse.Text = "Por Quemarse";
            this.porquemarse.CheckedChanged += new System.EventHandler(this.Porquemarse_CheckedChanged);
            // 
            // notificacionesToolStripMenuItem
            // 
            this.notificacionesToolStripMenuItem.DropDown = this.contextMenuStrip3;
            this.notificacionesToolStripMenuItem.Image = global::AsignarSiTTi.Properties.Resources.notificaciones;
            this.notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            this.notificacionesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.notificacionesToolStripMenuItem.Text = "Notificaciones";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activadasToolStripMenuItem,
            this.desactivadasToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.OwnerItem = this.notificacionesToolStripMenuItem;
            this.contextMenuStrip3.Size = new System.Drawing.Size(143, 48);
            // 
            // activadasToolStripMenuItem
            // 
            this.activadasToolStripMenuItem.CheckOnClick = true;
            this.activadasToolStripMenuItem.Name = "activadasToolStripMenuItem";
            this.activadasToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.activadasToolStripMenuItem.Text = "Activadas";
            this.activadasToolStripMenuItem.CheckedChanged += new System.EventHandler(this.activadasToolStripMenuItem_CheckedChanged);
            // 
            // desactivadasToolStripMenuItem
            // 
            this.desactivadasToolStripMenuItem.Checked = true;
            this.desactivadasToolStripMenuItem.CheckOnClick = true;
            this.desactivadasToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.desactivadasToolStripMenuItem.Name = "desactivadasToolStripMenuItem";
            this.desactivadasToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.desactivadasToolStripMenuItem.Text = "Desactivadas";
            this.desactivadasToolStripMenuItem.CheckedChanged += new System.EventHandler(this.desactivadasToolStripMenuItem_CheckedChanged);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::AsignarSiTTi.Properties.Resources.salir1;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ocultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 91);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Revisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(190, 123);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets por asignar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem revisarAhoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem configuraciónDeTiempoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem alcrearse;
        private System.Windows.Forms.ToolStripMenuItem porquemarse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem notificacionesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem activadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desactivadasToolStripMenuItem;
    }
}

