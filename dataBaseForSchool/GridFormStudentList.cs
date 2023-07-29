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
    public partial class GridFormStudentList : Form
    {
        public GridFormStudentList()
        {
            InitializeComponent();
        }

        private static GridFormStudentList f;
        public static GridFormStudentList fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new GridFormStudentList();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }


        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoollDataSet);

        }

        private void GridFormStudentList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoollDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.schoollDataSet.Student);
        }

        string GetSelectedFieldName()
        {
            return studentDataGridView.Columns[studentDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
               studentBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                studentBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких учеников нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                studentBindingSource.Position = 0;
            }

        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        studentBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                studentBindingSource.Filter = "";
            if (studentBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                studentBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }

        }


        public int idCurrent = -1;
        public int ShowSelectForm(int idDish, out decimal price)
        {
            idCurrent = idDish;
            ShowDialog();
            price =
           (decimal)((DataRowView)studentBindingSource.Current)["цена_меню"];
            return
           (int)((DataRowView)studentBindingSource.Current)["код_блюда"];
        }

        private void GridFormStudentList_Shown(object sender, EventArgs e)
        {
        }
    }
}
