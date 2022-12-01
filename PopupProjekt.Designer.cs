namespace Datenerfassung
{
    partial class PopupProjekt
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
            this.txtBoxZugewiesen = new System.Windows.Forms.TextBox();
            this.txtBoxErsteller = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dTPProjektende = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxBeschreibung = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zugewiesen an:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ersteller:";
            // 
            // txtBoxZugewiesen
            // 
            this.txtBoxZugewiesen.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxZugewiesen.Location = new System.Drawing.Point(20, 42);
            this.txtBoxZugewiesen.Name = "txtBoxZugewiesen";
            this.txtBoxZugewiesen.Size = new System.Drawing.Size(379, 35);
            this.txtBoxZugewiesen.TabIndex = 2;
            // 
            // txtBoxErsteller
            // 
            this.txtBoxErsteller.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxErsteller.Location = new System.Drawing.Point(20, 113);
            this.txtBoxErsteller.Name = "txtBoxErsteller";
            this.txtBoxErsteller.Size = new System.Drawing.Size(379, 35);
            this.txtBoxErsteller.TabIndex = 3;
            this.txtBoxErsteller.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fertig bis:";
            // 
            // dTPProjektende
            // 
            this.dTPProjektende.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPProjektende.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPProjektende.Location = new System.Drawing.Point(20, 184);
            this.dTPProjektende.Name = "dTPProjektende";
            this.dTPProjektende.Size = new System.Drawing.Size(147, 35);
            this.dTPProjektende.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Beschreibung:";
            // 
            // txtBoxBeschreibung
            // 
            this.txtBoxBeschreibung.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBeschreibung.Location = new System.Drawing.Point(20, 255);
            this.txtBoxBeschreibung.Multiline = true;
            this.txtBoxBeschreibung.Name = "txtBoxBeschreibung";
            this.txtBoxBeschreibung.Size = new System.Drawing.Size(379, 222);
            this.txtBoxBeschreibung.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(17, 498);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(121, 51);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(156, 498);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(132, 51);
            this.btnAbbrechen.TabIndex = 9;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            // 
            // PopupProjekt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(424, 559);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtBoxBeschreibung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dTPProjektende);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxErsteller);
            this.Controls.Add(this.txtBoxZugewiesen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PopupProjekt";
            this.Text = "PopupProjekt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxZugewiesen;
        private System.Windows.Forms.TextBox txtBoxErsteller;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTPProjektende;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxBeschreibung;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAbbrechen;
    }
}