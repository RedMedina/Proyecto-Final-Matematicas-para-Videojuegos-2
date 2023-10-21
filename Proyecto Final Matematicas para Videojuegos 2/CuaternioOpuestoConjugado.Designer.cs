namespace Proyecto_Final_Matematicas_para_Videojuegos_2
{
    partial class CuaternioOpuestoConjugado
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listCuaternio = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Resultadoes
            // 
            this.Resultadoes.AutoSize = true;
            this.Resultadoes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultadoes.Location = new System.Drawing.Point(165, 173);
            this.Resultadoes.Name = "Resultadoes";
            this.Resultadoes.Size = new System.Drawing.Size(114, 15);
            this.Resultadoes.TabIndex = 31;
            this.Resultadoes.Text = "El Resultado Es: ";
            this.Resultadoes.Visible = false;
            // 
            // lstResultado
            // 
            this.lstResultado.ColumnWidth = 5;
            this.lstResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(160, 191);
            this.lstResultado.MultiColumn = true;
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(119, 17);
            this.lstResultado.TabIndex = 30;
            this.lstResultado.Visible = false;
            // 
            // BtnVolverMenu
            // 
            this.BtnVolverMenu.Location = new System.Drawing.Point(177, 272);
            this.BtnVolverMenu.Name = "BtnVolverMenu";
            this.BtnVolverMenu.Size = new System.Drawing.Size(82, 41);
            this.BtnVolverMenu.TabIndex = 29;
            this.BtnVolverMenu.Text = "Volver al Menú";
            this.BtnVolverMenu.UseVisualStyleBackColor = true;
            this.BtnVolverMenu.Click += new System.EventHandler(this.BtnVolverMenu_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Location = new System.Drawing.Point(177, 225);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(82, 41);
            this.btnCalcular.TabIndex = 28;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(12, 48);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(111, 34);
            this.btnIngresar.TabIndex = 27;
            this.btnIngresar.Text = "Ingrese el Cuaternio";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cuaternio Opuesto Conjugado";
            // 
            // listCuaternio
            // 
            this.listCuaternio.ColumnWidth = 5;
            this.listCuaternio.Cursor = System.Windows.Forms.Cursors.Default;
            this.listCuaternio.FormattingEnabled = true;
            this.listCuaternio.Location = new System.Drawing.Point(12, 88);
            this.listCuaternio.MultiColumn = true;
            this.listCuaternio.Name = "listCuaternio";
            this.listCuaternio.Size = new System.Drawing.Size(111, 17);
            this.listCuaternio.TabIndex = 32;
            // 
            // CuaternioOpuestoConjugado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 325);
            this.Controls.Add(this.listCuaternio);
            this.Controls.Add(this.Resultadoes);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.BtnVolverMenu);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label1);
            this.Name = "CuaternioOpuestoConjugado";
            this.Text = "Cuaternio Opuesto Conjugado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Resultadoes;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button BtnVolverMenu;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listCuaternio;
    }
}