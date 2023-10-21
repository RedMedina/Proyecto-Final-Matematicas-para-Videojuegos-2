namespace Proyecto_Final_Matematicas_para_Videojuegos_2
{
    partial class Matriz_Por_Vector
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
            this.lstVector = new System.Windows.Forms.ListBox();
            this.lstMatriz1 = new System.Windows.Forms.ListBox();
            this.BtnVolverMenu = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnVector = new System.Windows.Forms.Button();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Llave2 = new System.Windows.Forms.PictureBox();
            this.Llave1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Llave2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Llave1)).BeginInit();
            this.SuspendLayout();
            // 
            // Resultadoes
            // 
            this.Resultadoes.AutoSize = true;
            this.Resultadoes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultadoes.Location = new System.Drawing.Point(163, 126);
            this.Resultadoes.Name = "Resultadoes";
            this.Resultadoes.Size = new System.Drawing.Size(114, 15);
            this.Resultadoes.TabIndex = 51;
            this.Resultadoes.Text = "El Resultado Es: ";
            this.Resultadoes.Visible = false;
            // 
            // lstResultado
            // 
            this.lstResultado.ColumnWidth = 5;
            this.lstResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(199, 144);
            this.lstResultado.MultiColumn = true;
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(31, 17);
            this.lstResultado.TabIndex = 50;
            this.lstResultado.Visible = false;
            // 
            // lstVector
            // 
            this.lstVector.FormattingEnabled = true;
            this.lstVector.Location = new System.Drawing.Point(307, 98);
            this.lstVector.Name = "lstVector";
            this.lstVector.Size = new System.Drawing.Size(82, 30);
            this.lstVector.TabIndex = 49;
            this.lstVector.Visible = false;
            // 
            // lstMatriz1
            // 
            this.lstMatriz1.ColumnWidth = 5;
            this.lstMatriz1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstMatriz1.FormattingEnabled = true;
            this.lstMatriz1.Location = new System.Drawing.Point(56, 98);
            this.lstMatriz1.MultiColumn = true;
            this.lstMatriz1.Name = "lstMatriz1";
            this.lstMatriz1.Size = new System.Drawing.Size(31, 17);
            this.lstMatriz1.TabIndex = 48;
            this.lstMatriz1.Visible = false;
            // 
            // BtnVolverMenu
            // 
            this.BtnVolverMenu.Location = new System.Drawing.Point(178, 273);
            this.BtnVolverMenu.Name = "BtnVolverMenu";
            this.BtnVolverMenu.Size = new System.Drawing.Size(82, 41);
            this.BtnVolverMenu.TabIndex = 43;
            this.BtnVolverMenu.Text = "Volver al Menú";
            this.BtnVolverMenu.UseVisualStyleBackColor = true;
            this.BtnVolverMenu.Click += new System.EventHandler(this.BtnVolverMenu_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Enabled = false;
            this.btnMultiplicar.Location = new System.Drawing.Point(178, 226);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(82, 41);
            this.btnMultiplicar.TabIndex = 42;
            this.btnMultiplicar.Text = "Calcular";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnVector
            // 
            this.btnVector.Location = new System.Drawing.Point(307, 51);
            this.btnVector.Name = "btnVector";
            this.btnVector.Size = new System.Drawing.Size(82, 41);
            this.btnVector.TabIndex = 41;
            this.btnVector.Text = "Vector";
            this.btnVector.UseVisualStyleBackColor = true;
            this.btnVector.Click += new System.EventHandler(this.btnVector_Click);
            // 
            // btnMatriz
            // 
            this.btnMatriz.Location = new System.Drawing.Point(33, 51);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(82, 41);
            this.btnMatriz.TabIndex = 40;
            this.btnMatriz.Text = "Matriz";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Matriz Por Vector";
            // 
            // Llave2
            // 
            this.Llave2.Image = global::Proyecto_Final_Matematicas_para_Videojuegos_2.Properties.Resources.llave2;
            this.Llave2.Location = new System.Drawing.Point(121, 89);
            this.Llave2.Name = "Llave2";
            this.Llave2.Size = new System.Drawing.Size(19, 50);
            this.Llave2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Llave2.TabIndex = 45;
            this.Llave2.TabStop = false;
            this.Llave2.Visible = false;
            // 
            // Llave1
            // 
            this.Llave1.Image = global::Proyecto_Final_Matematicas_para_Videojuegos_2.Properties.Resources.llave1;
            this.Llave1.Location = new System.Drawing.Point(12, 89);
            this.Llave1.Name = "Llave1";
            this.Llave1.Size = new System.Drawing.Size(19, 50);
            this.Llave1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Llave1.TabIndex = 44;
            this.Llave1.TabStop = false;
            this.Llave1.Visible = false;
            // 
            // Matriz_Por_Vector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 325);
            this.Controls.Add(this.Resultadoes);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.lstVector);
            this.Controls.Add(this.lstMatriz1);
            this.Controls.Add(this.Llave2);
            this.Controls.Add(this.Llave1);
            this.Controls.Add(this.BtnVolverMenu);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnVector);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.label1);
            this.Name = "Matriz_Por_Vector";
            this.Text = "Matriz_Por_Vector";
            this.Load += new System.EventHandler(this.Matriz_Por_Vector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Llave2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Llave1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Resultadoes;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.ListBox lstVector;
        private System.Windows.Forms.ListBox lstMatriz1;
        private System.Windows.Forms.PictureBox Llave2;
        private System.Windows.Forms.PictureBox Llave1;
        private System.Windows.Forms.Button BtnVolverMenu;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnVector;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.Label label1;
    }
}