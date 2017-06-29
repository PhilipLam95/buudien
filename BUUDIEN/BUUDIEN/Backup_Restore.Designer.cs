namespace BUUDIEN
{
    partial class Backup_Restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup_Restore));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tKBUUDIENDataSet = new BUUDIEN.TKBUUDIENDataSet();
            this.sP_DANHSACHBACKUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DANHSACHBACKUPTableAdapter = new BUUDIEN.TKBUUDIENDataSetTableAdapters.SP_DANHSACHBACKUPTableAdapter();
            this.tableAdapterManager = new BUUDIEN.TKBUUDIENDataSetTableAdapters.TableAdapterManager();
            this.sP_DANHSACHBACKUPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sP_DANHSACHBACKUPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sP_DANHSACHBACKUPDataGridView = new System.Windows.Forms.DataGridView();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupstartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tKBUUDIENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACHBACKUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACHBACKUPBindingNavigator)).BeginInit();
            this.sP_DANHSACHBACKUPBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACHBACKUPDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Back Up Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "BACK_UP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(284, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "backup";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sP_DANHSACHBACKUPDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(183, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 138);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sach backup";
            // 
            // tKBUUDIENDataSet
            // 
            this.tKBUUDIENDataSet.DataSetName = "TKBUUDIENDataSet";
            this.tKBUUDIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_DANHSACHBACKUPBindingSource
            // 
            this.sP_DANHSACHBACKUPBindingSource.DataMember = "SP_DANHSACHBACKUP";
            this.sP_DANHSACHBACKUPBindingSource.DataSource = this.tKBUUDIENDataSet;
            // 
            // sP_DANHSACHBACKUPTableAdapter
            // 
            this.sP_DANHSACHBACKUPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BUUDIEN.TKBUUDIENDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_DANHSACHBACKUPBindingNavigator
            // 
            this.sP_DANHSACHBACKUPBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sP_DANHSACHBACKUPBindingNavigator.BindingSource = this.sP_DANHSACHBACKUPBindingSource;
            this.sP_DANHSACHBACKUPBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sP_DANHSACHBACKUPBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sP_DANHSACHBACKUPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sP_DANHSACHBACKUPBindingNavigatorSaveItem});
            this.sP_DANHSACHBACKUPBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sP_DANHSACHBACKUPBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sP_DANHSACHBACKUPBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sP_DANHSACHBACKUPBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sP_DANHSACHBACKUPBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sP_DANHSACHBACKUPBindingNavigator.Name = "sP_DANHSACHBACKUPBindingNavigator";
            this.sP_DANHSACHBACKUPBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sP_DANHSACHBACKUPBindingNavigator.Size = new System.Drawing.Size(722, 25);
            this.sP_DANHSACHBACKUPBindingNavigator.TabIndex = 5;
            this.sP_DANHSACHBACKUPBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // sP_DANHSACHBACKUPBindingNavigatorSaveItem
            // 
            this.sP_DANHSACHBACKUPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sP_DANHSACHBACKUPBindingNavigatorSaveItem.Enabled = false;
            this.sP_DANHSACHBACKUPBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sP_DANHSACHBACKUPBindingNavigatorSaveItem.Image")));
            this.sP_DANHSACHBACKUPBindingNavigatorSaveItem.Name = "sP_DANHSACHBACKUPBindingNavigatorSaveItem";
            this.sP_DANHSACHBACKUPBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.sP_DANHSACHBACKUPBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // sP_DANHSACHBACKUPDataGridView
            // 
            this.sP_DANHSACHBACKUPDataGridView.AutoGenerateColumns = false;
            this.sP_DANHSACHBACKUPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sP_DANHSACHBACKUPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionDataGridViewTextBoxColumn,
            this.backupstartdateDataGridViewTextBoxColumn});
            this.sP_DANHSACHBACKUPDataGridView.DataSource = this.sP_DANHSACHBACKUPBindingSource;
            this.sP_DANHSACHBACKUPDataGridView.Location = new System.Drawing.Point(6, 19);
            this.sP_DANHSACHBACKUPDataGridView.Name = "sP_DANHSACHBACKUPDataGridView";
            this.sP_DANHSACHBACKUPDataGridView.Size = new System.Drawing.Size(389, 113);
            this.sP_DANHSACHBACKUPDataGridView.TabIndex = 0;
            this.sP_DANHSACHBACKUPDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sP_DANHSACHBACKUPDataGridView_CellContentClick);
            this.sP_DANHSACHBACKUPDataGridView.SelectionChanged += new System.EventHandler(this.sP_DANHSACHBACKUPDataGridView_SelectionChanged);
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // backupstartdateDataGridViewTextBoxColumn
            // 
            this.backupstartdateDataGridViewTextBoxColumn.DataPropertyName = "backup_start_date";
            this.backupstartdateDataGridViewTextBoxColumn.HeaderText = "backup_start_date";
            this.backupstartdateDataGridViewTextBoxColumn.Name = "backupstartdateDataGridViewTextBoxColumn";
            this.backupstartdateDataGridViewTextBoxColumn.Width = 250;
            // 
            // Backup_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 425);
            this.Controls.Add(this.sP_DANHSACHBACKUPBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Backup_Restore";
            this.Text = "Backup_Restore";
            this.Load += new System.EventHandler(this.Backup_Restore_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tKBUUDIENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACHBACKUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACHBACKUPBindingNavigator)).EndInit();
            this.sP_DANHSACHBACKUPBindingNavigator.ResumeLayout(false);
            this.sP_DANHSACHBACKUPBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACHBACKUPDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private TKBUUDIENDataSet tKBUUDIENDataSet;
        private System.Windows.Forms.BindingSource sP_DANHSACHBACKUPBindingSource;
        private TKBUUDIENDataSetTableAdapters.SP_DANHSACHBACKUPTableAdapter sP_DANHSACHBACKUPTableAdapter;
        private TKBUUDIENDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sP_DANHSACHBACKUPBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sP_DANHSACHBACKUPBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sP_DANHSACHBACKUPDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backupstartdateDataGridViewTextBoxColumn;
    }
}