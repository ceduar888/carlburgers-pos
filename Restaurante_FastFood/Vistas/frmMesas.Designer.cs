
namespace Restaurante_FastFood.Vistas
{
    partial class frmMesas
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMesa5 = new System.Windows.Forms.Button();
            this.btnMesa4 = new System.Windows.Forms.Button();
            this.btnMesa3 = new System.Windows.Forms.Button();
            this.btnMesa2 = new System.Windows.Forms.Button();
            this.btnMesa1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbLiberarMesa = new System.Windows.Forms.ComboBox();
            this.cmbAsignarMesa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataBase_RestaurantDataSet1 = new Restaurante_FastFood.DataBase_RestaurantDataSet1();
            this.mesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mesaTableAdapter = new Restaurante_FastFood.DataBase_RestaurantDataSet1TableAdapters.MesaTableAdapter();
            this.btnSalirMesa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_RestaurantDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ocupada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Disponible";
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Red;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(636, 102);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 33;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Green;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(460, 102);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 32;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMesa5);
            this.groupBox1.Controls.Add(this.btnMesa4);
            this.groupBox1.Controls.Add(this.btnMesa3);
            this.groupBox1.Controls.Add(this.btnMesa2);
            this.groupBox1.Controls.Add(this.btnMesa1);
            this.groupBox1.Location = new System.Drawing.Point(261, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 170);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // btnMesa5
            // 
            this.btnMesa5.BackColor = System.Drawing.Color.Green;
            this.btnMesa5.Location = new System.Drawing.Point(523, 61);
            this.btnMesa5.Name = "btnMesa5";
            this.btnMesa5.Size = new System.Drawing.Size(86, 57);
            this.btnMesa5.TabIndex = 4;
            this.btnMesa5.Text = "Mesa 5";
            this.btnMesa5.UseVisualStyleBackColor = false;
            this.btnMesa5.Click += new System.EventHandler(this.btnMesa5_Click);
            // 
            // btnMesa4
            // 
            this.btnMesa4.BackColor = System.Drawing.Color.Green;
            this.btnMesa4.Location = new System.Drawing.Point(401, 61);
            this.btnMesa4.Name = "btnMesa4";
            this.btnMesa4.Size = new System.Drawing.Size(86, 57);
            this.btnMesa4.TabIndex = 3;
            this.btnMesa4.Text = "Mesa 4";
            this.btnMesa4.UseVisualStyleBackColor = false;
            this.btnMesa4.Click += new System.EventHandler(this.btnMesa4_Click);
            // 
            // btnMesa3
            // 
            this.btnMesa3.BackColor = System.Drawing.Color.Green;
            this.btnMesa3.Location = new System.Drawing.Point(279, 61);
            this.btnMesa3.Name = "btnMesa3";
            this.btnMesa3.Size = new System.Drawing.Size(86, 57);
            this.btnMesa3.TabIndex = 2;
            this.btnMesa3.Text = "Mesa 3";
            this.btnMesa3.UseVisualStyleBackColor = false;
            this.btnMesa3.Click += new System.EventHandler(this.btnMesa3_Click);
            // 
            // btnMesa2
            // 
            this.btnMesa2.BackColor = System.Drawing.Color.Green;
            this.btnMesa2.Location = new System.Drawing.Point(156, 61);
            this.btnMesa2.Name = "btnMesa2";
            this.btnMesa2.Size = new System.Drawing.Size(86, 57);
            this.btnMesa2.TabIndex = 1;
            this.btnMesa2.Text = "Mesa 2";
            this.btnMesa2.UseVisualStyleBackColor = false;
            this.btnMesa2.Click += new System.EventHandler(this.btnMesa2_Click);
            // 
            // btnMesa1
            // 
            this.btnMesa1.BackColor = System.Drawing.Color.Green;
            this.btnMesa1.Location = new System.Drawing.Point(35, 61);
            this.btnMesa1.Name = "btnMesa1";
            this.btnMesa1.Size = new System.Drawing.Size(86, 57);
            this.btnMesa1.TabIndex = 0;
            this.btnMesa1.Text = "Mesa 1";
            this.btnMesa1.UseVisualStyleBackColor = false;
            this.btnMesa1.Click += new System.EventHandler(this.btnMesa1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 66);
            this.panel1.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(319, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(171, 20);
            this.label16.TabIndex = 13;
            this.label16.Text = "GESTION DE MESAS";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbLiberarMesa);
            this.groupBox2.Controls.Add(this.cmbAsignarMesa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(27, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 170);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administrar";
            // 
            // cmbLiberarMesa
            // 
            this.cmbLiberarMesa.FormattingEnabled = true;
            this.cmbLiberarMesa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbLiberarMesa.Location = new System.Drawing.Point(35, 117);
            this.cmbLiberarMesa.Name = "cmbLiberarMesa";
            this.cmbLiberarMesa.Size = new System.Drawing.Size(121, 21);
            this.cmbLiberarMesa.TabIndex = 5;
            this.cmbLiberarMesa.SelectedIndexChanged += new System.EventHandler(this.cmbLiberarMesa_SelectedIndexChanged_1);
            // 
            // cmbAsignarMesa
            // 
            this.cmbAsignarMesa.FormattingEnabled = true;
            this.cmbAsignarMesa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbAsignarMesa.Location = new System.Drawing.Point(35, 54);
            this.cmbAsignarMesa.Name = "cmbAsignarMesa";
            this.cmbAsignarMesa.Size = new System.Drawing.Size(121, 21);
            this.cmbAsignarMesa.TabIndex = 4;
            this.cmbAsignarMesa.SelectedIndexChanged += new System.EventHandler(this.cmbAsignarMesa_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Liberar Mesa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asignar Mesa";
            // 
            // dataBase_RestaurantDataSet1
            // 
            this.dataBase_RestaurantDataSet1.DataSetName = "DataBase_RestaurantDataSet1";
            this.dataBase_RestaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mesaBindingSource
            // 
            this.mesaBindingSource.DataMember = "Mesa";
            this.mesaBindingSource.DataSource = this.dataBase_RestaurantDataSet1;
            // 
            // mesaTableAdapter
            // 
            this.mesaTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalirMesa
            // 
            this.btnSalirMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirMesa.Image = global::Restaurante_FastFood.Properties.Resources.cerrar;
            this.btnSalirMesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirMesa.Location = new System.Drawing.Point(798, 327);
            this.btnSalirMesa.Name = "btnSalirMesa";
            this.btnSalirMesa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalirMesa.Size = new System.Drawing.Size(106, 41);
            this.btnSalirMesa.TabIndex = 36;
            this.btnSalirMesa.Text = "Salir";
            this.btnSalirMesa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirMesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalirMesa.UseVisualStyleBackColor = true;
            this.btnSalirMesa.Click += new System.EventHandler(this.btnSalirMesa_Click);
            // 
            // frmMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(960, 394);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalirMesa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmMesas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Mesas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMesas_FormClosing);
            this.Load += new System.EventHandler(this.frmMesas_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_RestaurantDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirMesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMesa5;
        private System.Windows.Forms.Button btnMesa4;
        private System.Windows.Forms.Button btnMesa3;
        private System.Windows.Forms.Button btnMesa2;
        private System.Windows.Forms.Button btnMesa1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DataBase_RestaurantDataSet1 dataBase_RestaurantDataSet1;
        private System.Windows.Forms.BindingSource mesaBindingSource;
        private DataBase_RestaurantDataSet1TableAdapters.MesaTableAdapter mesaTableAdapter;
        private System.Windows.Forms.ComboBox cmbLiberarMesa;
        private System.Windows.Forms.ComboBox cmbAsignarMesa;
    }
}