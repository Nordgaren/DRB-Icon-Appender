namespace DRB_Icon_Appender
{
    partial class FormMain
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
            System.Windows.Forms.Label lblGameDir;
            System.Windows.Forms.ToolTip toolTip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnExplore = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddIcon = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtGameDir = new System.Windows.Forms.TextBox();
            this.dgvIcons = new System.Windows.Forms.DataGridView();
            this.ofdExecutable = new System.Windows.Forms.OpenFileDialog();
            this.llbUpdate = new System.Windows.Forms.LinkLabel();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.nudIconID = new System.Windows.Forms.NumericUpDown();
            this.lblIconID = new System.Windows.Forms.Label();
            this.btnBatchSave = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textureDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.leftEdgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topEdgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spriteShapeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBatchLoad = new System.Windows.Forms.Button();
            lblGameDir = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIcons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIconID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteShapeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameDir
            // 
            lblGameDir.AutoSize = true;
            lblGameDir.Location = new System.Drawing.Point(18, 14);
            lblGameDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblGameDir.Name = "lblGameDir";
            lblGameDir.Size = new System.Drawing.Size(120, 20);
            lblGameDir.TabIndex = 0;
            lblGameDir.Text = "Game Directory";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(18, 78);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(112, 35);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            toolTip1.SetToolTip(this.btnBrowse, "Browse for your Dark Souls installation");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnExplore
            // 
            this.btnExplore.Location = new System.Drawing.Point(261, 78);
            this.btnExplore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(112, 35);
            this.btnExplore.TabIndex = 3;
            this.btnExplore.Text = "Explore";
            toolTip1.SetToolTip(this.btnExplore, "Open the game directory in Explorer");
            this.btnExplore.UseVisualStyleBackColor = true;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(382, 78);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(112, 35);
            this.btnRestore.TabIndex = 7;
            this.btnRestore.Text = "Restore";
            toolTip1.SetToolTip(this.btnRestore, "Restore backed-up files and reload");
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(747, 78);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            toolTip1.SetToolTip(this.btnSave, "Save changes");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddIcon
            // 
            this.btnAddIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddIcon.Enabled = false;
            this.btnAddIcon.Location = new System.Drawing.Point(868, 846);
            this.btnAddIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddIcon.Name = "btnAddIcon";
            this.btnAddIcon.Size = new System.Drawing.Size(112, 35);
            this.btnAddIcon.TabIndex = 12;
            this.btnAddIcon.Text = "Add Icon";
            toolTip1.SetToolTip(this.btnAddIcon, "Create a new icon with the given ID");
            this.btnAddIcon.UseVisualStyleBackColor = true;
            this.btnAddIcon.Click += new System.EventHandler(this.btnAddIcon_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(868, 78);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            toolTip1.SetToolTip(this.btnClose, "Close files without saving");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(140, 78);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(112, 35);
            this.btnOpen.TabIndex = 14;
            this.btnOpen.Text = "Open";
            toolTip1.SetToolTip(this.btnOpen, "Load files from the game directory");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtGameDir
            // 
            this.txtGameDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameDir.Location = new System.Drawing.Point(18, 38);
            this.txtGameDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGameDir.Name = "txtGameDir";
            this.txtGameDir.ReadOnly = true;
            this.txtGameDir.Size = new System.Drawing.Size(961, 26);
            this.txtGameDir.TabIndex = 1;
            this.txtGameDir.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\DARK SOULS REMASTERED";
            // 
            // dgvIcons
            // 
            this.dgvIcons.AllowUserToAddRows = false;
            this.dgvIcons.AllowUserToDeleteRows = false;
            this.dgvIcons.AllowUserToResizeColumns = false;
            this.dgvIcons.AllowUserToResizeRows = false;
            this.dgvIcons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIcons.AutoGenerateColumns = false;
            this.dgvIcons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIcons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.textureDataGridViewComboBoxColumn,
            this.leftEdgeDataGridViewTextBoxColumn,
            this.topEdgeDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn});
            this.dgvIcons.DataSource = this.spriteShapeBindingSource;
            this.dgvIcons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvIcons.Location = new System.Drawing.Point(18, 123);
            this.dgvIcons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvIcons.Name = "dgvIcons";
            this.dgvIcons.RowHeadersVisible = false;
            this.dgvIcons.RowHeadersWidth = 62;
            this.dgvIcons.Size = new System.Drawing.Size(963, 698);
            this.dgvIcons.TabIndex = 9;
            this.dgvIcons.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvIcons_DataError);
            // 
            // ofdExecutable
            // 
            this.ofdExecutable.Filter = "Dark Souls Executable|*.exe";
            this.ofdExecutable.Title = "Select Dark Souls executable...";
            // 
            // llbUpdate
            // 
            this.llbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llbUpdate.AutoSize = true;
            this.llbUpdate.Location = new System.Drawing.Point(18, 854);
            this.llbUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbUpdate.Name = "llbUpdate";
            this.llbUpdate.Size = new System.Drawing.Size(163, 20);
            this.llbUpdate.TabIndex = 21;
            this.llbUpdate.TabStop = true;
            this.llbUpdate.Text = "New version available!";
            this.llbUpdate.Visible = false;
            this.llbUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUpdate_LinkClicked);
            // 
            // lblUpdate
            // 
            this.lblUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(18, 854);
            this.lblUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(164, 20);
            this.lblUpdate.TabIndex = 20;
            this.lblUpdate.Text = "Checking for update...";
            // 
            // nudIconID
            // 
            this.nudIconID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudIconID.Location = new System.Drawing.Point(680, 851);
            this.nudIconID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudIconID.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudIconID.Name = "nudIconID";
            this.nudIconID.Size = new System.Drawing.Size(180, 26);
            this.nudIconID.TabIndex = 22;
            // 
            // lblIconID
            // 
            this.lblIconID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIconID.AutoSize = true;
            this.lblIconID.Location = new System.Drawing.Point(675, 826);
            this.lblIconID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIconID.Name = "lblIconID";
            this.lblIconID.Size = new System.Drawing.Size(61, 20);
            this.lblIconID.TabIndex = 23;
            this.lblIconID.Text = "Icon ID";
            // 
            // btnBatchSave
            // 
            this.btnBatchSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatchSave.Enabled = false;
            this.btnBatchSave.Location = new System.Drawing.Point(190, 851);
            this.btnBatchSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBatchSave.Name = "btnBatchSave";
            this.btnBatchSave.Size = new System.Drawing.Size(112, 35);
            this.btnBatchSave.TabIndex = 24;
            this.btnBatchSave.Text = "Batch Save";
            toolTip1.SetToolTip(this.btnBatchSave, "Create a new icon with the given ID");
            this.btnBatchSave.UseVisualStyleBackColor = true;
            this.btnBatchSave.Click += new System.EventHandler(this.btnBatchSave_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iDDataGridViewTextBoxColumn.Width = 78;
            // 
            // textureDataGridViewComboBoxColumn
            // 
            this.textureDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textureDataGridViewComboBoxColumn.DataPropertyName = "Texture";
            this.textureDataGridViewComboBoxColumn.HeaderText = "Texture";
            this.textureDataGridViewComboBoxColumn.MinimumWidth = 8;
            this.textureDataGridViewComboBoxColumn.Name = "textureDataGridViewComboBoxColumn";
            this.textureDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // leftEdgeDataGridViewTextBoxColumn
            // 
            this.leftEdgeDataGridViewTextBoxColumn.DataPropertyName = "LeftEdge";
            this.leftEdgeDataGridViewTextBoxColumn.HeaderText = "Left Edge";
            this.leftEdgeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.leftEdgeDataGridViewTextBoxColumn.Name = "leftEdgeDataGridViewTextBoxColumn";
            this.leftEdgeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.leftEdgeDataGridViewTextBoxColumn.Width = 78;
            // 
            // topEdgeDataGridViewTextBoxColumn
            // 
            this.topEdgeDataGridViewTextBoxColumn.DataPropertyName = "TopEdge";
            this.topEdgeDataGridViewTextBoxColumn.HeaderText = "Top Edge";
            this.topEdgeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.topEdgeDataGridViewTextBoxColumn.Name = "topEdgeDataGridViewTextBoxColumn";
            this.topEdgeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.topEdgeDataGridViewTextBoxColumn.Width = 78;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.widthDataGridViewTextBoxColumn.Width = 78;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.heightDataGridViewTextBoxColumn.Width = 78;
            // 
            // spriteShapeBindingSource
            // 
            this.spriteShapeBindingSource.DataSource = typeof(DRB_Icon_Appender.SpriteShape);
            // 
            // btnBatchLoad
            // 
            this.btnBatchLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatchLoad.Enabled = false;
            this.btnBatchLoad.Location = new System.Drawing.Point(310, 851);
            this.btnBatchLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBatchLoad.Name = "btnBatchLoad";
            this.btnBatchLoad.Size = new System.Drawing.Size(112, 35);
            this.btnBatchLoad.TabIndex = 25;
            this.btnBatchLoad.Text = "Batch Load";
            toolTip1.SetToolTip(this.btnBatchLoad, "Create a new icon with the given ID");
            this.btnBatchLoad.UseVisualStyleBackColor = true;
            this.btnBatchLoad.Click += new System.EventHandler(this.btnBatchLoad_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 900);
            this.Controls.Add(this.btnBatchLoad);
            this.Controls.Add(this.btnBatchSave);
            this.Controls.Add(this.lblIconID);
            this.Controls.Add(this.nudIconID);
            this.Controls.Add(this.llbUpdate);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddIcon);
            this.Controls.Add(this.dgvIcons);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnExplore);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtGameDir);
            this.Controls.Add(lblGameDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1012, 298);
            this.Name = "FormMain";
            this.Text = "DRB Icon Appender <version>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIcons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIconID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteShapeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGameDir;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvIcons;
        private System.Windows.Forms.OpenFileDialog ofdExecutable;
        private System.Windows.Forms.BindingSource spriteShapeBindingSource;
        private System.Windows.Forms.Button btnAddIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn textureDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftEdgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topEdgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.LinkLabel llbUpdate;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.NumericUpDown nudIconID;
        private System.Windows.Forms.Label lblIconID;
        private System.Windows.Forms.Button btnBatchSave;
        private System.Windows.Forms.Button btnBatchLoad;
    }
}

