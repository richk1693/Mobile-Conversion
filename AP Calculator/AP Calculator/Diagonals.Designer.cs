namespace AP_Calculator
{
    partial class Diagonals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagonals));
            this.shapeBox = new System.Windows.Forms.ComboBox();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.shapeLab = new System.Windows.Forms.Label();
            this.sizeLab = new System.Windows.Forms.Label();
            this.diagLab = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.diagNumLab = new System.Windows.Forms.Label();
            this.lenBox = new System.Windows.Forms.ComboBox();
            this.lenLab = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeBox
            // 
            this.shapeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shapeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeBox.FormattingEnabled = true;
            this.shapeBox.Items.AddRange(new object[] {
            "Square",
            "Rectangle",
            "Hexagon"});
            this.shapeBox.Location = new System.Drawing.Point(135, 120);
            this.shapeBox.Name = "shapeBox";
            this.shapeBox.Size = new System.Drawing.Size(121, 28);
            this.shapeBox.TabIndex = 0;
            this.shapeBox.SelectedIndexChanged += new System.EventHandler(this.shapeBox_SelectedIndexChanged);
            // 
            // sizeBox
            // 
            this.sizeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Items.AddRange(new object[] {
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
            "1-1/2",
            "1-17/32",
            "1-9/16",
            "1-3/4",
            "2",
            "3",
            "4"});
            this.sizeBox.Location = new System.Drawing.Point(135, 206);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(121, 28);
            this.sizeBox.TabIndex = 1;
            this.sizeBox.Visible = false;
            // 
            // shapeLab
            // 
            this.shapeLab.AutoSize = true;
            this.shapeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeLab.ForeColor = System.Drawing.Color.White;
            this.shapeLab.Location = new System.Drawing.Point(19, 123);
            this.shapeLab.Name = "shapeLab";
            this.shapeLab.Size = new System.Drawing.Size(70, 25);
            this.shapeLab.TabIndex = 2;
            this.shapeLab.Text = "Shape";
            // 
            // sizeLab
            // 
            this.sizeLab.AutoSize = true;
            this.sizeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLab.ForeColor = System.Drawing.Color.White;
            this.sizeLab.Location = new System.Drawing.Point(19, 209);
            this.sizeLab.Name = "sizeLab";
            this.sizeLab.Size = new System.Drawing.Size(51, 25);
            this.sizeLab.TabIndex = 3;
            this.sizeLab.Text = "Size";
            this.sizeLab.Visible = false;
            // 
            // diagLab
            // 
            this.diagLab.AutoSize = true;
            this.diagLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagLab.ForeColor = System.Drawing.Color.White;
            this.diagLab.Location = new System.Drawing.Point(19, 260);
            this.diagLab.Name = "diagLab";
            this.diagLab.Size = new System.Drawing.Size(89, 25);
            this.diagLab.TabIndex = 4;
            this.diagLab.Text = "Diagonal";
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.Color.Black;
            this.calcButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.calcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.ForeColor = System.Drawing.Color.Silver;
            this.calcButton.Location = new System.Drawing.Point(215, 309);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(113, 63);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Black;
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.Silver;
            this.homeButton.Location = new System.Drawing.Point(24, 309);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(113, 63);
            this.homeButton.TabIndex = 6;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // diagNumLab
            // 
            this.diagNumLab.AutoSize = true;
            this.diagNumLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagNumLab.ForeColor = System.Drawing.Color.White;
            this.diagNumLab.Location = new System.Drawing.Point(130, 260);
            this.diagNumLab.Name = "diagNumLab";
            this.diagNumLab.Size = new System.Drawing.Size(23, 25);
            this.diagNumLab.TabIndex = 7;
            this.diagNumLab.Text = "0";
            this.diagNumLab.Click += new System.EventHandler(this.diagNumLab_Click);
            // 
            // lenBox
            // 
            this.lenBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenBox.FormattingEnabled = true;
            this.lenBox.Items.AddRange(new object[] {
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
            "1-1/2",
            "1-17/32",
            "1-9/16",
            "1-3/4",
            "2",
            "3",
            "4"});
            this.lenBox.Location = new System.Drawing.Point(135, 163);
            this.lenBox.Name = "lenBox";
            this.lenBox.Size = new System.Drawing.Size(121, 28);
            this.lenBox.TabIndex = 8;
            this.lenBox.Visible = false;
            // 
            // lenLab
            // 
            this.lenLab.AutoSize = true;
            this.lenLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenLab.ForeColor = System.Drawing.Color.White;
            this.lenLab.Location = new System.Drawing.Point(19, 166);
            this.lenLab.Name = "lenLab";
            this.lenLab.Size = new System.Drawing.Size(72, 25);
            this.lenLab.TabIndex = 9;
            this.lenLab.Text = "Length";
            this.lenLab.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AP_Calculator.Properties.Resources.Banner1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Diagonals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(394, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lenLab);
            this.Controls.Add(this.lenBox);
            this.Controls.Add(this.diagNumLab);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.diagLab);
            this.Controls.Add(this.sizeLab);
            this.Controls.Add(this.shapeLab);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.shapeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Diagonals";
            this.Text = "Diagonals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Diagonals_FormClosing);
            this.Load += new System.EventHandler(this.Diagonals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox shapeBox;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.Label shapeLab;
        private System.Windows.Forms.Label sizeLab;
        private System.Windows.Forms.Label diagLab;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label diagNumLab;
        private System.Windows.Forms.ComboBox lenBox;
        private System.Windows.Forms.Label lenLab;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}