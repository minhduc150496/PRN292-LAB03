namespace PRN292_LAB03
{
    partial class DetailForm
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
            this.btnLoadFrom = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSaveTo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dgCD = new System.Windows.Forms.DataGridView();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSinger = new System.Windows.Forms.Label();
            this.txtSinger = new System.Windows.Forms.TextBox();
            this.lblAblbum = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.dgSongs = new System.Windows.Forms.DataGridView();
            this.MainForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgCD)).BeginInit();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadFrom
            // 
            this.btnLoadFrom.Location = new System.Drawing.Point(255, 424);
            this.btnLoadFrom.Name = "btnLoadFrom";
            this.btnLoadFrom.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFrom.TabIndex = 21;
            this.btnLoadFrom.Text = "Load from";
            this.btnLoadFrom.UseVisualStyleBackColor = true;
            this.btnLoadFrom.Click += new System.EventHandler(this.btnLoadFrom_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(272, 52);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSaveTo
            // 
            this.btnSaveTo.Location = new System.Drawing.Point(336, 424);
            this.btnSaveTo.Name = "btnSaveTo";
            this.btnSaveTo.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTo.TabIndex = 19;
            this.btnSaveTo.Text = "Save to";
            this.btnSaveTo.UseVisualStyleBackColor = true;
            this.btnSaveTo.Click += new System.EventHandler(this.btnSaveTo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 424);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(12, 424);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 16;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgCD
            // 
            this.dgCD.AllowUserToAddRows = false;
            this.dgCD.AllowUserToDeleteRows = false;
            this.dgCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCD.Location = new System.Drawing.Point(12, 171);
            this.dgCD.Name = "dgCD";
            this.dgCD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCD.Size = new System.Drawing.Size(750, 246);
            this.dgCD.TabIndex = 15;
            this.dgCD.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCD_CellMouseClick);
            this.dgCD.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCD_ColumnHeaderMouseClick);
            this.dgCD.SelectionChanged += new System.EventHandler(this.dgCD_SelectionChanged);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.txtSong);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.btnRefresh);
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Controls.Add(this.lblSinger);
            this.gbSearch.Controls.Add(this.txtSinger);
            this.gbSearch.Controls.Add(this.lblAblbum);
            this.gbSearch.Controls.Add(this.txtAlbum);
            this.gbSearch.Location = new System.Drawing.Point(12, 3);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(441, 162);
            this.gbSearch.TabIndex = 22;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // txtSong
            // 
            this.txtSong.Location = new System.Drawing.Point(66, 80);
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(182, 20);
            this.txtSong.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(272, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Song:";
            // 
            // lblSinger
            // 
            this.lblSinger.AutoSize = true;
            this.lblSinger.Location = new System.Drawing.Point(5, 54);
            this.lblSinger.Name = "lblSinger";
            this.lblSinger.Size = new System.Drawing.Size(40, 13);
            this.lblSinger.TabIndex = 3;
            this.lblSinger.Text = "Singer:";
            // 
            // txtSinger
            // 
            this.txtSinger.Location = new System.Drawing.Point(66, 54);
            this.txtSinger.Name = "txtSinger";
            this.txtSinger.Size = new System.Drawing.Size(182, 20);
            this.txtSinger.TabIndex = 2;
            // 
            // lblAblbum
            // 
            this.lblAblbum.AutoSize = true;
            this.lblAblbum.Location = new System.Drawing.Point(5, 28);
            this.lblAblbum.Name = "lblAblbum";
            this.lblAblbum.Size = new System.Drawing.Size(39, 13);
            this.lblAblbum.TabIndex = 1;
            this.lblAblbum.Text = "Album:";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(66, 28);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(182, 20);
            this.txtAlbum.TabIndex = 0;
            // 
            // dgSongs
            // 
            this.dgSongs.AllowUserToAddRows = false;
            this.dgSongs.AllowUserToDeleteRows = false;
            this.dgSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MainForm});
            this.dgSongs.Location = new System.Drawing.Point(459, 12);
            this.dgSongs.Name = "dgSongs";
            this.dgSongs.Size = new System.Drawing.Size(302, 150);
            this.dgSongs.TabIndex = 23;
            // 
            // MainForm
            // 
            this.MainForm.HeaderText = "Song Name";
            this.MainForm.Name = "MainForm";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 459);
            this.Controls.Add(this.dgSongs);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.btnLoadFrom);
            this.Controls.Add(this.btnSaveTo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgCD);
            //this.Name = "DetailForm";
            this.Text = "LAB 3 - DucBM";
            ((System.ComponentModel.ISupportInitialize)(this.dgCD)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSongs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFrom;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSaveTo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgCD;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSinger;
        private System.Windows.Forms.TextBox txtSinger;
        private System.Windows.Forms.Label lblAblbum;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.DataGridView dgSongs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainForm;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

