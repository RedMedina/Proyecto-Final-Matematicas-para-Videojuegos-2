namespace Proyecto_Final_Matematicas_para_Videojuegos_2
{
    partial class MatrizEscalar
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
            this.Resultadoes = new System.Windows.Forms.Label();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.lstMatriz1 = new System.Windows.Forms.ListBox();
            this.Llave2 = new System.Windows.Forms.PictureBox();
            this.Llave1 = new System.Windows.Forms.PictureBox();
            this.BtnVolverMenu = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnMatriz1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listEscalar = new System.Windows.Forms.ListBox();
            this.btnIngresar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Llave2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Llave1)).BeginInit();
            this.SuspendLayout();
            // 
            // Resultadoes
            // 
            this.Resultadoes.AutoSize = true;
            this.Resultadoes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultadoes.Location = new System.Drawing.Point(159, 124);
            this.Resultadoes.Name = "Resultadoes";
            this.Resultadoes.Size = new System.Drawing.Size(114, 15);
            this.Resultadoes.TabIndex = 34;
            this.Resultadoes.Text = "El Resultado Es: ";
            this.Resultadoes.Visible = false;
            // 
            // lstResultado
            // 
            this.lstResultado.ColumnWidth = 5;
            this.lstResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(195, 142);
            this.lstResultado.MultiColumn = true;
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(31, 17);
            this.lstResultado.TabIndex = 33;
            this.lstResultado.Visible = false;
            // 
            // lstMatriz1
            // 
            this.lstMatriz1.ColumnWidth = 5;
            this.lstMatriz1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstMatriz1.FormattingEnabled = true;
            this.lstMatriz1.Location = new System.Drawing.Point(52, 96);
            this.lstMatriz1.MultiColumn = true;
            this.lstMatriz1.Name = "lstMatriz1";
            this.lstMatriz1.Size = new System.Drawing.Size(31, 17);
            this.lstMatriz1.TabIndex = 32;
            this.lstMatriz1.Visible = false;
            // 
            // Llave2
            // 
            this.Llave2.Image = global::Proyecto_Final_Matematicas_para_Videojuegos_2.Properties.Resources.llave2;
            this.Llave2.Location = new System.Drawing.Point(117, 87);
            this.Llave2.Name = "Llave2";
            this.Llave2.Size = new System.Drawing.Size(19, 50);
            this.Llave2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Llave2.TabIndex = 31;
            this.Llave2.TabStop = false;
            this.Llave2.Visible = false;
            // 
            // Llave1
            // 
            this.Llave1.Image = global::Proyecto_Final_Matematicas_para_Videojuegos_2.Properties.Resources.llave1;
            this.Llave1.Location = new System.Drawing.Point(8, 87);
            this.Llave1.Name = "Llave1";
            this.Llave1.Size = new System.Drawing.Size(19, 50);
            this.Llave1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Llave1.TabIndex = 30;
            this.Llave1.TabStop = false;
            this.Llave1.Visible = false;
            // 
            // BtnVolverMenu
            // 
            this.BtnVolverMenu.Location = new System.Drawing.Point(174, 271);
            this.BtnVolverMenu.Name = "BtnVolverMenu";
            this.BtnVolverMenu.Size = new System.Drawing.Size(82, 41);
            this.BtnVolverMenu.TabIndex = 29;
            this.BtnVolverMenu.Text = "Volver al Menú";
            this.BtnVolverMenu.UseVisualStyleBackColor = true;
            this.BtnVolverMenu.Click += new System.EventHandler(this.BtnVolverMenu_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Enabled = false;
            this.btnSumar.Location = new System.Drawing.Point(174, 224);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(82, 41);
            this.btnSumar.TabIndex = 28;
            this.btnSumar.Text = "Calcular";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnMatriz1
            // 
            this.btnMatriz1.Location = new System.Drawing.Point(29, 49);
            this.btnMatriz1.Name = "btnMatriz1";
            this.btnMatriz1.Size = new System.Drawing.Size(82, 41);
            this.btnMatriz1.TabIndex = 27;
            this.btnMatriz1.Text = "Matriz 1";
            this.btnMatriz1.UseVisualStyleBackColor = true;
            this.btnMatriz1.Click += new System.EventHandler(this.btnMatriz1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Matriz X Escalar";
            // 
            // listEscalar
            // 
            this.listEscalar.ColumnWidth = 5;
            this.listEscalar.Cursor = System.Windows.Forms.Cursors.Default;
            this.listEscalar.FormattingEnabled = true;
            this.listEscalar.Location = new System.Drawing.Point(299, 89);
            this.listEscalar.MultiColumn = true;
            this.listEscalar.Name = "listEscalar";
            this.listEscalar.Size = new System.Drawing.Size(111, 17);
            this.listEscalar.TabIndex = 91;
            // 
            // btnIngresar2
            // 
            this.btnIngresar2.Location = new System.Drawing.Point(299, 49);
            this.btnIngresar2.Name = "btnIngresar2";
            this.btnIngresar2.Size = new System.Drawing.Size(111, 34);
            this.btnIngresar2.TabIndex = 90;
            this.btnIngresar2.Text = "Ingrese el Escalar";
            this.btnIngresar2.UseVisualStyleBackColor = true;
            this.btnIngresar2.Click += new System.EventHandler(this.btnIngresar2_Click);
            // 
            // MatrizEscalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 325);
            this.Controls.Add(this.listEscalar);
            this.Controls.Add(this.btnIngresar2);
            this.Controls.Add(this.Resultadoes);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.lstMatriz1);
            this.Controls.Add(this.Llave2);
            this.Controls.Add(this.Llave1);
            this.Controls.Add(this.BtnVolverMenu);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnMatriz1);
            this.Controls.Add(this.label1);
            this.Name = "MatrizEscalar";
            this.Text = "MatrizEscalar";
            ((System.ComponentModel.ISupportInitialize)(this.Llave2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Llave1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Resultadoes;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.ListBox lstMatriz1;
        private System.Windows.Forms.PictureBox Llave2;
        private System.Windows.Forms.PictureBox Llave1;
        private System.Windows.Forms.Button BtnVolverMenu;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnMatriz1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listEscalar;
        private System.Windows.Forms.Button btnIngresar2;
    }
}