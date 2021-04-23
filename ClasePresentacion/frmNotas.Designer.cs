
namespace ClasePresentacion
{
    partial class frmNotas
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
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtEscuelaProfesional = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnEvaluación = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(287, 55);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(161, 20);
            this.txtApellidos.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(287, 137);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(161, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(287, 180);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(161, 20);
            this.txtMateria.TabIndex = 2;
            // 
            // txtEscuelaProfesional
            // 
            this.txtEscuelaProfesional.Location = new System.Drawing.Point(287, 219);
            this.txtEscuelaProfesional.Name = "txtEscuelaProfesional";
            this.txtEscuelaProfesional.Size = new System.Drawing.Size(161, 20);
            this.txtEscuelaProfesional.TabIndex = 3;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(507, 73);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(507, 114);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 5;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnEvaluación
            // 
            this.btnEvaluación.Location = new System.Drawing.Point(185, 300);
            this.btnEvaluación.Name = "btnEvaluación";
            this.btnEvaluación.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluación.TabIndex = 6;
            this.btnEvaluación.Text = "Evaluación";
            this.btnEvaluación.UseVisualStyleBackColor = true;
            this.btnEvaluación.Click += new System.EventHandler(this.btnEvaluación_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(333, 300);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(75, 23);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Location = new System.Drawing.Point(483, 300);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(75, 23);
            this.btnAnalisis.TabIndex = 8;
            this.btnAnalisis.Text = "Analisis";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(287, 95);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(161, 20);
            this.txtNombres.TabIndex = 10;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnEvaluación);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtEscuelaProfesional);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtApellidos);
            this.Name = "frmNotas";
            this.Text = "Trabajar con la clase Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtEscuelaProfesional;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnEvaluación;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.TextBox txtNombres;
    }
}