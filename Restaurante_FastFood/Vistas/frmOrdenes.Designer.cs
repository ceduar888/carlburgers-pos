
namespace Restaurante_FastFood.Vistas
{
    partial class frmOrdenes
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
            this.dtgvPendientes = new System.Windows.Forms.DataGridView();
            this.dtgvListos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelListo = new System.Windows.Forms.Panel();
            this.btnListo = new System.Windows.Forms.Button();
            this.panelEntregado = new System.Windows.Forms.Panel();
            this.btnEntregado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdPlatillo = new System.Windows.Forms.TextBox();
            this.txtPrecioPlatillo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelListo.SuspendLayout();
            this.panelEntregado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvPendientes
            // 
            this.dtgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPendientes.Location = new System.Drawing.Point(30, 186);
            this.dtgvPendientes.Name = "dtgvPendientes";
            this.dtgvPendientes.Size = new System.Drawing.Size(448, 310);
            this.dtgvPendientes.TabIndex = 0;
            this.dtgvPendientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPendientes_CellClick);
            // 
            // dtgvListos
            // 
            this.dtgvListos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListos.Location = new System.Drawing.Point(537, 186);
            this.dtgvListos.Name = "dtgvListos";
            this.dtgvListos.Size = new System.Drawing.Size(448, 310);
            this.dtgvListos.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 66);
            this.panel1.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(419, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 20);
            this.label16.TabIndex = 13;
            this.label16.Text = "GESTION DE ORDENES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante_FastFood.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "PENDIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "LISTAS";
            // 
            // panelListo
            // 
            this.panelListo.Controls.Add(this.btnListo);
            this.panelListo.Location = new System.Drawing.Point(342, 132);
            this.panelListo.Name = "panelListo";
            this.panelListo.Size = new System.Drawing.Size(161, 51);
            this.panelListo.TabIndex = 40;
            // 
            // btnListo
            // 
            this.btnListo.Image = global::Restaurante_FastFood.Properties.Resources.listo;
            this.btnListo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListo.Location = new System.Drawing.Point(43, 7);
            this.btnListo.Name = "btnListo";
            this.btnListo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnListo.Size = new System.Drawing.Size(93, 41);
            this.btnListo.TabIndex = 35;
            this.btnListo.Text = "Listo";
            this.btnListo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // panelEntregado
            // 
            this.panelEntregado.Controls.Add(this.btnEntregado);
            this.panelEntregado.Location = new System.Drawing.Point(514, 132);
            this.panelEntregado.Name = "panelEntregado";
            this.panelEntregado.Size = new System.Drawing.Size(161, 51);
            this.panelEntregado.TabIndex = 41;
            // 
            // btnEntregado
            // 
            this.btnEntregado.Image = global::Restaurante_FastFood.Properties.Resources.entregado;
            this.btnEntregado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntregado.Location = new System.Drawing.Point(21, 7);
            this.btnEntregado.Name = "btnEntregado";
            this.btnEntregado.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEntregado.Size = new System.Drawing.Size(109, 41);
            this.btnEntregado.TabIndex = 35;
            this.btnEntregado.Text = "Entregado";
            this.btnEntregado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntregado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntregado.UseVisualStyleBackColor = true;
            this.btnEntregado.Click += new System.EventHandler(this.btnEntregado_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Restaurante_FastFood.Properties.Resources.cerrar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(881, 513);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(104, 41);
            this.button1.TabIndex = 34;
            this.button1.Text = "Cerrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdPlatillo
            // 
            this.txtIdPlatillo.Location = new System.Drawing.Point(30, 145);
            this.txtIdPlatillo.Name = "txtIdPlatillo";
            this.txtIdPlatillo.Size = new System.Drawing.Size(100, 20);
            this.txtIdPlatillo.TabIndex = 42;
            this.txtIdPlatillo.Visible = false;
            // 
            // txtPrecioPlatillo
            // 
            this.txtPrecioPlatillo.Location = new System.Drawing.Point(146, 145);
            this.txtPrecioPlatillo.Name = "txtPrecioPlatillo";
            this.txtPrecioPlatillo.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioPlatillo.TabIndex = 43;
            this.txtPrecioPlatillo.Visible = false;
            // 
            // frmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1021, 571);
            this.ControlBox = false;
            this.Controls.Add(this.txtPrecioPlatillo);
            this.Controls.Add(this.txtIdPlatillo);
            this.Controls.Add(this.panelEntregado);
            this.Controls.Add(this.panelListo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvListos);
            this.Controls.Add(this.dtgvPendientes);
            this.MaximizeBox = false;
            this.Name = "frmOrdenes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Ordenenes";
            this.Load += new System.EventHandler(this.frmOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelListo.ResumeLayout(false);
            this.panelEntregado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPendientes;
        private System.Windows.Forms.DataGridView dtgvListos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelListo;
        private System.Windows.Forms.Panel panelEntregado;
        private System.Windows.Forms.Button btnEntregado;
        private System.Windows.Forms.TextBox txtIdPlatillo;
        private System.Windows.Forms.TextBox txtPrecioPlatillo;
    }
}