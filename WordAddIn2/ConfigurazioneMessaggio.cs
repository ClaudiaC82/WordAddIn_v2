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
        public ConfigurazioneMessaggio()
        {
            InitializeComponent();
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
            lblCheckMail.Text = "Caricate " + listaMessaggi.Count + " righe";
            pnlControlloEmail.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaMessaggi.ForEach(delegate (messaggio m) {
                Invio.invioEmail(cbIndirizzi.Text, m);
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MailerLogger.SendLogToDB(1, "prova scrittura messaggio");
        }
    }
}
