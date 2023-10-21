namespace Proyecto_Final_Matematicas_para_Videojuegos_2
{
    partial class BresenhamI
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
            this.lstResultado1 = new System.Windows.Forms.ListBox();
            this.BtnVolverMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btningresar = new System.Windows.Forms.Button();
            this.lstResultado2 = new System.Windows.Forms.ListBox();
            this.lstResultado3 = new System.Windows.Forms.ListBox();
            this.lblK = new System.Windows.Forms.Label();
            this.lblPk = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Resultadoes
            // 
            this.Resultadoes.AutoSize = true;
            this.Resultadoes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultadoes.Location = new System.Drawing.Point(9, 54);
            this.Resultadoes.Name = "Resultadoes";
            this.Resultadoes.Size = new System.Drawing.Size(114, 15);
            this.Resultadoes.TabIndex = 86;
            this.Resultadoes.Text = "El Resultado Es: ";
            this.Resultadoes.Visible = false;
            // 
            // lstResultado1
            // 
            this.lstResultado1.ColumnWidth = 5;
            this.lstResultado1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstResultado1.FormattingEnabled = true;
            this.lstResultado1.HorizontalScrollbar = true;
            this.lstResultado1.Location = new System.Drawing.Point(12, 116);
            this.lstResultado1.MultiColumn = true;
            this.lstResultado1.Name = "lstResultado1";
            this.lstResultado1.Size = new System.Drawing.Size(26, 199);
            this.lstResultado1.TabIndex = 85;
            this.lstResultado1.Visible = false;
            // 
            // BtnVolverMenu
            // 
            this.BtnVolverMenu.Location = new System.Drawing.Point(204, 272);
            this.BtnVolverMenu.Name = "BtnVolverMenu";
            this.BtnVolverMenu.Size = new System.Drawing.Size(82, 41);
            this.BtnVolverMenu.TabIndex = 84;
            this.BtnVolverMenu.Text = "Volver al Menú";
            this.BtnVolverMenu.UseVisualStyleBackColor = true;
            this.BtnVolverMenu.Click += new System.EventHandler(this.BtnVolverMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 81;
            this.label1.Text = "Algoritmo de Bresenham I";
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(204, 65);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(77, 37);
            this.btningresar.TabIndex = 87;
            this.btningresar.Text = "Ingrese los datos";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // lstResultado2
            // 
            this.lstResultado2.ColumnWidth = 5;
            this.lstResultado2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstResultado2.FormattingEnabled = true;
            this.lstResultado2.Location = new System.Drawing.Point(40, 116);
            this.lstResultado2.MultiColumn = true;
            this.lstResultado2.Name = "lstResultado2";
            this.lstResultado2.Size = new System.Drawing.Size(48, 199);
            this.lstResultado2.TabIndex = 88;
            this.lstResultado2.Visible = false;
            // 
            // lstResultado3
            // 
            this.lstResultado3.ColumnWidth = 5;
            this.lstResultado3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstResultado3.FormattingEnabled = true;
            this.lstResultado3.Location = new System.Drawing.Point(94, 116);
            this.lstResultado3.MultiColumn = true;
            this.lstResultado3.Name = "lstResultado3";
            this.lstResultado3.Size = new System.Drawing.Size(104, 199);
            this.lstResultado3.TabIndex = 89;
            this.lstResultado3.Visible = false;
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(13, 100);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(14, 13);
            this.lblK.TabIndex = 90;
            this.lblK.Text = "K";
            this.lblK.Visible = false;
            // 
            // lblPk
            // 
            this.lblPk.AutoSize = true;
            this.lblPk.Location = new System.Drawing.Point(46, 100);
            this.lblPk.Name = "lblPk";
            this.lblPk.Size = new System.Drawing.Size(20, 13);
            this.lblPk.TabIndex = 91;
            this.lblPk.Text = "Pk";
            this.lblPk.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(112, 100);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(59, 13);
            this.lbl3.TabIndex = 92;
            this.lbl3.Text = "(x +1, y +1)";
            this.lbl3.Visible = false;
            // 
            // BresenhamI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 325);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblPk);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.lstResultado3);
            this.Controls.Add(this.lstResultado2);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.Resultadoes);
            this.Controls.Add(this.lstResultado1);
            this.Controls.Add(this.BtnVolverMenu);
            this.Controls.Add(this.label1);
            this.Name = "BresenhamI";
            this.Text = "BresenhamI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Resultadoes;
        private System.Windows.Forms.ListBox lstResultado1;
        private System.Windows.Forms.Button BtnVolverMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.ListBox lstResultado2;
        private System.Windows.Forms.ListBox lstResultado3;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblPk;
        private System.Windows.Forms.Label lbl3;
    }
}