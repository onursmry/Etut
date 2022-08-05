using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAEtutForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbxClass.SelectedIndex == 4)
            {
                MessageBox.Show("Lütfen ders seçiniz");
                return;
            }
            else
            {
                CalculateGrade calculateGrade = new CalculateGrade();
                calculateGrade.Name = tbxName.Text;
                calculateGrade.LastName = tbxLastName.Text;
                calculateGrade.Class = cbxClass.Text;
                calculateGrade.Visa = Convert.ToDouble(tbxVisa.Text);
                calculateGrade.Final = Convert.ToDouble(tbxFinal.Text);
                tbxScore.Text = calculateGrade.Score.ToString();

                //create a new listview item
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = calculateGrade.Name;
                listViewItem.SubItems.Add(calculateGrade.LastName);
                listViewItem.SubItems.Add(calculateGrade.Class);
                listViewItem.SubItems.Add(calculateGrade.Visa.ToString());
                listViewItem.SubItems.Add(calculateGrade.Final.ToString());
                listViewItem.SubItems.Add(calculateGrade.Score.ToString());

                //add the listview item to the listview
                lvwStudents.Items.Add(listViewItem);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbxClass.Items.Add("Fizik");
            cbxClass.Items.Add("Kimya");
            cbxClass.Items.Add("Biyoloji");
            cbxClass.Items.Add("Matematik");
            cbxClass.Items.Add("Ders Seçiniz");
            cbxClass.SelectedIndex = 4;
        }
    }
}
