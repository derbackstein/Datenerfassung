namespace Datenerfassung
{
    partial class PopupRechnungen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxBeschreibung = new System.Windows.Forms.TextBox();
            this.txtBoxBetrag = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.dtPRechnung = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Betrag:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Beschreibung:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(81, 12);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(160, 29);
            this.txtBoxName.TabIndex = 4;
            // 
            // txtBoxBeschreibung
            // 
            this.txtBoxBeschreibung.Location = new System.Drawing.Point(16, 182);
            this.txtBoxBeschreibung.Multiline = true;
            this.txtBoxBeschreibung.Name = "txtBoxBeschreibung";
            this.txtBoxBeschreibung.Size = new System.Drawing.Size(273, 131);
            this.txtBoxBeschreibung.TabIndex = 5;
            // 
            // txtBoxBetrag
            // 
            this.txtBoxBetrag.Location = new System.Drawing.Point(81, 108);
            this.txtBoxBetrag.Name = "txtBoxBetrag";
            this.txtBoxBetrag.Size = new System.Drawing.Size(160, 29);
            this.txtBoxBetrag.TabIndex = 6;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(48, 330);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(208, 39);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "Upload Rechnung";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // dtPRechnung
            // 
            this.dtPRechnung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPRechnung.Location = new System.Drawing.Point(81, 60);
            this.dtPRechnung.Name = "dtPRechnung";
            this.dtPRechnung.Size = new System.Drawing.Size(160, 29);
            this.dtPRechnung.TabIndex = 10;
            this.dtPRechnung.Value = new System.DateTime(2022, 11, 3, 0, 0, 0, 0);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(77, 393);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(132, 24);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "NUR ALS PDF";
            // 
            // PopupRechnungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 510);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dtPRechnung);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtBoxBetrag);
            this.Controls.Add(this.txtBoxBeschreibung);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PopupRechnungen";
            this.Text = "Rechnungen";
            this.Load += new System.EventHandler(this.Rechnungen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxBeschreibung;
        private System.Windows.Forms.TextBox txtBoxBetrag;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.DateTimePicker dtPRechnung;
        private System.Windows.Forms.Label lblStatus;
    }
}