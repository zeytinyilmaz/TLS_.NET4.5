namespace TLS
{
    partial class TLS
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbEnable = new System.Windows.Forms.RadioButton();
            this.rdbDisabled = new System.Windows.Forms.RadioButton();
            this.btnUygula = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(11, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(189, 199);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fremawork";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Architectural";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDisabled);
            this.groupBox1.Controls.Add(this.rdbEnable);
            this.groupBox1.Location = new System.Drawing.Point(207, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rdbEnable
            // 
            this.rdbEnable.AutoSize = true;
            this.rdbEnable.Checked = true;
            this.rdbEnable.Location = new System.Drawing.Point(13, 16);
            this.rdbEnable.Name = "rdbEnable";
            this.rdbEnable.Size = new System.Drawing.Size(118, 17);
            this.rdbEnable.TabIndex = 0;
            this.rdbEnable.TabStop = true;
            this.rdbEnable.Text = "TLS / SSL Enabled";
            this.rdbEnable.UseVisualStyleBackColor = true;
            // 
            // rdbDisabled
            // 
            this.rdbDisabled.AutoSize = true;
            this.rdbDisabled.Location = new System.Drawing.Point(13, 39);
            this.rdbDisabled.Name = "rdbDisabled";
            this.rdbDisabled.Size = new System.Drawing.Size(120, 17);
            this.rdbDisabled.TabIndex = 1;
            this.rdbDisabled.TabStop = true;
            this.rdbDisabled.Text = "TLS / SSL Disabled";
            this.rdbDisabled.UseVisualStyleBackColor = true;
            // 
            // btnUygula
            // 
            this.btnUygula.Location = new System.Drawing.Point(207, 171);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(172, 39);
            this.btnUygula.TabIndex = 2;
            this.btnUygula.Text = "Uygula";
            this.btnUygula.UseVisualStyleBackColor = true;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 220);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(369, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // TLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 252);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnUygula);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(407, 291);
            this.MinimumSize = new System.Drawing.Size(407, 291);
            this.Name = "TLS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TLS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TLS_FormClosing);
            this.Load += new System.EventHandler(this.TLS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDisabled;
        private System.Windows.Forms.RadioButton rdbEnable;
        private System.Windows.Forms.Button btnUygula;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}