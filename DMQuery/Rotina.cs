//using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;
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

        private static bool primeiroDia()
        {
            DateTime date = DateTime.Now;
            if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday && date.Day == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool ultimoDia()
        {
            DateTime date = DateTime.Now;
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }

            int lastDayOfMonth = DateTime.DaysInMonth(date.Year, date.Month);
            DateTime lastDay = new DateTime(date.Year, date.Month, lastDayOfMonth);

            return date == lastDay || (date > lastDay.AddDays(-7) && date.DayOfWeek == DayOfWeek.Friday);
        }
        public static Rotina lerRotina(string nomeR)
        {
            StreamReader rotina = new StreamReader("Rotinas/" + nomeR);
            string rot = rotina.ReadToEnd().ToString();
            Rotina rotinajson = JsonConvert.DeserializeObject<Rotina>(rot);
            rotina.Close();
            return rotinajson;
        }
        public static void atualizarUltVez(string nomeR)
        {
            StreamReader rotina = new StreamReader("Rotinas/" + nomeR);
            string rot = rotina.ReadToEnd().ToString();
            rotina.Close();
            Rotina rotinajson = JsonConvert.DeserializeObject<Rotina>(rot);
            rotinajson.ultima_vez = DateTime.Now.ToString("yyyy-MM-dd");
            string json = JsonConvert.SerializeObject(rotinajson, Formatting.Indented);
            StreamWriter rotw = new StreamWriter("Rotinas/" + nomeR);
            rotw.Write(json);
            rotw.Close();
        }
        public static string[] rodarHoje(string nomeR)
        {
            //foi rodado hoje / deve ser rodado hoje
            string diaDaSemana = DateTime.Now.DayOfWeek.ToString();
            string[] r = new string[] { "Nao", "" };
            string[] externo = new string[] {"Chamado GLPI", "Email", "Outro" };
            StreamReader rotina = new StreamReader("Rotinas/" + nomeR);
            string rot = rotina.ReadToEnd().ToString();
            rotina.Close();
            Rotina rotinajson = JsonConvert.DeserializeObject<Rotina>(rot);
            if (rotinajson.ultima_vez == DateTime.Now.ToString("yyyy-MM-dd"))
            {
                r[0] = "Sim";
            }
            if (externo.Contains(rotinajson.periodo))
            {
                r[1] = rotinajson.periodo;
            }
            else if (rotinajson.periodo == "Semanal")
            {
                if (rotinajson.quando_rodar == "Domingo" && diaDaSemana == "Sunday")
                {
                    r[1] = "Sim";
                }
                else if (rotinajson.quando_rodar == "Segunda-Feira" && diaDaSemana == "Moonday")
                {
                    r[1] = "Sim";
                }
                else if (rotinajson.quando_rodar == "Terca-Feira" && diaDaSemana == "Tuesday")
                {
                    r[1] = "Sim";
                }
                else if (rotinajson.quando_rodar == "Quarta-Feira" && diaDaSemana == "Wednesday")
                {
                    r[1] = "Sim";
                }
                else if (rotinajson.quando_rodar == "Quinta-Feira" && diaDaSemana == "Thursday")
                {
                    r[1] = "Sim";
                }
                else if (rotinajson.quando_rodar == "Sexta-Feira" && diaDaSemana == "Friday")
                {
                    r[1] = "Sim";
                }
                else if (rotinajson.quando_rodar == "Sabado" && diaDaSemana == "Saturday")
                {
                    r[1] = "Sim";
                }
                else { r[1] = "Nao"; }
            }
            else if (rotinajson.periodo == "Mensal")
            {
                if (rotinajson.quando_rodar == "Primeiro dia" && primeiroDia())
                {
                    r[1] = "Sim";
                }
                else if(rotinajson.quando_rodar == "Ultimo dia" && ultimoDia())
                {
                    r[1] = "Sim";
                }
                else if (rotinajson.quando_rodar == DateTime.Now.ToString("dd"))
                {
                    r[1] = "Sim";
                }
                else { r[1] = "Nao"; }
            }
            else if (rotinajson.periodo == "Diario")
            {
                r[1] = "Sim";
            }

            return r;
        }
        public static void criarRotina(string nomeR, string chamadoB, string queryB, string nomeReq, string periodoR, string observacoesR, string pastaReq, string quandoR = "")
        {
            nomeR = nomeR.Replace(" ", "_");
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
        public static void apagarRotina(string nomeArquivo)
        {
            string caminho = Directory.GetCurrentDirectory()+"/Rotinas/" + nomeArquivo;
            if (File.Exists(caminho))
            {
                File.Delete(caminho);
            }
        }
        public static void editarRotina(string nomeArquivo, string nomeNovo, string chamadoB, string nomeReq, string periodo, string observacoes, string pastaReq, string queryB, string quandoR = "")
        {
            Rotina rotAntiga = lerRotina(nomeArquivo);
            string nome_antigo = rotAntiga.nome_rotina;
            Rotina rotNova = rotAntiga;
            rotNova.nome_rotina = nomeNovo.Replace(" ", "_");
            rotNova.chamado_base = chamadoB;
            rotNova.nome_requerente = nomeReq;
            rotNova.periodo = periodo;
            if (periodo != "Diario") { rotNova.quando_rodar = quandoR; } else { rotNova.quando_rodar = ""; }
            rotNova.observacoes = observacoes;
            rotNova.pasta_requerente = pastaReq;
            rotNova.query_base= queryB;
            string json = JsonConvert.SerializeObject(rotNova, Formatting.Indented);
            StreamWriter rotn = new StreamWriter("Rotinas/" + rotNova.nome_rotina + ".rot");
            if (nome_antigo != rotNova.nome_rotina) 
            {
                apagarRotina(nomeArquivo); 
            }
            rotn.Write(json);
            rotn.Close();
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
