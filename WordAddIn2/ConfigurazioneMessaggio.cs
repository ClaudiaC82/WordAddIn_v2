using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MailerUtilities;
using System.IO;
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Outlook;

namespace WordAddIn2
{
    public partial class ConfigurazioneMessaggio : Form
    {
        List<messaggio> listaMessaggi;
        string messaggio = "";
        string[] sino = { "SI", "NO" };
        public ConfigurazioneMessaggio()
        {
            InitializeComponent();
            foreach (string s in sino) {
                cbSiNo.Items.Add(s);
            }
            cbSiNo.SelectedIndex = 0;
        }

        private void ConfigurazioneMessaggio_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Document documento = Globals.ThisAddIn.Application.ActiveDocument;
            messaggio = documento.Content.Text;
            /*XLSX excel = new XLSX();
            string base_directory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = ConfigReader.PersistableObject.Load<ConfigReader.Configuration>(String.Format("{0}\\config.xml", base_directory)).excel_path;
            excel.elaboraExcel(filePath,messaggio);*/
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XLSX xlsx = new XLSX();
                pnlControlloEmail.Hide();
                pnlRiepilogo.Hide();
                pnlCaricamento.TabIndex = 1;
                pnlCaricamento.Show();
                listaMessaggi = xlsx.elaboraExcel(Path.GetFullPath(openFileDialog.FileName),messaggio);
            }
            Microsoft.Office.Interop.Outlook.Application olkApp1 = new Outlook.Application();
            Outlook.MailItem olkMail1 = (MailItem)olkApp1.CreateItem(OlItemType.olMailItem);
            Accounts accounts = olkApp1.Application.Session.Accounts;
            cbIndirizzi.Items.Clear();
            foreach (Outlook.Account account in accounts)
            {
                cbIndirizzi.Items.Add(account.SmtpAddress.ToString());
            }
            cbIndirizzi.SelectedIndex = 0;
            List<messaggiErrati> listaMessaggiErrati = (from item in listaMessaggi where item.errore
                                                        select (new messaggiErrati() {
                                                            MessaggioTest = item.MessaggioTest ? "SI" : "NO",
                                                            Destinatario = item.Destinatario,
                                                            Allegati = String.Concat(item.Allegati)
                                                        })
                                                        ).ToList();

            dataGridView1.DataSource = listaMessaggiErrati;
            lblCheckMail.Text = "Caricate " + listaMessaggi.Count + " righe";
            pnlCaricamento.Hide();
            pnlRiepilogo.Hide();
            pnlControlloEmail.TabIndex = 1;
            pnlControlloEmail.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<messaggio> daInviare = (from item in listaMessaggi
                                         where
             (item.MessaggioTest && cbSiNo.Text == "SI")
             ||
             (!item.MessaggioTest && cbSiNo.Text == "NO")
                                         select item).ToList();
            int inviati = 0;
            int nonInviati = 0;
            List<messaggiErrati> mexNonInviati = new List<messaggiErrati>();
             daInviare.ForEach(delegate (messaggio m)
             {
                 if (Invio.invioEmail(cbIndirizzi.Text, m))
                 {
                     inviati = inviati + 1;
                 }
                 else {
                     nonInviati = nonInviati + 1;
                     messaggiErrati me = new messaggiErrati();
                     me.MessaggioTest = m.MessaggioTest ? "SI" : "NO";
                     me.Destinatario = m.Destinatario;
                     me.Allegati = String.Concat(m.Allegati);
                     mexNonInviati.Add(me);
                 }
             });
             caricaPannelloRiepilogativo(inviati, nonInviati, mexNonInviati);
        }

        private void caricaPannelloRiepilogativo(int inviati, int nonInviati, List<messaggiErrati> mexNonInviati) {
            lblTotale.Text = "Totale messaggi: " + (inviati + nonInviati).ToString();
            lblErrate.Text = "Messaggi non inviati: " + nonInviati.ToString();
            lblInviate.Text = "Messaggi inviati: " + inviati.ToString();
            if (nonInviati > 0)
            {
                gvErrori.DataSource = mexNonInviati;
                gvErrori.Show();
            }
            else {
                gvErrori.Hide();
            }
            pnlCaricamento.Hide();
            pnlControlloEmail.Hide();
            pnlCaricamento.TabIndex = 1;
            pnlRiepilogo.Show();
        }
    
    }
}
