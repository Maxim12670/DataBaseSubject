namespace dataBaseForSchool
{
    partial class FormAssignedTeacherList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAssignedTeacherList));
            System.Windows.Forms.Label id_teacherLabel;
            System.Windows.Forms.Label id_disciplineLabel;
            this.schoollDataSet = new dataBaseForSchool.schoollDataSet();
            this.assignedTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignedTeacherTableAdapter = new dataBaseForSchool.schoollDataSetTableAdapters.AssignedTeacherTableAdapter();
            this.tableAdapterManager = new dataBaseForSchool.schoollDataSetTableAdapters.TableAdapterManager();
            this.assignedTeacherBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.assignedTeacherBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_teacherTextBox = new System.Windows.Forms.TextBox();
            this.id_disciplineTextBox = new System.Windows.Forms.TextBox();
            id_teacherLabel = new System.Windows.Forms.Label();
            id_disciplineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoollDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedTeacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedTeacherBindingNavigator)).BeginInit();
            this.assignedTeacherBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // schoollDataSet
            // 
            this.schoollDataSet.DataSetName = "schoollDataSet";
            this.schoollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignedTeacherBindingSource
            // 
            this.assignedTeacherBindingSource.DataMember = "AssignedTeacher";
            this.assignedTeacherBindingSource.DataSource = this.schoollDataSet;
            // 
            // assignedTeacherTableAdapter
            // 
            this.assignedTeacherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignedTeacherTableAdapter = this.assignedTeacherTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.InformationParentTableAdapter = null;
            this.tableAdapterManager.RatingTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dataBaseForSchool.schoollDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // assignedTeacherBindingNavigator
            // 
            this.assignedTeacherBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.assignedTeacherBindingNavigator.BindingSource = this.assignedTeacherBindingSource;
            this.assignedTeacherBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.assignedTeacherBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.assignedTeacherBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.assignedTeacherBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.assignedTeacherBindingNavigatorSaveItem});
            this.assignedTeacherBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.assignedTeacherBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.assignedTeacherBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.assignedTeacherBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.assignedTeacherBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.assignedTeacherBindingNavigator.Name = "assignedTeacherBindingNavigator";
            this.assignedTeacherBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.assignedTeacherBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.assignedTeacherBindingNavigator.TabIndex = 0;
            this.assignedTeacherBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // assignedTeacherBindingNavigatorSaveItem
            // 
            this.assignedTeacherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.assignedTeacherBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("assignedTeacherBindingNavigatorSaveItem.Image")));
            this.assignedTeacherBindingNavigatorSaveItem.Name = "assignedTeacherBindingNavigatorSaveItem";
            this.assignedTeacherBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.assignedTeacherBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.assignedTeacherBindingNavigatorSaveItem.Click += new System.EventHandler(this.assignedTeacherBindingNavigatorSaveItem_Click);
            // 
            // id_teacherLabel
            // 
            id_teacherLabel.AutoSize = true;
            id_teacherLabel.Location = new System.Drawing.Point(9, 40);
            id_teacherLabel.Name = "id_teacherLabel";
            id_teacherLabel.Size = new System.Drawing.Size(69, 16);
            id_teacherLabel.TabIndex = 1;
            id_teacherLabel.Text = "id teacher:";
            // 
            // id_teacherTextBox
            // 
            this.id_teacherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignedTeacherBindingSource, "id_teacher", true));
            this.id_teacherTextBox.Location = new System.Drawing.Point(96, 37);
            this.id_teacherTextBox.Name = "id_teacherTextBox";
            this.id_teacherTextBox.Size = new System.Drawing.Size(172, 22);
            this.id_teacherTextBox.TabIndex = 2;
            // 
            // id_disciplineLabel
            // 
            id_disciplineLabel.AutoSize = true;
            id_disciplineLabel.Location = new System.Drawing.Point(9, 68);
            id_disciplineLabel.Name = "id_disciplineLabel";
            id_disciplineLabel.Size = new System.Drawing.Size(81, 16);
            id_disciplineLabel.TabIndex = 3;
            id_disciplineLabel.Text = "id discipline:";
            // 
            // id_disciplineTextBox
            // 
            this.id_disciplineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignedTeacherBindingSource, "id_discipline", true));
            this.id_disciplineTextBox.Location = new System.Drawing.Point(96, 65);
            this.id_disciplineTextBox.Name = "id_disciplineTextBox";
            this.id_disciplineTextBox.Size = new System.Drawing.Size(172, 22);
            this.id_disciplineTextBox.TabIndex = 4;
            // 
            // AssignedTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(id_teacherLabel);
            this.Controls.Add(this.id_teacherTextBox);
            this.Controls.Add(id_disciplineLabel);
            this.Controls.Add(this.id_disciplineTextBox);
            this.Controls.Add(this.assignedTeacherBindingNavigator);
            this.Name = "AssignedTeacher";
            this.Text = "Назначенный учитель";
            this.Load += new System.EventHandler(this.AssignedTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoollDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedTeacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedTeacherBindingNavigator)).EndInit();
            this.assignedTeacherBindingNavigator.ResumeLayout(false);
            this.assignedTeacherBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private schoollDataSet schoollDataSet;
        private System.Windows.Forms.BindingSource assignedTeacherBindingSource;
        private schoollDataSetTableAdapters.AssignedTeacherTableAdapter assignedTeacherTableAdapter;
        private schoollDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator assignedTeacherBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton assignedTeacherBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_teacherTextBox;
        private System.Windows.Forms.TextBox id_disciplineTextBox;
    }
}