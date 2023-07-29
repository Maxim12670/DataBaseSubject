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
    public partial class FormDisciplineList : Form
    {
        public FormDisciplineList()
        {
            InitializeComponent();
        }

        private static FormDisciplineList f;
        public static FormDisciplineList fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormDisciplineList();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void disciplineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disciplineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoollDataSet);

        }

        private void FormDisciplineList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoollDataSet.Discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.schoollDataSet.Discipline);

        }
    }
}
