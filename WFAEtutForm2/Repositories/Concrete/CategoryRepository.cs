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

            //get last id
            int lastId = 0;
            if (listview.Items.Count > 0)
            {
                lastId = int.Parse(listview.Items[listview.Items.Count - 1].Text);
            }
            _category.Id = lastId + 1;

            listViewItem.Text = _category.Id.ToString();

            //check if category is already in listview
            foreach (ListViewItem item in listview.Items)
            {
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                {
                    if (subitem.Text == _category.Name)
                    {
                        MessageBox.Show("Bu İsimde Bir Kategori Zaten Mevcut!");
                        return;
                    }
                }
            }

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