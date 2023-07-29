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
    public partial class FormTeacherList : Form
    {
        public FormTeacherList()
        {
            InitializeComponent();
        }

        private static FormTeacherList f;
        public static FormTeacherList fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormTeacherList();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void teacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoollDataSet);

        }

        private void FormTeacherList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoollDataSet.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.schoollDataSet.Teacher);

        }
    }
}
