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
    public partial class FormStudentList : Form
    {
        public FormStudentList()
        {
            InitializeComponent();
        }

        private static FormStudentList f;
        public static FormStudentList fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormStudentList();
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

        private void FormStudentList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoollDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.schoollDataSet.Student);

        }

        string fileImage = "";
        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogPhoto = new OpenFileDialog();
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                try
                {
                    photoPictureBox.Image = new
                   Bitmap(openFileDialogPhoto.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else fileImage = "";
        }
    }
}
