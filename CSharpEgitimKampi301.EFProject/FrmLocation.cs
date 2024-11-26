using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbRehber.DisplayMember = "FullName";
            cmbRehber.ValueMember = "GuideId";
            cmbRehber.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.LocationCity = txtSehir.Text;
            location.LocationCountry = txtUlke.Text;
            location.LocationCapacity = byte.Parse(numUpDownKapasite.Value.ToString());
            location.LocationPrice = decimal.Parse(txtFiyat.Text);
            location.DayNight = txtGunGece.Text;
            location.GuideId = int.Parse(cmbRehber.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = db.Location.Find(id);
            db.Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue = db.Location.Find(id);
            updatedValue.LocationCity = txtSehir.Text;
            updatedValue.LocationCountry = txtUlke.Text;
            updatedValue.LocationCapacity = byte.Parse(numUpDownKapasite.Value.ToString());
            updatedValue.LocationPrice = decimal.Parse(txtFiyat.Text);
            updatedValue.DayNight = txtGunGece.Text;
            updatedValue.GuideId = int.Parse(cmbRehber.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı!");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.Location.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
