namespace PrimG9.Formularios
{
    partial class Resultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultado));
            this.lblRes = new System.Windows.Forms.Label();
            this.lblCarr = new System.Windows.Forms.Label();
            this.lblCommon = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.BackColor = System.Drawing.Color.Transparent;
            this.lblRes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(84, 85);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(53, 19);
            this.lblRes.TabIndex = 0;
            this.lblRes.Text = "label1";
            // 
            // lblCarr
            // 
            this.lblCarr.AutoSize = true;
            this.lblCarr.BackColor = System.Drawing.Color.Transparent;
            this.lblCarr.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarr.ForeColor = System.Drawing.Color.Black;
            this.lblCarr.Location = new System.Drawing.Point(185, 276);
            this.lblCarr.Name = "lblCarr";
            this.lblCarr.Size = new System.Drawing.Size(42, 15);
            this.lblCarr.TabIndex = 1;
            this.lblCarr.Text = "label1";
            // 
            // lblCommon
            // 
            this.lblCommon.AutoSize = true;
            this.lblCommon.BackColor = System.Drawing.Color.Transparent;
            this.lblCommon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommon.Location = new System.Drawing.Point(69, 196);
            this.lblCommon.Name = "lblCommon";
            this.lblCommon.Size = new System.Drawing.Size(42, 15);
            this.lblCommon.TabIndex = 2;
            this.lblCommon.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(612, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 404);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(205, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 23);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PrimG9.Properties.Resources.Gif_logo_3;
            this.pictureBox2.Location = new System.Drawing.Point(1, 335);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 115);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(710, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btReiniciar
            // 
            this.btReiniciar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btReiniciar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReiniciar.Location = new System.Drawing.Point(418, 406);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(87, 31);
            this.btReiniciar.TabIndex = 7;
            this.btReiniciar.Text = "Reiniciar";
            this.btReiniciar.UseVisualStyleBackColor = false;
            this.btReiniciar.Click += new System.EventHandler(this.btReiniciar_Click);
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReiniciar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCommon);
            this.Controls.Add(this.lblCarr);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.Name = "Resultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Resultado_FormClosing);
            this.Load += new System.EventHandler(this.Resultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblCarr;
        private System.Windows.Forms.Label lblCommon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btReiniciar;
    }
}