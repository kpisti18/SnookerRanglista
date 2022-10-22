using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnookerRanglista
{
    public partial class FormNyito : Form
    {
        static Adatbazis a = new Adatbazis();
        private bool rendez = false;

        public FormNyito()
        {
            InitializeComponent();
        }

        private void FormNyito_Load(object sender, EventArgs e)
        {
            adatbazisBeolvas();
            oszlopokMeghatarozasa();
            adattablaFrissit();
        }

        private void adatbazisBeolvas()
        {
            a.versenyzok.Clear();

            try
            {
                a.con.Open();
                a.cmd = a.con.CreateCommand();
                a.cmd.CommandText = $"SELECT * FROM `snooker` ORDER BY `helyezes` ASC;";

                using (MySqlDataReader dr = a.cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        try
                        {
                            a.versenyzok.Add(new Versenyzo(dr.GetInt32("Id"), dr.GetInt32("Helyezes"), dr.GetString("Nev"), dr.GetString("Orszag"),  dr.GetDecimal("Nyeremeny")));
                        }
                        catch (ArgumentException ex)
                        {
                            MessageBox.Show($"Az alábbi hiba lépett fel:\n{ex.Message}");
                        }
                    }
                }

                a.con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Az alábbi hiba lépett fel:\n{ex.Message}");
                Environment.Exit(0);
            }
        }

        private void adattablaFrissit()
        {
            dataGridViewVersenyzo.Rows.Clear();

            foreach (Versenyzo item in a.versenyzok)
            {
                int sorszam = dataGridViewVersenyzo.Rows.Add();
                DataGridViewRow sor = dataGridViewVersenyzo.Rows[sorszam];

                sor.Cells["id"].Value = item.Id;
                sor.Cells["helyezes"].Value = item.Helyezes;
                sor.Cells["nev"].Value = item.Nev;
                sor.Cells["orszag"].Value = item.Orszag;
                sor.Cells["nyeremeny"].Value = item.Nyeremeny;
            }
        }

        private void oszlopokMeghatarozasa()
        {
            dataGridViewVersenyzo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVersenyzo.MultiSelect = false;
            dataGridViewVersenyzo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVersenyzo.EnableHeadersVisualStyles = false;
            dataGridViewVersenyzo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVersenyzo.ColumnHeadersDefaultCellStyle.BackColor = Color.Beige;
            dataGridViewVersenyzo.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewVersenyzo.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
            dataGridViewVersenyzo.RowTemplate.DefaultCellStyle.Padding = new Padding(1, 1, 1, 1);

            DataGridViewColumn colID = new DataGridViewColumn();
            {
                colID.Name = "id";
                colID.HeaderText = "ID";
                colID.CellTemplate = new DataGridViewTextBoxCell();
                colID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            dataGridViewVersenyzo.Columns.Add(colID);
            this.dataGridViewVersenyzo.Columns[0].Visible = false;

            DataGridViewColumn colHelyezes = new DataGridViewColumn();
            {
                colHelyezes.Name = "helyezes";
                colHelyezes.HeaderText = "Helyezés";
                colHelyezes.CellTemplate = new DataGridViewTextBoxCell();
                colHelyezes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            dataGridViewVersenyzo.Columns.Add(colHelyezes);

            DataGridViewColumn colNev = new DataGridViewColumn();
            {
                colNev.Name = "nev";
                colNev.HeaderText = "Név";
                colNev.CellTemplate = new DataGridViewTextBoxCell();
                colNev.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            dataGridViewVersenyzo.Columns.Add(colNev);

            DataGridViewColumn colOrszag = new DataGridViewColumn();
            {
                colOrszag.Name = "orszag";
                colOrszag.HeaderText = "Ország";
                colOrszag.CellTemplate = new DataGridViewTextBoxCell();
                colOrszag.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            dataGridViewVersenyzo.Columns.Add(colOrszag);

            DataGridViewColumn colNyeremeny = new DataGridViewColumn();
            {
                colNyeremeny.Name = "nyeremeny";
                colNyeremeny.HeaderText = "Nyermény";
                colNyeremeny.CellTemplate = new DataGridViewTextBoxCell();
                colNyeremeny.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            dataGridViewVersenyzo.Columns.Add(colNyeremeny);
        }

        private void dataGridViewVersenyzo_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewVersenyzo.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow kivalasztottSor = dataGridViewVersenyzo.SelectedRows[0];

            if (kivalasztottSor.Cells["helyezes"].Value != null)
            {
                tbID.Text = kivalasztottSor.Cells["id"].Value.ToString();
                tbHelyezes.Text = kivalasztottSor.Cells["helyezes"].Value.ToString();
                tbNev.Text = kivalasztottSor.Cells["nev"].Value.ToString();
                tbOrszag.Text = kivalasztottSor.Cells["orszag"].Value.ToString();
                numericUpDownNyeremeny.Value = decimal.Parse(kivalasztottSor.Cells["nyeremeny"].Value.ToString());
            }
        }

        private void dataGridViewVersenyzo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (rendez)
            {
                this.dataGridViewVersenyzo.Sort(this.dataGridViewVersenyzo.Columns[e.ColumnIndex], ListSortDirection.Ascending);
            }
            else
            {
                this.dataGridViewVersenyzo.Sort(this.dataGridViewVersenyzo.Columns[e.ColumnIndex], ListSortDirection.Descending);
            }
            rendez = !rendez;
        }

        private void btModosit_Click(object sender, EventArgs e)
        {
            modositGomb();
            adatbazisBeolvas();
            adattablaFrissit();
        }

        private void modositGomb()
        {
            try
            {
                nyeremenyKicserelese();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Az alábbi hiba lépett fel:\n{ex.Message}");
            }

            adatbazisBeolvas();
            adattablaFrissit();
        }

        private void nyeremenyKicserelese()
        {
            a.con.Open();
            a.cmd.Parameters.Clear();
            a.cmd = a.con.CreateCommand();
            a.cmd.CommandText = $"UPDATE `snooker` SET `Nyeremeny`= @osszeg WHERE `id`= @id;";
            a.cmd.Parameters.AddWithValue("@id", tbID.Text);
            a.cmd.Parameters.AddWithValue("@osszeg", numericUpDownNyeremeny.Value);

            if (a.cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("A nyeremény módosítása megtörtént.");
                tbHelyezes.Text = "";
                tbNev.Text = "";
                tbOrszag.Text = "";
                numericUpDownNyeremeny.Value = numericUpDownNyeremeny.Minimum;
            }
            else
            {
                MessageBox.Show("Sikertelen", "Hiba");
            }
            a.con.Close();
        }
    }
}
