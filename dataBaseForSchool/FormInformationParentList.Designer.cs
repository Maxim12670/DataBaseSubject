namespace dataBaseForSchool
{
    partial class FormInformationParentList
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
            System.Windows.Forms.Label id_parentsLabel;
            System.Windows.Forms.Label motherLabel;
            System.Windows.Forms.Label fatherLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformationParentList));
            this.schoollDataSet = new dataBaseForSchool.schoollDataSet();
            this.informationParentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informationParentTableAdapter = new dataBaseForSchool.schoollDataSetTableAdapters.InformationParentTableAdapter();
            this.tableAdapterManager = new dataBaseForSchool.schoollDataSetTableAdapters.TableAdapterManager();
            this.informationParentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_parentsTextBox = new System.Windows.Forms.TextBox();
            this.motherTextBox = new System.Windows.Forms.TextBox();
            this.fatherTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.informationParentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            id_parentsLabel = new System.Windows.Forms.Label();
            motherLabel = new System.Windows.Forms.Label();
            fatherLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoollDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationParentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationParentBindingNavigator)).BeginInit();
            this.informationParentBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // schoollDataSet
            // 
            this.schoollDataSet.DataSetName = "schoollDataSet";
            this.schoollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationParentBindingSource
            // 
            this.informationParentBindingSource.DataMember = "InformationParent";
            this.informationParentBindingSource.DataSource = this.schoollDataSet;
            // 
            // informationParentTableAdapter
            // 
            this.informationParentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignedTeacherTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.InformationParentTableAdapter = this.informationParentTableAdapter;
            this.tableAdapterManager.RatingTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dataBaseForSchool.schoollDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // informationParentBindingNavigator
            // 
            this.informationParentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.informationParentBindingNavigator.BindingSource = this.informationParentBindingSource;
            this.informationParentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.informationParentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.informationParentBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.informationParentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.informationParentBindingNavigatorSaveItem});
            this.informationParentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.informationParentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.informationParentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.informationParentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.informationParentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.informationParentBindingNavigator.Name = "informationParentBindingNavigator";
            this.informationParentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.informationParentBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.informationParentBindingNavigator.TabIndex = 0;
            this.informationParentBindingNavigator.Text = "bindingNavigator1";
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
            // id_parentsLabel
            // 
            id_parentsLabel.AutoSize = true;
            id_parentsLabel.Location = new System.Drawing.Point(7, 39);
            id_parentsLabel.Name = "id_parentsLabel";
            id_parentsLabel.Size = new System.Drawing.Size(69, 16);
            id_parentsLabel.TabIndex = 1;
            id_parentsLabel.Text = "id parents:";
            // 
            // id_parentsTextBox
            // 
            this.id_parentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationParentBindingSource, "id_parents", true));
            this.id_parentsTextBox.Location = new System.Drawing.Point(82, 36);
            this.id_parentsTextBox.Name = "id_parentsTextBox";
            this.id_parentsTextBox.Size = new System.Drawing.Size(254, 22);
            this.id_parentsTextBox.TabIndex = 2;
            // 
            // motherLabel
            // 
            motherLabel.AutoSize = true;
            motherLabel.Location = new System.Drawing.Point(7, 67);
            motherLabel.Name = "motherLabel";
            motherLabel.Size = new System.Drawing.Size(51, 16);
            motherLabel.TabIndex = 3;
            motherLabel.Text = "mother:";
            // 
            // motherTextBox
            // 
            this.motherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationParentBindingSource, "mother", true));
            this.motherTextBox.Location = new System.Drawing.Point(82, 64);
            this.motherTextBox.Name = "motherTextBox";
            this.motherTextBox.Size = new System.Drawing.Size(254, 22);
            this.motherTextBox.TabIndex = 4;
            // 
            // fatherLabel
            // 
            fatherLabel.AutoSize = true;
            fatherLabel.Location = new System.Drawing.Point(7, 95);
            fatherLabel.Name = "fatherLabel";
            fatherLabel.Size = new System.Drawing.Size(43, 16);
            fatherLabel.TabIndex = 5;
            fatherLabel.Text = "father:";
            // 
            // fatherTextBox
            // 
            this.fatherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationParentBindingSource, "father", true));
            this.fatherTextBox.Location = new System.Drawing.Point(82, 92);
            this.fatherTextBox.Name = "fatherTextBox";
            this.fatherTextBox.Size = new System.Drawing.Size(254, 22);
            this.fatherTextBox.TabIndex = 6;
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
            // informationParentBindingNavigatorSaveItem
            // 
            this.informationParentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.informationParentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("informationParentBindingNavigatorSaveItem.Image")));
            this.informationParentBindingNavigatorSaveItem.Name = "informationParentBindingNavigatorSaveItem";
            this.informationParentBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.informationParentBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.informationParentBindingNavigatorSaveItem.Click += new System.EventHandler(this.informationParentBindingNavigatorSaveItem_Click);
            // 
            // FormInformationParentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(id_parentsLabel);
            this.Controls.Add(this.id_parentsTextBox);
            this.Controls.Add(motherLabel);
            this.Controls.Add(this.motherTextBox);
            this.Controls.Add(fatherLabel);
            this.Controls.Add(this.fatherTextBox);
            this.Controls.Add(this.informationParentBindingNavigator);
            this.Name = "FormInformationParentList";
            this.Text = "Информация о родителях";
            this.Load += new System.EventHandler(this.FormInformationParentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoollDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationParentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationParentBindingNavigator)).EndInit();
            this.informationParentBindingNavigator.ResumeLayout(false);
            this.informationParentBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private schoollDataSet schoollDataSet;
        private System.Windows.Forms.BindingSource informationParentBindingSource;
        private schoollDataSetTableAdapters.InformationParentTableAdapter informationParentTableAdapter;
        private schoollDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator informationParentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton informationParentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_parentsTextBox;
        private System.Windows.Forms.TextBox motherTextBox;
        private System.Windows.Forms.TextBox fatherTextBox;
    }
}