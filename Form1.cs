using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_5_aoaoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            var listOfBooks = new List<Books>();
            FormForBooks f = new FormForBooks();
            f.ShowDialog();
            Books books = new Books();
            books.NameOfTowar = f.textName.Text;
            books.ListOfAuthors = f.textAuthor.Text;  
            books.Descriprion =f.textDescription.Text;
            books.Country = f.textCountry.Text;
            books.PublishingHouse = f.textPublishingHouse.Text;
            books.PublishingHouse = f.textPublishingHouse.Text;
            books.DateOfPacking = Convert.ToInt32(f.textDeliveryDate.Text);
            books.NumberOfPages = Convert.ToInt32(f.textPages.Text);
            books.Price = Convert.ToDouble(f.textPrice.Text);
            listOfBooks.Add(books);
            foreach (var book in listOfBooks)
            {
                Grid.Rows.Add(book.NameOfTowar, book.Price, book.Country,
                    book.NumberOfPages, book.ListOfAuthors, book.PublishingHouse, book.Descriprion, book.DateOfPacking);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in Grid.SelectedRows)
            {
                Grid.Rows.Remove(r);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var listOfProducts = new List<Products>();
            FormForProducts p = new FormForProducts();
            p.ShowDialog();
            Products products = new Products();
            products.NameOfTowar = p.textProduct.Text;
            products.Price = Convert.ToDouble(p.textPrice.Text);
            products.Descriprion = p.textDescription.Text;
            products.Country = p.textCountry.Text;
            products.UnitOfProducts = Convert.ToInt32(p.textUnit.Text);
            products.SellByDate = Convert.ToDouble(p.textSellll.Text);
            products.DateOfPacking = Convert.ToInt32(p.textPacking.Text);
            products.UnitsOfMeasurement = Convert.ToInt32(p.textMeaasurment.Text);
            listOfProducts.Add(products);



            foreach (var product in listOfProducts)
            {
                dataGridForProducts.Rows.Add(product.NameOfTowar, product.Price, product.Country,
                    product.Descriprion, product.DateOfPacking, product.UnitOfProducts, product.UnitsOfMeasurement, product.SellByDate);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridForProducts.SelectedRows)
            {
                dataGridForProducts.Rows.Remove(r);
            }
        }
    }
}
