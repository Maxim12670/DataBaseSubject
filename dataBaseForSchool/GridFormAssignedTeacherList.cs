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
    public partial class GridFormAssignedTeacherList : Form
    {
        public GridFormAssignedTeacherList()
        {
            InitializeComponent();
        }

        private static GridFormAssignedTeacherList f;
        public static GridFormAssignedTeacherList fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new GridFormAssignedTeacherList();
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
            try
            {
                this.Validate();
                this.assignedTeacherBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.schoollDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }


        }

        private void GridFormAssignedTeacherList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoollDataSet.Discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.schoollDataSet.Discipline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoollDataSet.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.schoollDataSet.Teacher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoollDataSet.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.schoollDataSet.Teacher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoollDataSet.Rating". При необходимости она может быть перемещена или удалена.
            this.ratingTableAdapter.Fill(this.schoollDataSet.Rating);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoollDataSet.AssignedTeacher". При необходимости она может быть перемещена или удалена.
            this.assignedTeacherTableAdapter.Fill(this.schoollDataSet.AssignedTeacher);

        }

        private void НазначенныйУчительtoolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assignedTeacherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoollDataSet);

        }

        private void buttonDiscipline_Click(object sender, EventArgs e)
        {
            
            int id = -1;

            if (((DataRowView)assignedTeacherBindingSource.Current)["id_discipline"].ToString() != "")
            {
                id = (int)(((DataRowView)assignedTeacherBindingSource.Current)["id_discipline"]);
            }
  
            id = GridFormDisciplineList.fw.ShowSelectForm(id);

            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)assignedTeacherBindingSource.Current)["id_discipline"] = id;
                assignedTeacherBindingSource.EndEdit();
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.assignedTeacherTableAdapter.FillBy(this.schoollDataSet.AssignedTeacher);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
