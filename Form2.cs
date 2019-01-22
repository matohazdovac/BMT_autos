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
using System.Threading;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            OdbcConnection baza = new OdbcConnection("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;PORT=3306;DATABASE=bmt; USER ID=root;PASSWORD=;");
            baza.Open();
            string sql = "SELECT DISTINCT marka_auta FROM oglas;";
            OdbcCommand command = new OdbcCommand(sql, baza);
            OdbcDataReader auti =  command.ExecuteReader();
            List<string> lista = new List<string>();
            lista.Add(" ");
            while (auti.Read())
            {
                lista.Add(auti[0].ToString());
            }
            comboBox1.DataSource = lista;
            baza.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string marka = comboBox1.GetItemText(comboBox1.SelectedItem);
            string sql = "SELECT DISTINCT model_auta FROM oglas WHERE marka_auta ='" + marka + "';";
            OdbcConnection baza = new OdbcConnection("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;PORT=3306;DATABASE=bmt; USER ID=root;PASSWORD=;");
            baza.Open();
            OdbcCommand command = new OdbcCommand(sql, baza);
            OdbcDataReader auti = command.ExecuteReader();
            List<string> lista = new List<string>();
            lista.Add(" ");
            while (auti.Read())
            {
                lista.Add(auti[0].ToString());
            }
            comboBox2.DataSource = lista;
            baza.Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            OdbcConnection baza = new OdbcConnection("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;PORT=3306;DATABASE=bmt; USER ID=root;PASSWORD=;");
            baza.Open();
            string marka = comboBox1.GetItemText(comboBox1.SelectedItem);
            string model = comboBox2.GetItemText(comboBox2.SelectedItem);
            string min = comboBox3.GetItemText(comboBox3.SelectedItem);
            string max = comboBox4.GetItemText(comboBox4.SelectedItem);
            if (marka == " " || model == " ")
            {
                MessageBox.Show("Izaberite proizvođača i model", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                if(Int32.Parse(min) == Int32.Parse(max))
                {
                    string sql = "SELECT marka_auta, model_auta, godina_proizvodnje, kilometri, cijena FROM oglas WHERE marka_auta = '" + marka + "' AND model_auta = '" + model + "' AND cijena>=" + min +";";
                    OdbcCommand command = new OdbcCommand(sql, baza);
                    OdbcDataReader auti = command.ExecuteReader();
                    Form4 f4 = new Form4(auti);
                    baza.Close();
                    this.Hide();
                    f4.ShowDialog();
                }
                /*else
                {
                    string sql = "SELECT marka_auta, model_auta, godina_proizvodnje, kilometri, cijena FROM oglas WHERE marka_auta = '" + marka + "' AND model_auta = '" + model + "' AND cijena>" + min + " AND cijena<" + max + ";";
                    OdbcDataAdapter dadapter = new OdbcDataAdapter(sql, baza);
                    Form4 f4 = new Form4(dadapter);
                    baza.Close();
                    this.Hide();
                    f4.ShowDialog();
                }*/
                
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string marka = comboBox1.GetItemText(comboBox1.SelectedItem);
            string model = comboBox2.GetItemText(comboBox2.SelectedItem);
            OdbcConnection baza = new OdbcConnection("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;PORT=3306;DATABASE=bmt; USER ID=root;PASSWORD=;");
            string sql = "SELECT DISTINCT cijena FROM oglas WHERE marka_auta ='" + marka + "' AND model_auta ='" + model + "'";
            baza.Open();
            OdbcCommand command = new OdbcCommand(sql, baza);
            OdbcDataReader auti = command.ExecuteReader();
            List<string> lista = new List<string>();
            lista.Add(" ");
            while (auti.Read())
            {
                lista.Add(auti[0].ToString());
            }
            comboBox3.DataSource = lista;
            comboBox4.DataSource = lista;
            baza.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (e.CloseReason == CloseReason.ApplicationExitCall) return;

            Application.Exit();




        }



    }
}
