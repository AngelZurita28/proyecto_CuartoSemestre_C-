namespace proyecto_CuartoSemestre.Deserializar
{
    partial class FormDeserializer
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
        private void InitializeComponent()
        {
            this.btnRequest = new System.Windows.Forms.Button();
            this.lbSerie = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(12, 25);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(109, 23);
            this.btnRequest.TabIndex = 0;
            this.btnRequest.Text = "Hacer Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSerie
            // 
            this.lbSerie.AutoSize = true;
            this.lbSerie.Font = new System.Drawing.Font("JetBrains Mono", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSerie.Location = new System.Drawing.Point(192, 9);
            this.lbSerie.Name = "lbSerie";
            this.lbSerie.Size = new System.Drawing.Size(0, 23);
            this.lbSerie.TabIndex = 1;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("JetBrains Mono", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(192, 38);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(0, 23);
            this.lbFecha.TabIndex = 2;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("JetBrains Mono", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(192, 67);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(0, 23);
            this.lbPrecio.TabIndex = 3;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(12, 143);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(109, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(12, 93);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(109, 20);
            this.dtpInicio.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fin";
            // 
            // FormDeserializer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(139, 205);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbSerie);
            this.Controls.Add(this.btnRequest);
            this.Name = "FormDeserializer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label lbSerie;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}