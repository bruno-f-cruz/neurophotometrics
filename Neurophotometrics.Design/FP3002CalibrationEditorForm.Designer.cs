﻿namespace Neurophotometrics.Design
{
    partial class FP3002CalibrationEditorForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.visualizerPanel = new System.Windows.Forms.Panel();
            this.menuLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.fileLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.loadSettingsButton = new System.Windows.Forms.Button();
            this.setupGroupBox = new System.Windows.Forms.GroupBox();
            this.setupLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.setupLaserButton = new System.Windows.Forms.Button();
            this.setupRegionsButton = new System.Windows.Forms.Button();
            this.setupPowerButton = new System.Windows.Forms.Button();
            this.propertyGroupBox = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new Neurophotometrics.Design.PropertyGrid();
            this.triggerGroupBox = new System.Windows.Forms.GroupBox();
            this.triggerStateView = new System.Windows.Forms.DataGridView();
            this.Led = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Out0 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Out1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.visualizerPanel.SuspendLayout();
            this.menuLayoutPanel.SuspendLayout();
            this.fileGroupBox.SuspendLayout();
            this.fileLayoutPanel.SuspendLayout();
            this.setupGroupBox.SuspendLayout();
            this.setupLayoutPanel.SuspendLayout();
            this.propertyGroupBox.SuspendLayout();
            this.triggerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triggerStateView)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "XML files|*.xml|All files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "FP3002Config.xml";
            this.saveFileDialog.Filter = "XML files|*.xml|All files|*.*";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 627);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(882, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(50, 20);
            this.connectionStatusLabel.Text = "Ready";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.visualizerPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.propertyGroupBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.triggerGroupBox, 2, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(882, 627);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // visualizerPanel
            // 
            this.visualizerPanel.Controls.Add(this.menuLayoutPanel);
            this.visualizerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizerPanel.Location = new System.Drawing.Point(2, 2);
            this.visualizerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.visualizerPanel.Name = "visualizerPanel";
            this.visualizerPanel.Size = new System.Drawing.Size(231, 623);
            this.visualizerPanel.TabIndex = 1;
            // 
            // menuLayoutPanel
            // 
            this.menuLayoutPanel.ColumnCount = 1;
            this.menuLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuLayoutPanel.Controls.Add(this.fileGroupBox, 0, 0);
            this.menuLayoutPanel.Controls.Add(this.setupGroupBox, 0, 1);
            this.menuLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.menuLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuLayoutPanel.Name = "menuLayoutPanel";
            this.menuLayoutPanel.RowCount = 2;
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.menuLayoutPanel.Size = new System.Drawing.Size(231, 623);
            this.menuLayoutPanel.TabIndex = 1;
            // 
            // fileGroupBox
            // 
            this.fileGroupBox.Controls.Add(this.fileLayoutPanel);
            this.fileGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileGroupBox.Location = new System.Drawing.Point(2, 2);
            this.fileGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.fileGroupBox.Size = new System.Drawing.Size(227, 245);
            this.fileGroupBox.TabIndex = 2;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "Load / Save";
            // 
            // fileLayoutPanel
            // 
            this.fileLayoutPanel.ColumnCount = 1;
            this.fileLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileLayoutPanel.Controls.Add(this.saveSettingsButton, 0, 1);
            this.fileLayoutPanel.Controls.Add(this.loadSettingsButton, 0, 0);
            this.fileLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileLayoutPanel.Location = new System.Drawing.Point(2, 17);
            this.fileLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.fileLayoutPanel.Name = "fileLayoutPanel";
            this.fileLayoutPanel.RowCount = 1;
            this.fileLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fileLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fileLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fileLayoutPanel.Size = new System.Drawing.Size(223, 226);
            this.fileLayoutPanel.TabIndex = 0;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveSettingsButton.Location = new System.Drawing.Point(2, 115);
            this.saveSettingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(219, 109);
            this.saveSettingsButton.TabIndex = 1;
            this.saveSettingsButton.Text = "Save Device Settings...";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            // 
            // loadSettingsButton
            // 
            this.loadSettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadSettingsButton.Location = new System.Drawing.Point(2, 2);
            this.loadSettingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadSettingsButton.Name = "loadSettingsButton";
            this.loadSettingsButton.Size = new System.Drawing.Size(219, 109);
            this.loadSettingsButton.TabIndex = 0;
            this.loadSettingsButton.Text = "Load Device Settings...";
            this.loadSettingsButton.UseVisualStyleBackColor = true;
            // 
            // setupGroupBox
            // 
            this.setupGroupBox.Controls.Add(this.setupLayoutPanel);
            this.setupGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setupGroupBox.Location = new System.Drawing.Point(2, 251);
            this.setupGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.setupGroupBox.Name = "setupGroupBox";
            this.setupGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.setupGroupBox.Size = new System.Drawing.Size(227, 370);
            this.setupGroupBox.TabIndex = 1;
            this.setupGroupBox.TabStop = false;
            this.setupGroupBox.Text = "Setup";
            // 
            // setupLayoutPanel
            // 
            this.setupLayoutPanel.ColumnCount = 1;
            this.setupLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.setupLayoutPanel.Controls.Add(this.setupLaserButton, 0, 2);
            this.setupLayoutPanel.Controls.Add(this.setupRegionsButton, 0, 0);
            this.setupLayoutPanel.Controls.Add(this.setupPowerButton, 0, 1);
            this.setupLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setupLayoutPanel.Location = new System.Drawing.Point(2, 17);
            this.setupLayoutPanel.Name = "setupLayoutPanel";
            this.setupLayoutPanel.RowCount = 3;
            this.setupLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.setupLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.setupLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.setupLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.setupLayoutPanel.Size = new System.Drawing.Size(223, 351);
            this.setupLayoutPanel.TabIndex = 2;
            // 
            // setupLaserButton
            // 
            this.setupLaserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setupLaserButton.Enabled = false;
            this.setupLaserButton.Location = new System.Drawing.Point(2, 236);
            this.setupLaserButton.Margin = new System.Windows.Forms.Padding(2);
            this.setupLaserButton.Name = "setupLaserButton";
            this.setupLaserButton.Size = new System.Drawing.Size(219, 113);
            this.setupLaserButton.TabIndex = 2;
            this.setupLaserButton.Text = "Calibrate Laser...";
            this.setupLaserButton.UseVisualStyleBackColor = true;
            this.setupLaserButton.Click += new System.EventHandler(this.setupLaserButton_Click);
            // 
            // setupRegionsButton
            // 
            this.setupRegionsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setupRegionsButton.Location = new System.Drawing.Point(2, 2);
            this.setupRegionsButton.Margin = new System.Windows.Forms.Padding(2);
            this.setupRegionsButton.Name = "setupRegionsButton";
            this.setupRegionsButton.Size = new System.Drawing.Size(219, 113);
            this.setupRegionsButton.TabIndex = 1;
            this.setupRegionsButton.Text = "Calibrate Regions...";
            this.setupRegionsButton.UseVisualStyleBackColor = true;
            this.setupRegionsButton.Click += new System.EventHandler(this.setupRegionsButton_Click);
            // 
            // setupPowerButton
            // 
            this.setupPowerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setupPowerButton.Location = new System.Drawing.Point(3, 120);
            this.setupPowerButton.Name = "setupPowerButton";
            this.setupPowerButton.Size = new System.Drawing.Size(217, 111);
            this.setupPowerButton.TabIndex = 3;
            this.setupPowerButton.Text = "Calibrate Power...";
            this.setupPowerButton.UseVisualStyleBackColor = true;
            this.setupPowerButton.Click += new System.EventHandler(this.setupPowerButton_Click);
            // 
            // propertyGroupBox
            // 
            this.propertyGroupBox.Controls.Add(this.propertyGrid);
            this.propertyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGroupBox.Location = new System.Drawing.Point(237, 2);
            this.propertyGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.propertyGroupBox.Name = "propertyGroupBox";
            this.propertyGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.propertyGroupBox.Size = new System.Drawing.Size(319, 623);
            this.propertyGroupBox.TabIndex = 2;
            this.propertyGroupBox.TabStop = false;
            this.propertyGroupBox.Text = "FP3002 Configuration";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(2, 17);
            this.propertyGrid.Margin = new System.Windows.Forms.Padding(2);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(315, 604);
            this.propertyGrid.SplitterDistance = 1.5D;
            this.propertyGrid.TabIndex = 2;
            // 
            // triggerGroupBox
            // 
            this.triggerGroupBox.Controls.Add(this.triggerStateView);
            this.triggerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggerGroupBox.Location = new System.Drawing.Point(560, 2);
            this.triggerGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.triggerGroupBox.Name = "triggerGroupBox";
            this.triggerGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.triggerGroupBox.Size = new System.Drawing.Size(320, 623);
            this.triggerGroupBox.TabIndex = 3;
            this.triggerGroupBox.TabStop = false;
            this.triggerGroupBox.Text = "Trigger Sequence";
            // 
            // triggerStateView
            // 
            this.triggerStateView.AllowUserToResizeRows = false;
            this.triggerStateView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.triggerStateView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Led,
            this.Out0,
            this.Out1});
            this.triggerStateView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggerStateView.Location = new System.Drawing.Point(2, 17);
            this.triggerStateView.Name = "triggerStateView";
            this.triggerStateView.RowHeadersWidth = 51;
            this.triggerStateView.RowTemplate.Height = 24;
            this.triggerStateView.Size = new System.Drawing.Size(316, 604);
            this.triggerStateView.TabIndex = 0;
            this.triggerStateView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.triggerStateView_CellMouseUp);
            this.triggerStateView.CurrentCellDirtyStateChanged += new System.EventHandler(this.triggerStateView_CurrentCellDirtyStateChanged);
            this.triggerStateView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.triggerStateView_DefaultValuesNeeded);
            this.triggerStateView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.triggerStateView_RowPostPaint);
            // 
            // Led
            // 
            this.Led.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Led.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Led.HeaderText = "LED";
            this.Led.Items.AddRange(new object[] {
            "None",
            "L415",
            "L470",
            "L560"});
            this.Led.MinimumWidth = 6;
            this.Led.Name = "Led";
            this.Led.Width = 75;
            // 
            // Out0
            // 
            this.Out0.HeaderText = "Out0";
            this.Out0.MinimumWidth = 6;
            this.Out0.Name = "Out0";
            this.Out0.Visible = false;
            this.Out0.Width = 50;
            // 
            // Out1
            // 
            this.Out1.HeaderText = "Out1";
            this.Out1.MinimumWidth = 6;
            this.Out1.Name = "Out1";
            this.Out1.Visible = false;
            this.Out1.Width = 50;
            // 
            // FP3002CalibrationEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.statusStrip);
            this.Icon = global::Neurophotometrics.Design.Properties.Resources.Neurophotometrics;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(673, 401);
            this.Name = "FP3002CalibrationEditorForm";
            this.Text = "FP3002 Setup";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.visualizerPanel.ResumeLayout(false);
            this.menuLayoutPanel.ResumeLayout(false);
            this.fileGroupBox.ResumeLayout(false);
            this.fileLayoutPanel.ResumeLayout(false);
            this.setupGroupBox.ResumeLayout(false);
            this.setupLayoutPanel.ResumeLayout(false);
            this.propertyGroupBox.ResumeLayout(false);
            this.triggerGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.triggerStateView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel visualizerPanel;
        private System.Windows.Forms.TableLayoutPanel menuLayoutPanel;
        private System.Windows.Forms.GroupBox fileGroupBox;
        private System.Windows.Forms.TableLayoutPanel fileLayoutPanel;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Button loadSettingsButton;
        private System.Windows.Forms.GroupBox setupGroupBox;
        private System.Windows.Forms.Button setupRegionsButton;
        private System.Windows.Forms.GroupBox propertyGroupBox;
        private PropertyGrid propertyGrid;
        private System.Windows.Forms.GroupBox triggerGroupBox;
        private System.Windows.Forms.DataGridView triggerStateView;
        private System.Windows.Forms.DataGridViewComboBoxColumn Led;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Out0;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Out1;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatusLabel;
        private System.Windows.Forms.TableLayoutPanel setupLayoutPanel;
        private System.Windows.Forms.Button setupLaserButton;
        private System.Windows.Forms.Button setupPowerButton;
    }
}