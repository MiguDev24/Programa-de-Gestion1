namespace UserInterface
{
    partial class frmAgregarUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncrear = new System.Windows.Forms.Button();
            this.txtboxcontraseña = new System.Windows.Forms.TextBox();
            this.txtboxmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxconcontra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 17);
            this.panel1.TabIndex = 9;
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(68, 254);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(75, 23);
            this.btncrear.TabIndex = 8;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // txtboxcontraseña
            // 
            this.txtboxcontraseña.Location = new System.Drawing.Point(55, 194);
            this.txtboxcontraseña.Name = "txtboxcontraseña";
            this.txtboxcontraseña.Size = new System.Drawing.Size(100, 20);
            this.txtboxcontraseña.TabIndex = 7;
            this.txtboxcontraseña.Text = "Contraseña";
            // 
            // txtboxmail
            // 
            this.txtboxmail.Location = new System.Drawing.Point(55, 160);
            this.txtboxmail.Name = "txtboxmail";
            this.txtboxmail.Size = new System.Drawing.Size(100, 20);
            this.txtboxmail.TabIndex = 6;
            this.txtboxmail.Text = "Ingrese su mail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtboxconcontra
            // 
            this.txtboxconcontra.Location = new System.Drawing.Point(55, 228);
            this.txtboxconcontra.Name = "txtboxconcontra";
            this.txtboxconcontra.Size = new System.Drawing.Size(100, 20);
            this.txtboxconcontra.TabIndex = 10;
            this.txtboxconcontra.Text = "Confirmar contraseña";
            // 
            // frmAgregarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 285);
            this.Controls.Add(this.txtboxconcontra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.txtboxcontraseña);
            this.Controls.Add(this.txtboxmail);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAgregarUser";
            this.Text = "Crear Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.TextBox txtboxcontraseña;
        private System.Windows.Forms.TextBox txtboxmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtboxconcontra;
    }
}

