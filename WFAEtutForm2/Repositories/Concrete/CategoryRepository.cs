using System.Windows.Forms;
using WFAEtutForm2.Entities.Concrete;
using WFAEtutForm2.Repositories.Abstract;

namespace WFAEtutForm2.Repositories.Concrete
{
    public class CategoryRepository : BaseRepository
    {
        Category _category;
        public override void CreateCategory(string categoryName, string description)
        {
            _category = new Category();
            _category.Name = categoryName;
            _category.Description = description;
        }

        public override void ListCategories(ListView listview)
        {
            //create listview item
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = _category.Id.ToString();
            listViewItem.SubItems.Add(_category.Name);
            listViewItem.SubItems.Add(_category.Description);
            listViewItem.SubItems.Add(_category.CreateDate.ToString());
            listViewItem.SubItems.Add(_category.Status.ToString());

            //add to listview
            listview.Items.Add(listViewItem);
        }

        public override void Eraser(GroupBox groupBox)
        {
            foreach (var item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }
    }

}