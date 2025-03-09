
namespace Restaurante_FastFood.Vistas
{
    partial class frmInicioSesion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.txtInicioContrasenia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInicioUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInicioSesion);
            this.panel1.Controls.Add(this.txtInicioContrasenia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtInicioUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(142, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 169);
            this.panel1.TabIndex = 7;
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicioSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInicioSesion.FlatAppearance.BorderSize = 0;
            this.btnInicioSesion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnInicioSesion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnInicioSesion.Location = new System.Drawing.Point(83, 124);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(114, 33);
            this.btnInicioSesion.TabIndex = 3;
            this.btnInicioSesion.Text = "Iniciar Sesión";
            this.btnInicioSesion.UseVisualStyleBackColor = true;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // txtInicioContrasenia
            // 
            this.txtInicioContrasenia.Location = new System.Drawing.Point(121, 68);
            this.txtInicioContrasenia.Name = "txtInicioContrasenia";
            this.txtInicioContrasenia.Size = new System.Drawing.Size(140, 20);
            this.txtInicioContrasenia.TabIndex = 2;
            this.txtInicioContrasenia.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txtInicioUsuario
            // 
            this.txtInicioUsuario.Location = new System.Drawing.Point(121, 22);
            this.txtInicioUsuario.Name = "txtInicioUsuario";
            this.txtInicioUsuario.Size = new System.Drawing.Size(140, 20);
            this.txtInicioUsuario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante_FastFood.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(189, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmInicioSesion
            // 
            this.AcceptButton = this.btnInicioSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(574, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmInicioSesion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión - Mr. Carl\'s  Burgers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInicioSesion_FormClosing);
            this.Load += new System.EventHandler(this.frmInicioSesion_Load);
            this.Shown += new System.EventHandler(this.frmInicioSesion_Shown_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.TextBox txtInicioContrasenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInicioUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}