namespace dataBaseForSchool
{
    partial class FormDisciplineList
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
            System.Windows.Forms.Label id_disciplineLabel;
            System.Windows.Forms.Label numberOfHoursLabel;
            System.Windows.Forms.Label nameDisciplineLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisciplineList));
            this.schoollDataSet = new dataBaseForSchool.schoollDataSet();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplineTableAdapter = new dataBaseForSchool.schoollDataSetTableAdapters.DisciplineTableAdapter();
            this.tableAdapterManager = new dataBaseForSchool.schoollDataSetTableAdapters.TableAdapterManager();
            this.disciplineBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_disciplineTextBox = new System.Windows.Forms.TextBox();
            this.numberOfHoursTextBox = new System.Windows.Forms.TextBox();
            this.nameDisciplineTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.disciplineBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            id_disciplineLabel = new System.Windows.Forms.Label();
            numberOfHoursLabel = new System.Windows.Forms.Label();
            nameDisciplineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoollDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingNavigator)).BeginInit();
            this.disciplineBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // schoollDataSet
            // 
            this.schoollDataSet.DataSetName = "schoollDataSet";
            this.schoollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataMember = "Discipline";
            this.disciplineBindingSource.DataSource = this.schoollDataSet;
            // 
            // disciplineTableAdapter
            // 
            this.disciplineTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignedTeacherTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = this.disciplineTableAdapter;
            this.tableAdapterManager.InformationParentTableAdapter = null;
            this.tableAdapterManager.RatingTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dataBaseForSchool.schoollDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // disciplineBindingNavigator
            // 
            this.disciplineBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.disciplineBindingNavigator.BindingSource = this.disciplineBindingSource;
            this.disciplineBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.disciplineBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.disciplineBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.disciplineBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.disciplineBindingNavigatorSaveItem});
            this.disciplineBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.disciplineBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.disciplineBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.disciplineBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.disciplineBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.disciplineBindingNavigator.Name = "disciplineBindingNavigator";
            this.disciplineBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.disciplineBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.disciplineBindingNavigator.TabIndex = 0;
            this.disciplineBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // id_disciplineLabel
            // 
            id_disciplineLabel.AutoSize = true;
            id_disciplineLabel.Location = new System.Drawing.Point(8, 42);
            id_disciplineLabel.Name = "id_disciplineLabel";
            id_disciplineLabel.Size = new System.Drawing.Size(81, 16);
            id_disciplineLabel.TabIndex = 1;
            id_disciplineLabel.Text = "id discipline:";
            // 
            // id_disciplineTextBox
            // 
            this.id_disciplineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplineBindingSource, "id_discipline", true));
            this.id_disciplineTextBox.Location = new System.Drawing.Point(124, 39);
            this.id_disciplineTextBox.Name = "id_disciplineTextBox";
            this.id_disciplineTextBox.Size = new System.Drawing.Size(256, 22);
            this.id_disciplineTextBox.TabIndex = 2;
            // 
            // numberOfHoursLabel
            // 
            numberOfHoursLabel.AutoSize = true;
            numberOfHoursLabel.Location = new System.Drawing.Point(8, 70);
            numberOfHoursLabel.Name = "numberOfHoursLabel";
            numberOfHoursLabel.Size = new System.Drawing.Size(110, 16);
            numberOfHoursLabel.TabIndex = 3;
            numberOfHoursLabel.Text = "number Of Hours:";
            // 
            // numberOfHoursTextBox
            // 
            this.numberOfHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplineBindingSource, "numberOfHours", true));
            this.numberOfHoursTextBox.Location = new System.Drawing.Point(124, 67);
            this.numberOfHoursTextBox.Name = "numberOfHoursTextBox";
            this.numberOfHoursTextBox.Size = new System.Drawing.Size(256, 22);
            this.numberOfHoursTextBox.TabIndex = 4;
            // 
            // nameDisciplineLabel
            // 
            nameDisciplineLabel.AutoSize = true;
            nameDisciplineLabel.Location = new System.Drawing.Point(8, 98);
            nameDisciplineLabel.Name = "nameDisciplineLabel";
            nameDisciplineLabel.Size = new System.Drawing.Size(106, 16);
            nameDisciplineLabel.TabIndex = 5;
            nameDisciplineLabel.Text = "name Discipline:";
            // 
            // nameDisciplineTextBox
            // 
            this.nameDisciplineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplineBindingSource, "nameDiscipline", true));
            this.nameDisciplineTextBox.Location = new System.Drawing.Point(124, 95);
            this.nameDisciplineTextBox.Name = "nameDisciplineTextBox";
            this.nameDisciplineTextBox.Size = new System.Drawing.Size(256, 22);
            this.nameDisciplineTextBox.TabIndex = 6;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // disciplineBindingNavigatorSaveItem
            // 
            this.disciplineBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disciplineBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("disciplineBindingNavigatorSaveItem.Image")));
            this.disciplineBindingNavigatorSaveItem.Name = "disciplineBindingNavigatorSaveItem";
            this.disciplineBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.disciplineBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.disciplineBindingNavigatorSaveItem.Click += new System.EventHandler(this.disciplineBindingNavigatorSaveItem_Click);
            // 
            // FormDisciplineList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(id_disciplineLabel);
            this.Controls.Add(this.id_disciplineTextBox);
            this.Controls.Add(numberOfHoursLabel);
            this.Controls.Add(this.numberOfHoursTextBox);
            this.Controls.Add(nameDisciplineLabel);
            this.Controls.Add(this.nameDisciplineTextBox);
            this.Controls.Add(this.disciplineBindingNavigator);
            this.Name = "FormDisciplineList";
            this.Text = "Дисциплина";
            this.Load += new System.EventHandler(this.FormDisciplineList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoollDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingNavigator)).EndInit();
            this.disciplineBindingNavigator.ResumeLayout(false);
            this.disciplineBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private schoollDataSet schoollDataSet;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private schoollDataSetTableAdapters.DisciplineTableAdapter disciplineTableAdapter;
        private schoollDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator disciplineBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton disciplineBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_disciplineTextBox;
        private System.Windows.Forms.TextBox numberOfHoursTextBox;
        private System.Windows.Forms.TextBox nameDisciplineTextBox;
    }
}