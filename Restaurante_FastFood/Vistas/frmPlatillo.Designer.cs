
namespace Restaurante_FastFood.Vistas
{
    partial class frmPlatillo
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
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBuscarPlatillo = new System.Windows.Forms.TextBox();
            this.btnSalirPlatillo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtgvDatosPlatillo = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtPrecioPlatillo = new System.Windows.Forms.TextBox();
            this.txtNombrePlatillo = new System.Windows.Forms.TextBox();
            this.txtIdPlatillo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCategoriasDeProd = new System.Windows.Forms.Button();
            this.btnBuscarPlatillo = new System.Windows.Forms.Button();
            this.btnEliminarPlatillo = new System.Windows.Forms.Button();
            this.btnActualizarPlatilo = new System.Windows.Forms.Button();
            this.btnRegistrarPlatillo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosPlatillo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 66);
            this.panel1.TabIndex = 48;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(342, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 20);
            this.label16.TabIndex = 13;
            this.label16.Text = "MENU";
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(188, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "Nombre, precio";
            // 
            // txtBuscarPlatillo
            // 
            this.txtBuscarPlatillo.Location = new System.Drawing.Point(189, 167);
            this.txtBuscarPlatillo.Multiline = true;
            this.txtBuscarPlatillo.Name = "txtBuscarPlatillo";
            this.txtBuscarPlatillo.Size = new System.Drawing.Size(444, 28);
            this.txtBuscarPlatillo.TabIndex = 45;
            this.txtBuscarPlatillo.TextChanged += new System.EventHandler(this.txtBuscarPlatillo_TextChanged);
            // 
            // btnSalirPlatillo
            // 
            this.btnSalirPlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirPlatillo.Image = global::Restaurante_FastFood.Properties.Resources.cerrar;
            this.btnSalirPlatillo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirPlatillo.Location = new System.Drawing.Point(543, 690);
            this.btnSalirPlatillo.Name = "btnSalirPlatillo";
            this.btnSalirPlatillo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalirPlatillo.Size = new System.Drawing.Size(132, 41);
            this.btnSalirPlatillo.TabIndex = 44;
            this.btnSalirPlatillo.Text = "Salir";
            this.btnSalirPlatillo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirPlatillo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalirPlatillo.UseVisualStyleBackColor = true;
            this.btnSalirPlatillo.Click += new System.EventHandler(this.btnSalirPlatillo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.dtgvDatosPlatillo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.txtPrecioPlatillo);
            this.groupBox1.Controls.Add(this.txtNombrePlatillo);
            this.groupBox1.Controls.Add(this.txtIdPlatillo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 451);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(331, 120);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(250, 36);
            this.txtDescripcion.TabIndex = 11;
            // 
            // dtgvDatosPlatillo
            // 
            this.dtgvDatosPlatillo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatosPlatillo.Location = new System.Drawing.Point(49, 261);
            this.dtgvDatosPlatillo.Name = "dtgvDatosPlatillo";
            this.dtgvDatosPlatillo.Size = new System.Drawing.Size(536, 178);
            this.dtgvDatosPlatillo.TabIndex = 10;
            this.dtgvDatosPlatillo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDatosPlatillo_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripción";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Combos",
            "Combos infantiles",
            "Desayunos",
            "Hamburguesas",
            "Papas fritas",
            "Bebidas",
            "Postres",
            "Extras",
            "Promociones"});
            this.cmbCategoria.Location = new System.Drawing.Point(331, 194);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 7;
            // 
            // txtPrecioPlatillo
            // 
            this.txtPrecioPlatillo.Location = new System.Drawing.Point(49, 194);
            this.txtPrecioPlatillo.Name = "txtPrecioPlatillo";
            this.txtPrecioPlatillo.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioPlatillo.TabIndex = 6;
            // 
            // txtNombrePlatillo
            // 
            this.txtNombrePlatillo.Location = new System.Drawing.Point(49, 120);
            this.txtNombrePlatillo.Name = "txtNombrePlatillo";
            this.txtNombrePlatillo.Size = new System.Drawing.Size(214, 20);
            this.txtNombrePlatillo.TabIndex = 5;
            // 
            // txtIdPlatillo
            // 
            this.txtIdPlatillo.Location = new System.Drawing.Point(49, 46);
            this.txtIdPlatillo.Name = "txtIdPlatillo";
            this.txtIdPlatillo.ReadOnly = true;
            this.txtIdPlatillo.Size = new System.Drawing.Size(100, 20);
            this.txtIdPlatillo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Platillo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btnCategoriasDeProd
            // 
            this.btnCategoriasDeProd.Location = new System.Drawing.Point(278, 96);
            this.btnCategoriasDeProd.Name = "btnCategoriasDeProd";
            this.btnCategoriasDeProd.Size = new System.Drawing.Size(162, 35);
            this.btnCategoriasDeProd.TabIndex = 39;
            this.btnCategoriasDeProd.Text = "CATEGORIAS";
            this.btnCategoriasDeProd.UseVisualStyleBackColor = true;
            this.btnCategoriasDeProd.Click += new System.EventHandler(this.btnCategoriasDeProd_Click);
            // 
            // btnBuscarPlatillo
            // 
            this.btnBuscarPlatillo.Image = global::Restaurante_FastFood.Properties.Resources.search_file;
            this.btnBuscarPlatillo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPlatillo.Location = new System.Drawing.Point(73, 161);
            this.btnBuscarPlatillo.Name = "btnBuscarPlatillo";
            this.btnBuscarPlatillo.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnBuscarPlatillo.Size = new System.Drawing.Size(104, 41);
            this.btnBuscarPlatillo.TabIndex = 46;
            this.btnBuscarPlatillo.Text = "BUSCAR";
            this.btnBuscarPlatillo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPlatillo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarPlatillo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPlatillo
            // 
            this.btnEliminarPlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPlatillo.Image = global::Restaurante_FastFood.Properties.Resources.delete_file;
            this.btnEliminarPlatillo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPlatillo.Location = new System.Drawing.Point(378, 690);
            this.btnEliminarPlatillo.Name = "btnEliminarPlatillo";
            this.btnEliminarPlatillo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEliminarPlatillo.Size = new System.Drawing.Size(132, 41);
            this.btnEliminarPlatillo.TabIndex = 43;
            this.btnEliminarPlatillo.Text = "Eliminar";
            this.btnEliminarPlatillo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPlatillo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarPlatillo.UseVisualStyleBackColor = true;
            this.btnEliminarPlatillo.Click += new System.EventHandler(this.btnEliminarPlatillo_Click);
            // 
            // btnActualizarPlatilo
            // 
            this.btnActualizarPlatilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPlatilo.Image = global::Restaurante_FastFood.Properties.Resources.resume;
            this.btnActualizarPlatilo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarPlatilo.Location = new System.Drawing.Point(210, 690);
            this.btnActualizarPlatilo.Name = "btnActualizarPlatilo";
            this.btnActualizarPlatilo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnActualizarPlatilo.Size = new System.Drawing.Size(139, 41);
            this.btnActualizarPlatilo.TabIndex = 42;
            this.btnActualizarPlatilo.Text = "Actualizar";
            this.btnActualizarPlatilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarPlatilo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarPlatilo.UseVisualStyleBackColor = true;
            this.btnActualizarPlatilo.Click += new System.EventHandler(this.btnActualizarPlatilo_Click);
            // 
            // btnRegistrarPlatillo
            // 
            this.btnRegistrarPlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPlatillo.Image = global::Restaurante_FastFood.Properties.Resources.add_file;
            this.btnRegistrarPlatillo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPlatillo.Location = new System.Drawing.Point(37, 690);
            this.btnRegistrarPlatillo.Name = "btnRegistrarPlatillo";
            this.btnRegistrarPlatillo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRegistrarPlatillo.Size = new System.Drawing.Size(139, 41);
            this.btnRegistrarPlatillo.TabIndex = 41;
            this.btnRegistrarPlatillo.Text = "Agregar";
            this.btnRegistrarPlatillo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPlatillo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarPlatillo.UseVisualStyleBackColor = true;
            this.btnRegistrarPlatillo.Click += new System.EventHandler(this.btnRegistrarPlatillo_Click);
            // 
            // frmPlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(711, 751);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnBuscarPlatillo);
            this.Controls.Add(this.txtBuscarPlatillo);
            this.Controls.Add(this.btnSalirPlatillo);
            this.Controls.Add(this.btnEliminarPlatillo);
            this.Controls.Add(this.btnActualizarPlatilo);
            this.Controls.Add(this.btnRegistrarPlatillo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCategoriasDeProd);
            this.MaximizeBox = false;
            this.Name = "frmPlatillo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Menú";
            this.Load += new System.EventHandler(this.frmPlatillo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosPlatillo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnBuscarPlatillo;
        private System.Windows.Forms.TextBox txtBuscarPlatillo;
        private System.Windows.Forms.Button btnSalirPlatillo;
        private System.Windows.Forms.Button btnEliminarPlatillo;
        private System.Windows.Forms.Button btnActualizarPlatilo;
        private System.Windows.Forms.Button btnRegistrarPlatillo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dtgvDatosPlatillo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtPrecioPlatillo;
        private System.Windows.Forms.TextBox txtNombrePlatillo;
        private System.Windows.Forms.TextBox txtIdPlatillo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCategoriasDeProd;
    }
}