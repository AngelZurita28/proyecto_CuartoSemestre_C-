namespace proyecto_CuartoSemestre
{
    partial class Form1
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
            this.btnFormXL = new System.Windows.Forms.Button();
            this.btnFormChart = new System.Windows.Forms.Button();
            this.btnFormTree = new System.Windows.Forms.Button();
            this.btnFormDeserializer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormXL
            // 
            this.btnFormXL.Location = new System.Drawing.Point(21, 25);
            this.btnFormXL.Name = "btnFormXL";
            this.btnFormXL.Size = new System.Drawing.Size(122, 71);
            this.btnFormXL.TabIndex = 0;
            this.btnFormXL.Text = "Abrir Aplicacion Tipo Excel de CP";
            this.btnFormXL.UseVisualStyleBackColor = true;
            this.btnFormXL.Click += new System.EventHandler(this.btnFormXL_Click);
            // 
            // btnFormChart
            // 
            this.btnFormChart.Location = new System.Drawing.Point(177, 25);
            this.btnFormChart.Name = "btnFormChart";
            this.btnFormChart.Size = new System.Drawing.Size(122, 71);
            this.btnFormChart.TabIndex = 1;
            this.btnFormChart.Text = "Abrir Aplicacion de Grafica de CP";
            this.btnFormChart.UseVisualStyleBackColor = true;
            this.btnFormChart.Click += new System.EventHandler(this.btnFormChart_Click);
            // 
            // btnFormTree
            // 
            this.btnFormTree.Location = new System.Drawing.Point(177, 140);
            this.btnFormTree.Name = "btnFormTree";
            this.btnFormTree.Size = new System.Drawing.Size(122, 71);
            this.btnFormTree.TabIndex = 2;
            this.btnFormTree.Text = "Abrir Aplicacion de Arbol de CP";
            this.btnFormTree.UseVisualStyleBackColor = true;
            this.btnFormTree.Click += new System.EventHandler(this.btnFormTree_Click);
            // 
            // btnFormDeserializer
            // 
            this.btnFormDeserializer.Location = new System.Drawing.Point(21, 140);
            this.btnFormDeserializer.Name = "btnFormDeserializer";
            this.btnFormDeserializer.Size = new System.Drawing.Size(122, 71);
            this.btnFormDeserializer.TabIndex = 3;
            this.btnFormDeserializer.Text = "Abrir Aplicacion de deserealizador con request a API";
            this.btnFormDeserializer.UseVisualStyleBackColor = true;
            this.btnFormDeserializer.Click += new System.EventHandler(this.btnFormDeserializer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 228);
            this.Controls.Add(this.btnFormDeserializer);
            this.Controls.Add(this.btnFormTree);
            this.Controls.Add(this.btnFormChart);
            this.Controls.Add(this.btnFormXL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormXL;
        private System.Windows.Forms.Button btnFormChart;
        private System.Windows.Forms.Button btnFormTree;
        private System.Windows.Forms.Button btnFormDeserializer;
    }
}

