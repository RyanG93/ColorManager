namespace ColorManager
{
    partial class MainForm
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listView = new ColorManager.Controls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnSelectHold = new System.Windows.Forms.Label();
            this.lblColorHex = new System.Windows.Forms.Label();
            this.lblColorRgb = new System.Windows.Forms.Label();
            this.txtColorHex = new System.Windows.Forms.TextBox();
            this.txtColorRgb = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnSelectToggle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCopyHex = new System.Windows.Forms.Button();
            this.btnCopyRbg = new System.Windows.Forms.Button();
            this.groupColor = new System.Windows.Forms.GroupBox();
            this.groupControl = new System.Windows.Forms.GroupBox();
            this.btnSettings = new System.Windows.Forms.Label();
            this.groupProfiles = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbProfiles = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.lensBox = new ColorManager.Controls.LensBox();
            this.contextMenuStrip.SuspendLayout();
            this.groupColor.SuspendLayout();
            this.groupControl.SuspendLayout();
            this.groupProfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lensBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.ColumnLockIndex = 1;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.ContextMenuStrip = this.contextMenuStrip;
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(6, 47);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(270, 150);
            this.listView.SmallImageList = this.imageList;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.OnListSelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Color";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 156;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.OnRemoveClick);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnSelectHold
            // 
            this.btnSelectHold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSelectHold.Location = new System.Drawing.Point(166, 17);
            this.btnSelectHold.Name = "btnSelectHold";
            this.btnSelectHold.Size = new System.Drawing.Size(110, 39);
            this.btnSelectHold.TabIndex = 12;
            this.btnSelectHold.Text = "Select from Screen\r\n(Press && Hold)";
            this.btnSelectHold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectHold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnButtonHoldSelectDown);
            this.btnSelectHold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnButtonHoldSelectUp);
            // 
            // lblColorHex
            // 
            this.lblColorHex.AutoSize = true;
            this.lblColorHex.Location = new System.Drawing.Point(138, 20);
            this.lblColorHex.Name = "lblColorHex";
            this.lblColorHex.Size = new System.Drawing.Size(14, 13);
            this.lblColorHex.TabIndex = 13;
            this.lblColorHex.Text = "#";
            // 
            // lblColorRgb
            // 
            this.lblColorRgb.AutoSize = true;
            this.lblColorRgb.Location = new System.Drawing.Point(126, 49);
            this.lblColorRgb.Name = "lblColorRgb";
            this.lblColorRgb.Size = new System.Drawing.Size(28, 13);
            this.lblColorRgb.TabIndex = 14;
            this.lblColorRgb.Text = "RGB";
            // 
            // txtColorHex
            // 
            this.txtColorHex.Location = new System.Drawing.Point(153, 17);
            this.txtColorHex.Name = "txtColorHex";
            this.txtColorHex.ReadOnly = true;
            this.txtColorHex.Size = new System.Drawing.Size(76, 22);
            this.txtColorHex.TabIndex = 15;
            // 
            // txtColorRgb
            // 
            this.txtColorRgb.Location = new System.Drawing.Point(153, 46);
            this.txtColorRgb.Name = "txtColorRgb";
            this.txtColorRgb.ReadOnly = true;
            this.txtColorRgb.Size = new System.Drawing.Size(76, 22);
            this.txtColorRgb.TabIndex = 16;
            // 
            // lblColor
            // 
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(6, 17);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(114, 50);
            this.lblColor.TabIndex = 17;
            // 
            // btnSelectToggle
            // 
            this.btnSelectToggle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSelectToggle.Location = new System.Drawing.Point(51, 17);
            this.btnSelectToggle.Name = "btnSelectToggle";
            this.btnSelectToggle.Size = new System.Drawing.Size(109, 39);
            this.btnSelectToggle.TabIndex = 18;
            this.btnSelectToggle.Text = "Toggle Select [Off]\r\n(Ctrl+G)";
            this.btnSelectToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Description:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(78, 75);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(151, 22);
            this.txtDesc.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(235, 74);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(41, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // btnCopyHex
            // 
            this.btnCopyHex.Location = new System.Drawing.Point(235, 16);
            this.btnCopyHex.Name = "btnCopyHex";
            this.btnCopyHex.Size = new System.Drawing.Size(41, 23);
            this.btnCopyHex.TabIndex = 22;
            this.btnCopyHex.Tag = "txtColorHex";
            this.btnCopyHex.Text = "Copy";
            this.btnCopyHex.UseVisualStyleBackColor = true;
            this.btnCopyHex.Click += new System.EventHandler(this.OnCopyClick);
            // 
            // btnCopyRbg
            // 
            this.btnCopyRbg.Location = new System.Drawing.Point(235, 45);
            this.btnCopyRbg.Name = "btnCopyRbg";
            this.btnCopyRbg.Size = new System.Drawing.Size(41, 23);
            this.btnCopyRbg.TabIndex = 23;
            this.btnCopyRbg.Tag = "txtColorRgb";
            this.btnCopyRbg.Text = "Copy";
            this.btnCopyRbg.UseVisualStyleBackColor = true;
            this.btnCopyRbg.Click += new System.EventHandler(this.OnCopyClick);
            // 
            // groupColor
            // 
            this.groupColor.Controls.Add(this.txtDesc);
            this.groupColor.Controls.Add(this.btnCopyRbg);
            this.groupColor.Controls.Add(this.label1);
            this.groupColor.Controls.Add(this.btnCopyHex);
            this.groupColor.Controls.Add(this.btnSave);
            this.groupColor.Controls.Add(this.lblColor);
            this.groupColor.Controls.Add(this.lblColorHex);
            this.groupColor.Controls.Add(this.txtColorRgb);
            this.groupColor.Controls.Add(this.lblColorRgb);
            this.groupColor.Controls.Add(this.txtColorHex);
            this.groupColor.Location = new System.Drawing.Point(1, 70);
            this.groupColor.Name = "groupColor";
            this.groupColor.Size = new System.Drawing.Size(282, 104);
            this.groupColor.TabIndex = 24;
            this.groupColor.TabStop = false;
            this.groupColor.Text = "Color";
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.btnSettings);
            this.groupControl.Controls.Add(this.btnSelectHold);
            this.groupControl.Controls.Add(this.btnSelectToggle);
            this.groupControl.Location = new System.Drawing.Point(1, 1);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(282, 63);
            this.groupControl.TabIndex = 25;
            this.groupControl.TabStop = false;
            this.groupControl.Text = "Control";
            // 
            // btnSettings
            // 
            this.btnSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSettings.Image = global::ColorManager.Properties.Resources.ui_settings;
            this.btnSettings.Location = new System.Drawing.Point(6, 17);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(39, 39);
            this.btnSettings.TabIndex = 20;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSettings.Click += new System.EventHandler(this.OnSettingsClick);
            // 
            // groupProfiles
            // 
            this.groupProfiles.Controls.Add(this.btnDelete);
            this.groupProfiles.Controls.Add(this.btnEdit);
            this.groupProfiles.Controls.Add(this.btnNew);
            this.groupProfiles.Controls.Add(this.cmbProfiles);
            this.groupProfiles.Controls.Add(this.listView);
            this.groupProfiles.Controls.Add(this.button1);
            this.groupProfiles.Location = new System.Drawing.Point(1, 180);
            this.groupProfiles.Name = "groupProfiles";
            this.groupProfiles.Size = new System.Drawing.Size(282, 204);
            this.groupProfiles.TabIndex = 26;
            this.groupProfiles.TabStop = false;
            this.groupProfiles.Text = "Profiles";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(229, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.OnDeleteProfileClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(188, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(38, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.OnEditProfileClick);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(147, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(38, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.OnNewProfileClick);
            // 
            // cmbProfiles
            // 
            this.cmbProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfiles.FormattingEnabled = true;
            this.cmbProfiles.Location = new System.Drawing.Point(6, 21);
            this.cmbProfiles.Name = "cmbProfiles";
            this.cmbProfiles.Size = new System.Drawing.Size(135, 21);
            this.cmbProfiles.TabIndex = 2;
            this.cmbProfiles.SelectedValueChanged += new System.EventHandler(this.OnProfileSelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // lensBox
            // 
            this.lensBox.LensSize = 300;
            this.lensBox.LensZoom = 14;
            this.lensBox.Location = new System.Drawing.Point(0, 384);
            this.lensBox.Name = "lensBox";
            this.lensBox.Size = new System.Drawing.Size(284, 76);
            this.lensBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lensBox.TabIndex = 27;
            this.lensBox.TabStop = false;
            this.lensBox.FocusChanged += new System.Action<System.Drawing.Color>(this.OnLensFocusChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 460);
            this.Controls.Add(this.lensBox);
            this.Controls.Add(this.groupProfiles);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.groupColor);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Manager";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OnLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.contextMenuStrip.ResumeLayout(false);
            this.groupColor.ResumeLayout(false);
            this.groupColor.PerformLayout();
            this.groupControl.ResumeLayout(false);
            this.groupProfiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lensBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ListViewEx listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label btnSelectHold;
        private System.Windows.Forms.Label lblColorHex;
        private System.Windows.Forms.Label lblColorRgb;
        private System.Windows.Forms.TextBox txtColorHex;
        private System.Windows.Forms.TextBox txtColorRgb;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label btnSelectToggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCopyHex;
        private System.Windows.Forms.Button btnCopyRbg;
        private System.Windows.Forms.GroupBox groupColor;
        private System.Windows.Forms.GroupBox groupControl;
        private System.Windows.Forms.GroupBox groupProfiles;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbProfiles;
        private Controls.LensBox lensBox;
        private System.Windows.Forms.Label btnSettings;
    }
}

