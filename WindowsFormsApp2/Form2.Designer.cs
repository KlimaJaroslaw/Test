
namespace WindowsFormsApp2
{
    partial class Form2
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cbPon = new System.Windows.Forms.CheckBox();
            this.cbWt = new System.Windows.Forms.CheckBox();
            this.cbSr = new System.Windows.Forms.CheckBox();
            this.cbCzw = new System.Windows.Forms.CheckBox();
            this.cbPt = new System.Windows.Forms.CheckBox();
            this.cbSob = new System.Windows.Forms.CheckBox();
            this.cbNdz = new System.Windows.Forms.CheckBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.lblPon = new System.Windows.Forms.Label();
            this.lblPt = new System.Windows.Forms.Label();
            this.lblCzw = new System.Windows.Forms.Label();
            this.lblSr = new System.Windows.Forms.Label();
            this.lblWt = new System.Windows.Forms.Label();
            this.lblNdz = new System.Windows.Forms.Label();
            this.lblSob = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "pozycja 1",
            "pozycja 2",
            "pozycja 3"});
            this.checkedListBox1.Location = new System.Drawing.Point(239, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox1.TabIndex = 1;
            // 
            // cbPon
            // 
            this.cbPon.AutoSize = true;
            this.cbPon.Location = new System.Drawing.Point(12, 67);
            this.cbPon.Name = "cbPon";
            this.cbPon.Size = new System.Drawing.Size(15, 14);
            this.cbPon.TabIndex = 2;
            this.cbPon.UseVisualStyleBackColor = true;
            // 
            // cbWt
            // 
            this.cbWt.AutoSize = true;
            this.cbWt.Location = new System.Drawing.Point(45, 67);
            this.cbWt.Name = "cbWt";
            this.cbWt.Size = new System.Drawing.Size(15, 14);
            this.cbWt.TabIndex = 3;
            this.cbWt.UseVisualStyleBackColor = true;
            // 
            // cbSr
            // 
            this.cbSr.AutoSize = true;
            this.cbSr.Location = new System.Drawing.Point(78, 67);
            this.cbSr.Name = "cbSr";
            this.cbSr.Size = new System.Drawing.Size(15, 14);
            this.cbSr.TabIndex = 4;
            this.cbSr.UseVisualStyleBackColor = true;
            // 
            // cbCzw
            // 
            this.cbCzw.AutoSize = true;
            this.cbCzw.Location = new System.Drawing.Point(111, 67);
            this.cbCzw.Name = "cbCzw";
            this.cbCzw.Size = new System.Drawing.Size(15, 14);
            this.cbCzw.TabIndex = 5;
            this.cbCzw.UseVisualStyleBackColor = true;
            this.cbCzw.CheckedChanged += new System.EventHandler(this.cbCzw_CheckedChanged);
            // 
            // cbPt
            // 
            this.cbPt.AutoSize = true;
            this.cbPt.Location = new System.Drawing.Point(144, 67);
            this.cbPt.Name = "cbPt";
            this.cbPt.Size = new System.Drawing.Size(15, 14);
            this.cbPt.TabIndex = 6;
            this.cbPt.UseVisualStyleBackColor = true;
            // 
            // cbSob
            // 
            this.cbSob.AutoSize = true;
            this.cbSob.Location = new System.Drawing.Point(177, 67);
            this.cbSob.Name = "cbSob";
            this.cbSob.Size = new System.Drawing.Size(15, 14);
            this.cbSob.TabIndex = 7;
            this.cbSob.UseVisualStyleBackColor = true;
            // 
            // cbNdz
            // 
            this.cbNdz.AutoSize = true;
            this.cbNdz.Location = new System.Drawing.Point(210, 67);
            this.cbNdz.Name = "cbNdz";
            this.cbNdz.Size = new System.Drawing.Size(15, 14);
            this.cbNdz.TabIndex = 8;
            this.cbNdz.UseVisualStyleBackColor = true;
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(12, 12);
            this.dtp1.MaxDate = new System.DateTime(9960, 12, 31, 14, 0, 0, 0);
            this.dtp1.MinDate = new System.DateTime(9960, 12, 31, 6, 0, 0, 0);
            this.dtp1.Name = "dtp1";
            this.dtp1.ShowUpDown = true;
            this.dtp1.Size = new System.Drawing.Size(100, 20);
            this.dtp1.TabIndex = 10;
            this.dtp1.Value = new System.DateTime(9960, 12, 31, 6, 0, 0, 0);
            // 
            // dtp2
            // 
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(125, 12);
            this.dtp2.MaxDate = new System.DateTime(9960, 12, 31, 14, 0, 0, 0);
            this.dtp2.MinDate = new System.DateTime(9960, 12, 31, 6, 0, 0, 0);
            this.dtp2.Name = "dtp2";
            this.dtp2.ShowUpDown = true;
            this.dtp2.Size = new System.Drawing.Size(100, 20);
            this.dtp2.TabIndex = 11;
            this.dtp2.Value = new System.DateTime(9960, 12, 31, 6, 0, 0, 0);
            // 
            // lblPon
            // 
            this.lblPon.AutoSize = true;
            this.lblPon.Location = new System.Drawing.Point(9, 51);
            this.lblPon.Name = "lblPon";
            this.lblPon.Size = new System.Drawing.Size(26, 13);
            this.lblPon.TabIndex = 12;
            this.lblPon.Text = "Pon";
            // 
            // lblPt
            // 
            this.lblPt.AutoSize = true;
            this.lblPt.Location = new System.Drawing.Point(141, 51);
            this.lblPt.Name = "lblPt";
            this.lblPt.Size = new System.Drawing.Size(17, 13);
            this.lblPt.TabIndex = 13;
            this.lblPt.Text = "Pt";
            // 
            // lblCzw
            // 
            this.lblCzw.AutoSize = true;
            this.lblCzw.Location = new System.Drawing.Point(108, 51);
            this.lblCzw.Name = "lblCzw";
            this.lblCzw.Size = new System.Drawing.Size(27, 13);
            this.lblCzw.TabIndex = 14;
            this.lblCzw.Text = "Czw";
            // 
            // lblSr
            // 
            this.lblSr.AutoSize = true;
            this.lblSr.Location = new System.Drawing.Point(75, 51);
            this.lblSr.Name = "lblSr";
            this.lblSr.Size = new System.Drawing.Size(17, 13);
            this.lblSr.TabIndex = 15;
            this.lblSr.Text = "Śr";
            // 
            // lblWt
            // 
            this.lblWt.AutoSize = true;
            this.lblWt.Location = new System.Drawing.Point(42, 51);
            this.lblWt.Name = "lblWt";
            this.lblWt.Size = new System.Drawing.Size(21, 13);
            this.lblWt.TabIndex = 16;
            this.lblWt.Text = "Wt";
            // 
            // lblNdz
            // 
            this.lblNdz.AutoSize = true;
            this.lblNdz.Location = new System.Drawing.Point(207, 51);
            this.lblNdz.Name = "lblNdz";
            this.lblNdz.Size = new System.Drawing.Size(26, 13);
            this.lblNdz.TabIndex = 17;
            this.lblNdz.Text = "Ndz";
            // 
            // lblSob
            // 
            this.lblSob.AutoSize = true;
            this.lblSob.Location = new System.Drawing.Point(174, 51);
            this.lblSob.Name = "lblSob";
            this.lblSob.Size = new System.Drawing.Size(26, 13);
            this.lblSob.TabIndex = 18;
            this.lblSob.Text = "Sob";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 243);
            this.Controls.Add(this.lblSob);
            this.Controls.Add(this.lblNdz);
            this.Controls.Add(this.lblWt);
            this.Controls.Add(this.lblSr);
            this.Controls.Add(this.lblCzw);
            this.Controls.Add(this.lblPt);
            this.Controls.Add(this.lblPon);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.cbNdz);
            this.Controls.Add(this.cbSob);
            this.Controls.Add(this.cbPt);
            this.Controls.Add(this.cbCzw);
            this.Controls.Add(this.cbSr);
            this.Controls.Add(this.cbWt);
            this.Controls.Add(this.cbPon);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox cbPon;
        private System.Windows.Forms.CheckBox cbWt;
        private System.Windows.Forms.CheckBox cbSr;
        private System.Windows.Forms.CheckBox cbCzw;
        private System.Windows.Forms.CheckBox cbPt;
        private System.Windows.Forms.CheckBox cbSob;
        private System.Windows.Forms.CheckBox cbNdz;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label lblPon;
        private System.Windows.Forms.Label lblPt;
        private System.Windows.Forms.Label lblCzw;
        private System.Windows.Forms.Label lblSr;
        private System.Windows.Forms.Label lblWt;
        private System.Windows.Forms.Label lblNdz;
        private System.Windows.Forms.Label lblSob;
    }
}