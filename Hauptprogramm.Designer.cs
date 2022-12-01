namespace Datenerfassung
{
    partial class Hauptprogramm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hauptprogramm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.dataGridZeit = new System.Windows.Forms.DataGridView();
            this.dTPBis = new System.Windows.Forms.DateTimePicker();
            this.dTPVon = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rBtnZeitraum = new System.Windows.Forms.RadioButton();
            this.rBtnLWoche = new System.Windows.Forms.RadioButton();
            this.rBtnDWoche = new System.Windows.Forms.RadioButton();
            this.rBtnHeute = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnZeit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.dataGridRechnung = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnDeleteProjekt = new System.Windows.Forms.Button();
            this.BtnUpdateProjekt = new System.Windows.Forms.Button();
            this.BtnAddProjekt = new System.Windows.Forms.Button();
            this.dataGridProjekt = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridZeit)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRechnung)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjekt)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1102, 594);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnPause);
            this.tabPage1.Controls.Add(this.btnZeit);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1094, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zeiterfassung";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 517);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "label5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnBearbeiten);
            this.groupBox1.Controls.Add(this.dataGridZeit);
            this.groupBox1.Controls.Add(this.dTPBis);
            this.groupBox1.Controls.Add(this.dTPVon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rBtnZeitraum);
            this.groupBox1.Controls.Add(this.rBtnLWoche);
            this.groupBox1.Controls.Add(this.rBtnDWoche);
            this.groupBox1.Controls.Add(this.rBtnHeute);
            this.groupBox1.Location = new System.Drawing.Point(170, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 521);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zeiten";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(10, 320);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 39);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Location = new System.Drawing.Point(10, 275);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(101, 39);
            this.btnBearbeiten.TabIndex = 9;
            this.btnBearbeiten.Text = "Bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            this.btnBearbeiten.Click += new System.EventHandler(this.btnBearbeiten_Click);
            // 
            // dataGridZeit
            // 
            this.dataGridZeit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridZeit.Location = new System.Drawing.Point(206, 25);
            this.dataGridZeit.Name = "dataGridZeit";
            this.dataGridZeit.Size = new System.Drawing.Size(632, 476);
            this.dataGridZeit.TabIndex = 8;
            this.dataGridZeit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridZeit_CellClick);
            // 
            // dTPBis
            // 
            this.dTPBis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPBis.Location = new System.Drawing.Point(6, 234);
            this.dTPBis.Name = "dTPBis";
            this.dTPBis.Size = new System.Drawing.Size(122, 26);
            this.dTPBis.TabIndex = 7;
            // 
            // dTPVon
            // 
            this.dTPVon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPVon.Location = new System.Drawing.Point(6, 182);
            this.dTPVon.Name = "dTPVon";
            this.dTPVon.Size = new System.Drawing.Size(122, 26);
            this.dTPVon.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "bis:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "von:";
            // 
            // rBtnZeitraum
            // 
            this.rBtnZeitraum.AutoSize = true;
            this.rBtnZeitraum.Location = new System.Drawing.Point(6, 132);
            this.rBtnZeitraum.Name = "rBtnZeitraum";
            this.rBtnZeitraum.Size = new System.Drawing.Size(90, 24);
            this.rBtnZeitraum.TabIndex = 3;
            this.rBtnZeitraum.TabStop = true;
            this.rBtnZeitraum.Text = "Zeitraum";
            this.rBtnZeitraum.UseVisualStyleBackColor = true;
            // 
            // rBtnLWoche
            // 
            this.rBtnLWoche.AutoSize = true;
            this.rBtnLWoche.Location = new System.Drawing.Point(6, 102);
            this.rBtnLWoche.Name = "rBtnLWoche";
            this.rBtnLWoche.Size = new System.Drawing.Size(126, 24);
            this.rBtnLWoche.TabIndex = 2;
            this.rBtnLWoche.TabStop = true;
            this.rBtnLWoche.Text = "Letzte Woche";
            this.rBtnLWoche.UseVisualStyleBackColor = true;
            // 
            // rBtnDWoche
            // 
            this.rBtnDWoche.AutoSize = true;
            this.rBtnDWoche.Location = new System.Drawing.Point(6, 72);
            this.rBtnDWoche.Name = "rBtnDWoche";
            this.rBtnDWoche.Size = new System.Drawing.Size(122, 24);
            this.rBtnDWoche.TabIndex = 1;
            this.rBtnDWoche.TabStop = true;
            this.rBtnDWoche.Text = "Diese Woche";
            this.rBtnDWoche.UseVisualStyleBackColor = true;
            // 
            // rBtnHeute
            // 
            this.rBtnHeute.AutoSize = true;
            this.rBtnHeute.Location = new System.Drawing.Point(6, 38);
            this.rBtnHeute.Name = "rBtnHeute";
            this.rBtnHeute.Size = new System.Drawing.Size(71, 24);
            this.rBtnHeute.TabIndex = 0;
            this.rBtnHeute.TabStop = true;
            this.rBtnHeute.Text = "Heute";
            this.rBtnHeute.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pause";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arbeitszeit";
            // 
            // btnPause
            // 
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(6, 67);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(45, 45);
            this.btnPause.TabIndex = 1;
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnZeit
            // 
            this.btnZeit.Image = ((System.Drawing.Image)(resources.GetObject("btnZeit.Image")));
            this.btnZeit.Location = new System.Drawing.Point(6, 16);
            this.btnZeit.Name = "btnZeit";
            this.btnZeit.Size = new System.Drawing.Size(45, 45);
            this.btnZeit.TabIndex = 0;
            this.btnZeit.UseVisualStyleBackColor = true;
            this.btnZeit.Click += new System.EventHandler(this.btnZeit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Controls.Add(this.dataGridRechnung);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1094, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rechungserfassung";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(930, 423);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(158, 119);
            this.webBrowser1.TabIndex = 12;
            // 
            // dataGridRechnung
            // 
            this.dataGridRechnung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRechnung.Location = new System.Drawing.Point(6, 6);
            this.dataGridRechnung.Name = "dataGridRechnung";
            this.dataGridRechnung.Size = new System.Drawing.Size(1082, 393);
            this.dataGridRechnung.TabIndex = 11;
            this.dataGridRechnung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRechnung_CellClick);
            this.dataGridRechnung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRechnung_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "Neu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BtnDeleteProjekt);
            this.tabPage3.Controls.Add(this.BtnUpdateProjekt);
            this.tabPage3.Controls.Add(this.BtnAddProjekt);
            this.tabPage3.Controls.Add(this.dataGridProjekt);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1094, 561);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Projekte";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteProjekt
            // 
            this.BtnDeleteProjekt.Location = new System.Drawing.Point(295, 491);
            this.BtnDeleteProjekt.Name = "BtnDeleteProjekt";
            this.BtnDeleteProjekt.Size = new System.Drawing.Size(135, 57);
            this.BtnDeleteProjekt.TabIndex = 3;
            this.BtnDeleteProjekt.Text = "Löschen";
            this.BtnDeleteProjekt.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateProjekt
            // 
            this.BtnUpdateProjekt.Location = new System.Drawing.Point(154, 491);
            this.BtnUpdateProjekt.Name = "BtnUpdateProjekt";
            this.BtnUpdateProjekt.Size = new System.Drawing.Size(135, 57);
            this.BtnUpdateProjekt.TabIndex = 2;
            this.BtnUpdateProjekt.Text = "Bearbeiten";
            this.BtnUpdateProjekt.UseVisualStyleBackColor = true;
            // 
            // BtnAddProjekt
            // 
            this.BtnAddProjekt.Location = new System.Drawing.Point(3, 491);
            this.BtnAddProjekt.Name = "BtnAddProjekt";
            this.BtnAddProjekt.Size = new System.Drawing.Size(135, 57);
            this.BtnAddProjekt.TabIndex = 1;
            this.BtnAddProjekt.Text = "Hinzufügen";
            this.BtnAddProjekt.UseVisualStyleBackColor = true;
            this.BtnAddProjekt.Click += new System.EventHandler(this.BtnAddProjekt_Click);
            // 
            // dataGridProjekt
            // 
            this.dataGridProjekt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProjekt.Location = new System.Drawing.Point(3, 3);
            this.dataGridProjekt.Name = "dataGridProjekt";
            this.dataGridProjekt.Size = new System.Drawing.Size(1088, 464);
            this.dataGridProjekt.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.listBox1);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1094, 561);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Selbsteinschätzung";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Bestätigen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.listBox1.Location = new System.Drawing.Point(10, 343);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 34);
            this.listBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(9, 433);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(476, 112);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(8, 195);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(477, 112);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(477, 112);
            this.textBox1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(346, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "Was hat dich diese Woche gestört?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Wöchentliche Zufriedenheit?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Erreichte wöchentliche Ziele:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Neue wöchentliche Ziele:";
            // 
            // Hauptprogramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 618);
            this.Controls.Add(this.tabControl1);
            this.Name = "Hauptprogramm";
            this.Text = "Hauptprogramm";
            this.Load += new System.EventHandler(this.Hauptprogramm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridZeit)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRechnung)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjekt)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnZeit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTPBis;
        private System.Windows.Forms.DateTimePicker dTPVon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rBtnZeitraum;
        private System.Windows.Forms.RadioButton rBtnLWoche;
        private System.Windows.Forms.RadioButton rBtnDWoche;
        private System.Windows.Forms.RadioButton rBtnHeute;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.DataGridView dataGridZeit;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridProjekt;
        private System.Windows.Forms.Button BtnDeleteProjekt;
        private System.Windows.Forms.Button BtnUpdateProjekt;
        private System.Windows.Forms.Button BtnAddProjekt;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridRechnung;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}