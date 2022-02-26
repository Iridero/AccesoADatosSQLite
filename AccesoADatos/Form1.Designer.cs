
namespace AccesoADatos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lstArticulos = new System.Windows.Forms.ListBox();
            this.btnCrearTabla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrId)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsertar);
            this.groupBox1.Controls.Add(this.txtDescripción);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nmrId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Articulo";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(194, 132);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(94, 29);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtDescripción
            // 
            this.txtDescripción.Location = new System.Drawing.Point(6, 99);
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(282, 27);
            this.txtDescripción.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // nmrId
            // 
            this.nmrId.Location = new System.Drawing.Point(6, 46);
            this.nmrId.Name = "nmrId";
            this.nmrId.Size = new System.Drawing.Size(282, 27);
            this.nmrId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(312, 12);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(166, 29);
            this.btnCargar.TabIndex = 5;
            this.btnCargar.Text = "Cargar datos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lstArticulos
            // 
            this.lstArticulos.FormattingEnabled = true;
            this.lstArticulos.ItemHeight = 20;
            this.lstArticulos.Location = new System.Drawing.Point(312, 47);
            this.lstArticulos.Name = "lstArticulos";
            this.lstArticulos.Size = new System.Drawing.Size(476, 144);
            this.lstArticulos.TabIndex = 6;
            // 
            // btnCrearTabla
            // 
            this.btnCrearTabla.Location = new System.Drawing.Point(11, 12);
            this.btnCrearTabla.Name = "btnCrearTabla";
            this.btnCrearTabla.Size = new System.Drawing.Size(289, 29);
            this.btnCrearTabla.TabIndex = 5;
            this.btnCrearTabla.Text = "Crear tabla";
            this.btnCrearTabla.UseVisualStyleBackColor = true;
            this.btnCrearTabla.Click += new System.EventHandler(this.btnCrearTabla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearTabla);
            this.Controls.Add(this.lstArticulos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListBox lstArticulos;
        private System.Windows.Forms.Button btnCrearTabla;
    }
}

