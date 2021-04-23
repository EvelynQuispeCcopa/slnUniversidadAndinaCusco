
namespace ClasePresentacion
{
    partial class frmPPP
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
            this.txtCicloEstudios = new System.Windows.Forms.TextBox();
            this.txtAmbiente = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnCapacitar = new System.Windows.Forms.Button();
            this.btnFichaInforme = new System.Windows.Forms.Button();
            this.btnActividades = new System.Windows.Forms.Button();
            this.txtAsesor = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCicloEstudios
            // 
            this.txtCicloEstudios.Location = new System.Drawing.Point(274, 136);
            this.txtCicloEstudios.Name = "txtCicloEstudios";
            this.txtCicloEstudios.Size = new System.Drawing.Size(139, 20);
            this.txtCicloEstudios.TabIndex = 2;
            // 
            // txtAmbiente
            // 
            this.txtAmbiente.Location = new System.Drawing.Point(274, 210);
            this.txtAmbiente.Name = "txtAmbiente";
            this.txtAmbiente.Size = new System.Drawing.Size(139, 20);
            this.txtAmbiente.TabIndex = 3;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(469, 76);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(469, 119);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 5;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnCapacitar
            // 
            this.btnCapacitar.Location = new System.Drawing.Point(162, 266);
            this.btnCapacitar.Name = "btnCapacitar";
            this.btnCapacitar.Size = new System.Drawing.Size(75, 23);
            this.btnCapacitar.TabIndex = 6;
            this.btnCapacitar.Text = "Capacitar";
            this.btnCapacitar.UseVisualStyleBackColor = true;
            this.btnCapacitar.Click += new System.EventHandler(this.btnCapacitar_Click);
            // 
            // btnFichaInforme
            // 
            this.btnFichaInforme.Location = new System.Drawing.Point(300, 266);
            this.btnFichaInforme.Name = "btnFichaInforme";
            this.btnFichaInforme.Size = new System.Drawing.Size(92, 23);
            this.btnFichaInforme.TabIndex = 7;
            this.btnFichaInforme.Text = "Ficha Informe";
            this.btnFichaInforme.UseVisualStyleBackColor = true;
            this.btnFichaInforme.Click += new System.EventHandler(this.btnFichaInforme_Click);
            // 
            // btnActividades
            // 
            this.btnActividades.Location = new System.Drawing.Point(442, 266);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Size = new System.Drawing.Size(75, 23);
            this.btnActividades.TabIndex = 8;
            this.btnActividades.Text = "Actividades";
            this.btnActividades.UseVisualStyleBackColor = true;
            this.btnActividades.Click += new System.EventHandler(this.btnActividades_Click);
            // 
            // txtAsesor
            // 
            this.txtAsesor.Location = new System.Drawing.Point(274, 96);
            this.txtAsesor.Name = "txtAsesor";
            this.txtAsesor.Size = new System.Drawing.Size(139, 20);
            this.txtAsesor.TabIndex = 9;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(274, 174);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(139, 20);
            this.txtEspecialidad.TabIndex = 10;
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(274, 60);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(139, 20);
            this.txtEstudiante.TabIndex = 11;
            // 
            // frmPPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtAsesor);
            this.Controls.Add(this.btnActividades);
            this.Controls.Add(this.btnFichaInforme);
            this.Controls.Add(this.btnCapacitar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtAmbiente);
            this.Controls.Add(this.txtCicloEstudios);
            this.Name = "frmPPP";
            this.Text = "Trabajar con la clase PPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCicloEstudios;
        private System.Windows.Forms.TextBox txtAmbiente;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnCapacitar;
        private System.Windows.Forms.Button btnFichaInforme;
        private System.Windows.Forms.Button btnActividades;
        private System.Windows.Forms.TextBox txtAsesor;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtEstudiante;
    }
}