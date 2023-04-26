using DocumentFormat.OpenXml.Office2016.Drawing.Command;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMQuery
{
    internal class Configuracao
    {
        public string login { get; set; }
        public string senha { get; set; }
        public string servidor { get; set; }
        public string metodo { get; set; }

        public static Configuracao lerConfig(string arquivoConfig)
        {
            StreamReader configuracao = new StreamReader(arquivoConfig);
            string config = configuracao.ReadToEnd().ToString();
            Configuracao configjson = JsonConvert.DeserializeObject<Configuracao>(config);
            configuracao.Close();
            return configjson;

        }
        public static void salvarConfig(string metodo, string servidor, string login = "", string senha = "")
        {
            var configuracao = new
            {
                login = login,
                senha = senha,
                servidor = servidor,
                metodo = metodo

            };
            string json = JsonConvert.SerializeObject(configuracao, Formatting.Indented);
            StreamWriter config = new StreamWriter("Config.json");
            config.Write(json);
            config.Close();
        }
    }
}
