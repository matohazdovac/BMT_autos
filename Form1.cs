using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;


namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Sva polja moraju biti popunjena", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (textBox6.Text.Length < 8)
                {
                    MessageBox.Show("Lozinka mora sadržavati minimalno 8 znakova", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (textBox6.Text != textBox7.Text)
                    {
                        MessageBox.Show("Lozinke se ne podudaraju", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        if (int.TryParse(textBox5.Text, out int n) && int.TryParse(textBox5.Text, out int a))
                        {
                            try
                            {
                                OdbcConnection baza = new OdbcConnection("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;PORT=3306;DATABASE=bmt; USER ID=root;PASSWORD=;");
                                baza.Open();
                                string sql = "INSERT INTO `korisnik`(`dat_rod`, `broj_mobitela`, `ime`, `mail`, `pbr_mjesto`, `prezime`, `username`, `password`) " +
                                            "VALUES ( NULL,'" + textBox4.Text + "', '" + textBox1.Text + "','" + textBox3.Text + "','" + textBox5.Text + "', '" + textBox2.Text + "', NULL ,'" + textBox7.Text + "');";
                                OdbcCommand command = new OdbcCommand(sql, baza);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Uspjesno", "Uspjesno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Form2 obj1 = new Form2();
                                obj1.ShowDialog();
                                this.Hide();
                               

                            }
                            catch
                            {
                                MessageBox.Show("Došlo je do greške u vezi!.\n Provjerite vezu s internetom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Unutar polja broj telefona i poštanski broj, ne smijete unosit ništa osim brojeva", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }


                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (e.CloseReason == CloseReason.ApplicationExitCall) return;

            Application.Exit();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }
    }
}

