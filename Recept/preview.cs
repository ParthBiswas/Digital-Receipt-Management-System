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
        List<DataRow> results = new List<DataRow>();
        int currentIndex = 0;

        public preview()
        {
            InitializeComponent();

            cusid.CharacterCasing = CharacterCasing.Upper;
            Memid.CharacterCasing = CharacterCasing.Upper;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Tloade ()
        {
            try
            {
                if (results.Count == 0)
                {
                    string query = "SELECT ID, cusname, amt, TRMODE, Trid FROM Rec WHERE Memid= ? AND cusid = ? AND reg_date= ?";
                OdbcCommand cmd = new OdbcCommand(query, con);
                    cmd.Parameters.AddWithValue("@Memid", Memid.Text);
                cmd.Parameters.AddWithValue("@cusid", cusid.Text);
                cmd.Parameters.AddWithValue("@reg_date", Convert.ToDateTime(date.Text));

                    OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                {
                        MessageBox.Show("No records found.");
                        return;
                    }

                    results = dt.AsEnumerable().ToList();
                    currentIndex = 0;
                }

                if (results.Count > 0 && currentIndex < results.Count)
                {
                    DataRow row = results[currentIndex];
                    cusname.Text = row["cusname"].ToString();
                    amt.Text = row["amt"].ToString();
                    Tmode.Text = row["TRMODE"].ToString();
                    reno.Text = row["ID"].ToString();
                    trid.Text = row["Trid"].ToString();

                    currentIndex++;
                    if (currentIndex >= results.Count)
                {
                        MessageBox.Show("End of records. Restarting...");
                        currentIndex = 0; // Loop back to first
                    }
                }

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
