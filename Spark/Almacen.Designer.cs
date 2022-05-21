
namespace Spark
{
    partial class Almacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Almacen));
            this.back = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_Capacidad = new System.Windows.Forms.TextBox();
            this.txt_Ubicacion = new System.Windows.Forms.TextBox();
            this.txt_Proveedor = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_nombre_eliminar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbleliminar = new System.Windows.Forms.Label();
            this.lblagregar = new System.Windows.Forms.Label();
            this.lbleditar = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(1072, -3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 81);
            this.back.TabIndex = 0;
            this.back.Text = "button1";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1170, 714);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_precio);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.btn_Agregar);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.txt_Fecha);
            this.tabPage1.Controls.Add(this.txt_Cantidad);
            this.tabPage1.Controls.Add(this.txt_Capacidad);
            this.tabPage1.Controls.Add(this.txt_Ubicacion);
            this.tabPage1.Controls.Add(this.txt_Proveedor);
            this.tabPage1.Controls.Add(this.txt_nombre);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1162, 681);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(854, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Precio:";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(854, 204);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(185, 27);
            this.txt_precio.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Spark.Properties.Resources.almacenscreen;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1043, 555);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 130);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.Silver;
            this.btn_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Agregar.Location = new System.Drawing.Point(481, 553);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(371, 60);
            this.btn_Agregar.TabIndex = 14;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(44, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 60);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Location = new System.Drawing.Point(481, 448);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(264, 27);
            this.txt_Fecha.TabIndex = 12;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(481, 204);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(264, 27);
            this.txt_Cantidad.TabIndex = 11;
            // 
            // txt_Capacidad
            // 
            this.txt_Capacidad.Location = new System.Drawing.Point(481, 322);
            this.txt_Capacidad.Name = "txt_Capacidad";
            this.txt_Capacidad.Size = new System.Drawing.Size(264, 27);
            this.txt_Capacidad.TabIndex = 10;
            // 
            // txt_Ubicacion
            // 
            this.txt_Ubicacion.Location = new System.Drawing.Point(44, 448);
            this.txt_Ubicacion.Name = "txt_Ubicacion";
            this.txt_Ubicacion.Size = new System.Drawing.Size(299, 27);
            this.txt_Ubicacion.TabIndex = 9;
            // 
            // txt_Proveedor
            // 
            this.txt_Proveedor.Location = new System.Drawing.Point(44, 322);
            this.txt_Proveedor.Name = "txt_Proveedor";
            this.txt_Proveedor.Size = new System.Drawing.Size(299, 27);
            this.txt_Proveedor.TabIndex = 8;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(44, 204);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(299, 27);
            this.txt_nombre.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(481, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fecha: \tAAAA-MM-DD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(481, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "Capacidad(Stock)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(481, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cantidad del producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ubicacion(Stock)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(44, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre del producto:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.btn_Guardar);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1162, 681);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(769, 424);
            this.dataGridView1.TabIndex = 22;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Spark.Properties.Resources.almacenscreen;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(1043, 555);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(125, 130);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button5.Location = new System.Drawing.Point(57, 588);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(272, 60);
            this.button5.TabIndex = 16;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Silver;
            this.btn_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Guardar.Location = new System.Drawing.Point(455, 588);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(371, 60);
            this.btn_Guardar.TabIndex = 15;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.txt_nombre_eliminar);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btn_eliminar);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1162, 681);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(33, 173);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(798, 420);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Spark.Properties.Resources.almacenscreen;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1043, 555);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 130);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txt_nombre_eliminar
            // 
            this.txt_nombre_eliminar.Location = new System.Drawing.Point(260, 142);
            this.txt_nombre_eliminar.Name = "txt_nombre_eliminar";
            this.txt_nombre_eliminar.Size = new System.Drawing.Size(379, 27);
            this.txt_nombre_eliminar.TabIndex = 18;
            this.txt_nombre_eliminar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_nombre_eliminar_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(33, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 28);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nombre del producto:";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Silver;
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_eliminar.Location = new System.Drawing.Point(394, 613);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(377, 60);
            this.btn_eliminar.TabIndex = 15;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            this.btn_eliminar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_eliminar_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbleliminar);
            this.panel1.Controls.Add(this.lblagregar);
            this.panel1.Controls.Add(this.lbleditar);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 136);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbleliminar
            // 
            this.lbleliminar.AutoSize = true;
            this.lbleliminar.BackColor = System.Drawing.Color.Transparent;
            this.lbleliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbleliminar.Location = new System.Drawing.Point(508, 21);
            this.lbleliminar.Name = "lbleliminar";
            this.lbleliminar.Size = new System.Drawing.Size(119, 31);
            this.lbleliminar.TabIndex = 6;
            this.lbleliminar.Text = "ELIMINAR";
            // 
            // lblagregar
            // 
            this.lblagregar.AutoSize = true;
            this.lblagregar.BackColor = System.Drawing.Color.Transparent;
            this.lblagregar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblagregar.Location = new System.Drawing.Point(508, 23);
            this.lblagregar.Name = "lblagregar";
            this.lblagregar.Size = new System.Drawing.Size(116, 31);
            this.lblagregar.TabIndex = 5;
            this.lblagregar.Text = "AGREGAR";
            // 
            // lbleditar
            // 
            this.lbleditar.AutoSize = true;
            this.lbleditar.BackColor = System.Drawing.Color.Transparent;
            this.lbleditar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbleditar.Location = new System.Drawing.Point(508, 23);
            this.lbleditar.Name = "lbleditar";
            this.lbleditar.Size = new System.Drawing.Size(90, 31);
            this.lbleditar.TabIndex = 4;
            this.lbleditar.Text = "EDITAR";
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.BackgroundImage = global::Spark.Properties.Resources.Menu_ico;
            this.radioButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton4.FlatAppearance.BorderSize = 0;
            this.radioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Wheat;
            this.radioButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.radioButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Location = new System.Drawing.Point(1116, -3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(50, 51);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton3.BackgroundImage")));
            this.radioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton3.FlatAppearance.BorderSize = 0;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Wheat;
            this.radioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.radioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Location = new System.Drawing.Point(240, 7);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 66);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton2.BackgroundImage")));
            this.radioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Wheat;
            this.radioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.radioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Location = new System.Drawing.Point(137, 7);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 66);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton1.BackgroundImage")));
            this.radioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Wheat;
            this.radioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.radioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton1.Location = new System.Drawing.Point(32, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 66);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1170, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Almacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Almacen_FormClosed);
            this.Load += new System.EventHandler(this.Almacen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Capacidad;
        private System.Windows.Forms.TextBox txt_Ubicacion;
        private System.Windows.Forms.TextBox txt_Proveedor;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblagregar;
        private System.Windows.Forms.Label lbleditar;
        private System.Windows.Forms.Label lbleliminar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txt_nombre_eliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_precio;
    }
}