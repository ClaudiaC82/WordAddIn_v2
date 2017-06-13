using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace MailerUtilities
{
    public class messaggiErrati {
        public string MessaggioTest { get; set; }
        public string Destinatario { get; set; }
        public string Allegati { get; set; }
    }
    public class messaggio {
        public bool errore { get; set; }
        public bool MessaggioTest { get; set; }
        public string Destinatario { get; set; }
        public string Copia { get; set; }
        public string CopiaNascosta { get; set; }
        public List<string> Allegati { get; set; }
        public string Oggetto { get; set; }
        public string Messaggio { get; set; }

    }
    public class XLSX
    {
        
        public List<messaggio> elaboraExcel(string percorso, string messaggioWord)
        {
            try
            {
                List<messaggio> messaggi = new List<messaggio>();
                List<string> tags = new List<string>();
                Application xlApp = new Application();
                Workbook xlWorkBook = xlApp.Workbooks.Open(@percorso, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Worksheet xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Range range = xlWorkSheet.UsedRange;
                int righe = range.Rows.Count;
                int colonne = range.Columns.Count;
                int rCnt;
                int cCnt;
                //Prendo la lista dei TAG
                for (cCnt = 1; cCnt <= colonne; cCnt++)
                {
                    if (cCnt > 6)
                    {
                        tags.Add((string)(range.Cells[1, cCnt] as Range).Value2);
                    }
                }
                //Dalla seconda riga in poi preparo i messaggi
                for (rCnt = 2; rCnt <= righe; rCnt++)
                {
                    messaggio mex = new messaggio();
                    mex.errore = false;
                    mex.MessaggioTest = ((string)(range.Cells[rCnt, 1] as Range).Value2).ToLower().Trim().Equals("si");
                    mex.Destinatario = (string)(range.Cells[rCnt, 2] as Range).Value2;
                    if (string.IsNullOrEmpty(mex.Destinatario))
                        mex.errore = true;
                    mex.Copia = (string)(range.Cells[rCnt, 3] as Range).Value2;
                    mex.CopiaNascosta = (string)(range.Cells[rCnt, 4] as Range).Value2;
                    mex.Oggetto = (string)(range.Cells[rCnt, 6] as Range).Value2;
                    if (string.IsNullOrEmpty(mex.Oggetto))
                        mex.errore = true;
                    if ((range.Cells[rCnt, 5] as Range).Value2 != null)
                    {
                        List<string> listaAllegati = ((string)(range.Cells[rCnt, 5] as Range).Value2).Split(';').ToList();
                        listaAllegati.ForEach(delegate (string allegato)
                        {
                            if (!File.Exists(allegato))
                                mex.errore = true;
                        });
                        mex.Allegati = listaAllegati;
                    }
                    else {
                        mex.Allegati = null;
                    }



                    mex.Messaggio = messaggioWord;

                    for (cCnt = 7; cCnt <= colonne; cCnt++)
                    {
                        mex.Messaggio = mex.Messaggio.Replace("<<" + tags[cCnt - 7] + ">>", (string)(range.Cells[rCnt, cCnt] as Range).Value2);
                    }
                    messaggi.Add(mex);
                }
                return messaggi;
            }
            catch (Exception EX) {
                MailerLogger.SendLogToDB(1, "Errore Durante Lettura Excel: "+EX.Message);
                return null;
            }
        }


    }

}
