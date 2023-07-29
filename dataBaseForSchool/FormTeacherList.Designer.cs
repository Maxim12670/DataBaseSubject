namespace dataBaseForSchool
{
    partial class FormTeacherList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_teacherLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label experienceLabel;
            System.Windows.Forms.Label conditionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacherList));
            this.schoollDataSet = new dataBaseForSchool.schoollDataSet();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new dataBaseForSchool.schoollDataSetTableAdapters.TeacherTableAdapter();
            this.tableAdapterManager = new dataBaseForSchool.schoollDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.teacherBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.id_teacherTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.experienceTextBox = new System.Windows.Forms.TextBox();
            this.conditionCheckBox = new System.Windows.Forms.CheckBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.teacherBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            id_teacherLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            experienceLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoollDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingNavigator)).BeginInit();
            this.teacherBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // schoollDataSet
            // 
            this.schoollDataSet.DataSetName = "schoollDataSet";
            this.schoollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.schoollDataSet;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignedTeacherTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.InformationParentTableAdapter = null;
            this.tableAdapterManager.RatingTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = this.teacherTableAdapter;
            this.tableAdapterManager.UpdateOrder = dataBaseForSchool.schoollDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // teacherBindingNavigator
            // 
            this.teacherBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.teacherBindingNavigator.BindingSource = this.teacherBindingSource;
            this.teacherBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teacherBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.teacherBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.teacherBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.teacherBindingNavigatorSaveItem});
            this.teacherBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teacherBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teacherBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teacherBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teacherBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teacherBindingNavigator.Name = "teacherBindingNavigator";
            this.teacherBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teacherBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.teacherBindingNavigator.TabIndex = 0;
            this.teacherBindingNavigator.Text = "bindingNavigator1";
            // 
            // id_teacherLabel
            // 
            id_teacherLabel.AutoSize = true;
            id_teacherLabel.Location = new System.Drawing.Point(12, 46);
            id_teacherLabel.Name = "id_teacherLabel";
            id_teacherLabel.Size = new System.Drawing.Size(69, 16);
            id_teacherLabel.TabIndex = 1;
            id_teacherLabel.Text = "id teacher:";
            // 
            // id_teacherTextBox
            // 
            this.id_teacherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "id_teacher", true));
            this.id_teacherTextBox.Location = new System.Drawing.Point(95, 43);
            this.id_teacherTextBox.Name = "id_teacherTextBox";
            this.id_teacherTextBox.Size = new System.Drawing.Size(300, 22);
            this.id_teacherTextBox.TabIndex = 2;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(12, 74);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(66, 16);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "full Name:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "fullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(95, 71);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(300, 22);
            this.fullNameTextBox.TabIndex = 4;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 102);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(43, 16);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(95, 99);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(300, 22);
            this.emailTextBox.TabIndex = 6;
            // 
            // experienceLabel
            // 
            experienceLabel.AutoSize = true;
            experienceLabel.Location = new System.Drawing.Point(12, 130);
            experienceLabel.Name = "experienceLabel";
            experienceLabel.Size = new System.Drawing.Size(77, 16);
            experienceLabel.TabIndex = 7;
            experienceLabel.Text = "experience:";
            // 
            // experienceTextBox
            // 
            this.experienceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "experience", true));
            this.experienceTextBox.Location = new System.Drawing.Point(95, 127);
            this.experienceTextBox.Name = "experienceTextBox";
            this.experienceTextBox.Size = new System.Drawing.Size(300, 22);
            this.experienceTextBox.TabIndex = 8;
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(12, 160);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(64, 16);
            conditionLabel.TabIndex = 9;
            conditionLabel.Text = "condition:";
            // 
            // conditionCheckBox
            // 
            this.conditionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.teacherBindingSource, "condition", true));
            this.conditionCheckBox.Location = new System.Drawing.Point(95, 155);
            this.conditionCheckBox.Name = "conditionCheckBox";
            this.conditionCheckBox.Size = new System.Drawing.Size(103, 30);
            this.conditionCheckBox.TabIndex = 10;
            this.conditionCheckBox.Text = "checkBox1";
            this.conditionCheckBox.UseVisualStyleBackColor = true;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // teacherBindingNavigatorSaveItem
            // 
            this.teacherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.teacherBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("teacherBindingNavigatorSaveItem.Image")));
            this.teacherBindingNavigatorSaveItem.Name = "teacherBindingNavigatorSaveItem";
            this.teacherBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.teacherBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.teacherBindingNavigatorSaveItem.Click += new System.EventHandler(this.teacherBindingNavigatorSaveItem_Click);
            // 
            // FormTeacherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(id_teacherLabel);
            this.Controls.Add(this.id_teacherTextBox);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(experienceLabel);
            this.Controls.Add(this.experienceTextBox);
            this.Controls.Add(conditionLabel);
            this.Controls.Add(this.conditionCheckBox);
            this.Controls.Add(this.teacherBindingNavigator);
            this.Name = "FormTeacherList";
            this.Text = "Учитель";
            this.Load += new System.EventHandler(this.FormTeacherList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoollDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingNavigator)).EndInit();
            this.teacherBindingNavigator.ResumeLayout(false);
            this.teacherBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private schoollDataSet schoollDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private schoollDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private schoollDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton teacherBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator teacherBindingNavigator;
        private System.Windows.Forms.TextBox id_teacherTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox experienceTextBox;
        private System.Windows.Forms.CheckBox conditionCheckBox;
    }
}