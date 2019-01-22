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
    public partial class Form4 : Form
    {
        public Form4(OdbcDataReader dadapter)
        {
            int j = 0;
            InitializeComponent();
            while (dadapter.Read())
            {
                
                for(int i = 0; i<5; i++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = dadapter[i].ToString();
                    
                }
                j++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
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
