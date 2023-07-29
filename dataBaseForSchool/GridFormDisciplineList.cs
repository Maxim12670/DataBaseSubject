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
    public partial class GridFormDisciplineList : Form
    {
        public GridFormDisciplineList()
        {
            InitializeComponent();
        }

        private static GridFormDisciplineList f;
        public static GridFormDisciplineList fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new GridFormDisciplineList();
                return f;
            }
        }


        private void disciplineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disciplineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoollDataSet);

        }

        private void GridFormDisciplineList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoollDataSet.Discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.schoollDataSet.Discipline);

        }

        int idCurrent = -1;

        public int ShowSelectForm(int id)
        {
            idCurrent = id;
            toolStripButtonOK.Visible = true;
            if (ShowDialog() == DialogResult.OK)
                return
               (int)((DataRowView)disciplineBindingSource.Current)["id_discipline"];
            else
                return -1;
        }

        private void GridFormDisciplineList_Shown(object sender, EventArgs e)
        {
            disciplineBindingSource.Position = disciplineBindingSource.Find("id_discipline", idCurrent);
        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            disciplineBindingSource.Position = 0;
            Show();
            Activate();
        }

    }
}
