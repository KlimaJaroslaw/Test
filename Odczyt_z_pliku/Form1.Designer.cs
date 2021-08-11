
namespace Odczyt_z_pliku
{
    partial class Form1
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
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.rtbPlik = new System.Windows.Forms.RichTextBox();
            this.btnPrzycisk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // rtbPlik
            // 
            this.rtbPlik.Location = new System.Drawing.Point(49, 144);
            this.rtbPlik.Name = "rtbPlik";
            this.rtbPlik.Size = new System.Drawing.Size(423, 264);
            this.rtbPlik.TabIndex = 0;
            this.rtbPlik.Text = "";
            // 
            // btnPrzycisk
            // 
            this.btnPrzycisk.Location = new System.Drawing.Point(49, 32);
            this.btnPrzycisk.Name = "btnPrzycisk";
            this.btnPrzycisk.Size = new System.Drawing.Size(423, 96);
            this.btnPrzycisk.TabIndex = 1;
            this.btnPrzycisk.Text = "button1";
            this.btnPrzycisk.UseVisualStyleBackColor = true;
            this.btnPrzycisk.Click += new System.EventHandler(this.btnPrzycisk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrzycisk);
            this.Controls.Add(this.rtbPlik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.RichTextBox rtbPlik;
        private System.Windows.Forms.Button btnPrzycisk;
    }
}

