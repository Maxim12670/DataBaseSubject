using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBaseForSchool
{
    public partial class GridFormRatingList : Form
    {
        public GridFormRatingList()
        {
            InitializeComponent();
        }

        private static GridFormRatingList f;
        public static GridFormRatingList fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new GridFormRatingList();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }


        private void ratingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ratingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoollDataSet);

        }

        private void GridFormRatingList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoollDataSet.Rating". При необходимости она может быть перемещена или удалена.
            this.ratingTableAdapter.Fill(this.schoollDataSet.Rating);

        }
    }
}
