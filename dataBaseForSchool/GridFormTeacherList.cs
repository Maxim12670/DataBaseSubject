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
    public partial class GridFormTeacherList : Form
    {
        public GridFormTeacherList()
        {
            InitializeComponent();
        }

        private static GridFormTeacherList f;
        public static GridFormTeacherList fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new GridFormTeacherList();
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

        private void GridFormTeacherList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoollDataSet.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.schoollDataSet.Teacher);

        }

        //dataGridViewCheckBoxColumnCondition
        //GridFormTeacherList
        private void teacherDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((teacherDataGridView.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumnCondition"].Value == null))
            {
            }

            else
            {
                if ((teacherDataGridView.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumnCondition"].Value.ToString() == "True"))
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Pink;
                }
            }

        }
    }
}
