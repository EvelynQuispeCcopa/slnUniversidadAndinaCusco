
namespace ClasePresentacion
{
    partial class frmAsignatura
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
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnEnseñar = new System.Windows.Forms.Button();
            this.btnAprender = new System.Windows.Forms.Button();
            this.btnEstudiar = new System.Windows.Forms.Button();
            this.dtHorario = new System.Windows.Forms.DateTimePicker();
            this.txtMetodoEducativo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(265, 60);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(153, 20);
            this.txtEstudiante.TabIndex = 0;
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(265, 97);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(153, 20);
            this.txtDocente.TabIndex = 1;
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(265, 134);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(153, 20);
            this.txtAula.TabIndex = 2;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(527, 97);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(527, 127);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 5;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnEnseñar
            // 
            this.btnEnseñar.Location = new System.Drawing.Point(142, 276);
            this.btnEnseñar.Name = "btnEnseñar";
            this.btnEnseñar.Size = new System.Drawing.Size(75, 23);
            this.btnEnseñar.TabIndex = 6;
            this.btnEnseñar.Text = "Enseñar";
            this.btnEnseñar.UseVisualStyleBackColor = true;
            this.btnEnseñar.Click += new System.EventHandler(this.btnEnseñar_Click);
            // 
            // btnAprender
            // 
            this.btnAprender.Location = new System.Drawing.Point(302, 276);
            this.btnAprender.Name = "btnAprender";
            this.btnAprender.Size = new System.Drawing.Size(75, 23);
            this.btnAprender.TabIndex = 7;
            this.btnAprender.Text = "Aprender";
            this.btnAprender.UseVisualStyleBackColor = true;
            this.btnAprender.Click += new System.EventHandler(this.btnAprender_Click);
            // 
            // btnEstudiar
            // 
            this.btnEstudiar.Location = new System.Drawing.Point(456, 276);
            this.btnEstudiar.Name = "btnEstudiar";
            this.btnEstudiar.Size = new System.Drawing.Size(75, 23);
            this.btnEstudiar.TabIndex = 8;
            this.btnEstudiar.Text = "Estudiar";
            this.btnEstudiar.UseVisualStyleBackColor = true;
            this.btnEstudiar.Click += new System.EventHandler(this.btnEstudiar_Click);
            // 
            // dtHorario
            // 
            this.dtHorario.Location = new System.Drawing.Point(265, 204);
            this.dtHorario.Name = "dtHorario";
            this.dtHorario.Size = new System.Drawing.Size(200, 20);
            this.dtHorario.TabIndex = 9;
            // 
            // txtMetodoEducativo
            // 
            this.txtMetodoEducativo.Location = new System.Drawing.Point(265, 170);
            this.txtMetodoEducativo.Name = "txtMetodoEducativo";
            this.txtMetodoEducativo.Size = new System.Drawing.Size(153, 20);
            this.txtMetodoEducativo.TabIndex = 10;
            // 
            // frmAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMetodoEducativo);
            this.Controls.Add(this.dtHorario);
            this.Controls.Add(this.btnEstudiar);
            this.Controls.Add(this.btnAprender);
            this.Controls.Add(this.btnEnseñar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.txtEstudiante);
            this.Name = "frmAsignatura";
            this.Text = "Trabajar con la clase Asignatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnEnseñar;
        private System.Windows.Forms.Button btnAprender;
        private System.Windows.Forms.Button btnEstudiar;
        private System.Windows.Forms.DateTimePicker dtHorario;
        private System.Windows.Forms.TextBox txtMetodoEducativo;
    }
}