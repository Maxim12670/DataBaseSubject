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
    public partial class FormRatingList : Form
    {
        public FormRatingList()
        {
            InitializeComponent();
        }

        private static FormRatingList f;
        public static FormRatingList fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormRatingList();
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

        private void FormRatingList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoollDataSet.Rating". При необходимости она может быть перемещена или удалена.
            this.ratingTableAdapter.Fill(this.schoollDataSet.Rating);

        }
    }
}
