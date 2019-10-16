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
            this.lblRes = new System.Windows.Forms.Label();
            this.lblCarr = new System.Windows.Forms.Label();
            this.lblCommon = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReini = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.BackColor = System.Drawing.Color.Transparent;
            this.lblRes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.ForeColor = System.Drawing.Color.White;
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
            this.lblCarr.ForeColor = System.Drawing.Color.White;
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
            this.lblCommon.ForeColor = System.Drawing.Color.White;
            this.lblCommon.Location = new System.Drawing.Point(69, 196);
            this.lblCommon.Name = "lblCommon";
            this.lblCommon.Size = new System.Drawing.Size(42, 15);
            this.lblCommon.TabIndex = 2;
            this.lblCommon.Text = "label1";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
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
            // btnReini
            // 
            this.btnReini.Location = new System.Drawing.Point(576, 415);
            this.btnReini.Name = "btnReini";
            this.btnReini.Size = new System.Drawing.Size(75, 23);
            this.btnReini.TabIndex = 8;
            this.btnReini.Text = "Reiniciar Test";
            this.btnReini.UseVisualStyleBackColor = true;
            this.btnReini.Click += new System.EventHandler(this.btnReini_Click);
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.btnReini);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCommon);
            this.Controls.Add(this.lblCarr);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.Name = "Resultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Resultado_FormClosing);
            this.Load += new System.EventHandler(this.Resultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblCarr;
        private System.Windows.Forms.Label lblCommon;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReini;
    }
}