using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_CuartoSemestre.Grafica
{
    public partial class FormChart : Form
    {
        public FormChart()
        { InitializeComponent(); }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            { return; }

            string[] lineas = File.ReadAllLines(dialogo.FileName);

            Array[] datos = new Array[lineas.Count()];
            for (int i = 0; i < lineas.Length; i++)
            { datos[i] = lineas[i].Split('|'); }

            List<List<string>> formatoGrafica = new List<List<string>>();
            foreach (Array dato in datos)
            {
                bool encontrado = false;
                foreach (List<string> estado in formatoGrafica)
                {
                    if (!estado.Contains(dato.GetValue(4).ToString()))
                    { continue; }

                    if (!estado.Contains(dato.GetValue(0).ToString()))
                    { estado.Add(dato.GetValue(0).ToString()); }

                    encontrado = true;
                }

                if (encontrado) { continue; }

                formatoGrafica.Add(new List<string> { dato.GetValue(4).ToString() });
            }

            foreach (List<string> estado in formatoGrafica)
            { chart1.Series[0].Points.AddXY(estado[0], estado.Count - 1); }
        }
    }
}

