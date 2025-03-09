
namespace Restaurante_FastFood.Vistas
{
    partial class frmMesa5
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
            this.btnHacerPedido = new System.Windows.Forms.Button();
            this.btnSalirNuevaOrden = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTipoOrden = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtEstadoOrden = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateOrden = new System.Windows.Forms.DateTimePicker();
            this.dtgvAgregarProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumeroMesa = new System.Windows.Forms.TextBox();
            this.txtPrecioPlatillo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPlatillo = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbCategoriaProd = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBase_RestaurantDataSet7 = new Restaurante_FastFood.DataBase_RestaurantDataSet7();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtgvPlatillos = new System.Windows.Forms.DataGridView();
            this.categoriaTableAdapter = new Restaurante_FastFood.DataBase_RestaurantDataSet7TableAdapters.CategoriaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAgregarProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_RestaurantDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPlatillos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHacerPedido
            // 
            this.btnHacerPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerPedido.Image = global::Restaurante_FastFood.Properties.Resources.hacer_pedido;
            this.btnHacerPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHacerPedido.Location = new System.Drawing.Point(759, 606);
            this.btnHacerPedido.Name = "btnHacerPedido";
            this.btnHacerPedido.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHacerPedido.Size = new System.Drawing.Size(151, 41);
            this.btnHacerPedido.TabIndex = 35;
            this.btnHacerPedido.Text = "Cerrar Pedido";
            this.btnHacerPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHacerPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHacerPedido.UseVisualStyleBackColor = true;
            this.btnHacerPedido.Click += new System.EventHandler(this.btnHacerPedido_Click);
            // 
            // btnSalirNuevaOrden
            // 
            this.btnSalirNuevaOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirNuevaOrden.Image = global::Restaurante_FastFood.Properties.Resources.cerrar;
            this.btnSalirNuevaOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirNuevaOrden.Location = new System.Drawing.Point(592, 606);
            this.btnSalirNuevaOrden.Name = "btnSalirNuevaOrden";
            this.btnSalirNuevaOrden.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalirNuevaOrden.Size = new System.Drawing.Size(146, 41);
            this.btnSalirNuevaOrden.TabIndex = 39;
            this.btnSalirNuevaOrden.Text = "Salir a Mesas";
            this.btnSalirNuevaOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirNuevaOrden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalirNuevaOrden.UseVisualStyleBackColor = true;
            this.btnSalirNuevaOrden.Click += new System.EventHandler(this.btnSalirNuevaOrden_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 66);
            this.panel1.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(405, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 76);
            this.panel3.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(431, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 20);
            this.label16.TabIndex = 13;
            this.label16.Text = "NUEVA ORDEN";
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
            this.groupBox2.Controls.Add(this.txtTipoOrden);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtIdEmpleado);
            this.groupBox2.Controls.Add(this.txtEstadoOrden);
            this.groupBox2.Controls.Add(this.lbTotal);
            this.groupBox2.Controls.Add(this.btnEliminarProd);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateOrden);
            this.groupBox2.Controls.Add(this.dtgvAgregarProductos);
            this.groupBox2.Location = new System.Drawing.Point(494, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 505);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de la Orden";
            // 
            // txtTipoOrden
            // 
            this.txtTipoOrden.Location = new System.Drawing.Point(28, 87);
            this.txtTipoOrden.Name = "txtTipoOrden";
            this.txtTipoOrden.Size = new System.Drawing.Size(116, 20);
            this.txtTipoOrden.TabIndex = 31;
            this.txtTipoOrden.Text = "Para comer aqui";
            this.txtTipoOrden.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Empleado N°";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(26, 45);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.ReadOnly = true;
            this.txtIdEmpleado.Size = new System.Drawing.Size(68, 20);
            this.txtIdEmpleado.TabIndex = 28;
            // 
            // txtEstadoOrden
            // 
            this.txtEstadoOrden.Location = new System.Drawing.Point(28, 129);
            this.txtEstadoOrden.Name = "txtEstadoOrden";
            this.txtEstadoOrden.Size = new System.Drawing.Size(100, 20);
            this.txtEstadoOrden.TabIndex = 27;
            this.txtEstadoOrden.Text = "Pendiente";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(314, 472);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(75, 20);
            this.lbTotal.TabIndex = 26;
            this.lbTotal.Text = "Cantidad";
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.Image = global::Restaurante_FastFood.Properties.Resources.delete_file;
            this.btnEliminarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProd.Location = new System.Drawing.Point(265, 116);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEliminarProd.Size = new System.Drawing.Size(151, 38);
            this.btnEliminarProd.TabIndex = 24;
            this.btnEliminarProd.Text = "Eliminar Producto";
            this.btnEliminarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarProd.UseVisualStyleBackColor = true;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(326, 600);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(264, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total:";
            // 
            // dateOrden
            // 
            this.dateOrden.Location = new System.Drawing.Point(216, 44);
            this.dateOrden.Name = "dateOrden";
            this.dateOrden.Size = new System.Drawing.Size(200, 20);
            this.dateOrden.TabIndex = 5;
            // 
            // dtgvAgregarProductos
            // 
            this.dtgvAgregarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAgregarProductos.Location = new System.Drawing.Point(26, 168);
            this.dtgvAgregarProductos.Name = "dtgvAgregarProductos";
            this.dtgvAgregarProductos.Size = new System.Drawing.Size(390, 294);
            this.dtgvAgregarProductos.TabIndex = 0;
            this.dtgvAgregarProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAgregarProductos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumeroMesa);
            this.groupBox1.Controls.Add(this.txtPrecioPlatillo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdPlatillo);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.btnAgregarProd);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbCategoriaProd);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtgvPlatillos);
            this.groupBox1.Location = new System.Drawing.Point(23, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 505);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // txtNumeroMesa
            // 
            this.txtNumeroMesa.Location = new System.Drawing.Point(335, 71);
            this.txtNumeroMesa.Name = "txtNumeroMesa";
            this.txtNumeroMesa.Size = new System.Drawing.Size(80, 20);
            this.txtNumeroMesa.TabIndex = 28;
            // 
            // txtPrecioPlatillo
            // 
            this.txtPrecioPlatillo.Location = new System.Drawing.Point(335, 44);
            this.txtPrecioPlatillo.Name = "txtPrecioPlatillo";
            this.txtPrecioPlatillo.Size = new System.Drawing.Size(80, 20);
            this.txtPrecioPlatillo.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "ID Producto";
            // 
            // txtIdPlatillo
            // 
            this.txtIdPlatillo.Location = new System.Drawing.Point(39, 40);
            this.txtIdPlatillo.Name = "txtIdPlatillo";
            this.txtIdPlatillo.ReadOnly = true;
            this.txtIdPlatillo.Size = new System.Drawing.Size(80, 20);
            this.txtIdPlatillo.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(308, 567);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 62);
            this.panel5.TabIndex = 24;
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.Image = global::Restaurante_FastFood.Properties.Resources.add_file;
            this.btnAgregarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProd.Location = new System.Drawing.Point(264, 119);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAgregarProd.Size = new System.Drawing.Size(151, 38);
            this.btnAgregarProd.TabIndex = 23;
            this.btnAgregarProd.Text = "Agregar Producto";
            this.btnAgregarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProd.UseVisualStyleBackColor = true;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Filtrar por Categoria";
            // 
            // cmbCategoriaProd
            // 
            this.cmbCategoriaProd.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriaBindingSource, "idCategoria", true));
            this.cmbCategoriaProd.DataSource = this.categoriaBindingSource;
            this.cmbCategoriaProd.DisplayMember = "nombreCategoria";
            this.cmbCategoriaProd.FormattingEnabled = true;
            this.cmbCategoriaProd.Location = new System.Drawing.Point(39, 87);
            this.cmbCategoriaProd.Name = "cmbCategoriaProd";
            this.cmbCategoriaProd.Size = new System.Drawing.Size(156, 21);
            this.cmbCategoriaProd.TabIndex = 4;
            this.cmbCategoriaProd.ValueMember = "idCategoria";
            this.cmbCategoriaProd.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriaProd_SelectedIndexChanged);
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.dataBase_RestaurantDataSet7;
            // 
            // dataBase_RestaurantDataSet7
            // 
            this.dataBase_RestaurantDataSet7.DataSetName = "DataBase_RestaurantDataSet7";
            this.dataBase_RestaurantDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(39, 137);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Cantidad";
            // 
            // dtgvPlatillos
            // 
            this.dtgvPlatillos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPlatillos.Location = new System.Drawing.Point(19, 169);
            this.dtgvPlatillos.Name = "dtgvPlatillos";
            this.dtgvPlatillos.Size = new System.Drawing.Size(396, 293);
            this.dtgvPlatillos.TabIndex = 0;
            this.dtgvPlatillos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPlatillos_CellClick);
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // frmMesa5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(966, 656);
            this.ControlBox = false;
            this.Controls.Add(this.btnHacerPedido);
            this.Controls.Add(this.btnSalirNuevaOrden);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmMesa5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden Mesa 5";
            this.Load += new System.EventHandler(this.frmMesa5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAgregarProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_RestaurantDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPlatillos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHacerPedido;
        private System.Windows.Forms.Button btnSalirNuevaOrden;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTipoOrden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtEstadoOrden;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateOrden;
        private System.Windows.Forms.DataGridView dtgvAgregarProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumeroMesa;
        private System.Windows.Forms.TextBox txtPrecioPlatillo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdPlatillo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCategoriaProd;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dtgvPlatillos;
        private DataBase_RestaurantDataSet7 dataBase_RestaurantDataSet7;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DataBase_RestaurantDataSet7TableAdapters.CategoriaTableAdapter categoriaTableAdapter;
    }
}