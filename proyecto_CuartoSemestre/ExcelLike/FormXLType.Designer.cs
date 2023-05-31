namespace proyecto_CuartoSemestre
{
    partial class FormXLType
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnExcelInterop = new System.Windows.Forms.Button();
            this.btnExcelOpenXML = new System.Windows.Forms.Button();
            this.lstvDatos = new System.Windows.Forms.ListView();
            this.btnGuardarWord = new System.Windows.Forms.Button();
            this.btnGuardarPDF = new System.Windows.Forms.Button();
            this.btnJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(307, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Texto Plano";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnExcelInterop
            // 
            this.btnExcelInterop.Location = new System.Drawing.Point(588, 12);
            this.btnExcelInterop.Name = "btnExcelInterop";
            this.btnExcelInterop.Size = new System.Drawing.Size(89, 23);
            this.btnExcelInterop.TabIndex = 3;
            this.btnExcelInterop.Text = "Excel Interop";
            this.btnExcelInterop.UseVisualStyleBackColor = true;
            this.btnExcelInterop.Click += new System.EventHandler(this.btnGuardarExcel_Click);
            // 
            // btnExcelOpenXML
            // 
            this.btnExcelOpenXML.Location = new System.Drawing.Point(683, 12);
            this.btnExcelOpenXML.Name = "btnExcelOpenXML";
            this.btnExcelOpenXML.Size = new System.Drawing.Size(105, 23);
            this.btnExcelOpenXML.TabIndex = 4;
            this.btnExcelOpenXML.Text = "Excel OpenXml";
            this.btnExcelOpenXML.UseVisualStyleBackColor = true;
            this.btnExcelOpenXML.Click += new System.EventHandler(this.btnExcelOpenXML_Click);
            // 
            // lstvDatos
            // 
            this.lstvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvDatos.HideSelection = false;
            this.lstvDatos.Location = new System.Drawing.Point(12, 44);
            this.lstvDatos.Name = "lstvDatos";
            this.lstvDatos.Size = new System.Drawing.Size(776, 362);
            this.lstvDatos.TabIndex = 5;
            this.lstvDatos.UseCompatibleStateImageBehavior = false;
            // 
            // btnGuardarWord
            // 
            this.btnGuardarWord.Location = new System.Drawing.Point(507, 12);
            this.btnGuardarWord.Name = "btnGuardarWord";
            this.btnGuardarWord.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarWord.TabIndex = 6;
            this.btnGuardarWord.Text = "Word";
            this.btnGuardarWord.UseVisualStyleBackColor = true;
            this.btnGuardarWord.Click += new System.EventHandler(this.btnGuardarWord_Click);
            // 
            // btnGuardarPDF
            // 
            this.btnGuardarPDF.Location = new System.Drawing.Point(426, 12);
            this.btnGuardarPDF.Name = "btnGuardarPDF";
            this.btnGuardarPDF.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPDF.TabIndex = 7;
            this.btnGuardarPDF.Text = "PDF";
            this.btnGuardarPDF.UseVisualStyleBackColor = true;
            this.btnGuardarPDF.Click += new System.EventHandler(this.btnGuardarPDF_Click);
            // 
            // btnJson
            // 
            this.btnJson.Location = new System.Drawing.Point(211, 12);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(90, 23);
            this.btnJson.TabIndex = 8;
            this.btnJson.Text = "Serializar Json";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // FormXLType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJson);
            this.Controls.Add(this.btnGuardarPDF);
            this.Controls.Add(this.btnGuardarWord);
            this.Controls.Add(this.lstvDatos);
            this.Controls.Add(this.btnExcelOpenXML);
            this.Controls.Add(this.btnExcelInterop);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbrir);
            this.Name = "FormXLType";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnExcelInterop;
        private System.Windows.Forms.Button btnExcelOpenXML;
        private System.Windows.Forms.ListView lstvDatos;
        private System.Windows.Forms.Button btnGuardarWord;
        private System.Windows.Forms.Button btnGuardarPDF;
        private System.Windows.Forms.Button btnJson;
    }
}