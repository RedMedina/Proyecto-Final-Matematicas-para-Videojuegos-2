namespace Proyecto_Final_Matematicas_para_Videojuegos_2
{
    partial class SumaVectores
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
            this.listVector2 = new System.Windows.Forms.ListBox();
            this.btnIngresar2 = new System.Windows.Forms.Button();
            this.listVector = new System.Windows.Forms.ListBox();
            this.Resultadoes = new System.Windows.Forms.Label();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.BtnVolverMenu = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listVector2
            // 
            this.listVector2.ColumnWidth = 5;
            this.listVector2.Cursor = System.Windows.Forms.Cursors.Default;
            this.listVector2.FormattingEnabled = true;
            this.listVector2.Location = new System.Drawing.Point(299, 90);
            this.listVector2.MultiColumn = true;
            this.listVector2.Name = "listVector2";
            this.listVector2.Size = new System.Drawing.Size(111, 17);
            this.listVector2.TabIndex = 71;
            // 
            // btnIngresar2
            // 
            this.btnIngresar2.Location = new System.Drawing.Point(299, 50);
            this.btnIngresar2.Name = "btnIngresar2";
            this.btnIngresar2.Size = new System.Drawing.Size(111, 34);
            this.btnIngresar2.TabIndex = 70;
            this.btnIngresar2.Text = "Ingrese el Vector";
            this.btnIngresar2.UseVisualStyleBackColor = true;
            this.btnIngresar2.Click += new System.EventHandler(this.btnIngresar2_Click);
            // 
            // listVector
            // 
            this.listVector.ColumnWidth = 5;
            this.listVector.Cursor = System.Windows.Forms.Cursors.Default;
            this.listVector.FormattingEnabled = true;
            this.listVector.Location = new System.Drawing.Point(22, 90);
            this.listVector.MultiColumn = true;
            this.listVector.Name = "listVector";
            this.listVector.Size = new System.Drawing.Size(111, 17);
            this.listVector.TabIndex = 69;
            // 
            // Resultadoes
            // 
            this.Resultadoes.AutoSize = true;
            this.Resultadoes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultadoes.Location = new System.Drawing.Point(167, 154);
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
            this.lstResultado.Location = new System.Drawing.Point(162, 172);
            this.lstResultado.MultiColumn = true;
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(119, 43);
            this.lstResultado.TabIndex = 67;
            this.lstResultado.Visible = false;
            // 
            // BtnVolverMenu
            // 
            this.BtnVolverMenu.Location = new System.Drawing.Point(187, 274);
            this.BtnVolverMenu.Name = "BtnVolverMenu";
            this.BtnVolverMenu.Size = new System.Drawing.Size(82, 41);
            this.BtnVolverMenu.TabIndex = 66;
            this.BtnVolverMenu.Text = "Volver al Menú";
            this.BtnVolverMenu.UseVisualStyleBackColor = true;
            this.BtnVolverMenu.Click += new System.EventHandler(this.BtnVolverMenu_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Location = new System.Drawing.Point(187, 227);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(82, 41);
            this.btnCalcular.TabIndex = 65;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(22, 50);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(111, 34);
            this.btnIngresar.TabIndex = 64;
            this.btnIngresar.Text = "Ingrese el Vector";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "Suma de Vectores";
            // 
            // SumaVectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 325);
            this.Controls.Add(this.listVector2);
            this.Controls.Add(this.btnIngresar2);
            this.Controls.Add(this.listVector);
            this.Controls.Add(this.Resultadoes);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.BtnVolverMenu);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label1);
            this.Name = "SumaVectores";
            this.Text = "SumaVectores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listVector2;
        private System.Windows.Forms.Button btnIngresar2;
        private System.Windows.Forms.ListBox listVector;
        private System.Windows.Forms.Label Resultadoes;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button BtnVolverMenu;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label1;
    }
}