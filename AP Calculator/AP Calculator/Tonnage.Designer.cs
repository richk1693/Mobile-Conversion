namespace AP_Calculator
{
    partial class Tonnage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tonnage));
            this.shapeLab = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.shapeBox = new System.Windows.Forms.ComboBox();
            this.holeLab = new System.Windows.Forms.Label();
            this.holeBox = new System.Windows.Forms.ComboBox();
            this.thickLab = new System.Windows.Forms.Label();
            this.thickBox = new System.Windows.Forms.ComboBox();
            this.lenLab = new System.Windows.Forms.Label();
            this.widLab = new System.Windows.Forms.Label();
            this.lenBox = new System.Windows.Forms.ComboBox();
            this.widBox = new System.Windows.Forms.ComboBox();
            this.holeNumLab = new System.Windows.Forms.Label();
            this.lenNumLab = new System.Windows.Forms.Label();
            this.widNumLab = new System.Windows.Forms.Label();
            this.thickNumLab = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.matLab = new System.Windows.Forms.Label();
            this.tonLab = new System.Windows.Forms.Label();
            this.psi50Lab = new System.Windows.Forms.Label();
            this.psi65Lab = new System.Windows.Forms.Label();
            this.psi75Lab = new System.Windows.Forms.Label();
            this.psi85Lab = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stainlessLab = new System.Windows.Forms.Label();
            this.steelLab = new System.Windows.Forms.Label();
            this.aluLab = new System.Windows.Forms.Label();
            this.calc50 = new System.Windows.Forms.Label();
            this.calc65 = new System.Windows.Forms.Label();
            this.calc75 = new System.Windows.Forms.Label();
            this.calc85 = new System.Windows.Forms.Label();
            this.calcCarbon = new System.Windows.Forms.Label();
            this.calcStain = new System.Windows.Forms.Label();
            this.calcSteel = new System.Windows.Forms.Label();
            this.calcAlu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeLab
            // 
            this.shapeLab.AutoSize = true;
            this.shapeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeLab.ForeColor = System.Drawing.Color.White;
            this.shapeLab.Location = new System.Drawing.Point(12, 138);
            this.shapeLab.Name = "shapeLab";
            this.shapeLab.Size = new System.Drawing.Size(56, 20);
            this.shapeLab.TabIndex = 0;
            this.shapeLab.Text = "Shape";
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Black;
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.Silver;
            this.HomeButton.Location = new System.Drawing.Point(16, 308);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(112, 53);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // shapeBox
            // 
            this.shapeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shapeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeBox.FormattingEnabled = true;
            this.shapeBox.Items.AddRange(new object[] {
            "Round",
            "Square",
            "Oblong",
            "Rectangle"});
            this.shapeBox.Location = new System.Drawing.Point(97, 135);
            this.shapeBox.Name = "shapeBox";
            this.shapeBox.Size = new System.Drawing.Size(121, 28);
            this.shapeBox.TabIndex = 2;
            this.shapeBox.SelectedIndexChanged += new System.EventHandler(this.shapeBox_SelectedIndexChanged);
            // 
            // holeLab
            // 
            this.holeLab.AutoSize = true;
            this.holeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holeLab.ForeColor = System.Drawing.Color.White;
            this.holeLab.Location = new System.Drawing.Point(12, 173);
            this.holeLab.Name = "holeLab";
            this.holeLab.Size = new System.Drawing.Size(77, 20);
            this.holeLab.TabIndex = 3;
            this.holeLab.Text = "Hole Size";
            this.holeLab.Visible = false;
            // 
            // holeBox
            // 
            this.holeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.holeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holeBox.FormattingEnabled = true;
            this.holeBox.Items.AddRange(new object[] {
            "1/8",
            "5/32",
            "3/16",
            "7/32",
            "1/4",
            "9/32",
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
            this.holeBox.Location = new System.Drawing.Point(97, 170);
            this.holeBox.Name = "holeBox";
            this.holeBox.Size = new System.Drawing.Size(121, 28);
            this.holeBox.TabIndex = 4;
            this.holeBox.Visible = false;
            this.holeBox.SelectedIndexChanged += new System.EventHandler(this.holeBox_SelectedIndexChanged);
            // 
            // thickLab
            // 
            this.thickLab.AutoSize = true;
            this.thickLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thickLab.ForeColor = System.Drawing.Color.White;
            this.thickLab.Location = new System.Drawing.Point(12, 274);
            this.thickLab.Name = "thickLab";
            this.thickLab.Size = new System.Drawing.Size(80, 20);
            this.thickLab.TabIndex = 5;
            this.thickLab.Text = "Thickness";
            this.thickLab.Visible = false;
            // 
            // thickBox
            // 
            this.thickBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.thickBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thickBox.FormattingEnabled = true;
            this.thickBox.Items.AddRange(new object[] {
            "16ga",
            "12ga",
            "1/8",
            "3/16",
            "1/4",
            "5/16",
            "3/8",
            "7/16",
            "1/2",
            "5/8",
            "7/8",
            "1"});
            this.thickBox.Location = new System.Drawing.Point(97, 274);
            this.thickBox.Name = "thickBox";
            this.thickBox.Size = new System.Drawing.Size(121, 28);
            this.thickBox.TabIndex = 6;
            this.thickBox.Visible = false;
            this.thickBox.SelectedIndexChanged += new System.EventHandler(this.thickBox_SelectedIndexChanged);
            // 
            // lenLab
            // 
            this.lenLab.AutoSize = true;
            this.lenLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenLab.ForeColor = System.Drawing.Color.White;
            this.lenLab.Location = new System.Drawing.Point(13, 206);
            this.lenLab.Name = "lenLab";
            this.lenLab.Size = new System.Drawing.Size(59, 20);
            this.lenLab.TabIndex = 7;
            this.lenLab.Text = "Length";
            this.lenLab.Visible = false;
            // 
            // widLab
            // 
            this.widLab.AutoSize = true;
            this.widLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widLab.ForeColor = System.Drawing.Color.White;
            this.widLab.Location = new System.Drawing.Point(12, 240);
            this.widLab.Name = "widLab";
            this.widLab.Size = new System.Drawing.Size(50, 20);
            this.widLab.TabIndex = 8;
            this.widLab.Text = "Width";
            this.widLab.Visible = false;
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
            this.lenBox.Location = new System.Drawing.Point(97, 203);
            this.lenBox.Name = "lenBox";
            this.lenBox.Size = new System.Drawing.Size(121, 28);
            this.lenBox.TabIndex = 9;
            this.lenBox.Visible = false;
            this.lenBox.SelectedIndexChanged += new System.EventHandler(this.lenBox_SelectedIndexChanged);
            // 
            // widBox
            // 
            this.widBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.widBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widBox.FormattingEnabled = true;
            this.widBox.Items.AddRange(new object[] {
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
            this.widBox.Location = new System.Drawing.Point(97, 237);
            this.widBox.Name = "widBox";
            this.widBox.Size = new System.Drawing.Size(121, 28);
            this.widBox.TabIndex = 10;
            this.widBox.Visible = false;
            this.widBox.SelectedIndexChanged += new System.EventHandler(this.widBox_SelectedIndexChanged);
            // 
            // holeNumLab
            // 
            this.holeNumLab.AutoSize = true;
            this.holeNumLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holeNumLab.ForeColor = System.Drawing.Color.White;
            this.holeNumLab.Location = new System.Drawing.Point(224, 178);
            this.holeNumLab.Name = "holeNumLab";
            this.holeNumLab.Size = new System.Drawing.Size(18, 20);
            this.holeNumLab.TabIndex = 11;
            this.holeNumLab.Text = "0";
            this.holeNumLab.Visible = false;
            // 
            // lenNumLab
            // 
            this.lenNumLab.AutoSize = true;
            this.lenNumLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenNumLab.ForeColor = System.Drawing.Color.White;
            this.lenNumLab.Location = new System.Drawing.Point(224, 206);
            this.lenNumLab.Name = "lenNumLab";
            this.lenNumLab.Size = new System.Drawing.Size(18, 20);
            this.lenNumLab.TabIndex = 12;
            this.lenNumLab.Text = "0";
            this.lenNumLab.Visible = false;
            // 
            // widNumLab
            // 
            this.widNumLab.AutoSize = true;
            this.widNumLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widNumLab.ForeColor = System.Drawing.Color.White;
            this.widNumLab.Location = new System.Drawing.Point(224, 245);
            this.widNumLab.Name = "widNumLab";
            this.widNumLab.Size = new System.Drawing.Size(18, 20);
            this.widNumLab.TabIndex = 13;
            this.widNumLab.Text = "0";
            this.widNumLab.Visible = false;
            // 
            // thickNumLab
            // 
            this.thickNumLab.AutoSize = true;
            this.thickNumLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thickNumLab.ForeColor = System.Drawing.Color.White;
            this.thickNumLab.Location = new System.Drawing.Point(224, 277);
            this.thickNumLab.Name = "thickNumLab";
            this.thickNumLab.Size = new System.Drawing.Size(18, 20);
            this.thickNumLab.TabIndex = 14;
            this.thickNumLab.Text = "0";
            this.thickNumLab.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(139, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 53);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // matLab
            // 
            this.matLab.AutoSize = true;
            this.matLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matLab.ForeColor = System.Drawing.Color.Silver;
            this.matLab.Location = new System.Drawing.Point(289, 118);
            this.matLab.Name = "matLab";
            this.matLab.Size = new System.Drawing.Size(107, 29);
            this.matLab.TabIndex = 16;
            this.matLab.Text = "Material";
            // 
            // tonLab
            // 
            this.tonLab.AutoSize = true;
            this.tonLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tonLab.ForeColor = System.Drawing.Color.Silver;
            this.tonLab.Location = new System.Drawing.Point(479, 118);
            this.tonLab.Name = "tonLab";
            this.tonLab.Size = new System.Drawing.Size(117, 29);
            this.tonLab.TabIndex = 17;
            this.tonLab.Text = "Tonnage";
            // 
            // psi50Lab
            // 
            this.psi50Lab.AutoSize = true;
            this.psi50Lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psi50Lab.ForeColor = System.Drawing.Color.White;
            this.psi50Lab.Location = new System.Drawing.Point(289, 173);
            this.psi50Lab.Name = "psi50Lab";
            this.psi50Lab.Size = new System.Drawing.Size(150, 20);
            this.psi50Lab.TabIndex = 18;
            this.psi50Lab.Text = "50,000 tensile psi";
            // 
            // psi65Lab
            // 
            this.psi65Lab.AutoSize = true;
            this.psi65Lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psi65Lab.ForeColor = System.Drawing.Color.White;
            this.psi65Lab.Location = new System.Drawing.Point(290, 193);
            this.psi65Lab.Name = "psi65Lab";
            this.psi65Lab.Size = new System.Drawing.Size(150, 20);
            this.psi65Lab.TabIndex = 19;
            this.psi65Lab.Text = "65,000 tensile psi";
            // 
            // psi75Lab
            // 
            this.psi75Lab.AutoSize = true;
            this.psi75Lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psi75Lab.ForeColor = System.Drawing.Color.White;
            this.psi75Lab.Location = new System.Drawing.Point(290, 213);
            this.psi75Lab.Name = "psi75Lab";
            this.psi75Lab.Size = new System.Drawing.Size(150, 20);
            this.psi75Lab.TabIndex = 20;
            this.psi75Lab.Text = "75,000 tensile psi";
            // 
            // psi85Lab
            // 
            this.psi85Lab.AutoSize = true;
            this.psi85Lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psi85Lab.ForeColor = System.Drawing.Color.White;
            this.psi85Lab.Location = new System.Drawing.Point(290, 237);
            this.psi85Lab.Name = "psi85Lab";
            this.psi85Lab.Size = new System.Drawing.Size(150, 20);
            this.psi85Lab.TabIndex = 21;
            this.psi85Lab.Text = "85,000 tensile psi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(289, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "C50 Carbon Steel";
            // 
            // stainlessLab
            // 
            this.stainlessLab.AutoSize = true;
            this.stainlessLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stainlessLab.ForeColor = System.Drawing.Color.White;
            this.stainlessLab.Location = new System.Drawing.Point(289, 277);
            this.stainlessLab.Name = "stainlessLab";
            this.stainlessLab.Size = new System.Drawing.Size(118, 20);
            this.stainlessLab.TabIndex = 23;
            this.stainlessLab.Text = "303 Stainless";
            // 
            // steelLab
            // 
            this.steelLab.AutoSize = true;
            this.steelLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steelLab.ForeColor = System.Drawing.Color.White;
            this.steelLab.Location = new System.Drawing.Point(289, 297);
            this.steelLab.Name = "steelLab";
            this.steelLab.Size = new System.Drawing.Size(96, 20);
            this.steelLab.TabIndex = 24;
            this.steelLab.Text = "1018 Steel";
            this.steelLab.Click += new System.EventHandler(this.steelLab_Click);
            // 
            // aluLab
            // 
            this.aluLab.AutoSize = true;
            this.aluLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aluLab.ForeColor = System.Drawing.Color.White;
            this.aluLab.Location = new System.Drawing.Point(289, 317);
            this.aluLab.Name = "aluLab";
            this.aluLab.Size = new System.Drawing.Size(132, 20);
            this.aluLab.TabIndex = 25;
            this.aluLab.Text = "2024 Aluminum";
            // 
            // calc50
            // 
            this.calc50.AutoSize = true;
            this.calc50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc50.ForeColor = System.Drawing.Color.White;
            this.calc50.Location = new System.Drawing.Point(479, 173);
            this.calc50.Name = "calc50";
            this.calc50.Size = new System.Drawing.Size(19, 20);
            this.calc50.TabIndex = 26;
            this.calc50.Text = "0";
            // 
            // calc65
            // 
            this.calc65.AutoSize = true;
            this.calc65.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc65.ForeColor = System.Drawing.Color.White;
            this.calc65.Location = new System.Drawing.Point(479, 193);
            this.calc65.Name = "calc65";
            this.calc65.Size = new System.Drawing.Size(19, 20);
            this.calc65.TabIndex = 27;
            this.calc65.Text = "0";
            // 
            // calc75
            // 
            this.calc75.AutoSize = true;
            this.calc75.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc75.ForeColor = System.Drawing.Color.White;
            this.calc75.Location = new System.Drawing.Point(480, 213);
            this.calc75.Name = "calc75";
            this.calc75.Size = new System.Drawing.Size(19, 20);
            this.calc75.TabIndex = 28;
            this.calc75.Text = "0";
            // 
            // calc85
            // 
            this.calc85.AutoSize = true;
            this.calc85.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc85.ForeColor = System.Drawing.Color.White;
            this.calc85.Location = new System.Drawing.Point(480, 233);
            this.calc85.Name = "calc85";
            this.calc85.Size = new System.Drawing.Size(19, 20);
            this.calc85.TabIndex = 29;
            this.calc85.Text = "0";
            // 
            // calcCarbon
            // 
            this.calcCarbon.AutoSize = true;
            this.calcCarbon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcCarbon.ForeColor = System.Drawing.Color.White;
            this.calcCarbon.Location = new System.Drawing.Point(480, 253);
            this.calcCarbon.Name = "calcCarbon";
            this.calcCarbon.Size = new System.Drawing.Size(19, 20);
            this.calcCarbon.TabIndex = 30;
            this.calcCarbon.Text = "0";
            // 
            // calcStain
            // 
            this.calcStain.AutoSize = true;
            this.calcStain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcStain.ForeColor = System.Drawing.Color.White;
            this.calcStain.Location = new System.Drawing.Point(480, 277);
            this.calcStain.Name = "calcStain";
            this.calcStain.Size = new System.Drawing.Size(19, 20);
            this.calcStain.TabIndex = 31;
            this.calcStain.Text = "0";
            // 
            // calcSteel
            // 
            this.calcSteel.AutoSize = true;
            this.calcSteel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcSteel.ForeColor = System.Drawing.Color.White;
            this.calcSteel.Location = new System.Drawing.Point(480, 297);
            this.calcSteel.Name = "calcSteel";
            this.calcSteel.Size = new System.Drawing.Size(19, 20);
            this.calcSteel.TabIndex = 32;
            this.calcSteel.Text = "0";
            this.calcSteel.Click += new System.EventHandler(this.label8_Click);
            // 
            // calcAlu
            // 
            this.calcAlu.AutoSize = true;
            this.calcAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcAlu.ForeColor = System.Drawing.Color.White;
            this.calcAlu.Location = new System.Drawing.Point(480, 317);
            this.calcAlu.Name = "calcAlu";
            this.calcAlu.Size = new System.Drawing.Size(19, 20);
            this.calcAlu.TabIndex = 33;
            this.calcAlu.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AP_Calculator.Properties.Resources.Banner1;
            this.pictureBox1.Location = new System.Drawing.Point(139, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Tonnage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(702, 374);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.calcAlu);
            this.Controls.Add(this.calcSteel);
            this.Controls.Add(this.calcStain);
            this.Controls.Add(this.calcCarbon);
            this.Controls.Add(this.calc85);
            this.Controls.Add(this.calc75);
            this.Controls.Add(this.calc65);
            this.Controls.Add(this.calc50);
            this.Controls.Add(this.aluLab);
            this.Controls.Add(this.steelLab);
            this.Controls.Add(this.stainlessLab);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.psi85Lab);
            this.Controls.Add(this.psi75Lab);
            this.Controls.Add(this.psi65Lab);
            this.Controls.Add(this.psi50Lab);
            this.Controls.Add(this.tonLab);
            this.Controls.Add(this.matLab);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.thickNumLab);
            this.Controls.Add(this.widNumLab);
            this.Controls.Add(this.lenNumLab);
            this.Controls.Add(this.holeNumLab);
            this.Controls.Add(this.widBox);
            this.Controls.Add(this.lenBox);
            this.Controls.Add(this.widLab);
            this.Controls.Add(this.lenLab);
            this.Controls.Add(this.thickBox);
            this.Controls.Add(this.thickLab);
            this.Controls.Add(this.holeBox);
            this.Controls.Add(this.holeLab);
            this.Controls.Add(this.shapeBox);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.shapeLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tonnage";
            this.Text = "Tonnage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tonnage_FormClosing);
            this.Load += new System.EventHandler(this.Tonnage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shapeLab;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.ComboBox shapeBox;
        private System.Windows.Forms.Label holeLab;
        private System.Windows.Forms.ComboBox holeBox;
        private System.Windows.Forms.Label thickLab;
        private System.Windows.Forms.ComboBox thickBox;
        private System.Windows.Forms.Label lenLab;
        private System.Windows.Forms.Label widLab;
        private System.Windows.Forms.ComboBox lenBox;
        private System.Windows.Forms.ComboBox widBox;
        private System.Windows.Forms.Label holeNumLab;
        private System.Windows.Forms.Label lenNumLab;
        private System.Windows.Forms.Label widNumLab;
        private System.Windows.Forms.Label thickNumLab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label matLab;
        private System.Windows.Forms.Label tonLab;
        private System.Windows.Forms.Label psi50Lab;
        private System.Windows.Forms.Label psi65Lab;
        private System.Windows.Forms.Label psi75Lab;
        private System.Windows.Forms.Label psi85Lab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label stainlessLab;
        private System.Windows.Forms.Label steelLab;
        private System.Windows.Forms.Label aluLab;
        private System.Windows.Forms.Label calc50;
        private System.Windows.Forms.Label calc65;
        private System.Windows.Forms.Label calc75;
        private System.Windows.Forms.Label calc85;
        private System.Windows.Forms.Label calcCarbon;
        private System.Windows.Forms.Label calcStain;
        private System.Windows.Forms.Label calcSteel;
        private System.Windows.Forms.Label calcAlu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}