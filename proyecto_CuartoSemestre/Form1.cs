using proyecto_CuartoSemestre.Deserializar;
using proyecto_CuartoSemestre.Grafica;
using proyecto_CuartoSemestre.Jerarquia;
using System;
using System.Windows.Forms;

namespace proyecto_CuartoSemestre
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }

        private void btnFormTree_Click(object sender, EventArgs e)
        { Form fTree = new FormTree();fTree.ShowDialog(); }

        private void btnFormDeserializer_Click(object sender, EventArgs e)
        { Form fDeserializar = new FormDeserializer(); fDeserializar.ShowDialog(); }

        private void btnFormChart_Click(object sender, EventArgs e)
        { Form fChart = new FormChart(); fChart.ShowDialog(); }

        private void btnFormXL_Click(object sender, EventArgs e)
        { Form fXL = new FormXLType(); fXL.ShowDialog(); }
    }
}
