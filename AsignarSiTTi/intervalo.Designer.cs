namespace AsignarSiTTi
{
    partial class intervalo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(intervalo));
            this.label1 = new System.Windows.Forms.Label();
            this.nvointervalo = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nvointervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutos:";
            // 
            // nvointervalo
            // 
            this.nvointervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvointervalo.Location = new System.Drawing.Point(81, 10);
            this.nvointervalo.Maximum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nvointervalo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nvointervalo.Name = "nvointervalo";
            this.nvointervalo.Size = new System.Drawing.Size(63, 22);
            this.nvointervalo.TabIndex = 1;
            this.nvointervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nvointervalo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nvointervalo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Nvointervalo_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // intervalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 78);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nvointervalo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "intervalo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Al crearse";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Intervalo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nvointervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nvointervalo;
        private System.Windows.Forms.Button button1;
    }
}