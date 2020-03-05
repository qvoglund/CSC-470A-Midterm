using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Midterm
{
    public partial class frmRecArea : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\source\\repos\\Midterm\\Midterm\\MidtermDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataReader rdr;
        public frmRecArea()
        {
            InitializeComponent();
        }

        private void frmRecArea_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midtermDBDataSet.peopleArea' table. You can move, or remove it, as needed.
            this.peopleAreaTableAdapter.Fill(this.midtermDBDataSet.peopleArea);
           // updateGrid();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double length, width, area;
            if (validTxt())
            {
                try
                {
                    length = Convert.ToDouble(tbxLength.Text);
                    width = Convert.ToDouble(tbxWidth.Text);
                    area = Math.Round((length * width), 2);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Invalid length are width entry!");
                    return;
                }
                String selectAid = "SELECT AId from people WHERE AFname = @AFname AND ALname = @ALname AND AEmail = @AEmail";
                cmd = new SqlCommand(selectAid, conn);
                cmd.Parameters.AddWithValue("@AFname", tbxFname.Text);
                cmd.Parameters.AddWithValue("@ALname", tbxLname.Text);
                cmd.Parameters.AddWithValue("@AEmail", tbxEmail.Text);
                cmd.Parameters.AddWithValue("@ALength", length);
                cmd.Parameters.AddWithValue("@AWidth", width);
                cmd.Parameters.AddWithValue("@AArea", area);

                conn.Open();
                rdr = cmd.ExecuteReader();

                String insertAreaQuery = "INSERT INTO area (AId, ALength, AWidth, AArea) VALUES (@AId, @ALength, @AWidth, @AArea)";
                String insertPeopleQuery = "INSERT INTO people (AFname, ALname, AEmail) VALUES (@AFname, @ALname, @AEmail)";

                if (rdr.Read())
                {
                    getAid(insertAreaQuery);
                }
                else
                {
                    conn.Close();
                    cmd.CommandText = insertPeopleQuery;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    cmd.CommandText = selectAid;
                    conn.Open();
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    getAid(insertAreaQuery);

                }
                clearForm();
                updateGrid();

            }
            else
            {
                MessageBox.Show("Invalid data entry!");
            }
        }

        public void getAid(String insert)
        {
            cmd.CommandText = insert;
            cmd.Parameters.AddWithValue("@AId", rdr["AId"]);
            conn.Close();

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void updateGrid()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM area, people WHERE area.AId = people.AId ORDER BY people.AId", conn);
            sda.Fill(dt);
            peopleAreaDataGridView.DataSource = dt;
        }

        public void clearForm()
        {
            tbxFname.Text = "";
            tbxLname.Text = "";
            tbxEmail.Text = "";
            tbxLength.Text = "";
            tbxWidth.Text = "";
        }

        private Boolean validTxt()
        {
            return tbxFname.Text != "" && tbxLname.Text != "" && tbxEmail.Text != "";
        }
    }
}
