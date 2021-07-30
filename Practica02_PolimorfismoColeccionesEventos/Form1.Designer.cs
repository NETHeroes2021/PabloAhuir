
namespace Practica02_PolimorfismoColeccionesEventos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAcero = new System.Windows.Forms.Button();
            this.buttonBronce = new System.Windows.Forms.Button();
            this.buttonChip = new System.Windows.Forms.Button();
            this.buttonGominola = new System.Windows.Forms.Button();
            this.buttonHigo = new System.Windows.Forms.Button();
            this.buttonPapel = new System.Windows.Forms.Button();
            this.buttonEscoba = new System.Windows.Forms.Button();
            this.labelKg = new System.Windows.Forms.Label();
            this.labelTotalMateriales = new System.Windows.Forms.Label();
            this.labelMediaNoPerecederos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAcero
            // 
            this.buttonAcero.Location = new System.Drawing.Point(14, 14);
            this.buttonAcero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAcero.Name = "buttonAcero";
            this.buttonAcero.Size = new System.Drawing.Size(88, 27);
            this.buttonAcero.TabIndex = 0;
            this.buttonAcero.Text = "Acero";
            this.buttonAcero.UseVisualStyleBackColor = true;
            this.buttonAcero.Click += new System.EventHandler(this.agnadirObjeto_Click);
            // 
            // buttonBronce
            // 
            this.buttonBronce.Location = new System.Drawing.Point(108, 14);
            this.buttonBronce.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBronce.Name = "buttonBronce";
            this.buttonBronce.Size = new System.Drawing.Size(88, 27);
            this.buttonBronce.TabIndex = 1;
            this.buttonBronce.Text = "Bronce";
            this.buttonBronce.UseVisualStyleBackColor = true;
            this.buttonBronce.Click += new System.EventHandler(this.agnadirObjeto_Click);
            // 
            // buttonChip
            // 
            this.buttonChip.Location = new System.Drawing.Point(14, 81);
            this.buttonChip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonChip.Name = "buttonChip";
            this.buttonChip.Size = new System.Drawing.Size(88, 27);
            this.buttonChip.TabIndex = 2;
            this.buttonChip.Text = "Chip";
            this.buttonChip.UseVisualStyleBackColor = true;
            this.buttonChip.Click += new System.EventHandler(this.agnadirObjeto_Click);
            // 
            // buttonGominola
            // 
            this.buttonGominola.Location = new System.Drawing.Point(14, 47);
            this.buttonGominola.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGominola.Name = "buttonGominola";
            this.buttonGominola.Size = new System.Drawing.Size(88, 27);
            this.buttonGominola.TabIndex = 3;
            this.buttonGominola.Text = "Gominola";
            this.buttonGominola.UseVisualStyleBackColor = true;
            this.buttonGominola.Click += new System.EventHandler(this.agnadirObjeto_Click);
            // 
            // buttonHigo
            // 
            this.buttonHigo.Location = new System.Drawing.Point(108, 47);
            this.buttonHigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonHigo.Name = "buttonHigo";
            this.buttonHigo.Size = new System.Drawing.Size(88, 27);
            this.buttonHigo.TabIndex = 4;
            this.buttonHigo.Text = "Higo";
            this.buttonHigo.UseVisualStyleBackColor = true;
            this.buttonHigo.Click += new System.EventHandler(this.agnadirObjeto_Click);
            // 
            // buttonPapel
            // 
            this.buttonPapel.Location = new System.Drawing.Point(203, 81);
            this.buttonPapel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPapel.Name = "buttonPapel";
            this.buttonPapel.Size = new System.Drawing.Size(88, 27);
            this.buttonPapel.TabIndex = 5;
            this.buttonPapel.Text = "Papel";
            this.buttonPapel.UseVisualStyleBackColor = true;
            this.buttonPapel.Click += new System.EventHandler(this.agnadirObjeto_Click);
            // 
            // buttonEscoba
            // 
            this.buttonEscoba.Location = new System.Drawing.Point(108, 81);
            this.buttonEscoba.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEscoba.Name = "buttonEscoba";
            this.buttonEscoba.Size = new System.Drawing.Size(88, 27);
            this.buttonEscoba.TabIndex = 6;
            this.buttonEscoba.Text = "Escoba";
            this.buttonEscoba.UseVisualStyleBackColor = true;
            this.buttonEscoba.Click += new System.EventHandler(this.agnadirObjeto_Click);
            // 
            // labelKg
            // 
            this.labelKg.AutoSize = true;
            this.labelKg.Location = new System.Drawing.Point(312, 81);
            this.labelKg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKg.Name = "labelKg";
            this.labelKg.Size = new System.Drawing.Size(235, 15);
            this.labelKg.TabIndex = 7;
            this.labelKg.Text = "Kilos de material perecedero no inflamable:";
            // 
            // labelTotalMateriales
            // 
            this.labelTotalMateriales.AutoSize = true;
            this.labelTotalMateriales.Location = new System.Drawing.Point(312, 14);
            this.labelTotalMateriales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalMateriales.Name = "labelTotalMateriales";
            this.labelTotalMateriales.Size = new System.Drawing.Size(144, 15);
            this.labelTotalMateriales.TabIndex = 8;
            this.labelTotalMateriales.Text = "Material total en almacén:";
            // 
            // labelMediaNoPerecederos
            // 
            this.labelMediaNoPerecederos.AutoSize = true;
            this.labelMediaNoPerecederos.Location = new System.Drawing.Point(312, 47);
            this.labelMediaNoPerecederos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMediaNoPerecederos.Name = "labelMediaNoPerecederos";
            this.labelMediaNoPerecederos.Size = new System.Drawing.Size(194, 15);
            this.labelMediaNoPerecederos.TabIndex = 9;
            this.labelMediaNoPerecederos.Text = "Cantidad media de no perecederos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 384);
            this.Controls.Add(this.labelMediaNoPerecederos);
            this.Controls.Add(this.labelTotalMateriales);
            this.Controls.Add(this.labelKg);
            this.Controls.Add(this.buttonEscoba);
            this.Controls.Add(this.buttonPapel);
            this.Controls.Add(this.buttonHigo);
            this.Controls.Add(this.buttonGominola);
            this.Controls.Add(this.buttonChip);
            this.Controls.Add(this.buttonBronce);
            this.Controls.Add(this.buttonAcero);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAcero;
        private System.Windows.Forms.Button buttonBronce;
        private System.Windows.Forms.Button buttonChip;
        private System.Windows.Forms.Button buttonGominola;
        private System.Windows.Forms.Button buttonHigo;
        private System.Windows.Forms.Button buttonPapel;
        private System.Windows.Forms.Button buttonEscoba;
        private System.Windows.Forms.Label labelKg;
        private System.Windows.Forms.Label labelTotalMateriales;
        private System.Windows.Forms.Label labelMediaNoPerecederos;
    }
}

