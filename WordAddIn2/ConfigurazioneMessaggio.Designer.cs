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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbIndirizzi = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlControlloEmail = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCheckMail = new System.Windows.Forms.Label();
            this.pnlControlloEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WordAddIn2.Properties.Resources.excel;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(68, 57);
            this.button1.TabIndex = 0;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 264);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.cbIndirizzi.Location = new System.Drawing.Point(129, 264);
            this.cbIndirizzi.Name = "cbIndirizzi";
            this.cbIndirizzi.Size = new System.Drawing.Size(121, 21);
            this.cbIndirizzi.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Prova Log";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlControlloEmail
            // 
            this.pnlControlloEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlControlloEmail.Controls.Add(this.lblCheckMail);
            this.pnlControlloEmail.Controls.Add(this.label2);
            this.pnlControlloEmail.Controls.Add(this.label1);
            this.pnlControlloEmail.Controls.Add(this.dataGridView1);
            this.pnlControlloEmail.Controls.Add(this.cbIndirizzi);
            this.pnlControlloEmail.Controls.Add(this.button2);
            this.pnlControlloEmail.Location = new System.Drawing.Point(12, 75);
            this.pnlControlloEmail.Name = "pnlControlloEmail";
            this.pnlControlloEmail.Size = new System.Drawing.Size(438, 297);
            this.pnlControlloEmail.TabIndex = 4;
            this.pnlControlloEmail.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Indirizzo Email";
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
            // lblCheckMail
            // 
            this.lblCheckMail.AutoSize = true;
            this.lblCheckMail.Location = new System.Drawing.Point(107, 7);
            this.lblCheckMail.Name = "lblCheckMail";
            this.lblCheckMail.Size = new System.Drawing.Size(0, 13);
            this.lblCheckMail.TabIndex = 5;
            // 
            // ConfigurazioneMessaggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 384);
            this.Controls.Add(this.pnlControlloEmail);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "ConfigurazioneMessaggio";
            this.Text = "Configurazione Messaggio";
            this.Load += new System.EventHandler(this.ConfigurazioneMessaggio_Load);
            this.pnlControlloEmail.ResumeLayout(false);
            this.pnlControlloEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbIndirizzi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlControlloEmail;
        private System.Windows.Forms.Label lblCheckMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}