
namespace CAPEK_Przegladarka_komunikatow
{
    partial class FormGrid
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrid));
            this.grid = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnZatwierdz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pKomunikator = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pKomunikator)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(-1, 68);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1113, 435);
            this.grid.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(149, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(175, 34);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnZatwierdz
            // 
            this.btnZatwierdz.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZatwierdz.Location = new System.Drawing.Point(12, 525);
            this.btnZatwierdz.Name = "btnZatwierdz";
            this.btnZatwierdz.Size = new System.Drawing.Size(269, 95);
            this.btnZatwierdz.TabIndex = 3;
            this.btnZatwierdz.Text = "Zatwierdz";
            this.btnZatwierdz.UseVisualStyleBackColor = false;
            this.btnZatwierdz.Click += new System.EventHandler(this.btnZatwierdz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(832, 525);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(269, 95);
            this.btnAnuluj.TabIndex = 4;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(291, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(576, 404);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pKomunikator
            // 
            this.pKomunikator.Image = ((System.Drawing.Image)(resources.GetObject("pKomunikator.Image")));
            this.pKomunikator.Location = new System.Drawing.Point(105, 101);
            this.pKomunikator.Name = "pKomunikator";
            this.pKomunikator.Size = new System.Drawing.Size(150, 98);
            this.pKomunikator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pKomunikator.TabIndex = 6;
            this.pKomunikator.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1113, 632);
            this.Controls.Add(this.pKomunikator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZatwierdz);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grid);
            this.Name = "FormGrid";
            this.Text = "FormGrid";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGrid_FormClosed);
            this.Load += new System.EventHandler(this.FormGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pKomunikator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnZatwierdz;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pKomunikator;
        private System.Windows.Forms.Timer timer1;
    }
}