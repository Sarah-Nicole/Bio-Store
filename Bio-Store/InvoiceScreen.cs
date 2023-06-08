using System;
using System.Collections;
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
    public partial class InvoiceScreen : Form

    {
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\manue\Documents\Bio-Store.mdf;Integrated Security = True; Connect Timeout = 30");
        private int lastSelectedInvoiceID;
        string invoiceID; 
        string invoiceRecipient; 
        string invoiceCatergory; 
        string invoicePrice; 


        public InvoiceScreen()
        {
            InitializeComponent();
            ShowProducts(); 
        }

        private void btnInvoiceSave_Click(object sender, EventArgs e)
        {
            CheckTextBoxes();


            // Check if invoiceID already exists
            string checkQuery = string.Format("SELECT COUNT(*) FROM Invoices WHERE InvoiceID = '{0}'", invoiceID);
            databaseConnection.Open();
            SqlCommand checkCommand = new SqlCommand(checkQuery, databaseConnection);
            int existingInvoiceCount = (int)checkCommand.ExecuteScalar();
            databaseConnection.Close();

            if (existingInvoiceCount > 0)
            {
                MessageBox.Show("Invoice Nr. schon vergeben.");
                return;
            }

            string query = string.Format("INSERT INTO Invoices VALUES ('{0}','{1}','{2}','{3}')", invoiceID, invoiceRecipient, invoiceCatergory, invoicePrice);
            ExecuteQuery(query);

            ShowProducts();
            ClearAllFields(); 


        }

        private void btnInvoiceEdit_Click(object sender, EventArgs e)
        {
            CheckTextBoxes(); 


            if (invoiceID == lastSelectedInvoiceID.ToString())
            {
                string query = string.Format("UPDATE Invoices SET Recepient = '{1}', Category='{2}', TotalPrice='{3}' WHERE InvoiceID = {0};", invoiceID, invoiceRecipient, invoiceCatergory, invoicePrice);
                ExecuteQuery(query);

            } else
            {
                string query = string.Format("INSERT INTO Invoices VALUES ('{0}','{1}','{2}','{3}')", invoiceID, invoiceRecipient, invoiceCatergory, invoicePrice);
                ExecuteQuery(query);
            }
           
            
            ClearAllFields(); 
            ShowProducts(); 

        }

        private void btnInvoiceEmpty_Click(object sender, EventArgs e)
        {
            ClearAllFields(); 
        }

        private void btnInvoiceDelete_Click(object sender, EventArgs e)
        {
            if (lastSelectedInvoiceID == 0)
            {
                MessageBox.Show("Bitte ein Feld anwählen.");
                return;
            }

            string query = string.Format("DELETE FROM Invoices WHERE InvoiceID = {0};", lastSelectedInvoiceID);
            ExecuteQuery(query);

            ShowProducts();
            ClearAllFields();
        }

        private void DataGridInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridInvoice.Rows[e.RowIndex];
                textBoxInvoiceID.Text = selectedRow.Cells[0].Value.ToString();
                textBoxInvoiceRecipient.Text = selectedRow.Cells[1].Value.ToString();
                comboBoxInvoiceCategory.Text = selectedRow.Cells[2].Value.ToString();
                textBoxInvoiceTotalPrice.Text = selectedRow.Cells[3].Value.ToString();

                lastSelectedInvoiceID = Convert.ToInt32(selectedRow.Cells[0].Value);
            }


        }

        // ------------ METHODS ------------
         
        private void CheckTextBoxes()
        {
            invoiceID = textBoxInvoiceID.Text;
            invoiceRecipient = textBoxInvoiceRecipient.Text;
            invoiceCatergory = comboBoxInvoiceCategory.Text;
            invoicePrice = textBoxInvoiceTotalPrice.Text;

            if (invoiceID == "" ||
                invoiceRecipient == "" ||
                invoiceCatergory == "" ||
                invoicePrice == "")
            {
                MessageBox.Show("Bitte alle Felder ausfüllen");
                return;
            }

        }

        private void ShowProducts()
        {
            string query = "SELECT * FROM Invoices"; 
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, databaseConnection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridInvoice.DataSource = ds.Tables[0];

        }


        private void ExecuteQuery(string query)
        {
            databaseConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery(); 

            databaseConnection.Close(); 
        }


        private void ClearAllFields()
        {
            textBoxInvoiceID.Text = "";
            textBoxInvoiceRecipient.Text = "";
            comboBoxInvoiceCategory.SelectedItem = null;
            textBoxInvoiceTotalPrice.Text = ""; 


        }

    }
}
