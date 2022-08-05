using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAEtutForm2.Repositories.Concrete;

namespace WFAEtutForm2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.CreateCategory(tbxName.Text, tbxDescription.Text);
            categoryRepository.ListCategories(listView1);
            categoryRepository.Eraser(groupBox1);
            
        }
    }
}
