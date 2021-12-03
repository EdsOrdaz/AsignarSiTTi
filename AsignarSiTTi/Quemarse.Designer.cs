namespace AsignarSiTTi
{
    partial class Quemarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quemarse));
            this.label1 = new System.Windows.Forms.Label();
            this.intvalquemarse = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.intvalquemarse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutos: ";
            // 
            // intvalquemarse
            // 
            this.intvalquemarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intvalquemarse.Location = new System.Drawing.Point(82, 11);
            this.intvalquemarse.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.intvalquemarse.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.intvalquemarse.Name = "intvalquemarse";
            this.intvalquemarse.Size = new System.Drawing.Size(58, 22);
            this.intvalquemarse.TabIndex = 1;
            this.intvalquemarse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.intvalquemarse.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.intvalquemarse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Intvalquemarse_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Quemarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 78);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.intvalquemarse);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Quemarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Por Quemarse";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Quemarse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intvalquemarse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown intvalquemarse;
        private System.Windows.Forms.Button button1;
    }
}