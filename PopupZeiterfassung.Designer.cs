namespace Datenerfassung
{
    partial class PopupZeiterfassung
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
            this.txtBoxProjekt = new System.Windows.Forms.TextBox();
            this.txtBoxBeschreibung = new System.Windows.Forms.TextBox();
            this.dTPVon = new System.Windows.Forms.DateTimePicker();
            this.dTPbis = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projekt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "von:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "bis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Beschreibung:";
            // 
            // txtBoxProjekt
            // 
            this.txtBoxProjekt.Location = new System.Drawing.Point(101, 16);
            this.txtBoxProjekt.Name = "txtBoxProjekt";
            this.txtBoxProjekt.Size = new System.Drawing.Size(295, 29);
            this.txtBoxProjekt.TabIndex = 4;
            // 
            // txtBoxBeschreibung
            // 
            this.txtBoxBeschreibung.Location = new System.Drawing.Point(27, 150);
            this.txtBoxBeschreibung.Multiline = true;
            this.txtBoxBeschreibung.Name = "txtBoxBeschreibung";
            this.txtBoxBeschreibung.Size = new System.Drawing.Size(369, 168);
            this.txtBoxBeschreibung.TabIndex = 6;
            // 
            // dTPVon
            // 
            this.dTPVon.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPVon.Location = new System.Drawing.Point(101, 49);
            this.dTPVon.Name = "dTPVon";
            this.dTPVon.Size = new System.Drawing.Size(96, 29);
            this.dTPVon.TabIndex = 7;
            // 
            // dTPbis
            // 
            this.dTPbis.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPbis.Location = new System.Drawing.Point(101, 91);
            this.dTPbis.Name = "dTPbis";
            this.dTPbis.Size = new System.Drawing.Size(96, 29);
            this.dTPbis.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(27, 341);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 33);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(270, 341);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(126, 33);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(253, 74);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 24);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "ID";
            // 
            // PopupZeiterfassung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 428);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dTPbis);
            this.Controls.Add(this.dTPVon);
            this.Controls.Add(this.txtBoxBeschreibung);
            this.Controls.Add(this.txtBoxProjekt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PopupZeiterfassung";
            this.Text = "Zeiterfassung";
            this.Load += new System.EventHandler(this.PopupZeiterfassung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtBoxProjekt;
        public System.Windows.Forms.TextBox txtBoxBeschreibung;
        public System.Windows.Forms.DateTimePicker dTPVon;
        public System.Windows.Forms.DateTimePicker dTPbis;
        public System.Windows.Forms.Label lblId;
    }
}