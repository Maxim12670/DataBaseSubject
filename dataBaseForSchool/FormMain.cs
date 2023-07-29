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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,КИБЭВС,Акайкин Максим Дмитриевич, группа 571-1, 2023", "О программе",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
           "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
           DialogResult.Yes;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormTeacherList fd = new FormTeacherList();
            fd.ShowForm();

        }

        private void toolStripButtonAssignedTeacher_Click(object sender, EventArgs e)
        {
            FormAssignedTeacherList fd = new FormAssignedTeacherList();
            fd.ShowForm();
        }

        private void toolStripButtonDiscipline_Click(object sender, EventArgs e)
        {
            FormDisciplineList fd = new FormDisciplineList();
            fd.ShowForm();
        }

        private void toolStripButtonRating_Click(object sender, EventArgs e)
        {
            FormRatingList fd = new FormRatingList();
            fd.ShowForm();
        }

        private void toolStripButtonStudent_Click(object sender, EventArgs e)
        {
            FormStudentList fd = new FormStudentList();
            fd.ShowForm();
        }

        private void toolStripButtonInformationParent_Click(object sender, EventArgs e)
        {
            FormInformationParentList fd = new FormInformationParentList();
            fd.ShowForm();
        }

        private void учителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridFormTeacherList fd = new GridFormTeacherList();
            fd.ShowForm();
        }


        private void дисциплинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridFormDisciplineList fd = new GridFormDisciplineList();
            fd.ShowForm();
        }

        private void инфОРодителяхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridFormInformationParentList fd = new GridFormInformationParentList();
            fd.ShowForm();
        }

        private void назначенныйУчительToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GridFormAssignedTeacherList.fw.ShowForm();
        }

        private void оценкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GridFormRatingList fd = new GridFormRatingList();
            fd.ShowForm();
        }

        private void ученикToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GridFormStudentList fd = new GridFormStudentList();
            fd.ShowForm();
        }

        private void запросыSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL fd = new FormSQL();
            fd.ShowForm();
        }
    }
}
