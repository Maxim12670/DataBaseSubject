﻿using System;
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
    public partial class GridFormInformationParentList : Form
    {
        public GridFormInformationParentList()
        {
            InitializeComponent();
        }

        private static GridFormInformationParentList f;
        public static GridFormInformationParentList fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new GridFormInformationParentList();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }


        private void informationParentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.informationParentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoollDataSet);

        }

        private void GridFormInformationParentList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoollDataSet.InformationParent". При необходимости она может быть перемещена или удалена.
            this.informationParentTableAdapter.Fill(this.schoollDataSet.InformationParent);

        }
    }
}
