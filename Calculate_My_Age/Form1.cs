using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Data.SqlClient;


namespace Calculate_My_Age
{
    public partial class Form1 : Form
    {
        
        DateTime dt = DateTime.Now;
        int MONTHS = 0;
        int DaysOfMonth = 0;
        int incrementSeconds = 0;
        public int calcYear;

        SqlConnection connection = new SqlConnection(@"Server=.\SQLEXPRESS; DataBase=Age; Integrated Security=true; ");
        SqlCommand command;
        SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnCaluclateMyAge.BackColor = Color.LightGoldenrodYellow;
            btnArabic.Enabled = false;
            btnEnglish.Enabled = false;

            switch (cmbMonth.SelectedItem.ToString())
            {
               case "January":
                    MONTHS = MONTHS + 1;
                    DaysOfMonth = 31;

                    break;
                case "February":
                    MONTHS = MONTHS + 2;
                    DaysOfMonth = 28;
                    break;
                case "March":
                    MONTHS = MONTHS + 3;
                    DaysOfMonth = 31;
                    break;
                case "April":
                    MONTHS = MONTHS + 4;
                    DaysOfMonth = 30;
                    break;
                case "May":
                    MONTHS = MONTHS + 5;
                    DaysOfMonth = 31;
                    break;
                case "June":
                    MONTHS = MONTHS + 6;
                    DaysOfMonth = 30;
                    break;
                case "July":
                    MONTHS = MONTHS + 7;
                    DaysOfMonth = 31;
                    break;
                case "August":
                    MONTHS = MONTHS + 8;
                    DaysOfMonth = 31;
                    break;
                case "September":
                    MONTHS = MONTHS + 9;
                    DaysOfMonth = 30;
                    break;
                case "October":
                    MONTHS = MONTHS + 10;
                    DaysOfMonth = 31;
                    break;
                case "November":
                    MONTHS = MONTHS + 11;
                    DaysOfMonth = 30;
                    break;
                case "December":
                    MONTHS = MONTHS + 12;
                    DaysOfMonth = 31;
                    break;
            }
            int yearNow = dt.Year;
            int monthNow = dt.Month;
            int dayNow = dt.Day;
            int calcDay = Convert.ToInt32(cmbDay.SelectedItem) - dayNow;
            if (calcDay < 0)
            {
                calcDay = calcDay + 30;
                monthNow--;
            }

            int calcMonth = monthNow - MONTHS;
            if (calcMonth < 0)
            {
                calcMonth = calcMonth + 12;
                yearNow--;
            }
              calcYear = yearNow - Convert.ToInt32(cmbYear.SelectedItem);


           
            lbResult.Text = calcYear.ToString() + " Years " + calcMonth.ToString() + " Months " + calcDay.ToString() + " Days";

            lbMonth.Text = Convert.ToString(calcYear * 12 + " Months");
            lbWeeks.Text = Convert.ToString(calcYear * 52 + " Weeks");
            lbDays.Text = Convert.ToString(calcYear * 365 + " Days");
            lbHours.Text = Convert.ToString(calcYear * 365 * 24 + " Hours");
            lbMinuts.Text = Convert.ToString(calcYear * 365 * 24 * 60 + " Minuts");
            lbSeconds.Text = Convert.ToString(calcYear * 365 * 24 * 60 * 60 + incrementSeconds++ + " Seconds");
            timer1.Start();


            if (Convert.ToInt32(cmbDay.SelectedItem) == dt.Day)
            {
                label7.Text = "Your BirthDay Is :";
                lbBirthday.Location = new Point(220, 420);
                lbBirthday.Text = "Today";
            }

            else if (Convert.ToInt32(cmbDay.SelectedItem) < dt.Day)
            {
                lbBirthday.Text = Convert.ToString(365 - (dt.Day - Convert.ToInt32(cmbDay.SelectedItem))) + " Days";
            }

            else if (Convert.ToInt32(cmbDay.SelectedItem) > dt.Day) // May >> 31
            {

                lbBirthday.Text = Convert.ToString(Convert.ToInt32(cmbDay.SelectedItem) - dt.Day) + " Days";

            }

            else if (MONTHS == (dt.Month + 1)) // June >> 30
            {
                lbBirthday.Text = Convert.ToString(31 - dt.Day + Convert.ToInt32(cmbDay.SelectedItem)) + " Days";
            }

            else if (MONTHS == (dt.Month + 2)) // July >> 31
            {
                lbBirthday.Text = Convert.ToString(31 - dt.Day + 30 + Convert.ToInt32(cmbDay.SelectedItem)) + " Days";
            }

            else if (MONTHS == (dt.Month + 3)) // August >> 31
            {
                lbBirthday.Text = Convert.ToString(31 - dt.Day + 30 + 31 + Convert.ToInt32(cmbDay.SelectedItem)) + " Days";
            }

            else if (MONTHS == (dt.Month + 4)) // September >> 30
            {
                lbBirthday.Text = Convert.ToString(31 - dt.Day + 30 + 31 + 31 + Convert.ToInt32(cmbDay.SelectedItem)) + " Days";
            }

            else if (MONTHS == (dt.Month + 5)) // October >> 31
            {
                lbBirthday.Text = Convert.ToString(31 - dt.Day + 30 + 31 + 31 + 30 + Convert.ToInt32(cmbDay.SelectedItem)) + " Days";
            }

            else if (MONTHS == (dt.Month + 6)) // November >> 30
            {
                lbBirthday.Text = Convert.ToString(31 - dt.Day + 30 + 31 + 31 + 30 + 31 + Convert.ToInt32(cmbDay.SelectedItem)) + " Days";
            }

            else if (MONTHS == (dt.Month + 7)) // December >> 30
            {
                lbBirthday.Text = Convert.ToString(31 - dt.Day + 30 + 31 + 31 + 30 + 31 + 30 + Convert.ToInt32(cmbDay.SelectedItem)) + " Days";
            }

            else if (MONTHS == (dt.Month - 4)) // January >> 31
            {
                lbBirthday.Text = Convert.ToString(31 - dt.Day + 30 + 31 + 31 + 30 + 31 + 30 + 30 + Convert.ToInt32(cmbDay.SelectedItem)) + " Days";
            }

            else if (MONTHS == (dt.Month - 3)) // February >> 28
            {
                lbBirthday.Text = Convert.ToString(31 - dt.Day + 30 + 31 + 31 + 30 + 31 + 30 + 30 + 31 + Convert.ToInt32(cmbDay.SelectedItem)) + " Days";
            }

            else if (MONTHS == (dt.Month - 2)) // March >> 31
            {
                lbBirthday.Text = Convert.ToString(31 - dt.Day + 30 + 31 + 31 + 30 + 31 + 30 + 30 + 31 + 28 + Convert.ToInt32(cmbDay.SelectedItem)) + " Days";
            }

            else if (MONTHS == (dt.Month - 1)) // April >> 30
            {
                lbBirthday.Text = Convert.ToString(31 - dt.Day + 30 + 31 + 31 + 30 + 31 + 30 + 30 + 31 + 28 + 31 + Convert.ToInt32(cmbDay.SelectedItem)) + " Days";
            }

           



            
            this.BackColor = Color.Silver;
            
            btnCaluclateMyAge.Enabled = false;
            cmbDay.Enabled = false;
            cmbMonth.Enabled = false;
            cmbYear.Enabled = false;
            txtEmail.Visible = true;
            btnSendToEmail.Visible = true;


            command = new SqlCommand("Insert into xx(Password,Name,Surname,D,M,Y) Values('" + txtPassword.Text + "','" + txtName.Text + "', '" + txtSurname.Text + "', '" + cmbDay.Text + "', '" + cmbMonth.Text + "', '" + cmbYear.Text + "')", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();


            ////////////////// I need to bring email from table >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lbTodayDateTime.Text = dt.ToShortDateString();
            
            timer1.Stop();
            txtEmail.Visible = false;
            btnSendToEmail.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Random x = new Random();
           
            lbSeconds.Text = Convert.ToString(calcYear * 365 * 24 * 60 * 60 + incrementSeconds++ + " Seconds") ;
            if (incrementSeconds == 61)
            {
                lbMinuts.Text = Convert.ToString(calcYear * 365 * 24 * 60 + 1 +" Minuts");
            }
           else if (incrementSeconds == 121)
            {
                lbMinuts.Text = Convert.ToString(calcYear * 365 * 24 * 60 + 2 + " Minuts");
            }

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            txtEmail.Visible = false;
            btnSendToEmail.Visible = false;
            btnCaluclateMyAge.BackColor = Color.Gold;
            this.BackColor = Color.OldLace;
            btnArabic.Enabled = true;
            btnEnglish.Enabled = true;
            MONTHS = 0;
            incrementSeconds = 0;

            lbResult.Text = 0.ToString()+" Years "+0.ToString()+" Months " +0.ToString()+" Days";
            lbMonth.Text = 0.ToString()+ " Months";
            lbWeeks.Text = 0.ToString() + " Weeks";
            lbDays.Text = 0.ToString() + " Days";
            lbHours.Text = 0.ToString() + " Hours";
            lbMinuts.Text = 0.ToString() + " Minuts";
            lbSeconds.Text = 0.ToString() + " Seconds";
            timer1.Stop();
            lbBirthday.Text = 0.ToString()+" Day (s)";
            label7.Text = "Your BirthDay Will Be IN :";
            lbBirthday.Location = new Point(305,420);

            cmbDay.Text = "Day";
            cmbYear.SelectedIndex = -1;
            cmbMonth.Text = "Month";
            cmbMonth.SelectedIndex = -1;
            cmbMonth.Text = "Month";
            cmbYear.Text = "Year";
            cmbYear.SelectedIndex = -1;
            
            btnCaluclateMyAge.Enabled = false;

            cmbDay.Enabled = true;
            cmbMonth.Enabled = true;
            cmbYear.Enabled = true;

            txtName.Text = "Name";
            txtName.ForeColor = Color.Gray;
            txtSurname.Text="Surname";
            txtSurname.ForeColor= Color.Gray;
            txtPassword.Text = "Password";
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.ForeColor = Color.Gray;
            btnEye.Enabled = false;


            

        }

        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable btnCalculateMyAge
            if (cmbYear.SelectedIndex > -1 && cmbMonth.SelectedIndex > -1 && cmbDay.SelectedIndex > -1)
            {
                btnCaluclateMyAge.Enabled = true;
            }
          


        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable btnCalculateMyAge
            if (cmbYear.SelectedIndex > -1 && cmbMonth.SelectedIndex > -1 && cmbDay.SelectedIndex > -1)
            {
                btnCaluclateMyAge.Enabled = true;
            }
            
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable btnCalculateMyAge
            if (cmbYear.SelectedIndex > -1 && cmbMonth.SelectedIndex > -1 && cmbDay.SelectedIndex > -1)
            {
                btnCaluclateMyAge.Enabled = true;
            }
            
        }

        private void btnArabic_Click(object sender, EventArgs e)
        {
            label9.Visible = true;      label1.Visible = false; label21.Visible = true;
            label10.Visible = true;     label2.Visible = false; label20.Visible = false;
            label11.Visible = true;     label3.Visible = false;
            label12.Visible = true;     label4.Visible = false;
            label13.Visible = true;     label5.Visible = false;
            label14.Visible = true;     label6.Visible = false;
            label17.Visible = true;     label7.Visible = false;
            label18.Visible = true;     label8.Visible = false;

            btnCaluclateMyAge.Text = "أحسب عمري";
            btnReset.Text = "تفريغ";
            lbBirthday.Text = "يوم 0";
            lbResult.Text = "سنة 0 شهر 0 يوم 0";
            lbMonth.Text = "شهر 0";
            lbWeeks.Text = "أسبوع 0";
            lbDays.Text = "يوم 0";
            lbHours.Text = "ساعة 0";
            lbMinuts.Text = "دقيقة 0";
            lbSeconds.Text = "ثانية 0";

            cmbDay.Text = "يوم";
            cmbMonth.Text = "شهر";
            cmbYear.Text = "سنة";
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            label9.Visible = false;  label1.Visible = true; label21.Visible = false;
            label10.Visible = false; label2.Visible = true; label20.Visible = true; ;
            label11.Visible = false; label3.Visible = true;
            label12.Visible = false; label4.Visible = true;
            label13.Visible = false; label5.Visible = true;
            label14.Visible = false; label6.Visible = true;
            label17.Visible = false; label7.Visible = true;
            label18.Visible = false; label8.Visible = true;

            btnCaluclateMyAge.Text = "Calculate My Age";
            btnReset.Text = "Reset";
            lbBirthday.Text = "0 Day (s)";
            lbResult.Text = "0 Years 0 Months 0 Days";
            lbMonth.Text = "0 Months";
            lbWeeks.Text = "0 Weeks";
            lbDays.Text = "0 Days";
            lbHours.Text = "0 Hours";
            lbMinuts.Text = "0 Minuts";
            lbSeconds.Text = "0 Seconds";

            cmbDay.Text = "Day";
            cmbMonth.Text = "Month";
            cmbYear.Text = "Year";



        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }



       


        private void btnSendToEmail_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtserver = new SmtpClient("smtp.live.com");
            mail.From = new MailAddress("gousef93royal@hotmail.com");

            Bitmap mybitmap = new Bitmap(660, 490);
            DrawToBitmap(mybitmap, new Rectangle(0, 0, mybitmap.Width, mybitmap.Height));
            mybitmap.Save(@"C:\Users\User\Desktop\Calculate my Age Pictures\n1.Jpeg", ImageFormat.Jpeg);
            try
            {
                mail.To.Add(txtEmail.Text);
                mail.Subject = "Calculate My Age Application";
                mail.Body ="Here is ( Your Calculation OF Your Age )";

            System.Net.Mail.Attachment att;
            att = new Attachment(@"C:\Users\User\Desktop\Calculate my Age Pictures\n1.Jpeg");
            mail.Attachments.Add(att);


            smtserver.Port = 587;
                smtserver.Credentials = new System.Net.NetworkCredential("gousef93royal@hotmail.com", "Yy94030209");
                smtserver.EnableSsl = true;
                smtserver.Send(mail);

                
                
                MessageBox.Show("Please Check Your Email ^_^");
            }
            catch
            {
                MessageBox.Show("Enter Your Email");
            }

            finally
            {
                command = new SqlCommand("Update  xx Set Email='"+ txtEmail.Text + "' Where Password='"+txtPassword.Text+"' ", connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }





        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            if (txtFeedbackName.Text=="")
            {
                MessageBox.Show("Enter Your Name");
            }

            else if (txtFeedbackCountry.Text=="")
            {
                MessageBox.Show("Enter Your Country");
            }

            else

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtserver = new SmtpClient("smtp.live.com");
                SmtpClient smtserver1 = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("feedback_age@hotmail.com");

            
                mail.To.Add("gousef93royal@hotmail.com");
                mail.Subject = "Feedback ^_^ >>> ";
                mail.Body = "Name: " + txtFeedbackName.Text + " Country: " + txtFeedbackCountry.Text+"\n" + richFeedback.Text ;


                smtserver.Port = 25;
                
                smtserver.Credentials = new System.Net.NetworkCredential("feedback_age@hotmail.com", "Yy94030209");
                smtserver.EnableSsl = true;
                smtserver.Send(mail);
               

                MessageBox.Show("Your Feedback has been sent");
            }
            catch
            {
                MessageBox.Show("Enter Your Name and Your Country");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void txtEmailFeedback_Enter(object sender, EventArgs e)
        {
            if (txtFeedbackName.Text =="Enter Your Name")
            {
                txtFeedbackName.Text = "";
                txtFeedbackName.ForeColor = Color.Blue;
                
            }
        }

        private void txtEmailFeedback_Leave(object sender, EventArgs e)
        {
            if (txtFeedbackName.Text=="")
            {
                txtFeedbackName.Text = "Enter Your Name";
                txtFeedbackName.ForeColor = Color.Gray;
            }
        }

        private void txtPasswordFeedback_Leave(object sender, EventArgs e)
        {
            if (txtFeedbackCountry.Text== "")
            {
                txtFeedbackCountry.Text = "Enter Your Password Email";
                txtFeedbackCountry.ForeColor = Color.Gray;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPasswordFeedback_Enter(object sender, EventArgs e)
        {
            if (txtFeedbackCountry.Text == "Enter Your Password Email")
            {
                txtFeedbackCountry.Text = "";
                txtFeedbackCountry.ForeColor = Color.Blue;
                txtFeedbackCountry.UseSystemPasswordChar = true;
                

            }
        }

        private void txtPasswordFeedback_TextChanged(object sender, EventArgs e)
        {

        }

        

        

        

      

        

        private void button1_Click_2(object sender, EventArgs e)
        {
            



        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.BlueViolet;

            }

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Name";
                txtName.ForeColor = Color.Gray;
            }

        }

        private void txtSurname_Enter(object sender, EventArgs e)
        {
            if (txtSurname.Text == "Surname")
            {
                txtSurname.Text = "";
                txtSurname.ForeColor = Color.BlueViolet;

            }

        }

        private void txtSurname_Leave(object sender, EventArgs e)
        {
            if (txtSurname.Text == "")
            {
                txtSurname.Text = "Surname";
                txtSurname.ForeColor = Color.Gray;
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtFeedbackCountry_Enter(object sender, EventArgs e)
        {
            if (txtFeedbackCountry.Text == "Enter Your Country")
            {
                txtFeedbackCountry.Text = "";
                txtFeedbackCountry.ForeColor = Color.Blue;

            }
        }

        private void txtFeedbackCountry_Leave(object sender, EventArgs e)
        {
            if (txtFeedbackCountry.Text == "")
            {
                txtFeedbackCountry.Text = "Enter Your Country";
                txtFeedbackCountry.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.BlueViolet;

            }


        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnEye.Enabled = true;

            command = new SqlCommand(" Select * From xx  Where Password='"+txtPassword.Text+"' and Name='"+txtName.Text+"' and Surname='"+txtSurname.Text+"' ", connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                    cmbDay.Text = reader[3].ToString();
                    cmbMonth.Text = reader[4].ToString();
                    cmbYear.Text = reader[5].ToString();
                    
            }

            
            reader.Close();
            connection.Close();

            //command = new SqlCommand("DELETE FROM   xx   WHERE  Password='" + txtPassword.Text + "' ", connection);
            //connection.Open();
            //command.ExecuteNonQuery();
            //connection.Close();

            

        }

        private void btnEye_MouseHover(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnEye_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //try
            //{
            //    command = new SqlCommand("Insert into xx(Password,Name,Surname,D,M,Y,Email) Values('" + txtPassword.Text + "','" + txtName.Text + "', '" + txtSurname.Text + "', '" + cmbDay.Text + "', '" + cmbMonth.Text + "', '" + cmbYear.Text + "', '"+txtEmail.Text+"' )", connection);
            //                connection.Open();
            //                command.ExecuteNonQuery();
            //                connection.Close();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Bye Bye ^_^ ");
            //}
            

        }

        private void TimerForNowTime_Tick(object sender, EventArgs e)
        {
            lbTimeNow.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCaluclateMyAge_MouseHover(object sender, EventArgs e)
        {
            btnCaluclateMyAge.BackColor = Color.Gray;
        }

        private void btnCaluclateMyAge_MouseLeave(object sender, EventArgs e)
        {
            btnCaluclateMyAge.BackColor = Color.Gold;
        }

        private void btnFacebook_MouseHover(object sender, EventArgs e)
        {
            btnFacebook.BackColor = Color.Gold;
        }

        private void btnFacebook_MouseLeave(object sender, EventArgs e)
        {
            btnFacebook.BackColor =Color.Gray;
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {

            txtEmail.Visible = false;
            btnSendToEmail.Visible = false;
            btnCaluclateMyAge.BackColor = Color.Gold;
            this.BackColor = Color.OldLace;
            btnArabic.Enabled = true;
            btnEnglish.Enabled = true;
            MONTHS = 0;
            incrementSeconds = 0;

            lbResult.Text = 0.ToString() + " Years " + 0.ToString() + " Months " + 0.ToString() + " Days";
            lbMonth.Text = 0.ToString() + " Months";
            lbWeeks.Text = 0.ToString() + " Weeks";
            lbDays.Text = 0.ToString() + " Days";
            lbHours.Text = 0.ToString() + " Hours";
            lbMinuts.Text = 0.ToString() + " Minuts";
            lbSeconds.Text = 0.ToString() + " Seconds";
            timer1.Stop();
            lbBirthday.Text = 0.ToString() + " Day (s)";
            label7.Text = "Your BirthDay Will Be IN :";
            lbBirthday.Location = new Point(305, 420);

            cmbDay.Text = "Day";
            cmbYear.SelectedIndex = -1;
            cmbMonth.Text = "Month";
            cmbMonth.SelectedIndex = -1;
            cmbMonth.Text = "Month";
            cmbYear.Text = "Year";
            cmbYear.SelectedIndex = -1;

            btnCaluclateMyAge.Enabled = false;

            cmbDay.Enabled = true;
            cmbMonth.Enabled = true;
            cmbYear.Enabled = true;

            txtName.Text = "Name";
            txtName.ForeColor = Color.Gray;
            txtSurname.Text = "Surname";
            txtSurname.ForeColor = Color.Gray;
            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.UseSystemPasswordChar = false;

        }

        
    }
}
