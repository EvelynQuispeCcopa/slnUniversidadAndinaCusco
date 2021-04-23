
namespace ClasePresentacion
{
    partial class frmRector
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
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtAñoRectorado = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnSupervisar = new System.Windows.Forms.Button();
            this.btnApoyar = new System.Windows.Forms.Button();
            this.btnOrganizarAcitividades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(288, 78);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(151, 20);
            this.txtApellidos.TabIndex = 0;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(288, 115);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(151, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(288, 159);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(151, 20);
            this.txtEdad.TabIndex = 2;
            // 
            // txtAñoRectorado
            // 
            this.txtAñoRectorado.Location = new System.Drawing.Point(288, 202);
            this.txtAñoRectorado.Name = "txtAñoRectorado";
            this.txtAñoRectorado.Size = new System.Drawing.Size(151, 20);
            this.txtAñoRectorado.TabIndex = 3;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(522, 93);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(522, 138);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 5;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnSupervisar
            // 
            this.btnSupervisar.Location = new System.Drawing.Point(186, 271);
            this.btnSupervisar.Name = "btnSupervisar";
            this.btnSupervisar.Size = new System.Drawing.Size(75, 23);
            this.btnSupervisar.TabIndex = 6;
            this.btnSupervisar.Text = "Supervisar";
            this.btnSupervisar.UseVisualStyleBackColor = true;
            this.btnSupervisar.Click += new System.EventHandler(this.btnSupervisar_Click);
            // 
            // btnApoyar
            // 
            this.btnApoyar.Location = new System.Drawing.Point(321, 271);
            this.btnApoyar.Name = "btnApoyar";
            this.btnApoyar.Size = new System.Drawing.Size(75, 23);
            this.btnApoyar.TabIndex = 7;
            this.btnApoyar.Text = "Apoyar";
            this.btnApoyar.UseVisualStyleBackColor = true;
            this.btnApoyar.Click += new System.EventHandler(this.btnApoyar_Click);
            // 
            // btnOrganizarAcitividades
            // 
            this.btnOrganizarAcitividades.Location = new System.Drawing.Point(455, 271);
            this.btnOrganizarAcitividades.Name = "btnOrganizarAcitividades";
            this.btnOrganizarAcitividades.Size = new System.Drawing.Size(124, 23);
            this.btnOrganizarAcitividades.TabIndex = 8;
            this.btnOrganizarAcitividades.Text = "Organizar Actividades";
            this.btnOrganizarAcitividades.UseVisualStyleBackColor = true;
            this.btnOrganizarAcitividades.Click += new System.EventHandler(this.btnOrganizarAcitividades_Click);
            // 
            // frmRector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrganizarAcitividades);
            this.Controls.Add(this.btnApoyar);
            this.Controls.Add(this.btnSupervisar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtAñoRectorado);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Name = "frmRector";
            this.Text = "Trabajar con la clase Rector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtAñoRectorado;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnSupervisar;
        private System.Windows.Forms.Button btnApoyar;
        private System.Windows.Forms.Button btnOrganizarAcitividades;
    }
}