namespace dataBaseForSchool
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дисциплинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инфОРодителяхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назначенныйУчительToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ученикToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.учителяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ученикиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonTeacher = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAssignedTeacher = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDiscipline = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRating = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStudent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInformationParent = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникToolStripMenuItem,
            this.документацияToolStripMenuItem,
            this.запросыSQLToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "Файл";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem.Text = "о Программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учителяToolStripMenuItem,
            this.дисциплинаToolStripMenuItem,
            this.инфОРодителяхToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // учителяToolStripMenuItem
            // 
            this.учителяToolStripMenuItem.Image = global::dataBaseForSchool.Properties.Resources.icons8_учитель;
            this.учителяToolStripMenuItem.Name = "учителяToolStripMenuItem";
            this.учителяToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.учителяToolStripMenuItem.Text = "Учителя";
            this.учителяToolStripMenuItem.Click += new System.EventHandler(this.учителяToolStripMenuItem_Click);
            // 
            // дисциплинаToolStripMenuItem
            // 
            this.дисциплинаToolStripMenuItem.Image = global::dataBaseForSchool.Properties.Resources.icons8_дисциплина;
            this.дисциплинаToolStripMenuItem.Name = "дисциплинаToolStripMenuItem";
            this.дисциплинаToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.дисциплинаToolStripMenuItem.Text = "Дисциплина";
            this.дисциплинаToolStripMenuItem.Click += new System.EventHandler(this.дисциплинаToolStripMenuItem_Click);
            // 
            // инфОРодителяхToolStripMenuItem
            // 
            this.инфОРодителяхToolStripMenuItem.Image = global::dataBaseForSchool.Properties.Resources.icons8_инф_о_родителях;
            this.инфОРодителяхToolStripMenuItem.Name = "инфОРодителяхToolStripMenuItem";
            this.инфОРодителяхToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.инфОРодителяхToolStripMenuItem.Text = "Инф о родителях";
            this.инфОРодителяхToolStripMenuItem.Click += new System.EventHandler(this.инфОРодителяхToolStripMenuItem_Click);
            // 
            // документацияToolStripMenuItem
            // 
            this.документацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назначенныйУчительToolStripMenuItem1,
            this.оценкаToolStripMenuItem1,
            this.ученикToolStripMenuItem1});
            this.документацияToolStripMenuItem.Name = "документацияToolStripMenuItem";
            this.документацияToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.документацияToolStripMenuItem.Text = "Документация";
            // 
            // назначенныйУчительToolStripMenuItem1
            // 
            this.назначенныйУчительToolStripMenuItem1.Image = global::dataBaseForSchool.Properties.Resources.icons8_Назначенный_учитель;
            this.назначенныйУчительToolStripMenuItem1.Name = "назначенныйУчительToolStripMenuItem1";
            this.назначенныйУчительToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.назначенныйУчительToolStripMenuItem1.Text = "Назначенный учитель";
            this.назначенныйУчительToolStripMenuItem1.Click += new System.EventHandler(this.назначенныйУчительToolStripMenuItem1_Click);
            // 
            // оценкаToolStripMenuItem1
            // 
            this.оценкаToolStripMenuItem1.Image = global::dataBaseForSchool.Properties.Resources.icons8_оценка;
            this.оценкаToolStripMenuItem1.Name = "оценкаToolStripMenuItem1";
            this.оценкаToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.оценкаToolStripMenuItem1.Text = "Оценка";
            this.оценкаToolStripMenuItem1.Click += new System.EventHandler(this.оценкаToolStripMenuItem1_Click);
            // 
            // ученикToolStripMenuItem1
            // 
            this.ученикToolStripMenuItem1.Image = global::dataBaseForSchool.Properties.Resources.icons8_студент;
            this.ученикToolStripMenuItem1.Name = "ученикToolStripMenuItem1";
            this.ученикToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.ученикToolStripMenuItem1.Text = "Ученик";
            this.ученикToolStripMenuItem1.Click += new System.EventHandler(this.ученикToolStripMenuItem1_Click);
            // 
            // запросыSQLToolStripMenuItem
            // 
            this.запросыSQLToolStripMenuItem.Name = "запросыSQLToolStripMenuItem";
            this.запросыSQLToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.запросыSQLToolStripMenuItem.Text = "Запросы SQL";
            this.запросыSQLToolStripMenuItem.Click += new System.EventHandler(this.запросыSQLToolStripMenuItem_Click);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.справочникToolStripMenuItem1});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(164, 52);
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem1});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(163, 24);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem1.Text = "о Программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справочникToolStripMenuItem1
            // 
            this.справочникToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учителяToolStripMenuItem1,
            this.ученикиToolStripMenuItem1});
            this.справочникToolStripMenuItem1.Name = "справочникToolStripMenuItem1";
            this.справочникToolStripMenuItem1.Size = new System.Drawing.Size(163, 24);
            this.справочникToolStripMenuItem1.Text = "Справочник";
            // 
            // учителяToolStripMenuItem1
            // 
            this.учителяToolStripMenuItem1.Name = "учителяToolStripMenuItem1";
            this.учителяToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.учителяToolStripMenuItem1.Text = "Учителя";
            // 
            // ученикиToolStripMenuItem1
            // 
            this.ученикиToolStripMenuItem1.Name = "ученикиToolStripMenuItem1";
            this.ученикиToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.ученикиToolStripMenuItem1.Text = "Ученики";
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonTeacher,
            this.toolStripButtonAssignedTeacher,
            this.toolStripButtonDiscipline,
            this.toolStripButtonRating,
            this.toolStripButtonStudent,
            this.toolStripButtonInformationParent});
            this.toolStripMain.Location = new System.Drawing.Point(0, 28);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(800, 27);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonTeacher
            // 
            this.toolStripButtonTeacher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTeacher.Image = global::dataBaseForSchool.Properties.Resources.icons8_учитель;
            this.toolStripButtonTeacher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTeacher.Name = "toolStripButtonTeacher";
            this.toolStripButtonTeacher.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonTeacher.Text = "toolStripButtonTeacher";
            this.toolStripButtonTeacher.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonAssignedTeacher
            // 
            this.toolStripButtonAssignedTeacher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAssignedTeacher.Image = global::dataBaseForSchool.Properties.Resources.icons8_Назначенный_учитель;
            this.toolStripButtonAssignedTeacher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAssignedTeacher.Name = "toolStripButtonAssignedTeacher";
            this.toolStripButtonAssignedTeacher.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonAssignedTeacher.Text = "toolStripButtonAssignedTeacher";
            this.toolStripButtonAssignedTeacher.Click += new System.EventHandler(this.toolStripButtonAssignedTeacher_Click);
            // 
            // toolStripButtonDiscipline
            // 
            this.toolStripButtonDiscipline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDiscipline.Image = global::dataBaseForSchool.Properties.Resources.icons8_дисциплина;
            this.toolStripButtonDiscipline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDiscipline.Name = "toolStripButtonDiscipline";
            this.toolStripButtonDiscipline.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonDiscipline.Text = "toolStripButtonDiscipline";
            this.toolStripButtonDiscipline.Click += new System.EventHandler(this.toolStripButtonDiscipline_Click);
            // 
            // toolStripButtonRating
            // 
            this.toolStripButtonRating.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRating.Image = global::dataBaseForSchool.Properties.Resources.icons8_оценка;
            this.toolStripButtonRating.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRating.Name = "toolStripButtonRating";
            this.toolStripButtonRating.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonRating.Text = "toolStripButtonRating";
            this.toolStripButtonRating.Click += new System.EventHandler(this.toolStripButtonRating_Click);
            // 
            // toolStripButtonStudent
            // 
            this.toolStripButtonStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStudent.Image = global::dataBaseForSchool.Properties.Resources.icons8_студент;
            this.toolStripButtonStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStudent.Name = "toolStripButtonStudent";
            this.toolStripButtonStudent.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonStudent.Text = "toolStripButtonStudent";
            this.toolStripButtonStudent.Click += new System.EventHandler(this.toolStripButtonStudent_Click);
            // 
            // toolStripButtonInformationParent
            // 
            this.toolStripButtonInformationParent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInformationParent.Image = global::dataBaseForSchool.Properties.Resources.icons8_инф_о_родителях;
            this.toolStripButtonInformationParent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInformationParent.Name = "toolStripButtonInformationParent";
            this.toolStripButtonInformationParent.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonInformationParent.Text = "toolStripButtonInformationParent";
            this.toolStripButtonInformationParent.Click += new System.EventHandler(this.toolStripButtonInformationParent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStripMain;
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::dataBaseForSchool.Properties.Settings.Default, "FormPos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::dataBaseForSchool.Properties.Settings.Default.FormPos;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Program for school";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учителяToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem учителяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ученикиToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonTeacher;
        private System.Windows.Forms.ToolStripButton toolStripButtonAssignedTeacher;
        private System.Windows.Forms.ToolStripButton toolStripButtonDiscipline;
        private System.Windows.Forms.ToolStripMenuItem дисциплинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инфОРодителяхToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonRating;
        private System.Windows.Forms.ToolStripButton toolStripButtonStudent;
        private System.Windows.Forms.ToolStripButton toolStripButtonInformationParent;
        private System.Windows.Forms.ToolStripMenuItem документацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назначенныйУчительToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оценкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ученикToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem запросыSQLToolStripMenuItem;
    }
}

