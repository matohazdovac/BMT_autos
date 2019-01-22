using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Threading;
namespace WindowsFormsApp8
{
    public partial class Form3 : Form
    {
        int i;
        String usr;
        String passw;
        OdbcConnection baza = new OdbcConnection("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;PORT=3306;DATABASE=bmt; USER ID=root;PASSWORD=;");
        Thread th;
        public Form3()
        {
            InitializeComponent();
            Init_Data();
            baza.Open();
        }
        private int login_Check(String usr,String pass) {
            string sql  = "select mail, password from Korisnik where mail='" + usr + "' and password='" + pass + "'";
            OdbcCommand command = new OdbcCommand(sql, baza);
            OdbcDataReader auti = command.ExecuteReader();
            auti.Read();
            if((auti[0].ToString()) == usr && (auti[1].ToString() == pass))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void login_Click(object sender, EventArgs e)
        {
            usr = (String)email.Text;
            passw = (String)pass.Text;
            Save_Data();
            if(string.IsNullOrEmpty(usr) || string.IsNullOrEmpty(passw)){
                MessageBox.Show("Polje nesmije biti prazno!","Error",MessageBoxButtons.OK);
            }
            else if (login_Check(usr, passw) == 0)
            {
                MessageBox.Show("Unijeli ste krivi mail ili lozinku!", "Error", MessageBoxButtons.OK);
            }
            else {
                this.Close();
                th = new Thread(openNewForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }
        private void openNewForm(object obj) {
            Application.Run(new Form2());
        }
        private void openNewForm1(object obj)
        {
            Application.Run(new Form1());
        }
        private void email_TextChanged(object sender, EventArgs e)
        {

        }
        private void Init_Data() {
            if (Properties.Settings.Default.UserName != "Email")
            {
                email.Text = Properties.Settings.Default.UserName;
                pass.Text = Properties.Settings.Default.Password;
                rember.Checked = true;
            }
            else
            {
                email.Text = Properties.Settings.Default.UserName;
                pass.Text = Properties.Settings.Default.Password;
            }
        }


        private void Save_Data() {
            if (rember.Checked)
            {
                Properties.Settings.Default.UserName = email.Text;
                Properties.Settings.Default.Password = pass.Text;
                Properties.Settings.Default.Save();
            }
            else {
                Properties.Settings.Default.UserName = "Email";
                Properties.Settings.Default.Password = "Password";
                Properties.Settings.Default.Save();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (e.CloseReason == CloseReason.ApplicationExitCall) return;

            Application.Exit();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Close();
        }
    }
     
}
