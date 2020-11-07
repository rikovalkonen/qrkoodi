using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using CG.Web.MegaApiClient;
using Newtonsoft.Json;
using System.Drawing.Imaging;
using System.IO;
using MySql;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using Ionic.Zip;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Configuration;



namespace Backend
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private string connectionString;

        bool DEBUG_MODE = true;
        
        
        //declaring array 
        List<string> product_codes = new List<string>();

        public int rows;
       
       
        public Form1()
        {
            

            InitializeComponent();




            
            connectionString = ConfigurationManager.ConnectionStrings["DBconnString"].ConnectionString; 
               

            connection = new MySqlConnection(connectionString: connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Start_mysql()
        {
            try
            {
                connection.Open();


                MessageBox.Show("Database connection ready.");

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + connectionString);
            }
        }

        private void Found_folder (string path)

       

        {
            try
            {
                if (!Directory.Exists(path))
                {
                    
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
            }
            catch (IOException ioex)
            {
                MessageBox.Show("Folder not exist and cannot be created."+ ioex);
            }

        }



        private void Generate()
        {
            
           
            string folder_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\qr";
            string dest_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\qr\qr.png";
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\qr\qr.png";
            Found_folder(folder_path);


            //deleting empty strings from codes list
            var count = product_codes.Count;
            for (var i = count - 1; i > -1; i--)
            {
                if (product_codes[i] == string.Empty) product_codes.RemoveAt(i);
            }
            
            product_codes = product_codes.Distinct().ToList();

            int o = product_codes.Count;
            int num = 0;
            
            MessageBox.Show("Loading codes from database...");
            try {
               
                for (var i = 0; i < o;)
                {
                    
                    string koodi = product_codes[num];
                    

                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\qr\" + koodi + ".png";

                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(koodi.ToString(), QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new QRCode(qrCodeData);
                    Bitmap qrCodeImage = qrCode.GetGraphic(20);

                    qrCodeImage.Save(koodi + ".png", ImageFormat.Png);
                    FileInfo img = new FileInfo(koodi + ".png");
                    img.MoveTo(path);

                    i++;
                    num++;
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show("Error saving Qr-Code images" + error);
                return;
            }finally
            {
                MessageBox.Show("Qr-Codes made successfully","All done");
            }







        }

        public void progress_code_upload_hoodie ()
        {
            progressBar1.Minimum = 0;
            int intValue = 0;
            if (!Int32.TryParse(amountbox.Text, out intValue))
            {
                MessageBox.Show("Please input numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int i = 0;
            progressBar1.Maximum = i;
            progressBar1.Value = 1;
            progressBar1.Step = 1;
            while (i < intValue)
            {
                i++;

                progressBar1.PerformStep();

                char[] chars =
              "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
                byte[] data = new byte[10];
                using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
                {
                    crypto.GetBytes(data);
                }
                StringBuilder result = new StringBuilder(10);
                foreach (byte b in data)
                {
                    result.Append(chars[b % (chars.Length)]);
                }
                string code = result.ToString();


                try
                {

                   

                    string time = DateTime.Now.ToString("yyyyMMdd");
                    int datenow = Convert.ToInt32(time);

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {


                        connection.Open();
                        MySqlCommand command = new MySqlCommand(null, connection);
                        command.CommandText = "INSERT INTO clothes(datetime,hoodies)" + " VALUES(?datetime,?hoodies)";

                        MySqlParameter date = new MySqlParameter("?datetime", MySqlDbType.Int32);
                        MySqlParameter tshirt = new MySqlParameter("?hoodies", MySqlDbType.VarChar);
                        date.Value = datenow;
                        
                        command.Parameters.AddWithValue("?datetime", datenow);
                        command.Parameters.AddWithValue("?hoodies", code);

                        command.Prepare();
                        command.ExecuteNonQuery();


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                }

                if (i == intValue)
                {
                    MessageBox.Show("Codes uploaded to database successfully.");
                }
            }

            

           

           

        }

        public void progress_code_upload()
        {
            progressBar1.Minimum = 0;
            

            int intValue = 0;
            if (!Int32.TryParse(amountbox.Text, out intValue))
            {
                MessageBox.Show("Please input numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int i = 0;
           
            while (i < intValue)
            {
                i++;

                char[] chars =
              "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
                byte[] data = new byte[10];
                using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
                {
                    crypto.GetBytes(data);
                }
                StringBuilder result = new StringBuilder(10);
                foreach (byte b in data)
                {
                    result.Append(chars[b % (chars.Length)]);
                }
                string code = result.ToString();


                try
                {

                 
                    string time = DateTime.Now.ToString("yyyyMMdd");
                    int datenow = Convert.ToInt32(time);

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {


                        connection.Open();
                        MySqlCommand command = new MySqlCommand(null, connection);
                        command.CommandText = "INSERT INTO clothes(datetime,tshirts)" + " VALUES(?datetime,?tshirts)";

                        MySqlParameter date = new MySqlParameter("?datetime", MySqlDbType.Int32);
                        MySqlParameter tshirt = new MySqlParameter("?tshirts", MySqlDbType.VarChar);
                        date.Value = datenow;
                        


                        command.Parameters.AddWithValue("?datetime", datenow);
                        command.Parameters.AddWithValue("?tshirts", code);

                        command.Prepare();
                        command.ExecuteNonQuery();


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                }

                if (i == intValue)
                {
                    MessageBox.Show("Codes uploaded to database successfully.");
                }
            }





           

           

        }

        public void progress_code_upload_shoes()
        {
            
            

            int intValue = 0;
            if (!Int32.TryParse(amountbox.Text, out intValue))
            {
                MessageBox.Show("Please input numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int i = 0;
           
            while (i < intValue)
            {
                i++;


                char[] chars =
              "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
                byte[] data = new byte[10];
                using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
                {
                    crypto.GetBytes(data);
                }
                StringBuilder result = new StringBuilder(10);
                foreach (byte b in data)
                {
                    result.Append(chars[b % (chars.Length)]);
                }
                string code = result.ToString();


                try
                {



                    string time = DateTime.Now.ToString("yyyyMMdd");
                    int datenow = Convert.ToInt32(time);

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {


                        connection.Open();
                        MySqlCommand command = new MySqlCommand(null, connection);
                        command.CommandText = "INSERT INTO clothes(datetime,shoes)" + " VALUES(?datetime,?shoes)";

                        MySqlParameter date = new MySqlParameter("?datetime", MySqlDbType.Int32);
                        MySqlParameter tshirt = new MySqlParameter("?shoes", MySqlDbType.VarChar);
                        date.Value = datenow;

                        command.Parameters.AddWithValue("?datetime", datenow);
                        command.Parameters.AddWithValue("?shoes", code);

                        command.Prepare();
                        command.ExecuteNonQuery();


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (DEBUG_MODE == true)
                    {
                        Console.WriteLine(ex);
                    }
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                }

                if (i == intValue)
                {
                    MessageBox.Show("Codes uploaded to database successfully.");
                }
            }





          

         
            
        }

        public void progress_code_upload_pants()
        {

            progressBar1.Minimum = 0;
            int intValue = 0;
            if (!Int32.TryParse(amountbox.Text, out intValue))
            {
                MessageBox.Show("Please input numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int i = 0;
           
            while (i < intValue)
            {
                i++;

              

                char[] chars =
              "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
                byte[] data = new byte[10];
                using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
                {
                    crypto.GetBytes(data);
                }
                StringBuilder result = new StringBuilder(10);
                foreach (byte b in data)
                {
                    result.Append(chars[b % (chars.Length)]);
                }
                string code = result.ToString();


                try
                {



                    string time = DateTime.Now.ToString("yyyyMMdd");
                    int datenow = Convert.ToInt32(time);

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {


                        connection.Open();
                        MySqlCommand command = new MySqlCommand(null, connection)
                        {
                            CommandText = "INSERT INTO clothes(datetime,pants)" + " VALUES(?datetime,?pants)"
                        };

                        MySqlParameter date = new MySqlParameter("?datetime", MySqlDbType.Int32);
                        MySqlParameter tshirt = new MySqlParameter("?pants", MySqlDbType.VarChar);
                        date.Value = datenow;

                        command.Parameters.AddWithValue("?datetime", datenow);
                        command.Parameters.AddWithValue("?pants", code);

                        command.Prepare();
                        command.ExecuteNonQuery();


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (DEBUG_MODE == true)
                    {
                        Console.WriteLine(ex);
                    }
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                }

                if (i == intValue)
                {
                    MessageBox.Show("Codes uploaded to database successfully.");
                }
            }





            

        }

        public void progress_qr_code_upload ()
        {

            int i;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;

            for (i = 0; i <= 200; i++)
            {
                progressBar1.Value = i;
            }

            if (progressBar1.Maximum == 250)
            {
                MessageBox.Show("Qr-codes uploaded to Mega successfully.");
            }
        }

        public void download_qr_codes(string linkki_u)
        {
            String linkki;
            linkki = linkki_u;
            
                       
 var client = new MegaApiClient();
            client.Login("ADD_MEGA_USERNAME_HERE", "PASSWORD_HERE");

            Uri folderLink = new Uri(linkki);
            IEnumerable<INode> nodes = client.GetNodesFromLink(folderLink);
            foreach (INode node in nodes.Where(x => x.Type == NodeType.File))
            {
                MessageBox.Show($"Downloading {node.Name}");
                client.DownloadFile(node, node.Name);
            }
           
            client.Logout();

        }

        public void mega()
        {
            progress_qr_code_upload();
            
            string qr_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\\qr";
            string qr_dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\codes.zip";


            using (ZipFile zip = new ZipFile(System.Text.Encoding.Default))
            {
                
                foreach (var file in System.IO.Directory.GetFiles(qr_path))
                {
                    zip.AddFile(file);
                }

                zip.Save(qr_dest);


            }

            try { 
                var client = new MegaApiClient();
            
            string zip_location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\\codes.zip";

            client.Login("ADD_MEGA_USERNAME_HERE", "PASSWORD_HERE");

            IEnumerable<INode> nodes = client.GetNodes();

            INode root = nodes.Single(x => x.Type == NodeType.Root);
            INode myFolder = client.CreateFolder("QR-Codes", root);

            INode myFile = client.UploadFile(zip_location, myFolder);
            Uri downloadLink = client.GetDownloadLink(myFile);
            Console.WriteLine(downloadLink);
            string download = downloadLink.ToString();
            MessageBox.Show(download+ "" + "Preview QR-Codes and save", "Copied to Clipboard", MessageBoxButtons.YesNo);
            if (MessageBox.Show("Do you really want to preview QR-codes?", "Preview", MessageBoxButtons.YesNo) ==DialogResult.Yes)
            {
                Form2 qrcode_preview = new Form2();
                qrcode_preview.ShowDialog();
            }
            Clipboard.SetText(download);

            client.Logout();

            MessageBox.Show("all done. qr-code location:" + zip_location);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error uploading QR-Codes to mega" + error);
                return;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

                 
            if ( !(tpaitaButton.Checked && huppariButton.Checked && kengatButton.Checked && housutButton.Checked) )
            {
                
            }else
            {
                MessageBox.Show("Please select item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(amountbox.Text))
            {
                MessageBox.Show("Please enter how many item codes you want.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
               
            }


            if (tpaitaButton.Checked == true)
            {
                progress_code_upload();
            }
            if (huppariButton.Checked == true)
            {
                progress_code_upload_hoodie();
            }
            if (kengatButton.Checked == true)
            {
                progress_code_upload_shoes();
            }
            if (housutButton.Checked == true)
            {
                progress_code_upload_pants();
            }
        }
        int numero_;
        private void Getcodes()
        {
            

            if (qrtshirtbutton.Checked == true)
            {
                numero_ = 2;
            }
            if (qrhoodiebutton.Checked == true)
            {
                numero_ = 3;
            }
            if (qrshoesbutton.Checked == true)
            {
                numero_ = 4;
            }
            if (qrpantsbutton.Checked == true)
            {
                numero_ = 5;
            }

            int date;
            if (Int32.TryParse(textBox3.Text, out date))
            {
                //was successful

                if (DEBUG_MODE == true)
                {
                    Console.WriteLine("Getcodes() TryParse success");
                }
              
            }else
            {
                //was failed
                MessageBox.Show("Please enter numbers only");
                return;
            }

            try
            {
                string queryString = "SELECT * FROM clothes where datetime=" + date;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(queryString, connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    
                    // Calling MysqlDataReader method. 
                    while (reader.Read())
                    {
                        rows++;
                        string code = reader[numero_].ToString();
                     //   string hoodies = reader[3].ToString();
                       // string shoes = reader[4].ToString();
                        //string pants = reader[5].ToString();

                        product_codes.Add(code);
                    }

                    // Calling Close when done reading.
                    if (reader != null)
                    {
                        reader.Close();
                        
                    }
                    

                }
                



            }
            catch (MySqlException error)
            {
                MessageBox.Show("Mysql error:"+ error);
                if (DEBUG_MODE == true)
                {
                    Console.WriteLine(error);
                }
            }
            finally
            {
                Generate();
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          if (DEBUG_MODE == true)
            {
                Console.WriteLine("Create Qr-codes button pressed");
            }
            Getcodes();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DEBUG_MODE == true)
            {
                Console.WriteLine("Test button pressed.");
            }
            Start_mysql();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void amountbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
