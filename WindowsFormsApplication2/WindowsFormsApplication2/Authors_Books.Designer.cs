namespace WindowsFormsApplication2
{
    partial class Authors_Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authors_Books));
            this.button1 = new System.Windows.Forms.Button();
            this.libraryDataSet = new WindowsFormsApplication2.LibraryDataSet();
            this.aUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHORTableAdapter = new WindowsFormsApplication2.LibraryDataSetTableAdapters.AUTHORTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication2.LibraryDataSetTableAdapters.TableAdapterManager();
            this.bOOKSTableAdapter = new WindowsFormsApplication2.LibraryDataSetTableAdapters.BOOKSTableAdapter();
            this.bORROWED_BYTableAdapter = new WindowsFormsApplication2.LibraryDataSetTableAdapters.BORROWED_BYTableAdapter();
            this.wRITTEN_BYTableAdapter = new WindowsFormsApplication2.LibraryDataSetTableAdapters.WRITTEN_BYTableAdapter();
            this.aUTHORBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aUTHORBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wRITTEN_BYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wRITTENBYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKWRITTENWRITTENBAUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKWRITTENWRITTENBAUTHORBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKBORROWEDBORROWEDBOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKWRITTENWRITTENBBOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHORBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bORROWEDBYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingNavigator)).BeginInit();
            this.aUTHORBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wRITTEN_BYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wRITTENBYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKWRITTENWRITTENBAUTHORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKWRITTENWRITTENBAUTHORBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBORROWEDBORROWEDBOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKWRITTENWRITTENBBOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWEDBYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Home Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aUTHORBindingSource
            // 
            this.aUTHORBindingSource.DataMember = "AUTHOR";
            this.aUTHORBindingSource.DataSource = this.libraryDataSet;
            // 
            // aUTHORTableAdapter
            // 
            this.aUTHORTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AUTHORTableAdapter = this.aUTHORTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = this.bOOKSTableAdapter;
            this.tableAdapterManager.BORROWED_BYTableAdapter = this.bORROWED_BYTableAdapter;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.CLIENTSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication2.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WRITTEN_BYTableAdapter = this.wRITTEN_BYTableAdapter;
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // bORROWED_BYTableAdapter
            // 
            this.bORROWED_BYTableAdapter.ClearBeforeFill = true;
            // 
            // wRITTEN_BYTableAdapter
            // 
            this.wRITTEN_BYTableAdapter.ClearBeforeFill = true;
            // 
            // aUTHORBindingNavigator
            // 
            this.aUTHORBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aUTHORBindingNavigator.BindingSource = this.aUTHORBindingSource;
            this.aUTHORBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aUTHORBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aUTHORBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aUTHORBindingNavigatorSaveItem});
            this.aUTHORBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aUTHORBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aUTHORBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aUTHORBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aUTHORBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aUTHORBindingNavigator.Name = "aUTHORBindingNavigator";
            this.aUTHORBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aUTHORBindingNavigator.Size = new System.Drawing.Size(957, 25);
            this.aUTHORBindingNavigator.TabIndex = 22;
            this.aUTHORBindingNavigator.Text = "bindingNavigator1";
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
            // aUTHORBindingNavigatorSaveItem
            // 
            this.aUTHORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aUTHORBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aUTHORBindingNavigatorSaveItem.Image")));
            this.aUTHORBindingNavigatorSaveItem.Name = "aUTHORBindingNavigatorSaveItem";
            this.aUTHORBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aUTHORBindingNavigatorSaveItem.Text = "Save Data";
            this.aUTHORBindingNavigatorSaveItem.Click += new System.EventHandler(this.aUTHORBindingNavigatorSaveItem_Click_1);
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.libraryDataSet;
            // 
            // wRITTEN_BYBindingSource
            // 
            this.wRITTEN_BYBindingSource.DataMember = "WRITTEN_BY";
            this.wRITTEN_BYBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSetBindingSource
            // 
            this.libraryDataSetBindingSource.DataSource = this.libraryDataSet;
            this.libraryDataSetBindingSource.Position = 0;
            // 
            // wRITTENBYBindingSource
            // 
            this.wRITTENBYBindingSource.DataMember = "WRITTEN_BY";
            this.wRITTENBYBindingSource.DataSource = this.libraryDataSet;
            // 
            // fKWRITTENWRITTENBAUTHORBindingSource
            // 
            this.fKWRITTENWRITTENBAUTHORBindingSource.DataMember = "FK_WRITTEN__WRITTEN_B_AUTHOR";
            this.fKWRITTENWRITTENBAUTHORBindingSource.DataSource = this.aUTHORBindingSource;
            // 
            // fKWRITTENWRITTENBAUTHORBindingSource1
            // 
            this.fKWRITTENWRITTENBAUTHORBindingSource1.DataMember = "FK_WRITTEN__WRITTEN_B_AUTHOR";
            this.fKWRITTENWRITTENBAUTHORBindingSource1.DataSource = this.aUTHORBindingSource;
            // 
            // fKBORROWEDBORROWEDBOOKSBindingSource
            // 
            this.fKBORROWEDBORROWEDBOOKSBindingSource.DataMember = "FK_BORROWED_BORROWED__BOOKS";
            this.fKBORROWEDBORROWEDBOOKSBindingSource.DataSource = this.bOOKSBindingSource;
            // 
            // fKWRITTENWRITTENBBOOKSBindingSource
            // 
            this.fKWRITTENWRITTENBBOOKSBindingSource.DataMember = "FK_WRITTEN__WRITTEN_B_BOOKS";
            this.fKWRITTENWRITTENBBOOKSBindingSource.DataSource = this.bOOKSBindingSource;
            // 
            // aUTHORBindingSource1
            // 
            this.aUTHORBindingSource1.DataMember = "AUTHOR";
            this.aUTHORBindingSource1.DataSource = this.libraryDataSetBindingSource;
            // 
            // bORROWEDBYBindingSource
            // 
            this.bORROWEDBYBindingSource.DataMember = "BORROWED_BY";
            this.bORROWEDBYBindingSource.DataSource = this.libraryDataSetBindingSource;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Show Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 190);
            this.dataGridView1.TabIndex = 35;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(274, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Back to Author";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Authors_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 377);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.aUTHORBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "Authors_Books";
            this.Text = "Authors_Books";
            this.Load += new System.EventHandler(this.Authors_Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingNavigator)).EndInit();
            this.aUTHORBindingNavigator.ResumeLayout(false);
            this.aUTHORBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wRITTEN_BYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wRITTENBYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKWRITTENWRITTENBAUTHORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKWRITTENWRITTENBAUTHORBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBORROWEDBORROWEDBOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKWRITTENWRITTENBBOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWEDBYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource aUTHORBindingSource;
        private LibraryDataSetTableAdapters.AUTHORTableAdapter aUTHORTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aUTHORBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aUTHORBindingNavigatorSaveItem;
        private LibraryDataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private LibraryDataSetTableAdapters.WRITTEN_BYTableAdapter wRITTEN_BYTableAdapter;
        private System.Windows.Forms.BindingSource wRITTEN_BYBindingSource;
        private LibraryDataSetTableAdapters.BORROWED_BYTableAdapter bORROWED_BYTableAdapter;
        private System.Windows.Forms.BindingSource fKWRITTENWRITTENBAUTHORBindingSource1;
        private System.Windows.Forms.BindingSource libraryDataSetBindingSource;
        private System.Windows.Forms.BindingSource wRITTENBYBindingSource;
        private System.Windows.Forms.BindingSource fKWRITTENWRITTENBAUTHORBindingSource;
        private System.Windows.Forms.BindingSource fKBORROWEDBORROWEDBOOKSBindingSource;
        private System.Windows.Forms.BindingSource fKWRITTENWRITTENBBOOKSBindingSource;
        private System.Windows.Forms.BindingSource aUTHORBindingSource1;
        private System.Windows.Forms.BindingSource bORROWEDBYBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
    }
}