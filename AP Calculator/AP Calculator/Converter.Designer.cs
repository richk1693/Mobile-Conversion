namespace AP_Calculator
{
    partial class Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.label1 = new System.Windows.Forms.Label();
            this.numBox = new System.Windows.Forms.TextBox();
            this.denBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.decNumLab = new System.Windows.Forms.Label();
            this.Divider1 = new System.Windows.Forms.Label();
            this.mmBox = new System.Windows.Forms.TextBox();
            this.Divider2 = new System.Windows.Forms.Label();
            this.mmLab = new System.Windows.Forms.Label();
            this.mmNumLab = new System.Windows.Forms.Label();
            this.mmButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inBox = new System.Windows.Forms.TextBox();
            this.inLabel = new System.Windows.Forms.Label();
            this.inNumLab = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "__________";
            // 
            // numBox
            // 
            this.numBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBox.Location = new System.Drawing.Point(12, 113);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(67, 30);
            this.numBox.TabIndex = 1;
            this.numBox.Text = "1";
            this.numBox.TextChanged += new System.EventHandler(this.numBox_TextChanged);
            // 
            // denBox
            // 
            this.denBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denBox.Location = new System.Drawing.Point(12, 152);
            this.denBox.Name = "denBox";
            this.denBox.Size = new System.Drawing.Size(67, 30);
            this.denBox.TabIndex = 2;
            this.denBox.Text = "2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(86, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "To Decimal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // decNumLab
            // 
            this.decNumLab.AutoSize = true;
            this.decNumLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decNumLab.ForeColor = System.Drawing.Color.White;
            this.decNumLab.Location = new System.Drawing.Point(206, 136);
            this.decNumLab.Name = "decNumLab";
            this.decNumLab.Size = new System.Drawing.Size(50, 25);
            this.decNumLab.TabIndex = 4;
            this.decNumLab.Text = "0.00";
            // 
            // Divider1
            // 
            this.Divider1.AutoSize = true;
            this.Divider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divider1.ForeColor = System.Drawing.Color.White;
            this.Divider1.Location = new System.Drawing.Point(-1, 180);
            this.Divider1.Name = "Divider1";
            this.Divider1.Size = new System.Drawing.Size(650, 25);
            this.Divider1.TabIndex = 5;
            this.Divider1.Text = "__________________________________________________________";
            this.Divider1.Click += new System.EventHandler(this.Divider1_Click);
            // 
            // mmBox
            // 
            this.mmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmBox.Location = new System.Drawing.Point(13, 216);
            this.mmBox.Name = "mmBox";
            this.mmBox.Size = new System.Drawing.Size(67, 30);
            this.mmBox.TabIndex = 6;
            this.mmBox.Text = "0";
            // 
            // Divider2
            // 
            this.Divider2.AutoSize = true;
            this.Divider2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divider2.ForeColor = System.Drawing.Color.White;
            this.Divider2.Location = new System.Drawing.Point(-1, 264);
            this.Divider2.Name = "Divider2";
            this.Divider2.Size = new System.Drawing.Size(826, 25);
            this.Divider2.TabIndex = 7;
            this.Divider2.Text = "__________________________________________________________________________";
            // 
            // mmLab
            // 
            this.mmLab.AutoSize = true;
            this.mmLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmLab.ForeColor = System.Drawing.Color.White;
            this.mmLab.Location = new System.Drawing.Point(13, 246);
            this.mmLab.Name = "mmLab";
            this.mmLab.Size = new System.Drawing.Size(49, 25);
            this.mmLab.TabIndex = 8;
            this.mmLab.Text = "mm.";
            // 
            // mmNumLab
            // 
            this.mmNumLab.AutoSize = true;
            this.mmNumLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmNumLab.ForeColor = System.Drawing.Color.White;
            this.mmNumLab.Location = new System.Drawing.Point(204, 233);
            this.mmNumLab.Name = "mmNumLab";
            this.mmNumLab.Size = new System.Drawing.Size(50, 25);
            this.mmNumLab.TabIndex = 9;
            this.mmNumLab.Text = "0.00";
            // 
            // mmButton
            // 
            this.mmButton.BackColor = System.Drawing.Color.Black;
            this.mmButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmButton.ForeColor = System.Drawing.Color.Silver;
            this.mmButton.Location = new System.Drawing.Point(86, 213);
            this.mmButton.Name = "mmButton";
            this.mmButton.Size = new System.Drawing.Size(114, 64);
            this.mmButton.TabIndex = 10;
            this.mmButton.Text = "To Decimal";
            this.mmButton.UseVisualStyleBackColor = false;
            this.mmButton.Click += new System.EventHandler(this.mmButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(86, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 64);
            this.button2.TabIndex = 11;
            this.button2.Text = "To Metric";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inBox
            // 
            this.inBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inBox.Location = new System.Drawing.Point(13, 296);
            this.inBox.Name = "inBox";
            this.inBox.Size = new System.Drawing.Size(67, 30);
            this.inBox.TabIndex = 12;
            this.inBox.Text = "0";
            // 
            // inLabel
            // 
            this.inLabel.AutoSize = true;
            this.inLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inLabel.ForeColor = System.Drawing.Color.White;
            this.inLabel.Location = new System.Drawing.Point(13, 326);
            this.inLabel.Name = "inLabel";
            this.inLabel.Size = new System.Drawing.Size(32, 25);
            this.inLabel.TabIndex = 13;
            this.inLabel.Text = "in.";
            // 
            // inNumLab
            // 
            this.inNumLab.AutoSize = true;
            this.inNumLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inNumLab.ForeColor = System.Drawing.Color.White;
            this.inNumLab.Location = new System.Drawing.Point(204, 319);
            this.inNumLab.Name = "inNumLab";
            this.inNumLab.Size = new System.Drawing.Size(50, 25);
            this.inNumLab.TabIndex = 14;
            this.inNumLab.Text = "0.00";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(67, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 32);
            this.button3.TabIndex = 15;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AP_Calculator.Properties.Resources.Banner1;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(380, 422);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.inNumLab);
            this.Controls.Add(this.inLabel);
            this.Controls.Add(this.inBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mmButton);
            this.Controls.Add(this.mmNumLab);
            this.Controls.Add(this.mmLab);
            this.Controls.Add(this.Divider2);
            this.Controls.Add(this.mmBox);
            this.Controls.Add(this.Divider1);
            this.Controls.Add(this.decNumLab);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.denBox);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Converter";
            this.Text = "Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Converter_FormClosing);
            this.Load += new System.EventHandler(this.Converter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.TextBox denBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label decNumLab;
        private System.Windows.Forms.Label Divider1;
        private System.Windows.Forms.TextBox mmBox;
        private System.Windows.Forms.Label Divider2;
        private System.Windows.Forms.Label mmLab;
        private System.Windows.Forms.Label mmNumLab;
        private System.Windows.Forms.Button mmButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inBox;
        private System.Windows.Forms.Label inLabel;
        private System.Windows.Forms.Label inNumLab;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}