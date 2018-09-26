using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace XmlSql0924
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        DataSet ds = new DataSet();
        

        //establishing a connection to the database server. 
        SqlConnection sqlcon = new SqlConnection(@"server=PL4\MTCDB;Database=Sandbox;Trusted_Connection=True;");
     
        OpenFileDialog ofd = new OpenFileDialog();


        private void LoadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileXML.ShowDialog() == DialogResult.OK)
                {
                    OpenFileDialog openfile = new OpenFileDialog();

                    // openfile.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                    // reading the path file and reading the xml file and loads it onto the datagrid
                    ds.ReadXml(@"C:\Users\Cyberadmin\Documents\People.xml");
                    Datagridview.DataSource = ds.Tables[0];

                    //table.Columns.Add("first_name", typeof(string));
                    //table.Columns.Add("last_name", typeof(string));
                    //table.Columns.Add("SSN", typeof(string));
                    //table.Columns.Add("gender", typeof(string));
                    //table.Columns.Add("Email", typeof(string));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                     
       
    
        private void AddBtn_Click(object sender, EventArgs e)
        {
           try
            {              


                //if (Firstnametextbox.Text != "" && Lastnametextbox.Text != "" && socialtextbox.Text != ""
                //    && Gendertextbox.Text != "" && Emailtextbox.Text != "")
                //{
                //    Datagridview.Rows[0].Cells[0].Value = (Firstnametextbox.Text);
                //    Datagridview.Rows[0].Cells[1].Value = (Lastnametextbox.Text);
                //    Datagridview.Rows[0].Cells[2].Value = (socialtextbox.Text);
                //    Datagridview.Rows[0].Cells[3].Value = (Gendertextbox.Text);
                //    Datagridview.Rows[0].Cells[4].Value = (Emailtextbox.Text);
                //    MessageBox.Show("Entry added!");

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "error...");
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlcommand = new SqlCommand("InsertXml",  sqlcon);
                sqlcommand.CommandType = CommandType.StoredProcedure;

                if (Datagridview.Rows.Count > 0)
                {
                    sqlcon.Open();
                }
                foreach (DataGridViewRow dgr in Datagridview.Rows)
                {

                    sqlcommand.Parameters.AddWithValue("@Firstname", dgr.Cells["first_name"].Value);
                    sqlcommand.Parameters.AddWithValue("@Lastname", dgr.Cells["last_name"].Value);
                    sqlcommand.Parameters.AddWithValue("@SSN", dgr.Cells["SSN"].Value);
                    sqlcommand.Parameters.AddWithValue("@Gender", dgr.Cells["gender"].Value);
                    sqlcommand.Parameters.AddWithValue("@Email", dgr.Cells["Email"].Value);
                    sqlcommand.ExecuteNonQuery();
                    sqlcommand.Parameters.Clear();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message ,"error...");
            }

            finally
            {
                sqlcon.Close();
            }
        }
        

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (this.Datagridview.SelectedRows.Count > 0)
            {
                Datagridview.Rows.RemoveAt(this.Datagridview.SelectedRows[0].Index);
                MessageBox.Show("row deleted");
            }
        }
    }
}
