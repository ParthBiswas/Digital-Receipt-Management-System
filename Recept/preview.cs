using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Recept
{
    public partial class preview : Form
    {
        OdbcConnection con = new OdbcConnection("Dsn=bintpex");
        OdbcCommand mcd;
        public preview()
        {
            InitializeComponent();

            cusid.CharacterCasing = CharacterCasing.Upper;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Tloade ()
        {
            try
            {
                string query = "SELECT ID, Memid, cusname, amt, TRMODE, Trid FROM Rec WHERE cusid = ? AND reg_date= ?";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.Parameters.AddWithValue("@cusid", cusid.Text);
                cmd.Parameters.AddWithValue("@reg_date", Convert.ToDateTime(date.Text));

                con.Open();
                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Memid.Text = reader["Memid"].ToString(); // Make sure `memberid` TextBox exists
                    cusname.Text = reader["cusname"].ToString();    // Optional label to show name
                    amt.Text = reader["amt"].ToString(); // Optional
                    Tmode.Text = reader["TRMODE"].ToString();
                    reno.Text = reader["ID"].ToString();
                    trid.Text = reader["trid"].ToString();
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void cusid_TextChanged(object sender, EventArgs e)
        {
           

           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tloade();
        }

        private Bitmap CaptureFormImage()
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            return bmp;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Capture the form as image
                Bitmap receiptImage = CaptureFormImage();

                // 2. Save the image temporarily
                string filePath = System.IO.Path.Combine(Application.StartupPath, "receipt.png");
                receiptImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                // 3. Notify user and open WhatsApp Web
                MessageBox.Show("Receipt image saved. Opening WhatsApp Web...");
                System.Diagnostics.Process.Start("https://web.whatsapp.com");

                // Optional: Open folder where image is saved
                System.Diagnostics.Process.Start("explorer.exe", "/select," + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
