namespace PrimG9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lbsSalir = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(146, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿No sabes que estudiar?";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.Color.White;
            this.lblInicio.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblInicio.Location = new System.Drawing.Point(356, 253);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(146, 31);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Iniciar Test";
            this.lblInicio.Click += new System.EventHandler(this.LblInicio_Click);
            // 
            // lbsSalir
            // 
            this.lbsSalir.AutoSize = true;
            this.lbsSalir.BackColor = System.Drawing.Color.White;
            this.lbsSalir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsSalir.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbsSalir.Image = global::PrimG9.Properties.Resources.Recuadro_Salir;
            this.lbsSalir.Location = new System.Drawing.Point(764, 437);
            this.lbsSalir.Name = "lbsSalir";
            this.lbsSalir.Size = new System.Drawing.Size(53, 24);
            this.lbsSalir.TabIndex = 4;
            this.lbsSalir.Text = "&Salir";
            this.lbsSalir.Click += new System.EventHandler(this.LbsSalir_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = global::PrimG9.Properties.Resources.Recuadro_Salir;
            this.pictureBox3.Image = global::PrimG9.Properties.Resources.Recuadro_Salir;
            this.pictureBox3.InitialImage = global::PrimG9.Properties.Resources.Recuadro_Salir;
            this.pictureBox3.Location = new System.Drawing.Point(743, 426);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PrimG9.Properties.Resources.Recuadro_Salir;
            this.pictureBox2.Location = new System.Drawing.Point(345, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::PrimG9.Properties.Resources.Gif_logo_3;
            this.pictureBox4.Location = new System.Drawing.Point(0, 365);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(129, 119);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(856, 484);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbsSalir);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lbsSalir;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

