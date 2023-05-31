using System;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Diagnostics;

namespace proyecto_CuartoSemestre.Deserializar
{
    public partial class FormDeserializer : Form
    {
        public FormDeserializer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inicio = dtpInicio.Value.Year.ToString() + "-" + dtpInicio.Value.Month.ToString() + "-" + dtpInicio.Value.Day.ToString();
            string final = dtpFin.Value.Year.ToString() + "-" + dtpFin.Value.Month.ToString() + "-" + dtpFin.Value.Day.ToString();
            string url = "https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF43718/datos/" + inicio + "/" + final;
            Response response = read(url);
            Serie serie = response.seriesResponse.series[0];
            lbSerie.Text = "Serie: " + serie.Title;
            StreamWriter sw = new StreamWriter("StreamReader.txt");
            
            if(serie.Data == null)
            {
                MessageBox.Show("Elija otra fecha por favor, o una fecha mas extensa");
                return;
            }
            foreach (DataSerie dataSerie in serie.Data)
            {
                if (dataSerie.Data.Equals("N/E")) continue;
                sw.WriteLine("Fecha: " + dataSerie.Date);
                sw.WriteLine("Precio: " + dataSerie.Data);
            }
            sw.Close();
            Process blocDeNOtas = Process.Start("StreamReader.txt");
            blocDeNOtas.WaitForExit();
            File.Delete("StreamReader.txt");
        }

        private static Response read(string url)
        {
            try
            {
                //string url = "https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF43718/datos/2023-01-31/2023-01-31";
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Accept = "application/json";
                request.Headers["Bmx-Token"] = "69260904c3e398685c78e54928e7129fb21c7f79443e3c8b59e5c91f8319ef47";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception(String.Format(
                    "Server error (HTTP {0}: {1}).",
                    response.StatusCode,
                    response.StatusDescription));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                Response jsonResponse = objResponse as Response;
                return jsonResponse;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
    }
}