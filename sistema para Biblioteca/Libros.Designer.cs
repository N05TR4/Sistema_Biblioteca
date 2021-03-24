namespace sistema_para_Biblioteca
{
    partial class Libros
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
            this.txtMateria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipo_libro = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnatras = new System.Windows.Forms.Button();
            this.tablaLibro = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMateria
            // 
            this.txtMateria.FormattingEnabled = true;
            this.txtMateria.Items.AddRange(new object[] {
            "Lengua y Literatura ",
            "Ingles ",
            "Frances ",
            "Ciencias Sociales ",
            "Ciencias Naturales ",
            "Moral y Civica ",
            "Religion ",
            "Formación",
            "Enciclopedia",
            "Diccionario",
            "Matematicas",
            "Historia "});
            this.txtMateria.Location = new System.Drawing.Point(20, 24);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(121, 21);
            this.txtMateria.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(164, 25);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(200, 20);
            this.txtAutor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de libro";
            // 
            // txtTipo_libro
            // 
            this.txtTipo_libro.FormattingEnabled = true;
            this.txtTipo_libro.Items.AddRange(new object[] {
            "Basico",
            "Medio",
            "Obra",
            "Diccionario",
            "Idiomas"});
            this.txtTipo_libro.Location = new System.Drawing.Point(401, 25);
            this.txtTipo_libro.Name = "txtTipo_libro";
            this.txtTipo_libro.Size = new System.Drawing.Size(121, 21);
            this.txtTipo_libro.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipo_libro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMateria);
            this.groupBox1.Location = new System.Drawing.Point(51, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 84);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(12, 12);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(52, 22);
            this.btnatras.TabIndex = 7;
            this.btnatras.Text = "Atras";
            this.btnatras.UseVisualStyleBackColor = true;
            // 
            // tablaLibro
            // 
            this.tablaLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLibro.Location = new System.Drawing.Point(51, 180);
            this.tablaLibro.Name = "tablaLibro";
            this.tablaLibro.Size = new System.Drawing.Size(549, 229);
            this.tablaLibro.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(461, 415);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 40);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 468);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tablaLibro);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.groupBox1);
            this.Name = "Libros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.Libros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox txtMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtTipo_libro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.DataGridView tablaLibro;
        private System.Windows.Forms.Button btnBuscar;
    }
}