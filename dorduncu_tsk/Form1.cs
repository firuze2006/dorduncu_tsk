
using System;
using System.Windows.Forms;

namespace dorduncu_tsk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbKurs.Items.Add("C#");
            cmbKurs.Items.Add("Java");
            cmbKurs.Items.Add("Python");

            numYas.Minimum = 16;
            numYas.Maximum = 100;
            numYas.Value = 18;

            lblMelumat.Text = "Tələbə seçilməyib";
        }

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string kurs = cmbKurs.Text;
            string cins;

            if (ad == "")
            {
                MessageBox.Show("Ad daxil edin!");
                return;
            }

            if (kurs == "")
            {
                MessageBox.Show("Kurs seçin!");
                return;
            }

            if (rbKisi.Checked)
                cins = "Kişi";
            else if (rbQadin.Checked)
                cins = "Qadın";
            else
            {
                MessageBox.Show("Cins seçin!");
                return;
            }

            string melumat = ad + " - " + numYas.Value +
                " yaş - " + kurs + " - " + cins;

            lstTelebeler.Items.Add(melumat);

            txtAd.Clear();
            cmbKurs.SelectedIndex = -1;
            rbKisi.Checked = false;
            rbQadin.Checked = false;
            numYas.Value = 18;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstTelebeler.SelectedIndex == -1)
            {
                MessageBox.Show("Silmək üçün tələbə seçin!");
                return;
            }

            DialogResult cavab = MessageBox.Show(
                "Seçilən tələbəni silmək istəyirsiniz?",
                "Təsdiq",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                lstTelebeler.Items.RemoveAt(lstTelebeler.SelectedIndex);
                lblMelumat.Text = "Tələbə seçilməyib";
            }
        }

        private void Telebeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTelebeler.SelectedIndex != -1)
                lblMelumat.Text = lstTelebeler.SelectedItem.ToString();
            else
                lblMelumat.Text = "Tələbə seçilməyib";
        }
    }
}
