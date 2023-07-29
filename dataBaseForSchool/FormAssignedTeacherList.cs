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
    public partial class FormAssignedTeacherList : Form
    {
        public FormAssignedTeacherList()
        {
            InitializeComponent();
        }

        private static FormAssignedTeacherList f;
        public static FormAssignedTeacherList fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormAssignedTeacherList();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }


        private void assignedTeacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assignedTeacherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoollDataSet);

        }

        private void AssignedTeacher_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoollDataSet.AssignedTeacher". При необходимости она может быть перемещена или удалена.
            this.assignedTeacherTableAdapter.Fill(this.schoollDataSet.AssignedTeacher);

        }
    }
}
