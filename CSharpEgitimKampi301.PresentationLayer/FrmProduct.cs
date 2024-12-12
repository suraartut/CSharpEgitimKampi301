using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;

        public FrmProduct(IProductService productService)
        {
            _productService = new ProductManager(new EfProductDal());
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productService.TGetAll();
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productService.TGetProductsWithCategory();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProdId.Text);
            var deletedValues = _productService.TGetById(id);
            _productService.TDelete(deletedValues);
            MessageBox.Show("Silme Başarılı!");
        }
    }
}
