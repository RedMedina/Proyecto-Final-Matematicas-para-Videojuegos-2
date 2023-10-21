namespace Proyecto_Final_Matematicas_para_Videojuegos_2
{
    partial class Suma_de_Matrices
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMatriz1 = new System.Windows.Forms.Button();
            this.btnMatriz2 = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.BtnVolverMenu = new System.Windows.Forms.Button();
            this.lstMatriz1 = new System.Windows.Forms.ListBox();
            this.lstMatriz2 = new System.Windows.Forms.ListBox();
            this.Llave4 = new System.Windows.Forms.PictureBox();
            this.Llave3 = new System.Windows.Forms.PictureBox();
            this.Llave2 = new System.Windows.Forms.PictureBox();
            this.Llave1 = new System.Windows.Forms.PictureBox();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.Resultadoes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Llave4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Llave3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Llave2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Llave1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suma de Matrices";
            // 
            // btnMatriz1
            // 
            this.btnMatriz1.Location = new System.Drawing.Point(33, 50);
            this.btnMatriz1.Name = "btnMatriz1";
            this.btnMatriz1.Size = new System.Drawing.Size(82, 41);
            this.btnMatriz1.TabIndex = 1;
            this.btnMatriz1.Text = "Matriz 1";
            this.btnMatriz1.UseVisualStyleBackColor = true;
            this.btnMatriz1.Click += new System.EventHandler(this.btnMatriz1_Click);
            // 
            // btnMatriz2
            // 
            this.btnMatriz2.Location = new System.Drawing.Point(307, 50);
            this.btnMatriz2.Name = "btnMatriz2";
            this.btnMatriz2.Size = new System.Drawing.Size(82, 41);
            this.btnMatriz2.TabIndex = 2;
            this.btnMatriz2.Text = "Matriz 2";
            this.btnMatriz2.UseVisualStyleBackColor = true;
            this.btnMatriz2.Click += new System.EventHandler(this.btnMatriz2_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Enabled = false;
            this.btnSumar.Location = new System.Drawing.Point(178, 225);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(82, 41);
            this.btnSumar.TabIndex = 3;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // BtnVolverMenu
            // 
            this.BtnVolverMenu.Location = new System.Drawing.Point(178, 272);
            this.BtnVolverMenu.Name = "BtnVolverMenu";
            this.BtnVolverMenu.Size = new System.Drawing.Size(82, 41);
            this.BtnVolverMenu.TabIndex = 4;
            this.BtnVolverMenu.Text = "Volver al Menú";
            this.BtnVolverMenu.UseVisualStyleBackColor = true;
            this.BtnVolverMenu.Click += new System.EventHandler(this.BtnVolverMenu_Click);
            // 
            // lstMatriz1
            // 
            this.lstMatriz1.ColumnWidth = 5;
            this.lstMatriz1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstMatriz1.FormattingEnabled = true;
            this.lstMatriz1.Location = new System.Drawing.Point(56, 97);
            this.lstMatriz1.MultiColumn = true;
            this.lstMatriz1.Name = "lstMatriz1";
            this.lstMatriz1.Size = new System.Drawing.Size(31, 17);
            this.lstMatriz1.TabIndex = 9;
            this.lstMatriz1.Visible = false;
            // 
            // lstMatriz2
            // 
            this.lstMatriz2.FormattingEnabled = true;
            this.lstMatriz2.Location = new System.Drawing.Point(335, 97);
            this.lstMatriz2.Name = "lstMatriz2";
            this.lstMatriz2.Size = new System.Drawing.Size(36, 17);
            this.lstMatriz2.TabIndex = 10;
            this.lstMatriz2.Visible = false;
            // 
            // Llave4
            // 
            this.Llave4.Image = global::Proyecto_Final_Matematicas_para_Videojuegos_2.Properties.Resources.llave2;
            this.Llave4.Location = new System.Drawing.Point(391, 88);
            this.Llave4.Name = "Llave4";
            this.Llave4.Size = new System.Drawing.Size(19, 50);
            this.Llave4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Llave4.TabIndex = 8;
            this.Llave4.TabStop = false;
            this.Llave4.Visible = false;
            // 
            // Llave3
            // 
            this.Llave3.Image = global::Proyecto_Final_Matematicas_para_Videojuegos_2.Properties.Resources.llave1;
            this.Llave3.Location = new System.Drawing.Point(283, 88);
            this.Llave3.Name = "Llave3";
            this.Llave3.Size = new System.Drawing.Size(19, 50);
            this.Llave3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Llave3.TabIndex = 7;
            this.Llave3.TabStop = false;
            this.Llave3.Visible = false;
            // 
            // Llave2
            // 
            this.Llave2.Image = global::Proyecto_Final_Matematicas_para_Videojuegos_2.Properties.Resources.llave2;
            this.Llave2.Location = new System.Drawing.Point(121, 88);
            this.Llave2.Name = "Llave2";
            this.Llave2.Size = new System.Drawing.Size(19, 50);
            this.Llave2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Llave2.TabIndex = 6;
            this.Llave2.TabStop = false;
            this.Llave2.Visible = false;
            // 
            // Llave1
            // 
            this.Llave1.Image = global::Proyecto_Final_Matematicas_para_Videojuegos_2.Properties.Resources.llave1;
            this.Llave1.Location = new System.Drawing.Point(12, 88);
            this.Llave1.Name = "Llave1";
            this.Llave1.Size = new System.Drawing.Size(19, 50);
            this.Llave1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Llave1.TabIndex = 5;
            this.Llave1.TabStop = false;
            this.Llave1.Visible = false;
            // 
            // lstResultado
            // 
            this.lstResultado.ColumnWidth = 5;
            this.lstResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(199, 143);
            this.lstResultado.MultiColumn = true;
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(31, 17);
            this.lstResultado.TabIndex = 11;
            this.lstResultado.Visible = false;
            // 
            // Resultadoes
            // 
            this.Resultadoes.AutoSize = true;
            this.Resultadoes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultadoes.Location = new System.Drawing.Point(163, 125);
            this.Resultadoes.Name = "Resultadoes";
            this.Resultadoes.Size = new System.Drawing.Size(114, 15);
            this.Resultadoes.TabIndex = 12;
            this.Resultadoes.Text = "El Resultado Es: ";
            this.Resultadoes.Visible = false;
            // 
            // Suma_de_Matrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 325);
            this.Controls.Add(this.Resultadoes);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.lstMatriz2);
            this.Controls.Add(this.lstMatriz1);
            this.Controls.Add(this.Llave4);
            this.Controls.Add(this.Llave3);
            this.Controls.Add(this.Llave2);
            this.Controls.Add(this.Llave1);
            this.Controls.Add(this.BtnVolverMenu);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnMatriz2);
            this.Controls.Add(this.btnMatriz1);
            this.Controls.Add(this.label1);
            this.Name = "Suma_de_Matrices";
            this.Text = "Suma_de_Matrices";
            this.Load += new System.EventHandler(this.Suma_de_Matrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Llave4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Llave3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Llave2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Llave1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatriz1;
        private System.Windows.Forms.Button btnMatriz2;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button BtnVolverMenu;
        private System.Windows.Forms.PictureBox Llave1;
        private System.Windows.Forms.PictureBox Llave2;
        private System.Windows.Forms.PictureBox Llave3;
        private System.Windows.Forms.PictureBox Llave4;
        private System.Windows.Forms.ListBox lstMatriz1;
        private System.Windows.Forms.ListBox lstMatriz2;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Label Resultadoes;
    }
}