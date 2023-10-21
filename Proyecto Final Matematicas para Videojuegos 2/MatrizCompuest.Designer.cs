namespace Proyecto_Final_Matematicas_para_Videojuegos_2
{
    partial class MatrizCompuest
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
            this.BtnVolverMenu = new System.Windows.Forms.Button();
            this.btnAngulos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCoordenadas = new System.Windows.Forms.Button();
            this.lstResultado2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Resultadoes
            // 
            this.Resultadoes.AutoSize = true;
            this.Resultadoes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultadoes.Location = new System.Drawing.Point(152, 75);
            this.Resultadoes.Name = "Resultadoes";
            this.Resultadoes.Size = new System.Drawing.Size(114, 15);
            this.Resultadoes.TabIndex = 68;
            this.Resultadoes.Text = "El Resultado Es: ";
            this.Resultadoes.Visible = false;
            // 
            // lstResultado
            // 
            this.lstResultado.ColumnWidth = 5;
            this.lstResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(6, 93);
            this.lstResultado.MultiColumn = true;
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(404, 69);
            this.lstResultado.TabIndex = 67;
            this.lstResultado.Visible = false;
            // 
            // BtnVolverMenu
            // 
            this.BtnVolverMenu.Location = new System.Drawing.Point(166, 372);
            this.BtnVolverMenu.Name = "BtnVolverMenu";
            this.BtnVolverMenu.Size = new System.Drawing.Size(82, 41);
            this.BtnVolverMenu.TabIndex = 66;
            this.BtnVolverMenu.Text = "Volver al Menú";
            this.BtnVolverMenu.UseVisualStyleBackColor = true;
            this.BtnVolverMenu.Click += new System.EventHandler(this.BtnVolverMenu_Click);
            // 
            // btnAngulos
            // 
            this.btnAngulos.Location = new System.Drawing.Point(166, 31);
            this.btnAngulos.Name = "btnAngulos";
            this.btnAngulos.Size = new System.Drawing.Size(82, 41);
            this.btnAngulos.TabIndex = 65;
            this.btnAngulos.Text = "Ingresar Datos";
            this.btnAngulos.UseVisualStyleBackColor = true;
            this.btnAngulos.Click += new System.EventHandler(this.btnAngulos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 64;
            this.label1.Text = "Matriz Compuesta ";
            // 
            // btnCoordenadas
            // 
            this.btnCoordenadas.Enabled = false;
            this.btnCoordenadas.Location = new System.Drawing.Point(150, 168);
            this.btnCoordenadas.Name = "btnCoordenadas";
            this.btnCoordenadas.Size = new System.Drawing.Size(116, 26);
            this.btnCoordenadas.TabIndex = 69;
            this.btnCoordenadas.Text = "IngreseCoordenadas";
            this.btnCoordenadas.UseVisualStyleBackColor = true;
            this.btnCoordenadas.Click += new System.EventHandler(this.btnCoordenadas_Click);
            // 
            // lstResultado2
            // 
            this.lstResultado2.FormattingEnabled = true;
            this.lstResultado2.Location = new System.Drawing.Point(6, 200);
            this.lstResultado2.Name = "lstResultado2";
            this.lstResultado2.Size = new System.Drawing.Size(404, 69);
            this.lstResultado2.TabIndex = 70;
            this.lstResultado2.Visible = false;
            // 
            // MatrizCompuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 425);
            this.Controls.Add(this.lstResultado2);
            this.Controls.Add(this.btnCoordenadas);
            this.Controls.Add(this.Resultadoes);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.BtnVolverMenu);
            this.Controls.Add(this.btnAngulos);
            this.Controls.Add(this.label1);
            this.Name = "MatrizCompuest";
            this.Text = "MatrizCompuesta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Resultadoes;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button BtnVolverMenu;
        private System.Windows.Forms.Button btnAngulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCoordenadas;
        private System.Windows.Forms.ListBox lstResultado2;
    }
}