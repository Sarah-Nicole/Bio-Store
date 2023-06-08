using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bio_Store
{
    public partial class ProductScreen : Form
    {
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\manue\Documents\Bio-Store.mdf;Integrated Security = True; Connect Timeout = 30");
        private int lastSelectedProductID; 

        public ProductScreen()
        {
            InitializeComponent();
            ShowProducts(); 
            
           

        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text;
            string productBrand = textBoxProductBrand.Text;
            string productCategory = comboBoxProductCategory.Text;
            string productPrice = textBoxProductPrice.Text; 

            if (productName == "" 
                || productBrand == ""
                || productCategory ==""
                || productPrice == "")
            {
                MessageBox.Show("Bitte alle Felder ausfüllen."); 
                return; 
            }


            string query = string.Format("INSERT INTO Products VALUES ('{0}','{1}','{2}','{3}')", productName, productBrand, productCategory, productPrice);
            ExecuteQuery(query); 
            
            ShowProducts();
            EmptyAllFields(); 


        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {

            if (lastSelectedProductID == 0)
            {
                MessageBox.Show("Bitte ein Produkt auswählen.");
                return;
            }

            string productName = textBoxProductName.Text;
            string productBrand = textBoxProductBrand.Text;
            string productCategory = comboBoxProductCategory.Text;
            string productPrice = textBoxProductPrice.Text;

            string query = string.Format("UPDATE Products SET Name='{0}', Brand='{1}', Category='{2}', Price='{3}' WHERE ID = {4};",
                productName, productBrand, productCategory, productPrice, lastSelectedProductID);
            
            ExecuteQuery(query);

            EmptyAllFields(); 
            ShowProducts();
        }

        private void btnProductEmpty_Click(object sender, EventArgs e)
        {
            EmptyAllFields(); 
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductID == 0)
            {
                MessageBox.Show("Bitte ein Produkt auswählen.");
                return; 
            }


            string query = string.Format("DELETE FROM Products WHERE ID = '{0}';", lastSelectedProductID);
            ExecuteQuery(query);

            EmptyAllFields();
            ShowProducts();
            

        }

        private void DataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridProduct.Rows[e.RowIndex];
                textBoxProductName.Text = selectedRow.Cells[0].Value.ToString();
                textBoxProductBrand.Text = selectedRow.Cells[1].Value.ToString();
                comboBoxProductCategory.Text = selectedRow.Cells[2].Value.ToString();
                textBoxProductPrice.Text = selectedRow.Cells[3].Value.ToString();

                lastSelectedProductID = Convert.ToInt32(selectedRow.Cells[0].Value);
            }

        }


        // ------   div Methoden -----------------
        private void ShowProducts()
        {
            // SQL Verknüpfung zu ProductScreen machen, damit Table angezeigt wird
            databaseConnection.Open();

            string query = "SELECT * FROM Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet);

            dataGridProduct.DataSource = dataSet.Tables[0];
            dataGridProduct.Columns[0].Visible = false;

            databaseConnection.Close();
        }

        private void ExecuteQuery(string query)
        {
            databaseConnection.Open();
 
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();

            databaseConnection.Close();
        }

        private void EmptyAllFields()
        {
            textBoxProductName.Text = "";
            textBoxProductBrand.Text = ""; 
            comboBoxProductCategory.SelectedItem = null;
            textBoxProductPrice.Text = ""; 
        }

       
    }
}
