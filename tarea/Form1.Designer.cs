namespace tarea
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.cmbFavoritos = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.BtnFavoritos = new System.Windows.Forms.Button();
            this.BtnIr = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.cmbFavoritos);
            this.panel1.Controls.Add(this.BtnFavoritos);
            this.panel1.Controls.Add(this.BtnIr);
            this.panel1.Controls.Add(this.BtnAtras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 91);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 91);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1033, 420);
            this.webBrowser1.TabIndex = 1;
            // 
            // cmbFavoritos
            // 
            this.cmbFavoritos.FormattingEnabled = true;
            this.cmbFavoritos.Location = new System.Drawing.Point(902, 45);
            this.cmbFavoritos.Name = "cmbFavoritos";
            this.cmbFavoritos.Size = new System.Drawing.Size(121, 21);
            this.cmbFavoritos.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(120, 46);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(621, 20);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // BtnFavoritos
            // 
            this.BtnFavoritos.Location = new System.Drawing.Point(902, 3);
            this.BtnFavoritos.Name = "BtnFavoritos";
            this.BtnFavoritos.Size = new System.Drawing.Size(121, 38);
            this.BtnFavoritos.TabIndex = 2;
            this.BtnFavoritos.Text = "favoritos";
            this.BtnFavoritos.UseVisualStyleBackColor = true;
            this.BtnFavoritos.Click += new System.EventHandler(this.BtnFavoritos_Click);
            // 
            // BtnIr
            // 
            this.BtnIr.Location = new System.Drawing.Point(756, 24);
            this.BtnIr.Name = "BtnIr";
            this.BtnIr.Size = new System.Drawing.Size(89, 44);
            this.BtnIr.TabIndex = 1;
            this.BtnIr.Text = "buscar";
            this.BtnIr.UseVisualStyleBackColor = true;
            this.BtnIr.Click += new System.EventHandler(this.BtnIr_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(12, 27);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(102, 41);
            this.BtnAtras.TabIndex = 0;
            this.BtnAtras.Text = "atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);

            this.BtnAtras.Location = new System.Drawing.Point(12, 27);
            this.BtnAtras.Name = "btnActualizar";
            this.BtnAtras.Size = new System.Drawing.Size(10, 41);
            this.BtnAtras.TabIndex = 0;
            this.BtnAtras.Text = "actualizar";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);




            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 511);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "AlexanderBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cmbFavoritos;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button BtnFavoritos;
        private System.Windows.Forms.Button BtnIr;
        private System.Windows.Forms.Button BtnAtras;
    }
}

