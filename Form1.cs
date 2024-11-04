using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace formquanlykhachhang
{
    public partial class Form1 : Form
    {
        private List<Customer> customers = new List<Customer>();
        private List<Service> services = new List<Service>();
        private List<Invoice> invoices = new List<Invoice>();
        private int customerIdCounter = 1;
        private int invoiceIdCounter = 1;

        public Form1()
        {
            InitializeComponent();
            LoadCustomers();
            LoadServices();
            UpdateCustomerDisplay();
            UpdateServiceDisplay();
            UpdateInvoiceDisplay();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo dữ liệu hoặc các thao tác cần thiết khi form load
        }

        private void LoadCustomers()
        {
            customers = new List<Customer>
            {
                new Customer { Id = customerIdCounter++, Name = "Nguyen Van A", Phone = "0123456789", Address = "Hanoi" },
                new Customer { Id = customerIdCounter++, Name = "Tran Thi B", Phone = "0987654321", Address = "Saigon" },
                new Customer { Id = customerIdCounter++, Name = "Le Van C", Phone = "0234567890", Address = "Danang" }
            };
        }

        private void LoadServices()
        {
            services = new List<Service>
            {
                new Service { Id = 1, Name = "Service 1", Price = 100 },
                new Service { Id = 2, Name = "Service 2", Price = 200 },
                new Service { Id = 3, Name = "Service 3", Price = 300 }
            };

            dataGridViewServices.DataSource = services;
        }

        private void UpdateCustomerDisplay()
        {
            dataGridViewCustomers.DataSource = null;
            dataGridViewCustomers.DataSource = customers;
        }

        private void UpdateServiceDisplay()
        {
            dataGridViewServices.DataSource = null;
            dataGridViewServices.DataSource = services;
        }

        private void UpdateInvoiceDisplay()
        {
            var invoiceDisplayData = invoices.Select(i => new
            {
                InvoiceId = i.Id,
                CustomerName = i.Customer.Name,
                TotalProducts = i.TotalProducts,
                TotalPrice = i.TotalPrice
            }).ToList();

            dataGridViewInvoice.DataSource = null;
            dataGridViewInvoice.DataSource = invoiceDisplayData;
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Id = customerIdCounter++,
                Name = textBoxName.Text,
                Phone = textBoxPhone.Text,
                Address = textBoxAddress.Text
            };
            customers.Add(customer);
            UpdateCustomerDisplay();
            ClearCustomerTextBoxes();
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.CurrentRow != null)
            {
                var selectedCustomer = dataGridViewCustomers.CurrentRow.DataBoundItem as Customer;
                if (selectedCustomer != null)
                {
                    selectedCustomer.Name = textBoxName.Text;
                    selectedCustomer.Phone = textBoxPhone.Text;
                    selectedCustomer.Address = textBoxAddress.Text;
                    UpdateCustomerDisplay();
                    ClearCustomerTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một khách hàng để sửa!");
            }
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.CurrentRow != null)
            {
                var selectedCustomer = dataGridViewCustomers.CurrentRow.DataBoundItem as Customer;
                if (selectedCustomer != null)
                {
                    customers.Remove(selectedCustomer);
                    UpdateCustomerDisplay();
                    ClearCustomerTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một khách hàng để xóa!");
            }
        }

        private void buttonCreateInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.CurrentRow != null && dataGridViewServices.CurrentRow != null)
            {
                var selectedCustomer = dataGridViewCustomers.CurrentRow.DataBoundItem as Customer;
                var selectedService = dataGridViewServices.CurrentRow.DataBoundItem as Service;
                if (selectedCustomer != null && selectedService != null)
                {
                    var invoice = new Invoice
                    {
                        Id = invoiceIdCounter++,
                        Customer = selectedCustomer,
                        Services = new List<Service> { selectedService }
                    };
                    invoices.Add(invoice);
                    UpdateInvoiceDisplay();
                }
            }
        }

        private void ClearCustomerTextBoxes()
        {
            textBoxName.Clear();
            textBoxPhone.Clear();
            textBoxAddress.Clear();
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi nội dung trong textBoxPhone thay đổi
        }
    }
}
