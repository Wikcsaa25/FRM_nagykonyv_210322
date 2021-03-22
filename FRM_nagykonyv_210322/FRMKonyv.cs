using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRM_nagykonyv_210322
{
    public partial class FRMKonyv : Form
    {
        string connectionString;
        SqlConnection connection;
        Action frissites;
        public FRMKonyv(string connectionString, object id, Action frissites)
        {
            this.frissites = frissites;
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
            InitializeComponent();
            CbFeltoltes();
            KonyvAdatok(id.ToString());
        }
        public FRMKonyv(string connectionString, Action frissites)
        {
            this.frissites = frissites;
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
            InitializeComponent();
            IdText();
            CbFeltoltes();
        }
        private void CbFeltoltes()
        {
            connection.Open();
            SqlDataReader comm = new SqlCommand($"select nev from szerzo order by id;", connection).ExecuteReader();
            while (comm.Read())
            {
                szerzoCB.Items.Add(comm[0]);
            }
            connection.Close();
        }
        private void KonyvAdatok(string id)
        {
            rogzitBTN.Enabled = false;
            connection.Open();
            SqlDataReader comm = new SqlCommand($"select konyv.id, szerzo.nev, konyv.cim, konyv.helyezes from konyv, szerzo " +
                $"where szerzo.id = konyv.szerzoId and konyv.id = {id}", connection).ExecuteReader();
            while (comm.Read())
            {
                idTB.Text = comm[0].ToString();
                szerzoCB.SelectedItem = comm[1];
                cimTB.Text = (string)comm[2];
                helyezesTB.Text = comm[3].ToString();
            }
            connection.Close();
        }
        private void IdText()
        {
            modositBTN.Enabled = false;
            torolBTN.Enabled = false;
            connection.Open();
            SqlDataReader comm = new SqlCommand($"select top 1 id from konyv order by id desc;", connection).ExecuteReader();
            comm.Read();
            idTB.Text = ((int)comm[0] + 1).ToString();
            connection.Close();
        }
        private bool BTNClick()
        {
            DialogResult valasz = MessageBox.Show("Biztosan rá szerettél volna nyomni?", "Rányomna?", MessageBoxButtons.YesNo);
            return valasz == DialogResult.Yes;
        }

        private void rogzitBTN_Click(object sender, EventArgs e)
        {
            if (BTNClick())
            {
                if (idTB.Text != null && szerzoCB.SelectedItem != null && cimTB.Text != null && helyezesTB.Text != null)
                {
                    connection.Open();
                    SqlDataReader comm = new SqlCommand($"insert into konyv (id, szerzoId, cim, helyezes) values({idTB.Text}, {szerzoCB.SelectedIndex + 1}, " +
                        $"'{cimTB.Text}', '{helyezesTB.Text}')", connection).ExecuteReader();
                    connection.Close();
                    Form.ActiveForm.Close();
                }
                else
                {
                    MessageBox.Show("Valami nem jó!");
                }
            }
        }

        private void FRMKonyv_FormClosing(object sender, FormClosingEventArgs e)
        {
            frissites.Invoke();
        }

        private void modositBTN_Click(object sender, EventArgs e)
        {
            if (BTNClick())
            {
                if (idTB.Text != null && szerzoCB.SelectedItem != null && cimTB.Text != null && helyezesTB.Text != null)
                {
                    connection.Open();
                    SqlDataReader comm = new SqlCommand($"update konyv set szerzoId = {szerzoCB.SelectedIndex + 1}," +
                        $"cim = '{cimTB.Text}', helyezes = '{helyezesTB.Text}' where id = {idTB.Text};", connection).ExecuteReader();
                    connection.Close();
                    Form.ActiveForm.Close();
                }
                else
                {
                    MessageBox.Show("Valami nem jó!");
                }
            }
        }

        private void torolBTN_Click(object sender, EventArgs e)
        {
            if (BTNClick())
            {
                connection.Open();
                SqlDataReader comm = new SqlCommand($"delete from konyv where id = {idTB.Text};", connection).ExecuteReader();
                connection.Close();
                Form.ActiveForm.Close();
            }
        }
    }
}
