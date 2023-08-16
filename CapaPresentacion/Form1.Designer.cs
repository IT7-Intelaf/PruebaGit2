namespace CRUD_BD_Clientes1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCodigo = new TextBox();
            txtDireccionEntrega = new TextBox();
            txtNombre = new TextBox();
            txtNitDpiPas = new TextBox();
            txtTelefono = new TextBox();
            txtFax = new TextBox();
            txtAtencion = new TextBox();
            txtCorreo1 = new TextBox();
            txtDescuento = new TextBox();
            txtCorreo2 = new TextBox();
            txtAnotaciones = new TextBox();
            cbxAgenteRetenedor = new ComboBox();
            txtZonaEntrega = new TextBox();
            rbnNit = new RadioButton();
            rbnDpi = new RadioButton();
            rdbPasaporte = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            rdbSiMayorista = new RadioButton();
            rbnNoMayorista = new RadioButton();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            rbnNoListaNegra = new RadioButton();
            rbnSiListaNegra = new RadioButton();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            btnIngresar = new Button();
            btnBuscar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(174, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 31);
            txtCodigo.TabIndex = 1;
            // 
            // txtDireccionEntrega
            // 
            txtDireccionEntrega.Location = new Point(828, 339);
            txtDireccionEntrega.Name = "txtDireccionEntrega";
            txtDireccionEntrega.Size = new Size(501, 31);
            txtDireccionEntrega.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(174, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(501, 31);
            txtNombre.TabIndex = 3;
            // 
            // txtNitDpiPas
            // 
            txtNitDpiPas.Location = new Point(174, 232);
            txtNitDpiPas.Name = "txtNitDpiPas";
            txtNitDpiPas.Size = new Size(150, 31);
            txtNitDpiPas.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(174, 283);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 5;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(174, 333);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(150, 31);
            txtFax.TabIndex = 6;
            // 
            // txtAtencion
            // 
            txtAtencion.Location = new Point(174, 390);
            txtAtencion.Name = "txtAtencion";
            txtAtencion.Size = new Size(318, 31);
            txtAtencion.TabIndex = 7;
            // 
            // txtCorreo1
            // 
            txtCorreo1.Location = new Point(828, 32);
            txtCorreo1.Name = "txtCorreo1";
            txtCorreo1.Size = new Size(318, 31);
            txtCorreo1.TabIndex = 9;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(828, 82);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(76, 31);
            txtDescuento.TabIndex = 10;
            // 
            // txtCorreo2
            // 
            txtCorreo2.Location = new Point(828, 133);
            txtCorreo2.Name = "txtCorreo2";
            txtCorreo2.Size = new Size(318, 31);
            txtCorreo2.TabIndex = 11;
            // 
            // txtAnotaciones
            // 
            txtAnotaciones.Location = new Point(828, 181);
            txtAnotaciones.Name = "txtAnotaciones";
            txtAnotaciones.Size = new Size(318, 31);
            txtAnotaciones.TabIndex = 12;
            // 
            // cbxAgenteRetenedor
            // 
            cbxAgenteRetenedor.FormattingEnabled = true;
            cbxAgenteRetenedor.Items.AddRange(new object[] { "Exportadores", "Estado(Gobierno)", "Contribuyente Especial", "No Es Agente Retenedor" });
            cbxAgenteRetenedor.Location = new Point(828, 282);
            cbxAgenteRetenedor.Name = "cbxAgenteRetenedor";
            cbxAgenteRetenedor.Size = new Size(258, 33);
            cbxAgenteRetenedor.TabIndex = 14;
            // 
            // txtZonaEntrega
            // 
            txtZonaEntrega.Location = new Point(828, 387);
            txtZonaEntrega.Name = "txtZonaEntrega";
            txtZonaEntrega.Size = new Size(76, 31);
            txtZonaEntrega.TabIndex = 15;
            // 
            // rbnNit
            // 
            rbnNit.AutoSize = true;
            rbnNit.Location = new Point(6, 14);
            rbnNit.Name = "rbnNit";
            rbnNit.Size = new Size(64, 29);
            rbnNit.TabIndex = 16;
            rbnNit.TabStop = true;
            rbnNit.Text = "NIT";
            rbnNit.UseVisualStyleBackColor = true;
            // 
            // rbnDpi
            // 
            rbnDpi.AutoSize = true;
            rbnDpi.Location = new Point(76, 14);
            rbnDpi.Name = "rbnDpi";
            rbnDpi.Size = new Size(65, 29);
            rbnDpi.TabIndex = 17;
            rbnDpi.TabStop = true;
            rbnDpi.Text = "DPI";
            rbnDpi.UseVisualStyleBackColor = true;
            // 
            // rdbPasaporte
            // 
            rdbPasaporte.AutoSize = true;
            rdbPasaporte.Location = new Point(147, 14);
            rdbPasaporte.Name = "rdbPasaporte";
            rdbPasaporte.Size = new Size(115, 29);
            rdbPasaporte.TabIndex = 18;
            rdbPasaporte.TabStop = true;
            rdbPasaporte.Text = "Pasaporte";
            rdbPasaporte.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 32);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 19;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 85);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 20;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 133);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 21;
            label3.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(174, 133);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(501, 31);
            txtDireccion.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 232);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 23;
            label4.Text = "NIT/DPI/Pasaporte:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 285);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 24;
            label5.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 333);
            label6.Name = "label6";
            label6.Size = new Size(41, 25);
            label6.TabIndex = 25;
            label6.Text = "Fax:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 393);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 26;
            label7.Text = "Atencion:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(85, 450);
            label8.Name = "label8";
            label8.Size = new Size(94, 25);
            label8.TabIndex = 27;
            label8.Text = "Mayorista:";
            // 
            // rdbSiMayorista
            // 
            rdbSiMayorista.AutoSize = true;
            rdbSiMayorista.Location = new Point(20, 16);
            rdbSiMayorista.Name = "rdbSiMayorista";
            rdbSiMayorista.Size = new Size(51, 29);
            rdbSiMayorista.TabIndex = 28;
            rdbSiMayorista.TabStop = true;
            rdbSiMayorista.Text = "Si";
            rdbSiMayorista.UseVisualStyleBackColor = true;
            // 
            // rbnNoMayorista
            // 
            rbnNoMayorista.AutoSize = true;
            rbnNoMayorista.Location = new Point(93, 16);
            rbnNoMayorista.Name = "rbnNoMayorista";
            rbnNoMayorista.Size = new Size(61, 29);
            rbnNoMayorista.TabIndex = 29;
            rbnNoMayorista.TabStop = true;
            rbnNoMayorista.Text = "No";
            rbnNoMayorista.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(737, 35);
            label9.Name = "label9";
            label9.Size = new Size(85, 25);
            label9.TabIndex = 30;
            label9.Text = "Correo 1:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(722, 85);
            label10.Name = "label10";
            label10.Size = new Size(100, 25);
            label10.TabIndex = 31;
            label10.Text = "Descuento:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(737, 136);
            label11.Name = "label11";
            label11.Size = new Size(85, 25);
            label11.TabIndex = 32;
            label11.Text = "Correo 2:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(708, 184);
            label12.Name = "label12";
            label12.Size = new Size(114, 25);
            label12.TabIndex = 33;
            label12.Text = "Anotaciones:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(718, 232);
            label13.Name = "label13";
            label13.Size = new Size(104, 25);
            label13.TabIndex = 34;
            label13.Text = "Lista Negra:";
            // 
            // rbnNoListaNegra
            // 
            rbnNoListaNegra.AutoSize = true;
            rbnNoListaNegra.Location = new Point(67, 7);
            rbnNoListaNegra.Name = "rbnNoListaNegra";
            rbnNoListaNegra.Size = new Size(61, 29);
            rbnNoListaNegra.TabIndex = 36;
            rbnNoListaNegra.TabStop = true;
            rbnNoListaNegra.Text = "No";
            rbnNoListaNegra.UseVisualStyleBackColor = true;
            // 
            // rbnSiListaNegra
            // 
            rbnSiListaNegra.AutoSize = true;
            rbnSiListaNegra.Location = new Point(10, 7);
            rbnSiListaNegra.Name = "rbnSiListaNegra";
            rbnSiListaNegra.Size = new Size(51, 29);
            rbnSiListaNegra.TabIndex = 35;
            rbnSiListaNegra.TabStop = true;
            rbnSiListaNegra.Text = "Si";
            rbnSiListaNegra.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(598, 283);
            label14.Name = "label14";
            label14.Size = new Size(224, 25);
            label14.TabIndex = 37;
            label14.Text = "Tipo de Agente Retenedor:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(643, 342);
            label15.Name = "label15";
            label15.Size = new Size(179, 25);
            label15.TabIndex = 38;
            label15.Text = "Direccion de Entrega:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(676, 390);
            label16.Name = "label16";
            label16.Size = new Size(146, 25);
            label16.TabIndex = 39;
            label16.Text = "Zona de Entrega:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(127, 535);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(172, 47);
            btnIngresar.TabIndex = 40;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(422, 535);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(172, 47);
            btnBuscar.TabIndex = 41;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(748, 535);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(172, 47);
            btnActualizar.TabIndex = 42;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1052, 535);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(172, 47);
            btnEliminar.TabIndex = 43;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbnNit);
            groupBox1.Controls.Add(rbnDpi);
            groupBox1.Controls.Add(rdbPasaporte);
            groupBox1.Location = new Point(174, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 60);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbnNoMayorista);
            groupBox2.Controls.Add(rdbSiMayorista);
            groupBox2.Location = new Point(185, 427);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(160, 50);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbnSiListaNegra);
            groupBox3.Controls.Add(rbnNoListaNegra);
            groupBox3.Location = new Point(828, 223);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(130, 40);
            groupBox3.TabIndex = 46;
            groupBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 608);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnBuscar);
            Controls.Add(btnIngresar);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtZonaEntrega);
            Controls.Add(cbxAgenteRetenedor);
            Controls.Add(txtAnotaciones);
            Controls.Add(txtCorreo2);
            Controls.Add(txtDescuento);
            Controls.Add(txtCorreo1);
            Controls.Add(txtAtencion);
            Controls.Add(txtFax);
            Controls.Add(txtTelefono);
            Controls.Add(txtNitDpiPas);
            Controls.Add(txtNombre);
            Controls.Add(txtDireccionEntrega);
            Controls.Add(txtCodigo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCodigo;
        private TextBox txtDireccionEntrega;
        private TextBox txtNombre;
        private TextBox txtNitDpiPas;
        private TextBox txtTelefono;
        private TextBox txtFax;
        private TextBox txtAtencion;
        private TextBox txtCorreo1;
        private TextBox txtDescuento;
        private TextBox txtCorreo2;
        private TextBox txtAnotaciones;
        private ComboBox cbxAgenteRetenedor;
        private TextBox txtZonaEntrega;
        private RadioButton rbnNit;
        private RadioButton rbnDpi;
        private RadioButton rdbPasaporte;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDireccion;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private RadioButton rdbSiMayorista;
        private RadioButton rbnNoMayorista;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private RadioButton rbnNoListaNegra;
        private RadioButton rbnSiListaNegra;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button btnIngresar;
        private Button btnBuscar;
        private Button btnActualizar;
        private Button btnEliminar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}