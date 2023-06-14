using ClosedXML.Excel;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMQuery
{
    internal class Arquivos
    {

        public static XLWorkbook Excel(DataTable relatorio)
        {
            XLWorkbook wb = new XLWorkbook();

            int maxRowCount = 900000; // Limite máximo de linhas por planilha
            int rowCount = 0; // Contador de linhas

            var worksheet = wb.Worksheets.Add("Relatório");

            // Cabeçalho
            for (int i = 0; i < relatorio.Columns.Count; i++)
            {
                worksheet.Cell(1, i + 1).Value = relatorio.Columns[i].ColumnName;
            }

            // Percorre as linhas do DataTable
            foreach (DataRow row in relatorio.Rows)
            {
                // Verifica se o limite de linhas por planilha foi atingido
                if (rowCount >= maxRowCount)
                {
                    // Cria uma nova folha
                    worksheet = wb.Worksheets.Add("Relatório " + (wb.Worksheets.Count + 1));

                    // Adiciona o cabeçalho na nova folha
                    for (int i = 0; i < relatorio.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = relatorio.Columns[i].ColumnName;
                    }

                    // Reinicia o contador de linhas
                    rowCount = 0;
                }

                // Adiciona uma nova linha à folha atual
                rowCount++;
                for (int i = 0; i < relatorio.Columns.Count; i++)
                {
                    worksheet.Cell(rowCount + 1, i + 1).Value = row[i].ToString();
                }
            }

            return wb;
        }
    }
}
