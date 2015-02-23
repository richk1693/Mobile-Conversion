namespace AP_Calculator
{
    partial class Clearance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clearance));
            this.homeButton = new System.Windows.Forms.Button();
            this.calcButton = new System.Windows.Forms.Button();
            this.punLab = new System.Windows.Forms.Label();
            this.thickLab = new System.Windows.Forms.Label();
            this.dieLab = new System.Windows.Forms.Label();
            this.dieNumLab = new System.Windows.Forms.Label();
            this.punBox = new System.Windows.Forms.ComboBox();
            this.thickBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Black;
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.Silver;
            this.homeButton.Location = new System.Drawing.Point(34, 302);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(113, 59);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.Color.Black;
            this.calcButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.calcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.ForeColor = System.Drawing.Color.Silver;
            this.calcButton.Location = new System.Drawing.Point(202, 302);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(113, 59);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // punLab
            // 
            this.punLab.AutoSize = true;
            this.punLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punLab.ForeColor = System.Drawing.Color.White;
            this.punLab.Location = new System.Drawing.Point(10, 110);
            this.punLab.Name = "punLab";
            this.punLab.Size = new System.Drawing.Size(99, 20);
            this.punLab.TabIndex = 2;
            this.punLab.Text = "Punch Size";
            this.punLab.Click += new System.EventHandler(this.punLab_Click);
            // 
            // thickLab
            // 
            this.thickLab.AutoSize = true;
            this.thickLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thickLab.ForeColor = System.Drawing.Color.White;
            this.thickLab.Location = new System.Drawing.Point(10, 156);
            this.thickLab.Name = "thickLab";
            this.thickLab.Size = new System.Drawing.Size(89, 20);
            this.thickLab.TabIndex = 3;
            this.thickLab.Text = "Thickness";
            this.thickLab.Click += new System.EventHandler(this.thickLab_Click);
            // 
            // dieLab
            // 
            this.dieLab.AutoSize = true;
            this.dieLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieLab.ForeColor = System.Drawing.Color.White;
            this.dieLab.Location = new System.Drawing.Point(19, 215);
            this.dieLab.Name = "dieLab";
            this.dieLab.Size = new System.Drawing.Size(76, 20);
            this.dieLab.TabIndex = 4;
            this.dieLab.Text = "Die Size";
            this.dieLab.Click += new System.EventHandler(this.dieLab_Click);
            // 
            // dieNumLab
            // 
            this.dieNumLab.AutoSize = true;
            this.dieNumLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieNumLab.ForeColor = System.Drawing.Color.White;
            this.dieNumLab.Location = new System.Drawing.Point(119, 215);
            this.dieNumLab.Name = "dieNumLab";
            this.dieNumLab.Size = new System.Drawing.Size(19, 20);
            this.dieNumLab.TabIndex = 5;
            this.dieNumLab.Text = "0";
            this.dieNumLab.Click += new System.EventHandler(this.dieNumLab_Click);
            // 
            // punBox
            // 
            this.punBox.BackColor = System.Drawing.Color.White;
            this.punBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.punBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punBox.ForeColor = System.Drawing.Color.Black;
            this.punBox.FormattingEnabled = true;
            this.punBox.Items.AddRange(new object[] {
            "1/8",
            "5/32",
            "3/16",
            "7/32",
            "1/4",
            "9/32",
            "5/16",
            "11/32",
            "3/8",
            "13/32",
            "7/16",
            "15/32",
            "1/2",
            "17/32",
            "9/16",
            "19/32",
            "5/8",
            "21/32",
            "11/16",
            "23/32",
            "3/4",
            "25/32",
            "13/16",
            "27/32",
            "7/8",
            "29/32",
            "15/16",
            "31/32",
            "1",
            "1-1/32",
            "1-1/16",
            "1-3/32",
            "1-1/8",
            "1-5/32",
            "1-3/16",
            "1-7/32",
            "1-1/4",
            "1-9/32",
            "1-5/16",
            "1-11/32",
            "1-3/8",
            "1-13-32",
            "1-7/16",
            "1-15/32",
            "1-1/2"});
            this.punBox.Location = new System.Drawing.Point(123, 107);
            this.punBox.Name = "punBox";
            this.punBox.Size = new System.Drawing.Size(121, 28);
            this.punBox.TabIndex = 6;
            // 
            // thickBox
            // 
            this.thickBox.BackColor = System.Drawing.Color.White;
            this.thickBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.thickBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thickBox.ForeColor = System.Drawing.Color.Black;
            this.thickBox.FormattingEnabled = true;
            this.thickBox.Items.AddRange(new object[] {
            "1/8",
            "1/4",
            "3/8",
            "1/2",
            "5/8",
            "3/4"});
            this.thickBox.Location = new System.Drawing.Point(123, 153);
            this.thickBox.Name = "thickBox";
            this.thickBox.Size = new System.Drawing.Size(121, 28);
            this.thickBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AP_Calculator.Properties.Resources.Banner1;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Clearance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(392, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.thickBox);
            this.Controls.Add(this.punBox);
            this.Controls.Add(this.dieNumLab);
            this.Controls.Add(this.dieLab);
            this.Controls.Add(this.thickLab);
            this.Controls.Add(this.punLab);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.homeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Clearance";
            this.Text = "Clearance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clearance_FormClosing);
            this.Load += new System.EventHandler(this.Clearance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label punLab;
        private System.Windows.Forms.Label thickLab;
        private System.Windows.Forms.Label dieLab;
        private System.Windows.Forms.Label dieNumLab;
        private System.Windows.Forms.ComboBox punBox;
        private System.Windows.Forms.ComboBox thickBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}