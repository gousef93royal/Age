namespace Calculate_My_Age
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnCaluclateMyAge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbDays = new System.Windows.Forms.Label();
            this.lbHours = new System.Windows.Forms.Label();
            this.lbMinuts = new System.Windows.Forms.Label();
            this.lbSeconds = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbWeeks = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSendToEmail = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.lbTodayDateTime = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFeedbackCountry = new System.Windows.Forms.TextBox();
            this.btnSendFeedback = new System.Windows.Forms.Button();
            this.richFeedback = new System.Windows.Forms.RichTextBox();
            this.txtFeedbackName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.btnInstagram = new System.Windows.Forms.Button();
            this.btnArabic = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEye = new System.Windows.Forms.Button();
            this.lbTimeNow = new System.Windows.Forms.Label();
            this.TimerForNowTime = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDay
            // 
            this.cmbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDay.Location = new System.Drawing.Point(6, 69);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(86, 33);
            this.cmbDay.TabIndex = 0;
            this.cmbDay.Text = "Day";
            this.cmbDay.SelectedIndexChanged += new System.EventHandler(this.cmbDay_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(106, 69);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(150, 33);
            this.cmbMonth.TabIndex = 1;
            this.cmbMonth.Text = "Month";
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016"});
            this.cmbYear.Location = new System.Drawing.Point(262, 69);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(191, 33);
            this.cmbYear.TabIndex = 2;
            this.cmbYear.Text = "Year";
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // btnCaluclateMyAge
            // 
            this.btnCaluclateMyAge.BackColor = System.Drawing.Color.Gold;
            this.btnCaluclateMyAge.Enabled = false;
            this.btnCaluclateMyAge.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaluclateMyAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCaluclateMyAge.Location = new System.Drawing.Point(474, 55);
            this.btnCaluclateMyAge.Name = "btnCaluclateMyAge";
            this.btnCaluclateMyAge.Size = new System.Drawing.Size(456, 72);
            this.btnCaluclateMyAge.TabIndex = 3;
            this.btnCaluclateMyAge.Text = "Calculate My Age";
            this.btnCaluclateMyAge.UseVisualStyleBackColor = false;
            this.btnCaluclateMyAge.Click += new System.EventHandler(this.button1_Click);
            this.btnCaluclateMyAge.MouseLeave += new System.EventHandler(this.btnCaluclateMyAge_MouseLeave);
            this.btnCaluclateMyAge.MouseHover += new System.EventHandler(this.btnCaluclateMyAge_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Result >>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "In Months ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "In Days ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 41);
            this.label4.TabIndex = 8;
            this.label4.Text = "In Hours ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 41);
            this.label5.TabIndex = 9;
            this.label5.Text = "In Minuts ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 558);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 41);
            this.label6.TabIndex = 10;
            this.label6.Text = "In Seconds ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 650);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(420, 36);
            this.label7.TabIndex = 11;
            this.label7.Text = "Your BirthDay Will Be IN :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.BackColor = System.Drawing.SystemColors.Info;
            this.lbResult.Font = new System.Drawing.Font("Lucida Sans", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Blue;
            this.lbResult.Location = new System.Drawing.Point(235, 232);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(368, 32);
            this.lbResult.TabIndex = 12;
            this.lbResult.Text = "0 Years 0 Months 0 Days";
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.BackColor = System.Drawing.SystemColors.Info;
            this.lbMonth.Font = new System.Drawing.Font("Lucida Sans", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonth.ForeColor = System.Drawing.Color.Blue;
            this.lbMonth.Location = new System.Drawing.Point(235, 283);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(146, 32);
            this.lbMonth.TabIndex = 13;
            this.lbMonth.Text = "0 Months";
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.BackColor = System.Drawing.SystemColors.Info;
            this.lbDays.Font = new System.Drawing.Font("Lucida Sans", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDays.ForeColor = System.Drawing.Color.Blue;
            this.lbDays.Location = new System.Drawing.Point(235, 392);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(112, 32);
            this.lbDays.TabIndex = 14;
            this.lbDays.Text = "0 Days";
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.BackColor = System.Drawing.SystemColors.Info;
            this.lbHours.Font = new System.Drawing.Font("Lucida Sans", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHours.ForeColor = System.Drawing.Color.Blue;
            this.lbHours.Location = new System.Drawing.Point(237, 446);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(128, 32);
            this.lbHours.TabIndex = 15;
            this.lbHours.Text = "0 Hours";
            // 
            // lbMinuts
            // 
            this.lbMinuts.AutoSize = true;
            this.lbMinuts.BackColor = System.Drawing.SystemColors.Info;
            this.lbMinuts.Font = new System.Drawing.Font("Lucida Sans", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinuts.ForeColor = System.Drawing.Color.Blue;
            this.lbMinuts.Location = new System.Drawing.Point(236, 500);
            this.lbMinuts.Name = "lbMinuts";
            this.lbMinuts.Size = new System.Drawing.Size(136, 32);
            this.lbMinuts.TabIndex = 16;
            this.lbMinuts.Text = "0 Minuts";
            // 
            // lbSeconds
            // 
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.BackColor = System.Drawing.SystemColors.Info;
            this.lbSeconds.Font = new System.Drawing.Font("Lucida Sans", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeconds.ForeColor = System.Drawing.Color.Blue;
            this.lbSeconds.Location = new System.Drawing.Point(236, 563);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(158, 32);
            this.lbSeconds.TabIndex = 17;
            this.lbSeconds.Text = "0 Seconds";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.BackColor = System.Drawing.Color.OrangeRed;
            this.lbBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBirthday.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthday.ForeColor = System.Drawing.Color.Yellow;
            this.lbBirthday.Location = new System.Drawing.Point(455, 650);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(148, 38);
            this.lbBirthday.TabIndex = 18;
            this.lbBirthday.Text = "0 Day (s)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FloralWhite;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 959);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 25);
            this.label15.TabIndex = 20;
            this.label15.Text = "Done By:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Info;
            this.label16.Font = new System.Drawing.Font("Lucida Calligraphy", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(127, 958);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(250, 28);
            this.label16.TabIndex = 21;
            this.label16.Text = "yousef_alharrasi93";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Green;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Cooper Black", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(979, 57);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(166, 70);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 41);
            this.label8.TabIndex = 24;
            this.label8.Text = "In Weeks ";
            // 
            // lbWeeks
            // 
            this.lbWeeks.AutoSize = true;
            this.lbWeeks.BackColor = System.Drawing.SystemColors.Info;
            this.lbWeeks.Font = new System.Drawing.Font("Lucida Sans", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeeks.ForeColor = System.Drawing.Color.Blue;
            this.lbWeeks.Location = new System.Drawing.Point(235, 339);
            this.lbWeeks.Name = "lbWeeks";
            this.lbWeeks.Size = new System.Drawing.Size(130, 32);
            this.lbWeeks.TabIndex = 25;
            this.lbWeeks.Text = "0 Weeks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(633, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 41);
            this.label9.TabIndex = 28;
            this.label9.Text = "<< النتيجة";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(686, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 41);
            this.label10.TabIndex = 29;
            this.label10.Text = "بالأشهر";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(666, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 41);
            this.label11.TabIndex = 30;
            this.label11.Text = "بالأسابيع";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(707, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 41);
            this.label12.TabIndex = 31;
            this.label12.Text = "بالأيام";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(666, 445);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 41);
            this.label13.TabIndex = 32;
            this.label13.Text = "بالساعات";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(686, 500);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 41);
            this.label14.TabIndex = 33;
            this.label14.Text = "بالدقائق";
            this.label14.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(686, 561);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 41);
            this.label17.TabIndex = 34;
            this.label17.Text = "بالثواني";
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Font = new System.Drawing.Font("Modern No. 20", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(632, 651);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(259, 36);
            this.label18.TabIndex = 35;
            this.label18.Text = ": عيد ميلادك سيكون بعد";
            this.label18.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(42, 791);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(430, 40);
            this.txtEmail.TabIndex = 37;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            
            // 
            // btnSendToEmail
            // 
            this.btnSendToEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSendToEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendToEmail.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendToEmail.ForeColor = System.Drawing.Color.Maroon;
            this.btnSendToEmail.Location = new System.Drawing.Point(42, 841);
            this.btnSendToEmail.Name = "btnSendToEmail";
            this.btnSendToEmail.Size = new System.Drawing.Size(176, 35);
            this.btnSendToEmail.TabIndex = 38;
            this.btnSendToEmail.Text = "Send to My Email";
            this.btnSendToEmail.UseVisualStyleBackColor = false;
            this.btnSendToEmail.Click += new System.EventHandler(this.btnSendToEmail_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Maroon;
            this.label20.Location = new System.Drawing.Point(14, 173);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(191, 41);
            this.label20.TabIndex = 39;
            this.label20.Text = "Today Is :";
            // 
            // lbTodayDateTime
            // 
            this.lbTodayDateTime.AutoSize = true;
            this.lbTodayDateTime.Font = new System.Drawing.Font("Engravers MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTodayDateTime.ForeColor = System.Drawing.Color.Navy;
            this.lbTodayDateTime.Location = new System.Drawing.Point(234, 173);
            this.lbTodayDateTime.Name = "lbTodayDateTime";
            this.lbTodayDateTime.Size = new System.Drawing.Size(284, 42);
            this.lbTodayDateTime.TabIndex = 40;
            this.lbTodayDateTime.Text = "Today Is :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Elephant", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(677, 174);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(138, 41);
            this.label21.TabIndex = 41;
            this.label21.Text = ": اليوم هو";
            this.label21.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.txtFeedbackCountry);
            this.groupBox1.Controls.Add(this.btnSendFeedback);
            this.groupBox1.Controls.Add(this.richFeedback);
            this.groupBox1.Controls.Add(this.txtFeedbackName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1271, 625);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 390);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feedback";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtFeedbackCountry
            // 
            this.txtFeedbackCountry.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedbackCountry.ForeColor = System.Drawing.Color.Gray;
            this.txtFeedbackCountry.Location = new System.Drawing.Point(11, 89);
            this.txtFeedbackCountry.Name = "txtFeedbackCountry";
            this.txtFeedbackCountry.Size = new System.Drawing.Size(298, 32);
            this.txtFeedbackCountry.TabIndex = 42;
            this.txtFeedbackCountry.Text = "Enter Your Country";
            this.txtFeedbackCountry.Enter += new System.EventHandler(this.txtFeedbackCountry_Enter);
            this.txtFeedbackCountry.Leave += new System.EventHandler(this.txtFeedbackCountry_Leave);
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.BackColor = System.Drawing.Color.Azure;
            this.btnSendFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendFeedback.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFeedback.ForeColor = System.Drawing.Color.Maroon;
            this.btnSendFeedback.Location = new System.Drawing.Point(403, 327);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(176, 43);
            this.btnSendFeedback.TabIndex = 41;
            this.btnSendFeedback.Text = "Send";
            this.btnSendFeedback.UseVisualStyleBackColor = false;
            this.btnSendFeedback.Click += new System.EventHandler(this.btnSendFeedback_Click);
            // 
            // richFeedback
            // 
            this.richFeedback.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richFeedback.ForeColor = System.Drawing.Color.Navy;
            this.richFeedback.Location = new System.Drawing.Point(11, 127);
            this.richFeedback.Name = "richFeedback";
            this.richFeedback.Size = new System.Drawing.Size(568, 194);
            this.richFeedback.TabIndex = 40;
            this.richFeedback.Text = "";
            // 
            // txtFeedbackName
            // 
            this.txtFeedbackName.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedbackName.ForeColor = System.Drawing.Color.Gray;
            this.txtFeedbackName.Location = new System.Drawing.Point(11, 41);
            this.txtFeedbackName.Name = "txtFeedbackName";
            this.txtFeedbackName.Size = new System.Drawing.Size(357, 32);
            this.txtFeedbackName.TabIndex = 38;
            this.txtFeedbackName.Text = "Enter Your Name";
            this.txtFeedbackName.Enter += new System.EventHandler(this.txtEmailFeedback_Enter);
            this.txtFeedbackName.Leave += new System.EventHandler(this.txtEmailFeedback_Leave);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.SeaShell;
            this.txtName.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(9, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 33);
            this.txtName.TabIndex = 43;
            this.txtName.Text = "Name";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.SeaShell;
            this.txtSurname.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.Gray;
            this.txtSurname.Location = new System.Drawing.Point(176, 12);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(161, 33);
            this.txtSurname.TabIndex = 44;
            this.txtSurname.Text = "Surname";
            this.txtSurname.Enter += new System.EventHandler(this.txtSurname_Enter);
            this.txtSurname.Leave += new System.EventHandler(this.txtSurname_Leave);
            // 
            // btnFacebook
            // 
            this.btnFacebook.BackgroundImage = global::Calculate_My_Age.Properties.Resources.Facebook;
            this.btnFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacebook.Location = new System.Drawing.Point(6, 25);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(115, 90);
            this.btnFacebook.TabIndex = 46;
            this.btnFacebook.UseVisualStyleBackColor = true;
            this.btnFacebook.MouseLeave += new System.EventHandler(this.btnFacebook_MouseLeave);
            this.btnFacebook.MouseHover += new System.EventHandler(this.btnFacebook_MouseHover);
            // 
            // btnInstagram
            // 
            this.btnInstagram.BackgroundImage = global::Calculate_My_Age.Properties.Resources.instagram;
            this.btnInstagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInstagram.Location = new System.Drawing.Point(173, 25);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Size = new System.Drawing.Size(115, 90);
            this.btnInstagram.TabIndex = 45;
            this.btnInstagram.UseVisualStyleBackColor = true;
            // 
            // btnArabic
            // 
            this.btnArabic.BackgroundImage = global::Calculate_My_Age.Properties.Resources.zz1;
            this.btnArabic.FlatAppearance.BorderSize = 0;
            this.btnArabic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnArabic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArabic.Location = new System.Drawing.Point(1301, 12);
            this.btnArabic.Name = "btnArabic";
            this.btnArabic.Size = new System.Drawing.Size(48, 52);
            this.btnArabic.TabIndex = 27;
            this.btnArabic.UseVisualStyleBackColor = true;
            this.btnArabic.Click += new System.EventHandler(this.btnArabic_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackgroundImage = global::Calculate_My_Age.Properties.Resources.Hopstarter_Flag_Borderless_United_Kingdom1;
            this.btnEnglish.FlatAppearance.BorderSize = 0;
            this.btnEnglish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnglish.Location = new System.Drawing.Point(1238, 12);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(50, 52);
            this.btnEnglish.TabIndex = 26;
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFacebook);
            this.groupBox2.Controls.Add(this.btnInstagram);
            this.groupBox2.Location = new System.Drawing.Point(1590, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 171);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Share on social media";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.SeaShell;
            this.txtPassword.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(343, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(161, 33);
            this.txtPassword.TabIndex = 45;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnEye
            // 
            this.btnEye.BackgroundImage = global::Calculate_My_Age.Properties.Resources.eye_password;
            this.btnEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEye.Enabled = false;
            this.btnEye.Location = new System.Drawing.Point(515, 10);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(57, 40);
            this.btnEye.TabIndex = 46;
            this.btnEye.UseVisualStyleBackColor = true;
            this.btnEye.MouseLeave += new System.EventHandler(this.btnEye_MouseLeave);
            this.btnEye.MouseHover += new System.EventHandler(this.btnEye_MouseHover);
            // 
            // lbTimeNow
            // 
            this.lbTimeNow.AutoSize = true;
            this.lbTimeNow.Font = new System.Drawing.Font("Engravers MT", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeNow.ForeColor = System.Drawing.Color.Navy;
            this.lbTimeNow.Location = new System.Drawing.Point(524, 178);
            this.lbTimeNow.Name = "lbTimeNow";
            this.lbTimeNow.Size = new System.Drawing.Size(0, 32);
            this.lbTimeNow.TabIndex = 47;
            // 
            // TimerForNowTime
            // 
            this.TimerForNowTime.Enabled = true;
            this.TimerForNowTime.Interval = 1000;
            this.TimerForNowTime.Tick += new System.EventHandler(this.TimerForNowTime_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(632, 841);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 40);
            this.textBox1.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1908, 1034);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbTimeNow);
            this.Controls.Add(this.btnEye);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lbTodayDateTime);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnSendToEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnArabic);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.lbWeeks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.lbSeconds);
            this.Controls.Add(this.lbMinuts);
            this.Controls.Add(this.lbHours);
            this.Controls.Add(this.lbDays);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCaluclateMyAge);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnCaluclateMyAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.Label lbMinuts;
        private System.Windows.Forms.Label lbSeconds;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbWeeks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnArabic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSendToEmail;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbTodayDateTime;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSendFeedback;
        private System.Windows.Forms.RichTextBox richFeedback;
        private System.Windows.Forms.TextBox txtFeedbackName;
        private System.Windows.Forms.TextBox txtFeedbackCountry;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnInstagram;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEye;
        private System.Windows.Forms.Label lbTimeNow;
        private System.Windows.Forms.Timer TimerForNowTime;
        private System.Windows.Forms.TextBox textBox1;
    }
}

