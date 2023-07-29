namespace dataBaseForSchool
{
    partial class FormRatingList
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
            System.Windows.Forms.Label id_ratingLabel;
            System.Windows.Forms.Label id_studentLabel;
            System.Windows.Forms.Label id_disciplineLabel;
            System.Windows.Forms.Label id_teacherLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label presenceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRatingList));
            this.schoollDataSet = new dataBaseForSchool.schoollDataSet();
            this.ratingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ratingTableAdapter = new dataBaseForSchool.schoollDataSetTableAdapters.RatingTableAdapter();
            this.tableAdapterManager = new dataBaseForSchool.schoollDataSetTableAdapters.TableAdapterManager();
            this.ratingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_ratingTextBox = new System.Windows.Forms.TextBox();
            this.id_studentTextBox = new System.Windows.Forms.TextBox();
            this.id_disciplineTextBox = new System.Windows.Forms.TextBox();
            this.id_teacherTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.presenceTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.ratingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            id_ratingLabel = new System.Windows.Forms.Label();
            id_studentLabel = new System.Windows.Forms.Label();
            id_disciplineLabel = new System.Windows.Forms.Label();
            id_teacherLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            presenceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoollDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingNavigator)).BeginInit();
            this.ratingBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // schoollDataSet
            // 
            this.schoollDataSet.DataSetName = "schoollDataSet";
            this.schoollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ratingBindingSource
            // 
            this.ratingBindingSource.DataMember = "Rating";
            this.ratingBindingSource.DataSource = this.schoollDataSet;
            // 
            // ratingTableAdapter
            // 
            this.ratingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignedTeacherTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.InformationParentTableAdapter = null;
            this.tableAdapterManager.RatingTableAdapter = this.ratingTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dataBaseForSchool.schoollDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ratingBindingNavigator
            // 
            this.ratingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ratingBindingNavigator.BindingSource = this.ratingBindingSource;
            this.ratingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ratingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ratingBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ratingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ratingBindingNavigatorSaveItem});
            this.ratingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ratingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ratingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ratingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ratingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ratingBindingNavigator.Name = "ratingBindingNavigator";
            this.ratingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ratingBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.ratingBindingNavigator.TabIndex = 0;
            this.ratingBindingNavigator.Text = "bindingNavigator1";
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
            // id_ratingLabel
            // 
            id_ratingLabel.AutoSize = true;
            id_ratingLabel.Location = new System.Drawing.Point(6, 37);
            id_ratingLabel.Name = "id_ratingLabel";
            id_ratingLabel.Size = new System.Drawing.Size(57, 16);
            id_ratingLabel.TabIndex = 1;
            id_ratingLabel.Text = "id rating:";
            // 
            // id_ratingTextBox
            // 
            this.id_ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ratingBindingSource, "id_rating", true));
            this.id_ratingTextBox.Location = new System.Drawing.Point(93, 34);
            this.id_ratingTextBox.Name = "id_ratingTextBox";
            this.id_ratingTextBox.Size = new System.Drawing.Size(281, 22);
            this.id_ratingTextBox.TabIndex = 2;
            // 
            // id_studentLabel
            // 
            id_studentLabel.AutoSize = true;
            id_studentLabel.Location = new System.Drawing.Point(6, 65);
            id_studentLabel.Name = "id_studentLabel";
            id_studentLabel.Size = new System.Drawing.Size(67, 16);
            id_studentLabel.TabIndex = 3;
            id_studentLabel.Text = "id student:";
            // 
            // id_studentTextBox
            // 
            this.id_studentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ratingBindingSource, "id_student", true));
            this.id_studentTextBox.Location = new System.Drawing.Point(93, 62);
            this.id_studentTextBox.Name = "id_studentTextBox";
            this.id_studentTextBox.Size = new System.Drawing.Size(281, 22);
            this.id_studentTextBox.TabIndex = 4;
            // 
            // id_disciplineLabel
            // 
            id_disciplineLabel.AutoSize = true;
            id_disciplineLabel.Location = new System.Drawing.Point(6, 93);
            id_disciplineLabel.Name = "id_disciplineLabel";
            id_disciplineLabel.Size = new System.Drawing.Size(81, 16);
            id_disciplineLabel.TabIndex = 5;
            id_disciplineLabel.Text = "id discipline:";
            // 
            // id_disciplineTextBox
            // 
            this.id_disciplineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ratingBindingSource, "id_discipline", true));
            this.id_disciplineTextBox.Location = new System.Drawing.Point(93, 90);
            this.id_disciplineTextBox.Name = "id_disciplineTextBox";
            this.id_disciplineTextBox.Size = new System.Drawing.Size(281, 22);
            this.id_disciplineTextBox.TabIndex = 6;
            // 
            // id_teacherLabel
            // 
            id_teacherLabel.AutoSize = true;
            id_teacherLabel.Location = new System.Drawing.Point(6, 121);
            id_teacherLabel.Name = "id_teacherLabel";
            id_teacherLabel.Size = new System.Drawing.Size(69, 16);
            id_teacherLabel.TabIndex = 7;
            id_teacherLabel.Text = "id teacher:";
            // 
            // id_teacherTextBox
            // 
            this.id_teacherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ratingBindingSource, "id_teacher", true));
            this.id_teacherTextBox.Location = new System.Drawing.Point(93, 118);
            this.id_teacherTextBox.Name = "id_teacherTextBox";
            this.id_teacherTextBox.Size = new System.Drawing.Size(281, 22);
            this.id_teacherTextBox.TabIndex = 8;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(6, 150);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(37, 16);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "date:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ratingBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(93, 146);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(281, 22);
            this.dateDateTimePicker.TabIndex = 10;
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(6, 177);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(43, 16);
            ratingLabel.TabIndex = 11;
            ratingLabel.Text = "rating:";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ratingBindingSource, "rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(93, 174);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(281, 22);
            this.ratingTextBox.TabIndex = 12;
            // 
            // presenceLabel
            // 
            presenceLabel.AutoSize = true;
            presenceLabel.Location = new System.Drawing.Point(6, 205);
            presenceLabel.Name = "presenceLabel";
            presenceLabel.Size = new System.Drawing.Size(67, 16);
            presenceLabel.TabIndex = 13;
            presenceLabel.Text = "presence:";
            // 
            // presenceTextBox
            // 
            this.presenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ratingBindingSource, "presence", true));
            this.presenceTextBox.Location = new System.Drawing.Point(93, 202);
            this.presenceTextBox.Name = "presenceTextBox";
            this.presenceTextBox.Size = new System.Drawing.Size(281, 22);
            this.presenceTextBox.TabIndex = 14;
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
            // ratingBindingNavigatorSaveItem
            // 
            this.ratingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ratingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ratingBindingNavigatorSaveItem.Image")));
            this.ratingBindingNavigatorSaveItem.Name = "ratingBindingNavigatorSaveItem";
            this.ratingBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.ratingBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ratingBindingNavigatorSaveItem.Click += new System.EventHandler(this.ratingBindingNavigatorSaveItem_Click);
            // 
            // FormRatingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(id_ratingLabel);
            this.Controls.Add(this.id_ratingTextBox);
            this.Controls.Add(id_studentLabel);
            this.Controls.Add(this.id_studentTextBox);
            this.Controls.Add(id_disciplineLabel);
            this.Controls.Add(this.id_disciplineTextBox);
            this.Controls.Add(id_teacherLabel);
            this.Controls.Add(this.id_teacherTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(presenceLabel);
            this.Controls.Add(this.presenceTextBox);
            this.Controls.Add(this.ratingBindingNavigator);
            this.Name = "FormRatingList";
            this.Text = "Оценка";
            this.Load += new System.EventHandler(this.FormRatingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoollDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingNavigator)).EndInit();
            this.ratingBindingNavigator.ResumeLayout(false);
            this.ratingBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private schoollDataSet schoollDataSet;
        private System.Windows.Forms.BindingSource ratingBindingSource;
        private schoollDataSetTableAdapters.RatingTableAdapter ratingTableAdapter;
        private schoollDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ratingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ratingBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_ratingTextBox;
        private System.Windows.Forms.TextBox id_studentTextBox;
        private System.Windows.Forms.TextBox id_disciplineTextBox;
        private System.Windows.Forms.TextBox id_teacherTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox presenceTextBox;
    }
}