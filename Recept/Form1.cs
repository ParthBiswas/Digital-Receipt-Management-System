using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Odbc;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Recept
{
    public partial class Form1 : Form
    {
        OdbcConnection con = new OdbcConnection("Dsn=bintpex");
        OdbcCommand mcd;
        public Form1()
        {
            InitializeComponent();

            cusid.CharacterCasing = CharacterCasing.Upper;
            Memid.CharacterCasing = CharacterCasing.Upper;
            cusname.CharacterCasing = CharacterCasing.Upper;
            amt.CharacterCasing = CharacterCasing.Upper;
            TRMODE.CharacterCasing = CharacterCasing.Upper;
            trid.CharacterCasing = CharacterCasing.Upper;
            Trtype.CharacterCasing = CharacterCasing.Upper;
            sendby.CharacterCasing = CharacterCasing.Upper;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void Data_set()
        {
            mcd = con.CreateCommand();
            mcd.CommandText = "INSERT INTO Rec (Memid, cusid, cusname, amt, Trtype, TRMODE, sendby, trid, dese) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
            mcd.Parameters.AddWithValue("@Memid", Memid.Text);
            mcd.Parameters.AddWithValue("@cusid", cusid.Text);
            mcd.Parameters.AddWithValue("@cusname", cusname.Text);
            mcd.Parameters.AddWithValue("@amt", amt.Text);
            mcd.Parameters.AddWithValue("@Trtype", Trtype.Text);
            mcd.Parameters.AddWithValue("@TRMODE", TRMODE.Text);
            mcd.Parameters.AddWithValue("@sendby", sendby.Text);
            mcd.Parameters.AddWithValue("@trid", trid.Text);
            mcd.Parameters.AddWithValue("@dese", dese.Text);
            //Execute SQL command
            opencon();
            mcd.ExecuteNonQuery();
            closecon();
        }

        private void ClearFields()
        {
            Memid.Text = "";
            cusid.Text = "";
            cusname.Text = "";
            amt.Text = "";
            Trtype.Text = "";
            TRMODE.Text = "";
            sendby.Text = "";
            trid.Text = "";
            dese.Text = "";
        }
        private void opencon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void closecon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            Data_set();
            ClearFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form h = new preview();
            h.Show();
        }

        
    }
}
