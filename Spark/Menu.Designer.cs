
namespace Spark
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_provedor = new System.Windows.Forms.Button();
            this.btn_almacen = new System.Windows.Forms.Button();
            this.btn_cc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ventas
            // 
            this.btn_ventas.BackColor = System.Drawing.Color.Transparent;
            this.btn_ventas.BackgroundImage = global::Spark.Properties.Resources.ventas;
            this.btn_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Location = new System.Drawing.Point(86, 220);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(103, 104);
            this.btn_ventas.TabIndex = 0;
            this.btn_ventas.UseMnemonic = false;
            this.btn_ventas.UseVisualStyleBackColor = false;
            this.btn_ventas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_provedor
            // 
            this.btn_provedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_provedor.BackgroundImage = global::Spark.Properties.Resources.proveedores;
            this.btn_provedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_provedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_provedor.FlatAppearance.BorderSize = 0;
            this.btn_provedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_provedor.Location = new System.Drawing.Point(311, 220);
            this.btn_provedor.Name = "btn_provedor";
            this.btn_provedor.Size = new System.Drawing.Size(103, 104);
            this.btn_provedor.TabIndex = 1;
            this.btn_provedor.UseVisualStyleBackColor = false;
            this.btn_provedor.Click += new System.EventHandler(this.btn_provedor_Click);
            // 
            // btn_almacen
            // 
            this.btn_almacen.BackgroundImage = global::Spark.Properties.Resources.almacen;
            this.btn_almacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_almacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_almacen.FlatAppearance.BorderSize = 0;
            this.btn_almacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_almacen.Location = new System.Drawing.Point(562, 220);
            this.btn_almacen.Name = "btn_almacen";
            this.btn_almacen.Size = new System.Drawing.Size(108, 104);
            this.btn_almacen.TabIndex = 2;
            this.btn_almacen.UseVisualStyleBackColor = true;
            this.btn_almacen.Click += new System.EventHandler(this.btn_almacen_Click);
            // 
            // btn_cc
            // 
            this.btn_cc.BackColor = System.Drawing.Color.Transparent;
            this.btn_cc.BackgroundImage = global::Spark.Properties.Resources.control_de_calidad;
            this.btn_cc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cc.FlatAppearance.BorderSize = 0;
            this.btn_cc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cc.Location = new System.Drawing.Point(820, 220);
            this.btn_cc.Name = "btn_cc";
            this.btn_cc.Size = new System.Drawing.Size(108, 104);
            this.btn_cc.TabIndex = 3;
            this.btn_cc.UseVisualStyleBackColor = false;
            this.btn_cc.Click += new System.EventHandler(this.btn_cc_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 582);
            this.Controls.Add(this.btn_cc);
            this.Controls.Add(this.btn_almacen);
            this.Controls.Add(this.btn_provedor);
            this.Controls.Add(this.btn_ventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_provedor;
        private System.Windows.Forms.Button btn_almacen;
        private System.Windows.Forms.Button btn_cc;
    }
}