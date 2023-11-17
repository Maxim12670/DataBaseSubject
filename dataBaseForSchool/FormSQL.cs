using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.Common;

namespace dataBaseForSchool
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        private void FormSQL_Load(object sender, EventArgs e)
        {

        }

        private static FormSQL f;
        public static FormSQL fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.schoollConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void radioButtonTeacher_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Teacher");
        }

        private void radioButtonStudent_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Student");
        }

        private void radioButtonDiscipline_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Discipline");
        }

        private void buttonF_select_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTeacher.Text))
            {
                MessageBox.Show(
                    "Обязательно укажите фамилию необходимого сотрудника.\nДопустим ввод первых символов.", 
                    "Внимание", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }
            if(checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указан стаж работы", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }

            string sqlSelect = "";

            if (radioButtonDet_condition.Checked)
            {
                sqlSelect = @"select id_teacher, fullName, email, experience, condition
                                from Teacher
                                where condition = 1 and fullName like @last_name
                                group by id_teacher, fullName, email, experience, condition";
            }
            else
            {
                sqlSelect = @"select id_teacher, fullName, email, experience 
                                from Teacher
                                where fullName like @last_name
                                group by id_teacher, fullName, email, experience";
            }

            if(checkBoxMore.Checked)
            {
                sqlSelect += @" having experience >@amount";
            }

            if(checkBoxExperience.Checked)
            {
                sqlSelect += @" order by experience asc";
            }


            SqlConnection connection = new SqlConnection(Properties.Settings.Default.schoollConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@last_name", textBoxTeacher.Text + "%");

            if(checkBoxMore.Checked)
            {
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Int).Value = Int32.Parse(textBoxMore.Text);
                }
                catch
                {
                    MessageBox.Show("Стаж в условии должна быть задана числом", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                    checkBoxMore.Checked = false;
                    return;
                }
            }




            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нет значений!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Обязательно укажите номер необходимой оценки", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlSelect = "";

            if(adioButtonCorrelated.Checked)
            {
                sqlSelect = @"select fullName, education
                                from Student
                                where id_student in (select id_student
					            from Rating
					            where rating = @number)";
            }
            else if (radioButtonNoCorrelated.Checked)
            {
                sqlSelect = @"select fullName, education, registration
                                from Student
                                where @number in 
		                        (select rating
		                        from Rating
		                        where id_student = Student.id_student)";
            }
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.schoollConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.Add("@number", SqlDbType.Int).Value =
               int.Parse(textBoxNumber.Text);
            }
            catch
            {
                MessageBox.Show("Оценка в условии должна быть задана числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        string fileImage = "";

        private void buttonOpenPhoto_student_Click(object sender, EventArgs e)
        {
            openFileDialogStudent.Title = "Укажите файл для фото";
            if (openFileDialogStudent.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogStudent.FileName;
                try
                {
                    pictureBoxPhoto_student.Load(openFileDialogStudent.FileName);
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

        void InsertStudent()
        {
            if(
                    (String.IsNullOrEmpty(textBoxName_student.Text)) ||
                    (String.IsNullOrEmpty(textBoxEducation_student.Text)) ||
                    (String.IsNullOrEmpty(textBoxRegistration_student.Text)))
            {
                MessageBox.Show("Обязательно введите ФИО, образование и прописку ученика", "Внимание", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
            }
            int _ed;
            if (!int.TryParse(textBoxEducation_student.Text, out _ed))
            {
                MessageBox.Show("Некоректное значение образования ученика!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlInsert = @"insert into Student (fullName, education, registration, photo) 
                                    values (@fullName, @educat, @registr, @photo)";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.schoollConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@fullName", textBoxName_student.Text);
            command.Parameters.AddWithValue("@educat", SqlDbType.Int).Value = textBoxEducation_student.Text;
            command.Parameters.AddWithValue("@registr", textBoxRegistration_student.Text);

            if (!String.IsNullOrEmpty(fileImage))
            {
                command.Parameters.AddWithValue("@Photo", File.ReadAllBytes(fileImage));
            }
            else
            {
                command.Parameters.Add("@Photo", SqlDbType.VarBinary);
                command.Parameters["@Photo"].Value = DBNull.Value;
            }
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
            buttonSelectStudent_Click(this, EventArgs.Empty);
        }

        private void buttonSelectStudent_Click(object sender, EventArgs e)
        {
            dataGridViewStudent.DataSource = FillDataGridView("SELECT * FROM Student");
            DataGridViewImageColumn column =
            (DataGridViewImageColumn)dataGridViewStudent.Columns["photo"];
            column.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        void UpdateStudent()
        {
            if (String.IsNullOrEmpty(textBoxId_student.Text))
            {
                MessageBox.Show("Обязательно укажите код ученика, для которого будете менять данные",
                    "Внимание", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                return;
            }
            int id;
            if (!int.TryParse(textBoxId_student.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода ученика!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlUpdate = "UPDATE Student SET {0} WHERE id_student = @id";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.schoollConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            if (!String.IsNullOrEmpty(textBoxName_student.Text))
                sqlValues += "fullName=@fullName,";
            if (!String.IsNullOrEmpty(textBoxEducation_student.Text))
                sqlValues += "education=@educat,";
            if (!String.IsNullOrEmpty(textBoxRegistration_student.Text))
                sqlValues += "registration=@registr,";

            if (!String.IsNullOrEmpty(fileImage))
                sqlValues += "photo=@photo,";
            sqlValues = sqlValues.Substring(0, sqlValues.Length - 1);
            command.CommandText = String.Format(sqlUpdate, sqlValues);
            if (!String.IsNullOrEmpty(textBoxName_student.Text))
                command.Parameters.AddWithValue(
                    "@fullName", textBoxName_student.Text);
            if (!String.IsNullOrEmpty(textBoxEducation_student.Text))
                command.Parameters.AddWithValue("@educat", SqlDbType.NVarChar).Value =
                    textBoxEducation_student.Text;
            if (!String.IsNullOrEmpty(textBoxRegistration_student.Text))
                command.Parameters.AddWithValue(
                    "@registr", textBoxRegistration_student.Text);
            if (!String.IsNullOrEmpty(fileImage))
                command.Parameters.AddWithValue("@photo",
               File.ReadAllBytes(fileImage));
            command.Parameters.AddWithValue("@id", id);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            buttonSelectStudent_Click(this, EventArgs.Empty);
        }

        void DeleteStudent()
        {
            if (String.IsNullOrEmpty(textBoxId_student.Text))
            {
                MessageBox.Show("Обязательно укажите код ученика данные которого необходимо удалить", 
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            int _id;
            if (!int.TryParse(textBoxId_student.Text, out _id))
            {
                MessageBox.Show("Некоректное значение кода ученика!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlDelete = @"delete from Student where id_student=@id_student";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.schoollConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@id_student", _id);

            try
            {
                command.ExecuteNonQuery();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonSelectStudent_Click(this, EventArgs.Empty);

        }

        private void radioButtonDelete_student_CheckedChanged(object sender, EventArgs e)
        {
            panelStudent.Visible = !radioButtonDelete_student.Checked;
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert_student.Checked)
            {
                InsertStudent();
            }
            else if (radioButtonUpdate_student.Checked)
            {
                UpdateStudent();
            }
            else if (radioButtonDelete_student.Checked)
            {
                DeleteStudent();
            }
            else
            {
                MessageBox.Show("Вы не выбрали действие", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


    }
}

