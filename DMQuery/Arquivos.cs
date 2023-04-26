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
            wb.Worksheets.Add(relatorio, "Relatório");
            return wb;

        }
    }
}
