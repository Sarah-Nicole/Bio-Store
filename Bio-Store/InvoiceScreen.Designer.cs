namespace Bio_Store
{
    partial class InvoiceScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxInvoiceCategory = new System.Windows.Forms.ComboBox();
            this.textBoxInvoiceTotalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInvoiceRecipient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInvoiceID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dataGridInvoice = new System.Windows.Forms.DataGridView();
            this.btnInvoiceDelete = new System.Windows.Forms.Button();
            this.btnInvoiceEmpty = new System.Windows.Forms.Button();
            this.btnInvoiceEdit = new System.Windows.Forms.Button();
            this.btnInvoiceSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxInvoiceCategory
            // 
            this.comboBoxInvoiceCategory.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxInvoiceCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxInvoiceCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInvoiceCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxInvoiceCategory.ForeColor = System.Drawing.Color.White;
            this.comboBoxInvoiceCategory.FormattingEnabled = true;
            this.comboBoxInvoiceCategory.Items.AddRange(new object[] {
            "Vorauskasse",
            "PayPal",
            "Kreditkarte"});
            this.comboBoxInvoiceCategory.Location = new System.Drawing.Point(177, 99);
            this.comboBoxInvoiceCategory.Name = "comboBoxInvoiceCategory";
            this.comboBoxInvoiceCategory.Size = new System.Drawing.Size(300, 29);
            this.comboBoxInvoiceCategory.TabIndex = 17;
            // 
            // textBoxInvoiceTotalPrice
            // 
            this.textBoxInvoiceTotalPrice.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxInvoiceTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInvoiceTotalPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInvoiceTotalPrice.ForeColor = System.Drawing.Color.White;
            this.textBoxInvoiceTotalPrice.Location = new System.Drawing.Point(177, 139);
            this.textBoxInvoiceTotalPrice.Name = "textBoxInvoiceTotalPrice";
            this.textBoxInvoiceTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxInvoiceTotalPrice.Size = new System.Drawing.Size(300, 30);
            this.textBoxInvoiceTotalPrice.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Gesamt-Preis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kategorie";
            // 
            // textBoxInvoiceRecipient
            // 
            this.textBoxInvoiceRecipient.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxInvoiceRecipient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInvoiceRecipient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInvoiceRecipient.ForeColor = System.Drawing.Color.White;
            this.textBoxInvoiceRecipient.Location = new System.Drawing.Point(177, 59);
            this.textBoxInvoiceRecipient.Name = "textBoxInvoiceRecipient";
            this.textBoxInvoiceRecipient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxInvoiceRecipient.Size = new System.Drawing.Size(300, 30);
            this.textBoxInvoiceRecipient.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Empfänger";
            // 
            // textBoxInvoiceID
            // 
            this.textBoxInvoiceID.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxInvoiceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInvoiceID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInvoiceID.ForeColor = System.Drawing.Color.White;
            this.textBoxInvoiceID.Location = new System.Drawing.Point(177, 19);
            this.textBoxInvoiceID.Name = "textBoxInvoiceID";
            this.textBoxInvoiceID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxInvoiceID.Size = new System.Drawing.Size(300, 30);
            this.textBoxInvoiceID.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(23, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 22);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Rechnungs-Nr.";
            // 
            // dataGridInvoice
            // 
            this.dataGridInvoice.AllowUserToAddRows = false;
            this.dataGridInvoice.AllowUserToDeleteRows = false;
            this.dataGridInvoice.AllowUserToResizeColumns = false;
            this.dataGridInvoice.AllowUserToResizeRows = false;
            this.dataGridInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridInvoice.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(96)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridInvoice.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridInvoice.Location = new System.Drawing.Point(27, 234);
            this.dataGridInvoice.MultiSelect = false;
            this.dataGridInvoice.Name = "dataGridInvoice";
            this.dataGridInvoice.ReadOnly = true;
            this.dataGridInvoice.RowHeadersVisible = false;
            this.dataGridInvoice.RowHeadersWidth = 62;
            this.dataGridInvoice.RowTemplate.Height = 28;
            this.dataGridInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridInvoice.Size = new System.Drawing.Size(924, 498);
            this.dataGridInvoice.TabIndex = 22;
            this.dataGridInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridInvoice_CellClick);
            // 
            // btnInvoiceDelete
            // 
            this.btnInvoiceDelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnInvoiceDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceDelete.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceDelete.Location = new System.Drawing.Point(586, 182);
            this.btnInvoiceDelete.Name = "btnInvoiceDelete";
            this.btnInvoiceDelete.Size = new System.Drawing.Size(130, 40);
            this.btnInvoiceDelete.TabIndex = 21;
            this.btnInvoiceDelete.Text = "Löschen";
            this.btnInvoiceDelete.UseVisualStyleBackColor = false;
            this.btnInvoiceDelete.Click += new System.EventHandler(this.btnInvoiceDelete_Click);
            // 
            // btnInvoiceEmpty
            // 
            this.btnInvoiceEmpty.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnInvoiceEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceEmpty.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceEmpty.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceEmpty.Location = new System.Drawing.Point(450, 182);
            this.btnInvoiceEmpty.Name = "btnInvoiceEmpty";
            this.btnInvoiceEmpty.Size = new System.Drawing.Size(130, 40);
            this.btnInvoiceEmpty.TabIndex = 20;
            this.btnInvoiceEmpty.Text = "Leeren";
            this.btnInvoiceEmpty.UseVisualStyleBackColor = false;
            this.btnInvoiceEmpty.Click += new System.EventHandler(this.btnInvoiceEmpty_Click);
            // 
            // btnInvoiceEdit
            // 
            this.btnInvoiceEdit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnInvoiceEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceEdit.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceEdit.Location = new System.Drawing.Point(314, 182);
            this.btnInvoiceEdit.Name = "btnInvoiceEdit";
            this.btnInvoiceEdit.Size = new System.Drawing.Size(130, 40);
            this.btnInvoiceEdit.TabIndex = 19;
            this.btnInvoiceEdit.Text = "Bearbeiten";
            this.btnInvoiceEdit.UseVisualStyleBackColor = false;
            this.btnInvoiceEdit.Click += new System.EventHandler(this.btnInvoiceEdit_Click);
            // 
            // btnInvoiceSave
            // 
            this.btnInvoiceSave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnInvoiceSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceSave.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceSave.Location = new System.Drawing.Point(178, 182);
            this.btnInvoiceSave.Name = "btnInvoiceSave";
            this.btnInvoiceSave.Size = new System.Drawing.Size(130, 40);
            this.btnInvoiceSave.TabIndex = 18;
            this.btnInvoiceSave.Text = "Speichern";
            this.btnInvoiceSave.UseVisualStyleBackColor = false;
            this.btnInvoiceSave.Click += new System.EventHandler(this.btnInvoiceSave_Click);
            // 
            // InvoiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bio_Store.Properties.Resources.ImgBgInvoice;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.dataGridInvoice);
            this.Controls.Add(this.btnInvoiceDelete);
            this.Controls.Add(this.btnInvoiceEmpty);
            this.Controls.Add(this.btnInvoiceEdit);
            this.Controls.Add(this.btnInvoiceSave);
            this.Controls.Add(this.comboBoxInvoiceCategory);
            this.Controls.Add(this.textBoxInvoiceTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxInvoiceRecipient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInvoiceID);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InvoiceScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxInvoiceCategory;
        private System.Windows.Forms.TextBox textBoxInvoiceTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInvoiceRecipient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInvoiceID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dataGridInvoice;
        private System.Windows.Forms.Button btnInvoiceDelete;
        private System.Windows.Forms.Button btnInvoiceEmpty;
        private System.Windows.Forms.Button btnInvoiceEdit;
        private System.Windows.Forms.Button btnInvoiceSave;
    }
}