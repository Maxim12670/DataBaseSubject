namespace dataBaseForSchool
{
    partial class FormSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.radioButtonDiscipline = new System.Windows.Forms.RadioButton();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonTeacher = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.checkBoxExperience = new System.Windows.Forms.CheckBox();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.buttonF_select = new System.Windows.Forms.Button();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButton_NO = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_condition = new System.Windows.Forms.RadioButton();
            this.textBoxTeacher = new System.Windows.Forms.TextBox();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.adioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.buttonSelectStudent = new System.Windows.Forms.Button();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.buttonOpenPhoto_student = new System.Windows.Forms.Button();
            this.pictureBoxPhoto_student = new System.Windows.Forms.PictureBox();
            this.textBoxEducation_student = new System.Windows.Forms.TextBox();
            this.labelEducation_student = new System.Windows.Forms.Label();
            this.textBoxRegistration_student = new System.Windows.Forms.TextBox();
            this.labelRegistration_student = new System.Windows.Forms.Label();
            this.labelPhoto_student = new System.Windows.Forms.Label();
            this.textBoxName_student = new System.Windows.Forms.TextBox();
            this.labelName_student = new System.Windows.Forms.Label();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.textBoxId_student = new System.Windows.Forms.TextBox();
            this.labelId_student = new System.Windows.Forms.Label();
            this.radioButtonDelete_student = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate_student = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert_student = new System.Windows.Forms.RadioButton();
            this.openFileDialogStudent = new System.Windows.Forms.OpenFileDialog();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            this.groupBoxSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.tabPageSelect.SuspendLayout();
            this.groupBoxFSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxDet.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.panelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_student)).BeginInit();
            this.groupBoxDML.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubquery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(1053, 587);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(1045, 558);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.dataGridViewSelect);
            this.groupBoxSelect.Controls.Add(this.radioButtonDiscipline);
            this.groupBoxSelect.Controls.Add(this.radioButtonStudent);
            this.groupBoxSelect.Controls.Add(this.radioButtonTeacher);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(1039, 552);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 38);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.RowHeadersWidth = 51;
            this.dataGridViewSelect.RowTemplate.Height = 24;
            this.dataGridViewSelect.Size = new System.Drawing.Size(1033, 511);
            this.dataGridViewSelect.TabIndex = 3;
            // 
            // radioButtonDiscipline
            // 
            this.radioButtonDiscipline.AutoSize = true;
            this.radioButtonDiscipline.Location = new System.Drawing.Point(181, 18);
            this.radioButtonDiscipline.Name = "radioButtonDiscipline";
            this.radioButtonDiscipline.Size = new System.Drawing.Size(109, 20);
            this.radioButtonDiscipline.TabIndex = 2;
            this.radioButtonDiscipline.TabStop = true;
            this.radioButtonDiscipline.Text = "Дисциплины";
            this.radioButtonDiscipline.UseVisualStyleBackColor = true;
            this.radioButtonDiscipline.CheckedChanged += new System.EventHandler(this.radioButtonDiscipline_CheckedChanged);
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(91, 18);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(84, 20);
            this.radioButtonStudent.TabIndex = 1;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Ученики";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            this.radioButtonStudent.CheckedChanged += new System.EventHandler(this.radioButtonStudent_CheckedChanged);
            // 
            // radioButtonTeacher
            // 
            this.radioButtonTeacher.AutoSize = true;
            this.radioButtonTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonTeacher.Location = new System.Drawing.Point(3, 18);
            this.radioButtonTeacher.Name = "radioButtonTeacher";
            this.radioButtonTeacher.Size = new System.Drawing.Size(1033, 20);
            this.radioButtonTeacher.TabIndex = 0;
            this.radioButtonTeacher.TabStop = true;
            this.radioButtonTeacher.Text = "Учители";
            this.radioButtonTeacher.UseVisualStyleBackColor = true;
            this.radioButtonTeacher.CheckedChanged += new System.EventHandler(this.radioButtonTeacher_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 25);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(1045, 558);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.checkBoxExperience);
            this.groupBoxFSelect.Controls.Add(this.dataGridViewFSelect);
            this.groupBoxFSelect.Controls.Add(this.buttonF_select);
            this.groupBoxFSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFSelect.Controls.Add(this.groupBoxDet);
            this.groupBoxFSelect.Controls.Add(this.textBoxTeacher);
            this.groupBoxFSelect.Controls.Add(this.labelTeacher);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(1039, 552);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Информация об учителях";
            // 
            // checkBoxExperience
            // 
            this.checkBoxExperience.AutoSize = true;
            this.checkBoxExperience.Location = new System.Drawing.Point(9, 121);
            this.checkBoxExperience.Name = "checkBoxExperience";
            this.checkBoxExperience.Size = new System.Drawing.Size(376, 20);
            this.checkBoxExperience.TabIndex = 7;
            this.checkBoxExperience.Text = "Включить сортировку по возрастанию стажа работы";
            this.checkBoxExperience.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 318);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.RowHeadersWidth = 51;
            this.dataGridViewFSelect.RowTemplate.Height = 24;
            this.dataGridViewFSelect.Size = new System.Drawing.Size(1033, 231);
            this.dataGridViewFSelect.TabIndex = 6;
            // 
            // buttonF_select
            // 
            this.buttonF_select.Image = global::dataBaseForSchool.Properties.Resources.icons8_учитель;
            this.buttonF_select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonF_select.Location = new System.Drawing.Point(294, 147);
            this.buttonF_select.Name = "buttonF_select";
            this.buttonF_select.Size = new System.Drawing.Size(139, 28);
            this.buttonF_select.TabIndex = 5;
            this.buttonF_select.Text = "Поиск учителей";
            this.buttonF_select.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonF_select.UseVisualStyleBackColor = true;
            this.buttonF_select.Click += new System.EventHandler(this.buttonF_select_Click);
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(179, 74);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(100, 22);
            this.textBoxMore.TabIndex = 4;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(9, 76);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(164, 20);
            this.checkBoxMore.TabIndex = 3;
            this.checkBoxMore.Text = "Стаж работы больше";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButton_NO);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_condition);
            this.groupBoxDet.Location = new System.Drawing.Point(431, 21);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(349, 76);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация учителей";
            // 
            // radioButton_NO
            // 
            this.radioButton_NO.AutoSize = true;
            this.radioButton_NO.Location = new System.Drawing.Point(6, 47);
            this.radioButton_NO.Name = "radioButton_NO";
            this.radioButton_NO.Size = new System.Drawing.Size(143, 20);
            this.radioButton_NO.TabIndex = 1;
            this.radioButton_NO.TabStop = true;
            this.radioButton_NO.Text = "Нет детализаций";
            this.radioButton_NO.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_condition
            // 
            this.radioButtonDet_condition.AutoSize = true;
            this.radioButtonDet_condition.Location = new System.Drawing.Point(6, 21);
            this.radioButtonDet_condition.Name = "radioButtonDet_condition";
            this.radioButtonDet_condition.Size = new System.Drawing.Size(212, 20);
            this.radioButtonDet_condition.TabIndex = 0;
            this.radioButtonDet_condition.TabStop = true;
            this.radioButtonDet_condition.Text = "Наличие учителя на работе";
            this.radioButtonDet_condition.UseVisualStyleBackColor = true;
            // 
            // textBoxTeacher
            // 
            this.textBoxTeacher.Location = new System.Drawing.Point(106, 39);
            this.textBoxTeacher.Name = "textBoxTeacher";
            this.textBoxTeacher.Size = new System.Drawing.Size(173, 22);
            this.textBoxTeacher.TabIndex = 1;
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(5, 42);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(95, 16);
            this.labelTeacher.TabIndex = 0;
            this.labelTeacher.Text = "ФИО учителя";
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 25);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(1045, 558);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(3, 128);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.RowHeadersWidth = 51;
            this.dataGridViewSubquery.RowTemplate.Height = 24;
            this.dataGridViewSubquery.Size = new System.Drawing.Size(1039, 427);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxNumber);
            this.groupBoxSubquery.Controls.Add(this.labelNumber);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.adioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(1039, 125);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(428, 77);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(176, 32);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(193, 87);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(103, 22);
            this.textBoxNumber.TabIndex = 3;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(131, 90);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(56, 16);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Оценка";
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(428, 40);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(240, 20);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // adioButtonCorrelated
            // 
            this.adioButtonCorrelated.AutoSize = true;
            this.adioButtonCorrelated.Location = new System.Drawing.Point(73, 40);
            this.adioButtonCorrelated.Name = "adioButtonCorrelated";
            this.adioButtonCorrelated.Size = new System.Drawing.Size(223, 20);
            this.adioButtonCorrelated.TabIndex = 0;
            this.adioButtonCorrelated.TabStop = true;
            this.adioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.adioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.buttonSelectStudent);
            this.tabPageDML.Controls.Add(this.dataGridViewStudent);
            this.tabPageDML.Controls.Add(this.panelStudent);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 25);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(1045, 558);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // buttonSelectStudent
            // 
            this.buttonSelectStudent.Location = new System.Drawing.Point(343, 278);
            this.buttonSelectStudent.Name = "buttonSelectStudent";
            this.buttonSelectStudent.Size = new System.Drawing.Size(205, 27);
            this.buttonSelectStudent.TabIndex = 3;
            this.buttonSelectStudent.Text = "Показать список учеников";
            this.buttonSelectStudent.UseVisualStyleBackColor = true;
            this.buttonSelectStudent.Click += new System.EventHandler(this.buttonSelectStudent_Click);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewStudent.Location = new System.Drawing.Point(3, 311);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.RowTemplate.Height = 24;
            this.dataGridViewStudent.Size = new System.Drawing.Size(1039, 244);
            this.dataGridViewStudent.TabIndex = 2;
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.buttonOpenPhoto_student);
            this.panelStudent.Controls.Add(this.pictureBoxPhoto_student);
            this.panelStudent.Controls.Add(this.textBoxEducation_student);
            this.panelStudent.Controls.Add(this.labelEducation_student);
            this.panelStudent.Controls.Add(this.textBoxRegistration_student);
            this.panelStudent.Controls.Add(this.labelRegistration_student);
            this.panelStudent.Controls.Add(this.labelPhoto_student);
            this.panelStudent.Controls.Add(this.textBoxName_student);
            this.panelStudent.Controls.Add(this.labelName_student);
            this.panelStudent.Location = new System.Drawing.Point(3, 100);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(1039, 172);
            this.panelStudent.TabIndex = 1;
            // 
            // buttonOpenPhoto_student
            // 
            this.buttonOpenPhoto_student.Location = new System.Drawing.Point(381, 137);
            this.buttonOpenPhoto_student.Name = "buttonOpenPhoto_student";
            this.buttonOpenPhoto_student.Size = new System.Drawing.Size(118, 27);
            this.buttonOpenPhoto_student.TabIndex = 9;
            this.buttonOpenPhoto_student.Text = "Открыть фото";
            this.buttonOpenPhoto_student.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto_student.Click += new System.EventHandler(this.buttonOpenPhoto_student_Click);
            // 
            // pictureBoxPhoto_student
            // 
            this.pictureBoxPhoto_student.Location = new System.Drawing.Point(381, 22);
            this.pictureBoxPhoto_student.Name = "pictureBoxPhoto_student";
            this.pictureBoxPhoto_student.Size = new System.Drawing.Size(118, 109);
            this.pictureBoxPhoto_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto_student.TabIndex = 8;
            this.pictureBoxPhoto_student.TabStop = false;
            // 
            // textBoxEducation_student
            // 
            this.textBoxEducation_student.Location = new System.Drawing.Point(109, 60);
            this.textBoxEducation_student.Name = "textBoxEducation_student";
            this.textBoxEducation_student.Size = new System.Drawing.Size(176, 22);
            this.textBoxEducation_student.TabIndex = 7;
            // 
            // labelEducation_student
            // 
            this.labelEducation_student.AutoSize = true;
            this.labelEducation_student.Location = new System.Drawing.Point(6, 63);
            this.labelEducation_student.Name = "labelEducation_student";
            this.labelEducation_student.Size = new System.Drawing.Size(97, 16);
            this.labelEducation_student.TabIndex = 6;
            this.labelEducation_student.Text = "Образование";
            // 
            // textBoxRegistration_student
            // 
            this.textBoxRegistration_student.Location = new System.Drawing.Point(109, 94);
            this.textBoxRegistration_student.Name = "textBoxRegistration_student";
            this.textBoxRegistration_student.Size = new System.Drawing.Size(176, 22);
            this.textBoxRegistration_student.TabIndex = 5;
            // 
            // labelRegistration_student
            // 
            this.labelRegistration_student.AutoSize = true;
            this.labelRegistration_student.Location = new System.Drawing.Point(27, 100);
            this.labelRegistration_student.Name = "labelRegistration_student";
            this.labelRegistration_student.Size = new System.Drawing.Size(71, 16);
            this.labelRegistration_student.TabIndex = 4;
            this.labelRegistration_student.Text = "Прописка";
            // 
            // labelPhoto_student
            // 
            this.labelPhoto_student.AutoSize = true;
            this.labelPhoto_student.Location = new System.Drawing.Point(391, 3);
            this.labelPhoto_student.Name = "labelPhoto_student";
            this.labelPhoto_student.Size = new System.Drawing.Size(99, 16);
            this.labelPhoto_student.TabIndex = 2;
            this.labelPhoto_student.Text = "Фото ученика";
            // 
            // textBoxName_student
            // 
            this.textBoxName_student.Location = new System.Drawing.Point(50, 19);
            this.textBoxName_student.Name = "textBoxName_student";
            this.textBoxName_student.Size = new System.Drawing.Size(235, 22);
            this.textBoxName_student.TabIndex = 1;
            // 
            // labelName_student
            // 
            this.labelName_student.AutoSize = true;
            this.labelName_student.Location = new System.Drawing.Point(6, 22);
            this.labelName_student.Name = "labelName_student";
            this.labelName_student.Size = new System.Drawing.Size(38, 16);
            this.labelName_student.TabIndex = 0;
            this.labelName_student.Text = "ФИО";
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.textBoxId_student);
            this.groupBoxDML.Controls.Add(this.labelId_student);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete_student);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate_student);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert_student);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(1039, 97);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(245, 60);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(141, 31);
            this.buttonExecuteDML.TabIndex = 5;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // textBoxId_student
            // 
            this.textBoxId_student.Location = new System.Drawing.Point(101, 64);
            this.textBoxId_student.Name = "textBoxId_student";
            this.textBoxId_student.Size = new System.Drawing.Size(100, 22);
            this.textBoxId_student.TabIndex = 4;
            // 
            // labelId_student
            // 
            this.labelId_student.AutoSize = true;
            this.labelId_student.Location = new System.Drawing.Point(6, 67);
            this.labelId_student.Name = "labelId_student";
            this.labelId_student.Size = new System.Drawing.Size(89, 16);
            this.labelId_student.TabIndex = 3;
            this.labelId_student.Text = "Код ученика";
            // 
            // radioButtonDelete_student
            // 
            this.radioButtonDelete_student.AutoSize = true;
            this.radioButtonDelete_student.Location = new System.Drawing.Point(587, 31);
            this.radioButtonDelete_student.Name = "radioButtonDelete_student";
            this.radioButtonDelete_student.Size = new System.Drawing.Size(193, 20);
            this.radioButtonDelete_student.TabIndex = 2;
            this.radioButtonDelete_student.TabStop = true;
            this.radioButtonDelete_student.Text = "Удалить данные ученика";
            this.radioButtonDelete_student.UseVisualStyleBackColor = true;
            this.radioButtonDelete_student.CheckedChanged += new System.EventHandler(this.radioButtonDelete_student_CheckedChanged);
            // 
            // radioButtonUpdate_student
            // 
            this.radioButtonUpdate_student.AutoSize = true;
            this.radioButtonUpdate_student.Location = new System.Drawing.Point(245, 31);
            this.radioButtonUpdate_student.Name = "radioButtonUpdate_student";
            this.radioButtonUpdate_student.Size = new System.Drawing.Size(325, 20);
            this.radioButtonUpdate_student.TabIndex = 1;
            this.radioButtonUpdate_student.TabStop = true;
            this.radioButtonUpdate_student.Text = "Изменить данные ученика с заданным кодом";
            this.radioButtonUpdate_student.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsert_student
            // 
            this.radioButtonInsert_student.AutoSize = true;
            this.radioButtonInsert_student.Location = new System.Drawing.Point(6, 31);
            this.radioButtonInsert_student.Name = "radioButtonInsert_student";
            this.radioButtonInsert_student.Size = new System.Drawing.Size(220, 20);
            this.radioButtonInsert_student.TabIndex = 0;
            this.radioButtonInsert_student.TabStop = true;
            this.radioButtonInsert_student.Text = "Добавить данные по ученику";
            this.radioButtonInsert_student.UseVisualStyleBackColor = true;
            // 
            // openFileDialogStudent
            // 
            this.openFileDialogStudent.FileName = "openFileDialogStudent";
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 587);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.Load += new System.EventHandler(this.FormSQL_Load);
            this.tabControlSQL.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.tabPageSelect.ResumeLayout(false);
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_student)).EndInit();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.RadioButton radioButtonDiscipline;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.RadioButton radioButtonTeacher;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.TextBox textBoxTeacher;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Button buttonF_select;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.RadioButton radioButton_NO;
        private System.Windows.Forms.RadioButton radioButtonDet_condition;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.CheckBox checkBoxExperience;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton adioButtonCorrelated;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.TextBox textBoxId_student;
        private System.Windows.Forms.Label labelId_student;
        private System.Windows.Forms.RadioButton radioButtonDelete_student;
        private System.Windows.Forms.RadioButton radioButtonUpdate_student;
        private System.Windows.Forms.RadioButton radioButtonInsert_student;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.TextBox textBoxEducation_student;
        private System.Windows.Forms.Label labelEducation_student;
        private System.Windows.Forms.TextBox textBoxRegistration_student;
        private System.Windows.Forms.Label labelRegistration_student;
        private System.Windows.Forms.Label labelPhoto_student;
        private System.Windows.Forms.TextBox textBoxName_student;
        private System.Windows.Forms.Label labelName_student;
        private System.Windows.Forms.Button buttonOpenPhoto_student;
        private System.Windows.Forms.PictureBox pictureBoxPhoto_student;
        private System.Windows.Forms.OpenFileDialog openFileDialogStudent;
        private System.Windows.Forms.Button buttonSelectStudent;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
    }
}