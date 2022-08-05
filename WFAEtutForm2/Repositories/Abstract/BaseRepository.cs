using System;
using System.Windows.Forms;

namespace WFAEtutForm2.Repositories.Abstract
{
    public abstract class BaseRepository
    {
        public abstract void CreateCategory(string CategoryName, string Description);

        public abstract void ListCategories(ListView listview);
        public abstract void Eraser(GroupBox groupBox);

    }
}