
namespace Spark
{
    partial class caja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(caja));
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_caja = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cantidad.Location = new System.Drawing.Point(12, 63);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(175, 28);
            this.lbl_cantidad.TabIndex = 0;
            this.lbl_cantidad.Text = "Cantidad a vender:";
            // 
            // txt_caja
            // 
            this.txt_caja.Location = new System.Drawing.Point(209, 64);
            this.txt_caja.Name = "txt_caja";
            this.txt_caja.Size = new System.Drawing.Size(125, 27);
            this.txt_caja.TabIndex = 1;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(240, 107);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(94, 29);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(35, 107);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(125, 27);
            this.txt_total.TabIndex = 3;
            this.txt_total.Visible = false;
            // 
            // caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spark.Properties.Resources.Menú_fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(348, 183);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_caja);
            this.Controls.Add(this.lbl_cantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "caja";
            this.Load += new System.EventHandler(this.caja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Button btn_ok;
        public System.Windows.Forms.TextBox txt_caja;
        public System.Windows.Forms.TextBox txt_total;
    }
}