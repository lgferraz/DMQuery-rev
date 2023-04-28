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
    internal class Rotina
    {
        public string nome_rotina { get; set; }
        public string chamado_base { get; set; }
        public string query_base { get; set; }
        public string nome_requerente { get; set; }
        public string periodo { get; set; }
        public string quando_rodar { get; set; }
        public string observacoes { get; set; }
        public string pasta_requerente { get; set; }
        public string data_criacao { get; set; }
        public string ultima_vez { get; set; }

        public static Rotina lerRotina(string arquivoRotina)
        {
            StreamReader rotina = new StreamReader(arquivoRotina);
            string rot = rotina.ReadToEnd().ToString();
            Rotina rotinajson = JsonConvert.DeserializeObject<Rotina>(rot);
            rotina.Close();
            return rotinajson;
        }

        public static void criarRotina(string nomeR, string chamadoB, string queryB, string nomeReq, string periodoR, string observacoesR, string pastaReq, string quandoR = "")
        {
            var rotina = new
            {
                nome_rotina = nomeR,
                chamado_base = chamadoB,
                query_base = queryB,
                nome_requerente = nomeReq,
                periodo = periodoR,
                quando_rodar = quandoR,
                observacoes = observacoesR,
                pasta_requerente = pastaReq,
                data_criacao = DateTime.Now.ToString("yyyy-MM-dd"),
                ultima_vez = "null"
            };
            string json = JsonConvert.SerializeObject(rotina, Formatting.Indented);
            StreamWriter rot = new StreamWriter("Rotinas/"+nomeR+".rot");
            rot.Write(json);
            rot.Close();
        }
        public static string[] lerRotinas()
        {   
            List<string> rotinasN = new List<string>();
            string[] rotinas = Directory.GetFiles(Directory.GetCurrentDirectory()+"/Rotinas");
            foreach (string rotina in rotinas)
            {
                string rotinaN = Path.GetFileName(rotina);
                rotinasN.Add(rotinaN);

            }
            string[] result = rotinasN.ToArray();
            return result;
        }
    }
}
