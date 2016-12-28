namespace WindowsFormsApplication2
{
    partial class Clients_Loans
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
            System.Windows.Forms.Label c_IDLabel;
            System.Windows.Forms.Label c_FnameLabel;
            System.Windows.Forms.Label c_LnameLabel;
            System.Windows.Forms.Label pHONE_NUMBERLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients_Loans));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.libraryDataSet = new WindowsFormsApplication2.LibraryDataSet();
            this.cLIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTSTableAdapter = new WindowsFormsApplication2.LibraryDataSetTableAdapters.CLIENTSTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication2.LibraryDataSetTableAdapters.TableAdapterManager();
            this.bORROWED_BYTableAdapter = new WindowsFormsApplication2.LibraryDataSetTableAdapters.BORROWED_BYTableAdapter();
            this.cLIENTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cLIENTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.c_IDTextBox = new System.Windows.Forms.TextBox();
            this.c_FnameTextBox = new System.Windows.Forms.TextBox();
            this.c_LnameTextBox = new System.Windows.Forms.TextBox();
            this.pHONE_NUMBERTextBox = new System.Windows.Forms.TextBox();
            this.bORROWED_BYDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bORROWED_BYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            c_IDLabel = new System.Windows.Forms.Label();
            c_FnameLabel = new System.Windows.Forms.Label();
            c_LnameLabel = new System.Windows.Forms.Label();
            pHONE_NUMBERLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingNavigator)).BeginInit();
            this.cLIENTSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWED_BYDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWED_BYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // c_IDLabel
            // 
            c_IDLabel.AutoSize = true;
            c_IDLabel.Location = new System.Drawing.Point(50, 58);
            c_IDLabel.Name = "c_IDLabel";
            c_IDLabel.Size = new System.Drawing.Size(31, 13);
            c_IDLabel.TabIndex = 1;
            c_IDLabel.Text = "C ID:";
            // 
            // c_FnameLabel
            // 
            c_FnameLabel.AutoSize = true;
            c_FnameLabel.Location = new System.Drawing.Point(50, 84);
            c_FnameLabel.Name = "c_FnameLabel";
            c_FnameLabel.Size = new System.Drawing.Size(52, 13);
            c_FnameLabel.TabIndex = 3;
            c_FnameLabel.Text = "C Fname:";
            // 
            // c_LnameLabel
            // 
            c_LnameLabel.AutoSize = true;
            c_LnameLabel.Location = new System.Drawing.Point(50, 110);
            c_LnameLabel.Name = "c_LnameLabel";
            c_LnameLabel.Size = new System.Drawing.Size(52, 13);
            c_LnameLabel.TabIndex = 5;
            c_LnameLabel.Text = "C Lname:";
            // 
            // pHONE_NUMBERLabel
            // 
            pHONE_NUMBERLabel.AutoSize = true;
            pHONE_NUMBERLabel.Location = new System.Drawing.Point(50, 136);
            pHONE_NUMBERLabel.Name = "pHONE_NUMBERLabel";
            pHONE_NUMBERLabel.Size = new System.Drawing.Size(98, 13);
            pHONE_NUMBERLabel.TabIndex = 7;
            pHONE_NUMBERLabel.Text = "PHONE NUMBER:";
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTSBindingSource
            // 
            this.cLIENTSBindingSource.DataMember = "CLIENTS";
            this.cLIENTSBindingSource.DataSource = this.libraryDataSet;
            // 
            // cLIENTSTableAdapter
            // 
            this.cLIENTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AUTHORTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.BORROWED_BYTableAdapter = this.bORROWED_BYTableAdapter;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.CLIENTSTableAdapter = this.cLIENTSTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication2.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WRITTEN_BYTableAdapter = null;
            // 
            // bORROWED_BYTableAdapter
            // 
            this.bORROWED_BYTableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTSBindingNavigator
            // 
            this.cLIENTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cLIENTSBindingNavigator.BindingSource = this.cLIENTSBindingSource;
            this.cLIENTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cLIENTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cLIENTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cLIENTSBindingNavigatorSaveItem});
            this.cLIENTSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cLIENTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cLIENTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cLIENTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cLIENTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cLIENTSBindingNavigator.Name = "cLIENTSBindingNavigator";
            this.cLIENTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cLIENTSBindingNavigator.Size = new System.Drawing.Size(832, 25);
            this.cLIENTSBindingNavigator.TabIndex = 0;
            this.cLIENTSBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cLIENTSBindingNavigatorSaveItem
            // 
            this.cLIENTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cLIENTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cLIENTSBindingNavigatorSaveItem.Image")));
            this.cLIENTSBindingNavigatorSaveItem.Name = "cLIENTSBindingNavigatorSaveItem";
            this.cLIENTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cLIENTSBindingNavigatorSaveItem.Text = "Save Data";
            this.cLIENTSBindingNavigatorSaveItem.Click += new System.EventHandler(this.cLIENTSBindingNavigatorSaveItem_Click);
            // 
            // c_IDTextBox
            // 
            this.c_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "C_ID", true));
            this.c_IDTextBox.Location = new System.Drawing.Point(154, 55);
            this.c_IDTextBox.Name = "c_IDTextBox";
            this.c_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.c_IDTextBox.TabIndex = 2;
            // 
            // c_FnameTextBox
            // 
            this.c_FnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "C_Fname", true));
            this.c_FnameTextBox.Location = new System.Drawing.Point(154, 81);
            this.c_FnameTextBox.Name = "c_FnameTextBox";
            this.c_FnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.c_FnameTextBox.TabIndex = 4;
            // 
            // c_LnameTextBox
            // 
            this.c_LnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "C_Lname", true));
            this.c_LnameTextBox.Location = new System.Drawing.Point(154, 107);
            this.c_LnameTextBox.Name = "c_LnameTextBox";
            this.c_LnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.c_LnameTextBox.TabIndex = 6;
            // 
            // pHONE_NUMBERTextBox
            // 
            this.pHONE_NUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "PHONE_NUMBER", true));
            this.pHONE_NUMBERTextBox.Location = new System.Drawing.Point(154, 133);
            this.pHONE_NUMBERTextBox.Name = "pHONE_NUMBERTextBox";
            this.pHONE_NUMBERTextBox.Size = new System.Drawing.Size(100, 20);
            this.pHONE_NUMBERTextBox.TabIndex = 8;
            // 
            // bORROWED_BYDataGridView
            // 
            this.bORROWED_BYDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bORROWED_BYDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bORROWED_BYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bORROWED_BYDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.bORROWED_BYDataGridView.DataSource = this.bORROWED_BYBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bORROWED_BYDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.bORROWED_BYDataGridView.Location = new System.Drawing.Point(274, 55);
            this.bORROWED_BYDataGridView.Name = "bORROWED_BYDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bORROWED_BYDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bORROWED_BYDataGridView.Size = new System.Drawing.Size(546, 220);
            this.bORROWED_BYDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "B_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "B_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "C_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "C_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BORROW_DATE";
            this.dataGridViewTextBoxColumn3.HeaderText = "BORROW_DATE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DUE_DATE";
            this.dataGridViewTextBoxColumn4.HeaderText = "DUE_DATE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FINE";
            this.dataGridViewTextBoxColumn5.HeaderText = "FINE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // bORROWED_BYBindingSource
            // 
            this.bORROWED_BYBindingSource.DataMember = "FK_BORROWED_BORROWED__CLIENTS";
            this.bORROWED_BYBindingSource.DataSource = this.cLIENTSBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Home Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clients_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bORROWED_BYDataGridView);
            this.Controls.Add(c_IDLabel);
            this.Controls.Add(this.c_IDTextBox);
            this.Controls.Add(c_FnameLabel);
            this.Controls.Add(this.c_FnameTextBox);
            this.Controls.Add(c_LnameLabel);
            this.Controls.Add(this.c_LnameTextBox);
            this.Controls.Add(pHONE_NUMBERLabel);
            this.Controls.Add(this.pHONE_NUMBERTextBox);
            this.Controls.Add(this.cLIENTSBindingNavigator);
            this.Name = "Clients_Selection";
            this.Text = "Loans Selection";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingNavigator)).EndInit();
            this.cLIENTSBindingNavigator.ResumeLayout(false);
            this.cLIENTSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWED_BYDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWED_BYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource cLIENTSBindingSource;
        private LibraryDataSetTableAdapters.CLIENTSTableAdapter cLIENTSTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cLIENTSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cLIENTSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox c_IDTextBox;
        private System.Windows.Forms.TextBox c_FnameTextBox;
        private System.Windows.Forms.TextBox c_LnameTextBox;
        private System.Windows.Forms.TextBox pHONE_NUMBERTextBox;
        private LibraryDataSetTableAdapters.BORROWED_BYTableAdapter bORROWED_BYTableAdapter;
        private System.Windows.Forms.BindingSource bORROWED_BYBindingSource;
        private System.Windows.Forms.DataGridView bORROWED_BYDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
    }
}