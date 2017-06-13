namespace WordAddIn2
{
    partial class ConfigurazioneMessaggio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); 
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbIndirizzi = new System.Windows.Forms.ComboBox();
            this.pnlControlloEmail = new System.Windows.Forms.Panel();
            this.pnlRiepilogo = new System.Windows.Forms.Panel();
            this.gvErrori = new System.Windows.Forms.DataGridView();
            this.lblErrate = new System.Windows.Forms.Label();
            this.lblInviate = new System.Windows.Forms.Label();
            this.lblTotale = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSiNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCheckMail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlCaricamento = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlControlloEmail.SuspendLayout();
            this.pnlRiepilogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvErrori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlCaricamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 309);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "Invio Mail";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbIndirizzi
            // 
            this.cbIndirizzi.FormattingEnabled = true;
            this.cbIndirizzi.Location = new System.Drawing.Point(92, 310);
            this.cbIndirizzi.Name = "cbIndirizzi";
            this.cbIndirizzi.Size = new System.Drawing.Size(121, 21);
            this.cbIndirizzi.TabIndex = 2;
            // 
            // pnlControlloEmail
            // 
            this.pnlControlloEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlControlloEmail.Controls.Add(this.pnlRiepilogo);
            this.pnlControlloEmail.Controls.Add(this.label5);
            this.pnlControlloEmail.Controls.Add(this.cbSiNo);
            this.pnlControlloEmail.Controls.Add(this.label4);
            this.pnlControlloEmail.Controls.Add(this.lblCheckMail);
            this.pnlControlloEmail.Controls.Add(this.label2);
            this.pnlControlloEmail.Controls.Add(this.label1);
            this.pnlControlloEmail.Controls.Add(this.dataGridView1);
            this.pnlControlloEmail.Controls.Add(this.cbIndirizzi);
            this.pnlControlloEmail.Controls.Add(this.button2);
            this.pnlControlloEmail.Location = new System.Drawing.Point(-1, 75);
            this.pnlControlloEmail.Name = "pnlControlloEmail";
            this.pnlControlloEmail.Size = new System.Drawing.Size(461, 351);
            this.pnlControlloEmail.TabIndex = 4;
            this.pnlControlloEmail.Visible = false;
            // 
            // pnlRiepilogo
            // 
            this.pnlRiepilogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlRiepilogo.Controls.Add(this.gvErrori);
            this.pnlRiepilogo.Controls.Add(this.lblErrate);
            this.pnlRiepilogo.Controls.Add(this.lblInviate);
            this.pnlRiepilogo.Controls.Add(this.lblTotale);
            this.pnlRiepilogo.Controls.Add(this.label6);
            this.pnlRiepilogo.Location = new System.Drawing.Point(0, 0);
            this.pnlRiepilogo.Name = "pnlRiepilogo";
            this.pnlRiepilogo.Size = new System.Drawing.Size(461, 348);
            this.pnlRiepilogo.TabIndex = 1;
            this.pnlRiepilogo.Visible = false;
            // 
            // gvErrori
            // 
            this.gvErrori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvErrori.Location = new System.Drawing.Point(15, 140);
            this.gvErrori.Name = "gvErrori";
            this.gvErrori.Size = new System.Drawing.Size(426, 164);
            this.gvErrori.TabIndex = 4;
            // 
            // lblErrate
            // 
            this.lblErrate.AutoSize = true;
            this.lblErrate.ForeColor = System.Drawing.Color.Red;
            this.lblErrate.Location = new System.Drawing.Point(14, 114);
            this.lblErrate.Name = "lblErrate";
            this.lblErrate.Size = new System.Drawing.Size(35, 13);
            this.lblErrate.TabIndex = 3;
            this.lblErrate.Text = "label7";
            // 
            // lblInviate
            // 
            this.lblInviate.AutoSize = true;
            this.lblInviate.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblInviate.Location = new System.Drawing.Point(14, 87);
            this.lblInviate.Name = "lblInviate";
            this.lblInviate.Size = new System.Drawing.Size(35, 13);
            this.lblInviate.TabIndex = 2;
            this.lblInviate.Text = "label7";
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Location = new System.Drawing.Point(14, 59);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(47, 13);
            this.lblTotale.TabIndex = 1;
            this.lblTotale.Text = "lblTotale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Riepilogo Invio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(406, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "I seguenti messaggi non verranno inviati (indirizzo di destinazione mancante o al" +
    "legato inesistente)";
            // 
            // cbSiNo
            // 
            this.cbSiNo.FormattingEnabled = true;
            this.cbSiNo.Location = new System.Drawing.Point(258, 310);
            this.cbSiNo.Name = "cbSiNo";
            this.cbSiNo.Size = new System.Drawing.Size(70, 21);
            this.cbSiNo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Test";
            // 
            // lblCheckMail
            // 
            this.lblCheckMail.AutoSize = true;
            this.lblCheckMail.Location = new System.Drawing.Point(107, 7);
            this.lblCheckMail.Name = "lblCheckMail";
            this.lblCheckMail.Size = new System.Drawing.Size(0, 13);
            this.lblCheckMail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Check Email: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Indirizzo Email";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // pnlCaricamento
            // 
            this.pnlCaricamento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCaricamento.BackgroundImage = global::WordAddIn2.Properties.Resources.Loading_icon;
            this.pnlCaricamento.Controls.Add(this.label3);
            this.pnlCaricamento.Location = new System.Drawing.Point(12, 75);
            this.pnlCaricamento.Name = "pnlCaricamento";
            this.pnlCaricamento.Size = new System.Drawing.Size(431, 294);
            this.pnlCaricamento.TabIndex = 5;
            this.pnlCaricamento.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "CARICAMENTO";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WordAddIn2.Properties.Resources.excel;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(183, 12);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(68, 57);
            this.button1.TabIndex = 0;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ConfigurazioneMessaggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 438);
            this.Controls.Add(this.pnlControlloEmail);
            this.Controls.Add(this.pnlCaricamento);
            this.Controls.Add(this.button1);
            this.Name = "ConfigurazioneMessaggio";
            this.Text = "Configurazione Messaggio";
            this.Load += new System.EventHandler(this.ConfigurazioneMessaggio_Load);
            this.pnlControlloEmail.ResumeLayout(false);
            this.pnlControlloEmail.PerformLayout();
            this.pnlRiepilogo.ResumeLayout(false);
            this.pnlRiepilogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvErrori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlCaricamento.ResumeLayout(false);
            this.pnlCaricamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbIndirizzi;
        private System.Windows.Forms.Panel pnlControlloEmail;
        private System.Windows.Forms.Label lblCheckMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlCaricamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSiNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlRiepilogo;
        private System.Windows.Forms.DataGridView gvErrori;
        private System.Windows.Forms.Label lblErrate;
        private System.Windows.Forms.Label lblInviate;
        private System.Windows.Forms.Label lblTotale;
        private System.Windows.Forms.Label label6;
    }
}