namespace Datenerfassung
{
    partial class PopupProjektBearbeiten
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnToDo = new System.Windows.Forms.Button();
            this.btnProgress = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnBearbeitenProjekt = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1078, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnToDo
            // 
            this.btnToDo.Location = new System.Drawing.Point(12, 476);
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.Size = new System.Drawing.Size(150, 50);
            this.btnToDo.TabIndex = 1;
            this.btnToDo.Text = "ToDo";
            this.btnToDo.UseVisualStyleBackColor = true;
            this.btnToDo.Click += new System.EventHandler(this.btnToDo_Click);
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(207, 476);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(150, 50);
            this.btnProgress.TabIndex = 2;
            this.btnProgress.Text = "InProgress";
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(398, 476);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(150, 50);
            this.btnReview.TabIndex = 3;
            this.btnReview.Text = "InReview";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(579, 476);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(150, 50);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnBearbeitenProjekt
            // 
            this.btnBearbeitenProjekt.Location = new System.Drawing.Point(761, 476);
            this.btnBearbeitenProjekt.Name = "btnBearbeitenProjekt";
            this.btnBearbeitenProjekt.Size = new System.Drawing.Size(150, 50);
            this.btnBearbeitenProjekt.TabIndex = 5;
            this.btnBearbeitenProjekt.Text = "Bearbeiten";
            this.btnBearbeitenProjekt.UseVisualStyleBackColor = true;
            this.btnBearbeitenProjekt.Click += new System.EventHandler(this.btnBearbeitenProjekt_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(931, 476);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 50);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PopupProjektBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 563);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBearbeitenProjekt);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.btnToDo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PopupProjektBearbeiten";
            this.Text = "PopupProjektBearbeiten";
            this.Load += new System.EventHandler(this.PopupProjektBearbeiten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnToDo;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnBearbeitenProjekt;
        private System.Windows.Forms.Button btnClose;
    }
}