using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        IProductService _productService;
        ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxAddCategoryName .DataSource = _categoryService.GetAll();
            cbxAddCategoryName.DisplayMember = "CategoryName";
            cbxAddCategoryName.ValueMember = "CategoryId";

            cbxUpdateCategoryName.DataSource = _categoryService.GetAll();
            cbxUpdateCategoryName.DisplayMember = "CategoryName";
            cbxUpdateCategoryName.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch 
            {
            }

        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryId = Convert.ToInt32(cbxAddCategoryName.SelectedValue), 
                ProductName = tbxAddProductName.Text,
                QuantityPerUnit = tbxAddQuantity.Text,
                UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(tbxAddStockAmount.Text)
            });
            MessageBox.Show("Product Added!");
            LoadProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId= Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName=tbxUpdateProductName.Text,
                CategoryId = Convert.ToInt32(cbxUpdateCategoryName.SelectedValue),
                UnitsInStock = Convert.ToInt16(tbxUpdateStockAmount.Text),
                QuantityPerUnit = tbxUpdateQuantity.Text,
                UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text)
            });
            MessageBox.Show("Product Updated!");
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxUpdateProductName.Text = row.Cells[1].Value.ToString();
            cbxUpdateCategoryName.SelectedValue = row.Cells[2].Value;
            tbxUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
            tbxUpdateQuantity.Text = row.Cells[4].Value.ToString();
            tbxUpdateStockAmount.Text = row.Cells[5].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwProduct.CurrentRow != null)
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                }
                MessageBox.Show("Product Deleted!");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }
    }
}
