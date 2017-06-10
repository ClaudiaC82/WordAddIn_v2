using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Outlook;

namespace MailerUtilities
{
    public class Invio
    {
        public static bool invioEmail(string indirizzo, messaggio messaggio)
        {
            try
            {
                Outlook.Application olkApp1 = new Outlook.Application();
                Outlook.MailItem olkMail1 = (MailItem)olkApp1.CreateItem(OlItemType.olMailItem);
                Accounts accounts = olkApp1.Application.Session.Accounts;
                foreach (Account a in accounts)
                {
                    if (a.SmtpAddress == indirizzo)
                    {
                        olkMail1.SendUsingAccount = a;
                    }
                }

                olkMail1.To = messaggio.Destinatario;
                olkMail1.CC = messaggio.Copia;
                olkMail1.BCC = messaggio.CopiaNascosta;
                olkMail1.Subject = messaggio.Oggetto;
                olkMail1.Body = messaggio.Messaggio;
                if (messaggio.Allegati.Count > 0)
                {
                    messaggio.Allegati.ForEach(delegate (string allegato)
                    {
                        olkMail1.Attachments.Add(allegato);
                    });
                }
                olkMail1.Send();
                return true;
            }
            catch (System.Exception ex) {
                MailerLogger.SendLogToDB(1, "Errore Durante Invio Messaggi: " + ex.Message);
                return false;
            }
        }
    }
}
