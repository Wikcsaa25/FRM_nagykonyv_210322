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
    public partial class FRMLista : Form
    {
        static string connectionString = @"Server = (localdb)\MSSQLLocalDB;" +
            @"AttachDbFileName=|DataDirectory|Resources\nagykonyv.mdf;";
        static SqlConnection connection = new SqlConnection(connectionString);
        public FRMLista()
        {
            //kezdés: 2021.03.22. 11:30
            //befejezés: 2021.03.22. 14:35
            InitializeComponent();
            Betolt();
        }
        private List<string[]> dgwBackup = new List<string[]>();
        private void Betolt()
        {
            dgwKonyv.Rows.Clear();
            connection.Open();
            SqlDataReader sqlComm = new SqlCommand($"select konyv.id, konyv.helyezes, szerzo.nev, konyv.cim from konyv, szerzo where konyv.szerzoId = szerzo.id order by helyezes;", connection).ExecuteReader();
            while (sqlComm.Read())
            {
                dgwKonyv.Rows.Add(sqlComm[0], sqlComm[1], sqlComm[2], sqlComm[3]);
                dgwBackup.Add(new string[] { sqlComm[0].ToString(), sqlComm[1].ToString(), sqlComm[2].ToString(), sqlComm[3].ToString() });
            }
            connection.Close();
        }
        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            List<string[]> results = new List<string[]>();
            foreach (string[] item in dgwBackup)
            {
                if (item[2].ToLower().Contains(searchTB.Text.ToLower()) || item[3].ToLower().Contains(searchTB.Text.ToLower()))
                {
                    results.Add(item);
                }
            }
            dgwKonyv.Rows.Clear();
            foreach (string[] item in results)
            {
                dgwKonyv.Rows.Add(item);
            }
        }

        private void újKönyvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMKonyv frm = new FRMKonyv(connectionString, Frissites);
            frm.ShowDialog();
        }

        private void dgwKonyv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FRMKonyv frm1 = new FRMKonyv(connectionString, dgwKonyv.Rows[e.RowIndex].Cells[0].Value, Frissites);
            frm1.ShowDialog();
        }

        private void Frissites()
        {
            Betolt();
        }
    }
}
