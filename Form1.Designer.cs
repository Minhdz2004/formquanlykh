namespace formquanlykhachhang
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridViewCustomers = new DataGridView();
            dataGridViewServices = new DataGridView();
            dataGridViewInvoice = new DataGridView();
            buttonAddCustomer = new Button();
            buttonEditCustomer = new Button();
            buttonDeleteCustomer = new Button();
            buttonCreateInvoice = new Button();
            textBoxName = new TextBox();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            labelName = new Label();
            labelPhone = new Label();
            labelAddress = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(62, 37);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.Size = new Size(567, 238);
            dataGridViewCustomers.TabIndex = 0;
            // 
            // dataGridViewServices
            // 
            dataGridViewServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServices.Location = new Point(683, 37);
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.RowHeadersWidth = 51;
            dataGridViewServices.Size = new Size(462, 191);
            dataGridViewServices.TabIndex = 1;
            // 
            // dataGridViewInvoice
            // 
            dataGridViewInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoice.Location = new Point(683, 313);
            dataGridViewInvoice.Name = "dataGridViewInvoice";
            dataGridViewInvoice.RowHeadersWidth = 51;
            dataGridViewInvoice.Size = new Size(462, 208);
            dataGridViewInvoice.TabIndex = 2;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Location = new Point(40, 504);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(120, 29);
            buttonAddCustomer.TabIndex = 3;
            buttonAddCustomer.Text = "Thêm khách hàng";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            buttonAddCustomer.Click += new System.EventHandler(buttonAddCustomer_Click);
            // 
            // buttonEditCustomer
            // 
            buttonEditCustomer.Location = new Point(177, 504);
            buttonEditCustomer.Name = "buttonEditCustomer";
            buttonEditCustomer.Size = new Size(99, 29);
            buttonEditCustomer.TabIndex = 4;
            buttonEditCustomer.Text = "Sửa";
            buttonEditCustomer.UseVisualStyleBackColor = true;
            buttonEditCustomer.Click += new System.EventHandler(buttonEditCustomer_Click);
            // 
            // buttonDeleteCustomer
            // 
            buttonDeleteCustomer.Location = new Point(303, 504);
            buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            buttonDeleteCustomer.Size = new Size(141, 29);
            buttonDeleteCustomer.TabIndex = 5;
            buttonDeleteCustomer.Text = "Xóa khách hàng";
            buttonDeleteCustomer.UseVisualStyleBackColor = true;
            buttonDeleteCustomer.Click += new System.EventHandler(buttonDeleteCustomer_Click);
            // 
            // buttonCreateInvoice
            // 
            buttonCreateInvoice.Location = new Point(952, 246);
            buttonCreateInvoice.Name = "buttonCreateInvoice";
            buttonCreateInvoice.Size = new Size(193, 29);
            buttonCreateInvoice.TabIndex = 6;
            buttonCreateInvoice.Text = "Tạo hóa đơn";
            buttonCreateInvoice.UseVisualStyleBackColor = true;
            buttonCreateInvoice.Click += new System.EventHandler(buttonCreateInvoice_Click);
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(185, 302);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(259, 27);
            textBoxName.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(185, 362);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(259, 27);
            textBoxPhone.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(185, 413);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(259, 27);
            textBoxAddress.TabIndex = 9;
            // 
            // labelName
            // 
            labelName.Location = new Point(62, 302);
            labelName.Name = "labelName";
            labelName.Size = new Size(100, 23);
            labelName.TabIndex = 10;
            labelName.Text = "Tên";
            // 
            // labelPhone
            // 
            labelPhone.Location = new Point(62, 362);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(100, 23);
            labelPhone.TabIndex = 11;
            labelPhone.Text = "Số điện thoại";
            // 
            // labelAddress
            // 
            labelAddress.Location = new Point(62, 413);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(100, 23);
            labelAddress.TabIndex = 12;
            labelAddress.Text = "Địa chỉ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 638);
            Controls.Add(labelAddress);
            Controls.Add(labelPhone);
            Controls.Add(labelName);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxName);
            Controls.Add(buttonCreateInvoice);
            Controls.Add(buttonDeleteCustomer);
            Controls.Add(buttonEditCustomer);
            Controls.Add(buttonAddCustomer);
            Controls.Add(dataGridViewInvoice);
            Controls.Add(dataGridViewServices);
            Controls.Add(dataGridViewCustomers);
            Name = "Form1";
            Text = "Form1";
            Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCustomers;
        private DataGridView dataGridViewServices;
        private DataGridView dataGridViewInvoice;
        private Button buttonAddCustomer;
        private Button buttonEditCustomer;
        private Button buttonDeleteCustomer;
        private Button buttonCreateInvoice;
        private TextBox textBoxName;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private Label labelName;
        private Label labelPhone;
        private Label labelAddress;
    }
}
