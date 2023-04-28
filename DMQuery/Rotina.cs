using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMQuery
{
    internal class Rotina
    {
        public string nomeRotina { get; set; }
        public string chamadoBase { get; set; }
        public string queryBase { get; set; }
        public string nomeRequerente { get; set; }
        public string observacoes { get; set; }
        public string pastaRequerente { get; set; }
        public string dataCriacao { get; set; }
        public string ultimaVez { get; set; }

        public static Rotina lerRotina(string arquivoRotina)
        {
            StreamReader rotina = new StreamReader(arquivoRotina);
            string rot = rotina.ReadToEnd().ToString();
            Rotina rotinajson = JsonConvert.DeserializeObject<Rotina>(rot);
            rotina.Close();
            return rotinajson;
        }

        public static void criarRotina(string nomeR, string chamadoB, string queryB, string nomeReq, string observacoesR, string pastaReq)
        {
            var rotina = new
            {
                nome_rotina = nomeR,
                chamado_base = chamadoB,
                query_base = queryB,
                nome_requerente = nomeReq,
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
    }
}
