namespace PMS_v1.Pages
{
    partial class LeasingModule
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            tlpMainSkeleton = new TableLayoutPanel();
            pnlHeaderBlock = new Panel();
            lblBreadcrumb = new Label();
            lblModuleTitle = new Label();
            tlpMetricsRow = new TableLayoutPanel();
            statCardActive = new PMS_v1.UserControls.Statcard();
            statCardPending = new PMS_v1.UserControls.Statcard();
            statCardExpired = new PMS_v1.UserControls.Statcard();
            statCardTerminated = new PMS_v1.UserControls.Statcard();
            pnlCommandActionRow = new Panel();
            txtSearchInput = new Krypton.Toolkit.KryptonTextBox();
            cmbFilterDropdown = new Krypton.Toolkit.KryptonComboBox();
            btnNewLease = new Krypton.Toolkit.KryptonButton();
            dgvLeases = new DataGridView();
            tlpMainSkeleton.SuspendLayout();
            pnlHeaderBlock.SuspendLayout();
            tlpMetricsRow.SuspendLayout();
            pnlCommandActionRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbFilterDropdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLeases).BeginInit();
            SuspendLayout();
            // 
            // tlpMainSkeleton
            // 
            tlpMainSkeleton.ColumnCount = 1;
            tlpMainSkeleton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainSkeleton.Controls.Add(pnlHeaderBlock, 0, 0);
            tlpMainSkeleton.Controls.Add(tlpMetricsRow, 0, 1);
            tlpMainSkeleton.Controls.Add(pnlCommandActionRow, 0, 2);
            tlpMainSkeleton.Controls.Add(dgvLeases, 0, 3);
            tlpMainSkeleton.Dock = DockStyle.Fill;
            tlpMainSkeleton.Location = new Point(0, 0);
            tlpMainSkeleton.Name = "tlpMainSkeleton";
            tlpMainSkeleton.RowCount = 4;
            tlpMainSkeleton.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tlpMainSkeleton.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tlpMainSkeleton.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpMainSkeleton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainSkeleton.Size = new Size(1150, 938);
            tlpMainSkeleton.TabIndex = 0;
            // 
            // pnlHeaderBlock
            // 
            pnlHeaderBlock.Controls.Add(lblBreadcrumb);
            pnlHeaderBlock.Controls.Add(lblModuleTitle);
            pnlHeaderBlock.Dock = DockStyle.Fill;
            pnlHeaderBlock.Location = new Point(3, 3);
            pnlHeaderBlock.Name = "pnlHeaderBlock";
            pnlHeaderBlock.Size = new Size(1144, 73);
            pnlHeaderBlock.TabIndex = 0;
            // 
            // lblBreadcrumb
            // 
            lblBreadcrumb.AutoSize = true;
            lblBreadcrumb.Font = new Font("Segoe UI", 8.5F);
            lblBreadcrumb.ForeColor = Color.FromArgb(108, 117, 125);
            lblBreadcrumb.Location = new Point(32, 12);
            lblBreadcrumb.Name = "lblBreadcrumb";
            lblBreadcrumb.Size = new Size(91, 15);
            lblBreadcrumb.TabIndex = 0;
            lblBreadcrumb.Text = "Home / Leasing";
            // 
            // lblModuleTitle
            // 
            lblModuleTitle.AutoSize = true;
            lblModuleTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblModuleTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblModuleTitle.Location = new Point(32, 30);
            lblModuleTitle.Name = "lblModuleTitle";
            lblModuleTitle.Size = new Size(124, 41);
            lblModuleTitle.TabIndex = 1;
            lblModuleTitle.Text = "Leasing";
            // 
            // tlpMetricsRow
            // 
            tlpMetricsRow.ColumnCount = 4;
            tlpMetricsRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMetricsRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMetricsRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMetricsRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMetricsRow.Controls.Add(statCardActive, 0, 0);
            tlpMetricsRow.Controls.Add(statCardPending, 1, 0);
            tlpMetricsRow.Controls.Add(statCardExpired, 2, 0);
            tlpMetricsRow.Controls.Add(statCardTerminated, 3, 0);
            tlpMetricsRow.Dock = DockStyle.Fill;
            tlpMetricsRow.Location = new Point(20, 79);
            tlpMetricsRow.Margin = new Padding(20, 0, 20, 0);
            tlpMetricsRow.Name = "tlpMetricsRow";
            tlpMetricsRow.RowCount = 1;
            tlpMetricsRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMetricsRow.Size = new Size(1110, 110);
            tlpMetricsRow.TabIndex = 1;
            // 
            // statCardActive
            // 
            statCardActive.CardCaption = "Active";
            statCardActive.CardIcon = Resources.Resources.check;
            statCardActive.CardNumber = "00";
            statCardActive.Dock = DockStyle.Fill;
            statCardActive.Location = new Point(8, 0);
            statCardActive.Margin = new Padding(8, 0, 8, 0);
            statCardActive.Name = "statCardActive";
            statCardActive.Size = new Size(261, 110);
            statCardActive.TabIndex = 0;
            // 
            // statCardPending
            // 
            statCardPending.CardCaption = "Pending";
            statCardPending.CardIcon = Resources.Resources.clock;
            statCardPending.CardNumber = "00";
            statCardPending.Dock = DockStyle.Fill;
            statCardPending.Location = new Point(285, 0);
            statCardPending.Margin = new Padding(8, 0, 8, 0);
            statCardPending.Name = "statCardPending";
            statCardPending.Size = new Size(261, 110);
            statCardPending.TabIndex = 1;
            // 
            // statCardExpired
            // 
            statCardExpired.CardCaption = "Expired";
            statCardExpired.CardIcon = Resources.Resources.exclamation;
            statCardExpired.CardNumber = "00";
            statCardExpired.Dock = DockStyle.Fill;
            statCardExpired.Location = new Point(562, 0);
            statCardExpired.Margin = new Padding(8, 0, 8, 0);
            statCardExpired.Name = "statCardExpired";
            statCardExpired.Size = new Size(261, 110);
            statCardExpired.TabIndex = 2;
            // 
            // statCardTerminated
            // 
            statCardTerminated.CardCaption = "Terminated";
            statCardTerminated.CardIcon = Resources.Resources.remove;
            statCardTerminated.CardNumber = "00";
            statCardTerminated.Dock = DockStyle.Fill;
            statCardTerminated.Location = new Point(839, 0);
            statCardTerminated.Margin = new Padding(8, 0, 8, 0);
            statCardTerminated.Name = "statCardTerminated";
            statCardTerminated.Size = new Size(263, 110);
            statCardTerminated.TabIndex = 3;
            // 
            // pnlCommandActionRow
            // 
            pnlCommandActionRow.Controls.Add(txtSearchInput);
            pnlCommandActionRow.Controls.Add(cmbFilterDropdown);
            pnlCommandActionRow.Controls.Add(btnNewLease);
            pnlCommandActionRow.Dock = DockStyle.Fill;
            pnlCommandActionRow.Location = new Point(3, 192);
            pnlCommandActionRow.Name = "pnlCommandActionRow";
            pnlCommandActionRow.Size = new Size(1144, 59);
            pnlCommandActionRow.TabIndex = 2;
            // 
            // txtSearchInput
            // 
            txtSearchInput.Location = new Point(32, 12);
            txtSearchInput.Name = "txtSearchInput";
            txtSearchInput.Size = new Size(580, 31);
            txtSearchInput.StateCommon.Back.Color1 = Color.White;
            txtSearchInput.StateCommon.Border.Color1 = Color.FromArgb(222, 226, 230);
            txtSearchInput.StateCommon.Border.Rounding = 12F;
            txtSearchInput.TabIndex = 0;
            txtSearchInput.Text = "Search tenant, unit or lease...";
            // 
            // cmbFilterDropdown
            // 
            cmbFilterDropdown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFilterDropdown.Location = new Point(734, 12);
            cmbFilterDropdown.Name = "cmbFilterDropdown";
            cmbFilterDropdown.Size = new Size(150, 30);
            cmbFilterDropdown.StateCommon.ComboBox.Back.Color1 = Color.White;
            cmbFilterDropdown.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(222, 226, 230);
            cmbFilterDropdown.StateCommon.ComboBox.Border.Rounding = 12F;
            cmbFilterDropdown.TabIndex = 1;
            cmbFilterDropdown.Text = "Filter";
            // 
            // btnNewLease
            // 
            btnNewLease.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewLease.Location = new Point(912, 12);
            btnNewLease.Name = "btnNewLease";
            btnNewLease.Size = new Size(200, 38);
            btnNewLease.StateCommon.Back.Color1 = Color.FromArgb(141, 198, 63);
            btnNewLease.StateCommon.Back.Color2 = Color.FromArgb(91, 154, 42);
            btnNewLease.StateCommon.Back.ColorAngle = 90F;
            btnNewLease.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            btnNewLease.StateCommon.Border.Rounding = 12F;
            btnNewLease.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNewLease.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnNewLease.TabIndex = 2;
            btnNewLease.Values.DropDownArrowColor = Color.Empty;
            btnNewLease.Values.Text = "+   New Lease";
            // 
            // dgvLeases
            // 
            dgvLeases.BackgroundColor = Color.White;
            dgvLeases.BorderStyle = BorderStyle.None;
            dgvLeases.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLeases.ColumnHeadersHeight = 40;
            dgvLeases.Dock = DockStyle.Fill;
            dgvLeases.GridColor = Color.FromArgb(233, 236, 239);
            dgvLeases.Location = new Point(32, 264);
            dgvLeases.Margin = new Padding(32, 10, 32, 32);
            dgvLeases.Name = "dgvLeases";
            dgvLeases.RowHeadersVisible = false;
            dgvLeases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLeases.Size = new Size(1086, 642);
            dgvLeases.TabIndex = 3;
            // 
            // LeasingModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 247);
            Controls.Add(tlpMainSkeleton);
            MinimumSize = new Size(1150, 938);
            Name = "LeasingModule";
            Size = new Size(1150, 938);
            tlpMainSkeleton.ResumeLayout(false);
            pnlHeaderBlock.ResumeLayout(false);
            pnlHeaderBlock.PerformLayout();
            tlpMetricsRow.ResumeLayout(false);
            pnlCommandActionRow.ResumeLayout(false);
            pnlCommandActionRow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbFilterDropdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLeases).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpMainSkeleton;
        private System.Windows.Forms.Panel pnlHeaderBlock;
        private System.Windows.Forms.Label lblBreadcrumb;
        private System.Windows.Forms.Label lblModuleTitle;
        private System.Windows.Forms.TableLayoutPanel tlpMetricsRow;
        // 🚀 Cleaned-up 4 Statcard Fields
        private PMS_v1.UserControls.Statcard statCardActive;
        private PMS_v1.UserControls.Statcard statCardPending;
        private PMS_v1.UserControls.Statcard statCardExpired;
        private PMS_v1.UserControls.Statcard statCardTerminated;
        private System.Windows.Forms.Panel pnlCommandActionRow;
        private Krypton.Toolkit.KryptonTextBox txtSearchInput;
        private Krypton.Toolkit.KryptonComboBox cmbFilterDropdown;
        private Krypton.Toolkit.KryptonButton btnNewLease;
        private System.Windows.Forms.DataGridView dgvLeases;
    }
}
