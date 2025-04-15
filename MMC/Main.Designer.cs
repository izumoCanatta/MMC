namespace MMC
{
    partial class Main
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
            tabMainApp = new TabControl();
            tabPageDashboard = new TabPage();
            panelDashboard = new Panel();
            tableWeekDues = new TableLayoutPanel();
            labelStatus = new Label();
            labelDueDate = new Label();
            labelAmountDue = new Label();
            labelLoanAmount = new Label();
            labelMemberName = new Label();
            labelLoanID = new Label();
            outputWeekDuesTo = new Label();
            labelTo = new Label();
            outputWeeklyDuesFrom = new Label();
            labelFrom = new Label();
            labelWeeklyDues = new Label();
            outputDatetime = new Label();
            labelDashboardTitle = new Label();
            labelAsOf = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            labelPHP6 = new Label();
            labelTotalDividends = new Label();
            outputTotalDividendsReleased = new Label();
            panelAvailableFund = new Panel();
            labelPHP5 = new Label();
            labelAvailableFund = new Label();
            outputAvailableFund = new Label();
            panelTotalMembers = new Panel();
            labelTotalActiveMembers = new Label();
            outputTotalActiveMembers = new Label();
            panelCollectibleInterest = new Panel();
            labelPHP3 = new Label();
            labelTotalCollectibleInterest = new Label();
            outputCollectibleInterest = new Label();
            panelContributions = new Panel();
            labelPHP2 = new Label();
            labelOutputTotalContributions = new Label();
            labelTotalContributions = new Label();
            panelActiveLoan = new Panel();
            labelPHP = new Label();
            labelTotalLoan = new Label();
            outputTotalLoan = new Label();
            tabPageFinance = new TabPage();
            tabFinance = new TabControl();
            tabLoan = new TabPage();
            btnPrintLoanVoucher = new Button();
            panel5 = new Panel();
            labelLoanVoucher = new Label();
            btnCancelLoan = new Button();
            btnConfirmLoan = new Button();
            outputInterestRateLoan = new TextBox();
            labelInterestRate = new Label();
            labelLoanType = new Label();
            inputLoanType = new ComboBox();
            outputMemberIDLoan = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            btnValidate = new Button();
            labelSuffix = new Label();
            inputSuffixLoan = new TextBox();
            labelLName = new Label();
            inputLNameLoan = new TextBox();
            labelMiddleName = new Label();
            inputMNameLoan = new TextBox();
            labelFName = new Label();
            inputFNameLoan = new TextBox();
            tabPay = new TabPage();
            panel6 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label22 = new Label();
            textBox6 = new TextBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label24 = new Label();
            label23 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            tabContribute = new TabPage();
            tabWithdraw = new TabPage();
            tabSOA = new TabPage();
            panelFinanceHead = new Panel();
            labelFinanceTitle = new Label();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            labelPHPFinance = new Label();
            labelTotalActiveLoans = new Label();
            outputTotalAmountofActiveLoans = new Label();
            panelAvailableFundFinance = new Panel();
            labelPHPFinance1 = new Label();
            labelTotalAvailableFundFinance = new Label();
            outputAvailableFundFinance = new Label();
            panel4 = new Panel();
            tabPageMembers = new TabPage();
            tabPageSystemSettings = new TabPage();
            tabMainApp.SuspendLayout();
            tabPageDashboard.SuspendLayout();
            panelDashboard.SuspendLayout();
            tableWeekDues.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panelAvailableFund.SuspendLayout();
            panelTotalMembers.SuspendLayout();
            panelCollectibleInterest.SuspendLayout();
            panelContributions.SuspendLayout();
            panelActiveLoan.SuspendLayout();
            tabPageFinance.SuspendLayout();
            tabFinance.SuspendLayout();
            tabLoan.SuspendLayout();
            tabPay.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panelFinanceHead.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panelAvailableFundFinance.SuspendLayout();
            SuspendLayout();
            // 
            // tabMainApp
            // 
            tabMainApp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabMainApp.Appearance = TabAppearance.Buttons;
            tabMainApp.Controls.Add(tabPageDashboard);
            tabMainApp.Controls.Add(tabPageFinance);
            tabMainApp.Controls.Add(tabPageMembers);
            tabMainApp.Controls.Add(tabPageSystemSettings);
            tabMainApp.Cursor = Cursors.Hand;
            tabMainApp.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabMainApp.ImeMode = ImeMode.NoControl;
            tabMainApp.Location = new Point(12, 3);
            tabMainApp.Name = "tabMainApp";
            tabMainApp.Padding = new Point(15, 5);
            tabMainApp.SelectedIndex = 0;
            tabMainApp.Size = new Size(1108, 948);
            tabMainApp.TabIndex = 0;
            // 
            // tabPageDashboard
            // 
            tabPageDashboard.AutoScroll = true;
            tabPageDashboard.Controls.Add(panelDashboard);
            tabPageDashboard.Location = new Point(4, 47);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Padding = new Padding(3);
            tabPageDashboard.Size = new Size(1100, 897);
            tabPageDashboard.TabIndex = 0;
            tabPageDashboard.Text = "Dashboard";
            tabPageDashboard.UseVisualStyleBackColor = true;
            tabPageDashboard.Click += tabPage1_Click;
            // 
            // panelDashboard
            // 
            panelDashboard.AutoScroll = true;
            panelDashboard.BorderStyle = BorderStyle.Fixed3D;
            panelDashboard.Controls.Add(tableWeekDues);
            panelDashboard.Controls.Add(outputWeekDuesTo);
            panelDashboard.Controls.Add(labelTo);
            panelDashboard.Controls.Add(outputWeeklyDuesFrom);
            panelDashboard.Controls.Add(labelFrom);
            panelDashboard.Controls.Add(labelWeeklyDues);
            panelDashboard.Controls.Add(outputDatetime);
            panelDashboard.Controls.Add(labelDashboardTitle);
            panelDashboard.Controls.Add(labelAsOf);
            panelDashboard.Controls.Add(tableLayoutPanel1);
            panelDashboard.Location = new Point(6, 3);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(1087, 1203);
            panelDashboard.TabIndex = 0;
            // 
            // tableWeekDues
            // 
            tableWeekDues.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableWeekDues.ColumnCount = 6;
            tableWeekDues.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableWeekDues.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableWeekDues.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableWeekDues.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableWeekDues.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableWeekDues.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableWeekDues.Controls.Add(labelStatus, 5, 0);
            tableWeekDues.Controls.Add(labelDueDate, 4, 0);
            tableWeekDues.Controls.Add(labelAmountDue, 3, 0);
            tableWeekDues.Controls.Add(labelLoanAmount, 2, 0);
            tableWeekDues.Controls.Add(labelMemberName, 1, 0);
            tableWeekDues.Controls.Add(labelLoanID, 0, 0);
            tableWeekDues.Location = new Point(51, 910);
            tableWeekDues.Name = "tableWeekDues";
            tableWeekDues.RowCount = 4;
            tableWeekDues.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableWeekDues.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableWeekDues.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableWeekDues.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableWeekDues.Size = new Size(966, 125);
            tableWeekDues.TabIndex = 25;
            // 
            // labelStatus
            // 
            labelStatus.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(868, 1);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(89, 30);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "Status";
            labelStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDueDate
            // 
            labelDueDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDueDate.Location = new Point(772, 1);
            labelDueDate.Name = "labelDueDate";
            labelDueDate.Size = new Size(89, 30);
            labelDueDate.TabIndex = 4;
            labelDueDate.Text = "Due Date";
            labelDueDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAmountDue
            // 
            labelAmountDue.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAmountDue.Location = new Point(580, 1);
            labelAmountDue.Name = "labelAmountDue";
            labelAmountDue.Size = new Size(185, 30);
            labelAmountDue.TabIndex = 3;
            labelAmountDue.Text = "Amount Due (Interest)";
            labelAmountDue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelLoanAmount
            // 
            labelLoanAmount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLoanAmount.Location = new Point(388, 1);
            labelLoanAmount.Name = "labelLoanAmount";
            labelLoanAmount.Size = new Size(185, 30);
            labelLoanAmount.TabIndex = 2;
            labelLoanAmount.Text = "Loan Amount";
            labelLoanAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMemberName
            // 
            labelMemberName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMemberName.Location = new Point(100, 1);
            labelMemberName.Name = "labelMemberName";
            labelMemberName.Size = new Size(281, 30);
            labelMemberName.TabIndex = 1;
            labelMemberName.Text = "Member Name";
            labelMemberName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelLoanID
            // 
            labelLoanID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLoanID.Location = new Point(4, 1);
            labelLoanID.Name = "labelLoanID";
            labelLoanID.Size = new Size(89, 30);
            labelLoanID.TabIndex = 0;
            labelLoanID.Text = "LoanID";
            labelLoanID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // outputWeekDuesTo
            // 
            outputWeekDuesTo.AutoSize = true;
            outputWeekDuesTo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputWeekDuesTo.ForeColor = Color.RoyalBlue;
            outputWeekDuesTo.Location = new Point(609, 862);
            outputWeekDuesTo.Name = "outputWeekDuesTo";
            outputWeekDuesTo.Size = new Size(109, 23);
            outputWeekDuesTo.TabIndex = 24;
            outputWeekDuesTo.Text = "(timestamp)";
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTo.Location = new Point(548, 865);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(35, 20);
            labelTo.TabIndex = 23;
            labelTo.Text = "To:";
            // 
            // outputWeeklyDuesFrom
            // 
            outputWeeklyDuesFrom.AutoSize = true;
            outputWeeklyDuesFrom.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputWeeklyDuesFrom.ForeColor = Color.RoyalBlue;
            outputWeeklyDuesFrom.Location = new Point(415, 862);
            outputWeeklyDuesFrom.Name = "outputWeeklyDuesFrom";
            outputWeeklyDuesFrom.Size = new Size(109, 23);
            outputWeeklyDuesFrom.TabIndex = 22;
            outputWeeklyDuesFrom.Text = "(timestamp)";
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFrom.Location = new Point(354, 865);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(56, 20);
            labelFrom.TabIndex = 21;
            labelFrom.Text = "From:";
            // 
            // labelWeeklyDues
            // 
            labelWeeklyDues.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWeeklyDues.Location = new Point(0, 792);
            labelWeeklyDues.Name = "labelWeeklyDues";
            labelWeeklyDues.Size = new Size(1082, 73);
            labelWeeklyDues.TabIndex = 20;
            labelWeeklyDues.Text = "Weekly Dues";
            labelWeeklyDues.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // outputDatetime
            // 
            outputDatetime.AutoSize = true;
            outputDatetime.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputDatetime.ForeColor = Color.RoyalBlue;
            outputDatetime.Location = new Point(489, 134);
            outputDatetime.Name = "outputDatetime";
            outputDatetime.Size = new Size(109, 23);
            outputDatetime.TabIndex = 13;
            outputDatetime.Text = "(timestamp)";
            // 
            // labelDashboardTitle
            // 
            labelDashboardTitle.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDashboardTitle.Location = new Point(6, 61);
            labelDashboardTitle.Name = "labelDashboardTitle";
            labelDashboardTitle.Size = new Size(1082, 73);
            labelDashboardTitle.TabIndex = 14;
            labelDashboardTitle.Text = "Record Summary";
            labelDashboardTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAsOf
            // 
            labelAsOf.AutoSize = true;
            labelAsOf.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAsOf.Location = new Point(428, 137);
            labelAsOf.Name = "labelAsOf";
            labelAsOf.Size = new Size(55, 20);
            labelAsOf.TabIndex = 12;
            labelAsOf.Text = "As of:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Controls.Add(panelAvailableFund, 0, 2);
            tableLayoutPanel1.Controls.Add(panelTotalMembers, 1, 1);
            tableLayoutPanel1.Controls.Add(panelCollectibleInterest, 0, 1);
            tableLayoutPanel1.Controls.Add(panelContributions, 1, 0);
            tableLayoutPanel1.Controls.Add(panelActiveLoan, 0, 0);
            tableLayoutPanel1.Location = new Point(185, 187);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(721, 530);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelPHP6);
            panel1.Controls.Add(labelTotalDividends);
            panel1.Controls.Add(outputTotalDividendsReleased);
            panel1.Location = new Point(363, 355);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 147);
            panel1.TabIndex = 7;
            // 
            // labelPHP6
            // 
            labelPHP6.BackColor = Color.Transparent;
            labelPHP6.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPHP6.Location = new Point(-1, 67);
            labelPHP6.Name = "labelPHP6";
            labelPHP6.Size = new Size(323, 28);
            labelPHP6.TabIndex = 2;
            labelPHP6.Text = "(PHP)";
            labelPHP6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalDividends
            // 
            labelTotalDividends.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTotalDividends.Location = new Point(0, 88);
            labelTotalDividends.Name = "labelTotalDividends";
            labelTotalDividends.Size = new Size(322, 34);
            labelTotalDividends.TabIndex = 1;
            labelTotalDividends.Text = "Total Dividends Distributed";
            labelTotalDividends.TextAlign = ContentAlignment.MiddleCenter;
            labelTotalDividends.Click += label2_Click_1;
            // 
            // outputTotalDividendsReleased
            // 
            outputTotalDividendsReleased.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputTotalDividendsReleased.ForeColor = Color.Red;
            outputTotalDividendsReleased.Location = new Point(0, -1);
            outputTotalDividendsReleased.Name = "outputTotalDividendsReleased";
            outputTotalDividendsReleased.Size = new Size(325, 100);
            outputTotalDividendsReleased.TabIndex = 0;
            outputTotalDividendsReleased.Text = "300.00";
            outputTotalDividendsReleased.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelAvailableFund
            // 
            panelAvailableFund.BorderStyle = BorderStyle.FixedSingle;
            panelAvailableFund.Controls.Add(labelPHP5);
            panelAvailableFund.Controls.Add(labelAvailableFund);
            panelAvailableFund.Controls.Add(outputAvailableFund);
            panelAvailableFund.Location = new Point(3, 355);
            panelAvailableFund.Name = "panelAvailableFund";
            panelAvailableFund.Size = new Size(321, 147);
            panelAvailableFund.TabIndex = 6;
            // 
            // labelPHP5
            // 
            labelPHP5.BackColor = Color.Transparent;
            labelPHP5.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPHP5.Location = new Point(-1, 67);
            labelPHP5.Name = "labelPHP5";
            labelPHP5.Size = new Size(323, 28);
            labelPHP5.TabIndex = 2;
            labelPHP5.Text = "(PHP)";
            labelPHP5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAvailableFund
            // 
            labelAvailableFund.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAvailableFund.Location = new Point(0, 88);
            labelAvailableFund.Name = "labelAvailableFund";
            labelAvailableFund.Size = new Size(322, 34);
            labelAvailableFund.TabIndex = 1;
            labelAvailableFund.Text = "Total Available Fund";
            labelAvailableFund.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // outputAvailableFund
            // 
            outputAvailableFund.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputAvailableFund.ForeColor = Color.Red;
            outputAvailableFund.Location = new Point(0, -1);
            outputAvailableFund.Name = "outputAvailableFund";
            outputAvailableFund.Size = new Size(325, 100);
            outputAvailableFund.TabIndex = 0;
            outputAvailableFund.Text = "800.00";
            outputAvailableFund.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTotalMembers
            // 
            panelTotalMembers.BorderStyle = BorderStyle.FixedSingle;
            panelTotalMembers.Controls.Add(labelTotalActiveMembers);
            panelTotalMembers.Controls.Add(outputTotalActiveMembers);
            panelTotalMembers.Location = new Point(363, 179);
            panelTotalMembers.Name = "panelTotalMembers";
            panelTotalMembers.Size = new Size(321, 147);
            panelTotalMembers.TabIndex = 6;
            // 
            // labelTotalActiveMembers
            // 
            labelTotalActiveMembers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTotalActiveMembers.Location = new Point(0, 88);
            labelTotalActiveMembers.Name = "labelTotalActiveMembers";
            labelTotalActiveMembers.Size = new Size(322, 34);
            labelTotalActiveMembers.TabIndex = 1;
            labelTotalActiveMembers.Text = "Total Active Members";
            labelTotalActiveMembers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // outputTotalActiveMembers
            // 
            outputTotalActiveMembers.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputTotalActiveMembers.ForeColor = Color.Red;
            outputTotalActiveMembers.Location = new Point(-1, -5);
            outputTotalActiveMembers.Name = "outputTotalActiveMembers";
            outputTotalActiveMembers.Size = new Size(325, 100);
            outputTotalActiveMembers.TabIndex = 0;
            outputTotalActiveMembers.Text = "20";
            outputTotalActiveMembers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCollectibleInterest
            // 
            panelCollectibleInterest.BorderStyle = BorderStyle.FixedSingle;
            panelCollectibleInterest.Controls.Add(labelPHP3);
            panelCollectibleInterest.Controls.Add(labelTotalCollectibleInterest);
            panelCollectibleInterest.Controls.Add(outputCollectibleInterest);
            panelCollectibleInterest.Location = new Point(3, 179);
            panelCollectibleInterest.Name = "panelCollectibleInterest";
            panelCollectibleInterest.Size = new Size(321, 147);
            panelCollectibleInterest.TabIndex = 5;
            // 
            // labelPHP3
            // 
            labelPHP3.BackColor = Color.Transparent;
            labelPHP3.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPHP3.Location = new Point(-1, 67);
            labelPHP3.Name = "labelPHP3";
            labelPHP3.Size = new Size(323, 28);
            labelPHP3.TabIndex = 2;
            labelPHP3.Text = "(PHP)";
            labelPHP3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalCollectibleInterest
            // 
            labelTotalCollectibleInterest.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTotalCollectibleInterest.Location = new Point(0, 88);
            labelTotalCollectibleInterest.Name = "labelTotalCollectibleInterest";
            labelTotalCollectibleInterest.Size = new Size(322, 34);
            labelTotalCollectibleInterest.TabIndex = 1;
            labelTotalCollectibleInterest.Text = "Total Collectible Interest";
            labelTotalCollectibleInterest.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // outputCollectibleInterest
            // 
            outputCollectibleInterest.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputCollectibleInterest.ForeColor = Color.Red;
            outputCollectibleInterest.Location = new Point(0, -1);
            outputCollectibleInterest.Name = "outputCollectibleInterest";
            outputCollectibleInterest.Size = new Size(325, 100);
            outputCollectibleInterest.TabIndex = 0;
            outputCollectibleInterest.Text = "500.00";
            outputCollectibleInterest.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContributions
            // 
            panelContributions.BorderStyle = BorderStyle.FixedSingle;
            panelContributions.Controls.Add(labelPHP2);
            panelContributions.Controls.Add(labelOutputTotalContributions);
            panelContributions.Controls.Add(labelTotalContributions);
            panelContributions.Location = new Point(363, 3);
            panelContributions.Name = "panelContributions";
            panelContributions.Size = new Size(321, 146);
            panelContributions.TabIndex = 5;
            // 
            // labelPHP2
            // 
            labelPHP2.BackColor = Color.Transparent;
            labelPHP2.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPHP2.Location = new Point(-1, 68);
            labelPHP2.Name = "labelPHP2";
            labelPHP2.Size = new Size(323, 28);
            labelPHP2.TabIndex = 2;
            labelPHP2.Text = "(PHP)";
            labelPHP2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOutputTotalContributions
            // 
            labelOutputTotalContributions.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOutputTotalContributions.ForeColor = Color.Red;
            labelOutputTotalContributions.Location = new Point(0, 0);
            labelOutputTotalContributions.Name = "labelOutputTotalContributions";
            labelOutputTotalContributions.Size = new Size(325, 96);
            labelOutputTotalContributions.TabIndex = 0;
            labelOutputTotalContributions.Text = "250.00";
            labelOutputTotalContributions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalContributions
            // 
            labelTotalContributions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTotalContributions.Location = new Point(0, 96);
            labelTotalContributions.Name = "labelTotalContributions";
            labelTotalContributions.Size = new Size(320, 34);
            labelTotalContributions.TabIndex = 1;
            labelTotalContributions.Text = "Total Contributions";
            labelTotalContributions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelActiveLoan
            // 
            panelActiveLoan.BorderStyle = BorderStyle.FixedSingle;
            panelActiveLoan.Controls.Add(labelPHP);
            panelActiveLoan.Controls.Add(labelTotalLoan);
            panelActiveLoan.Controls.Add(outputTotalLoan);
            panelActiveLoan.Location = new Point(3, 3);
            panelActiveLoan.Name = "panelActiveLoan";
            panelActiveLoan.Size = new Size(321, 147);
            panelActiveLoan.TabIndex = 4;
            // 
            // labelPHP
            // 
            labelPHP.BackColor = Color.Transparent;
            labelPHP.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPHP.Location = new Point(-1, 68);
            labelPHP.Name = "labelPHP";
            labelPHP.Size = new Size(323, 28);
            labelPHP.TabIndex = 2;
            labelPHP.Text = "(PHP)";
            labelPHP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalLoan
            // 
            labelTotalLoan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTotalLoan.Location = new Point(0, 96);
            labelTotalLoan.Name = "labelTotalLoan";
            labelTotalLoan.Size = new Size(322, 34);
            labelTotalLoan.TabIndex = 1;
            labelTotalLoan.Text = "Total Active Loan";
            labelTotalLoan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // outputTotalLoan
            // 
            outputTotalLoan.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputTotalLoan.ForeColor = Color.Red;
            outputTotalLoan.Location = new Point(0, -6);
            outputTotalLoan.Name = "outputTotalLoan";
            outputTotalLoan.Size = new Size(325, 100);
            outputTotalLoan.TabIndex = 0;
            outputTotalLoan.Text = "250.00";
            outputTotalLoan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPageFinance
            // 
            tabPageFinance.AutoScroll = true;
            tabPageFinance.BorderStyle = BorderStyle.Fixed3D;
            tabPageFinance.Controls.Add(tabFinance);
            tabPageFinance.Controls.Add(panelFinanceHead);
            tabPageFinance.Controls.Add(panel4);
            tabPageFinance.Location = new Point(4, 47);
            tabPageFinance.Name = "tabPageFinance";
            tabPageFinance.Padding = new Padding(3);
            tabPageFinance.Size = new Size(1100, 897);
            tabPageFinance.TabIndex = 1;
            tabPageFinance.Text = "Finance";
            tabPageFinance.UseVisualStyleBackColor = true;
            // 
            // tabFinance
            // 
            tabFinance.Appearance = TabAppearance.Buttons;
            tabFinance.Controls.Add(tabLoan);
            tabFinance.Controls.Add(tabPay);
            tabFinance.Controls.Add(tabContribute);
            tabFinance.Controls.Add(tabWithdraw);
            tabFinance.Controls.Add(tabSOA);
            tabFinance.Location = new Point(44, 324);
            tabFinance.Name = "tabFinance";
            tabFinance.SelectedIndex = 0;
            tabFinance.Size = new Size(1011, 891);
            tabFinance.TabIndex = 2;
            // 
            // tabLoan
            // 
            tabLoan.BackColor = Color.MediumAquamarine;
            tabLoan.BorderStyle = BorderStyle.Fixed3D;
            tabLoan.Controls.Add(btnPrintLoanVoucher);
            tabLoan.Controls.Add(panel5);
            tabLoan.Controls.Add(labelLoanVoucher);
            tabLoan.Controls.Add(btnCancelLoan);
            tabLoan.Controls.Add(btnConfirmLoan);
            tabLoan.Controls.Add(outputInterestRateLoan);
            tabLoan.Controls.Add(labelInterestRate);
            tabLoan.Controls.Add(labelLoanType);
            tabLoan.Controls.Add(inputLoanType);
            tabLoan.Controls.Add(outputMemberIDLoan);
            tabLoan.Controls.Add(label5);
            tabLoan.Controls.Add(label4);
            tabLoan.Controls.Add(textBox1);
            tabLoan.Controls.Add(btnValidate);
            tabLoan.Controls.Add(labelSuffix);
            tabLoan.Controls.Add(inputSuffixLoan);
            tabLoan.Controls.Add(labelLName);
            tabLoan.Controls.Add(inputLNameLoan);
            tabLoan.Controls.Add(labelMiddleName);
            tabLoan.Controls.Add(inputMNameLoan);
            tabLoan.Controls.Add(labelFName);
            tabLoan.Controls.Add(inputFNameLoan);
            tabLoan.Location = new Point(4, 43);
            tabLoan.Name = "tabLoan";
            tabLoan.Padding = new Padding(3);
            tabLoan.Size = new Size(1003, 844);
            tabLoan.TabIndex = 0;
            tabLoan.Text = "Loan";
            // 
            // btnPrintLoanVoucher
            // 
            btnPrintLoanVoucher.AutoSize = true;
            btnPrintLoanVoucher.Location = new Point(863, 482);
            btnPrintLoanVoucher.Name = "btnPrintLoanVoucher";
            btnPrintLoanVoucher.Size = new Size(103, 41);
            btnPrintLoanVoucher.TabIndex = 27;
            btnPrintLoanVoucher.Text = "Print";
            btnPrintLoanVoucher.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Window;
            panel5.Location = new Point(22, 536);
            panel5.Name = "panel5";
            panel5.Size = new Size(944, 261);
            panel5.TabIndex = 26;
            // 
            // labelLoanVoucher
            // 
            labelLoanVoucher.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLoanVoucher.ForeColor = SystemColors.ActiveCaptionText;
            labelLoanVoucher.Location = new Point(6, 476);
            labelLoanVoucher.Name = "labelLoanVoucher";
            labelLoanVoucher.Size = new Size(987, 46);
            labelLoanVoucher.TabIndex = 25;
            labelLoanVoucher.Text = "Loan Voucher";
            labelLoanVoucher.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelLoan
            // 
            btnCancelLoan.AutoSize = true;
            btnCancelLoan.BackColor = Color.IndianRed;
            btnCancelLoan.ForeColor = Color.Transparent;
            btnCancelLoan.Location = new Point(582, 344);
            btnCancelLoan.Name = "btnCancelLoan";
            btnCancelLoan.Size = new Size(164, 56);
            btnCancelLoan.TabIndex = 24;
            btnCancelLoan.Text = "Cancel";
            btnCancelLoan.UseVisualStyleBackColor = false;
            // 
            // btnConfirmLoan
            // 
            btnConfirmLoan.AutoSize = true;
            btnConfirmLoan.BackColor = Color.Goldenrod;
            btnConfirmLoan.ForeColor = Color.Transparent;
            btnConfirmLoan.Location = new Point(582, 282);
            btnConfirmLoan.Name = "btnConfirmLoan";
            btnConfirmLoan.Size = new Size(164, 56);
            btnConfirmLoan.TabIndex = 23;
            btnConfirmLoan.Text = "Confirm Loan";
            btnConfirmLoan.UseVisualStyleBackColor = false;
            // 
            // outputInterestRateLoan
            // 
            outputInterestRateLoan.Location = new Point(162, 390);
            outputInterestRateLoan.Name = "outputInterestRateLoan";
            outputInterestRateLoan.Size = new Size(210, 38);
            outputInterestRateLoan.TabIndex = 22;
            // 
            // labelInterestRate
            // 
            labelInterestRate.AutoSize = true;
            labelInterestRate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInterestRate.Location = new Point(13, 395);
            labelInterestRate.Name = "labelInterestRate";
            labelInterestRate.Size = new Size(125, 28);
            labelInterestRate.TabIndex = 21;
            labelInterestRate.Text = "Interest Rate:";
            // 
            // labelLoanType
            // 
            labelLoanType.AutoSize = true;
            labelLoanType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLoanType.Location = new Point(13, 337);
            labelLoanType.Name = "labelLoanType";
            labelLoanType.Size = new Size(104, 28);
            labelLoanType.TabIndex = 20;
            labelLoanType.Text = "Loan Type:";
            // 
            // inputLoanType
            // 
            inputLoanType.AutoCompleteCustomSource.AddRange(new string[] { "Flexi", "Installment", "Privileged" });
            inputLoanType.AutoCompleteMode = AutoCompleteMode.Suggest;
            inputLoanType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            inputLoanType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputLoanType.FormattingEnabled = true;
            inputLoanType.Location = new Point(162, 332);
            inputLoanType.Name = "inputLoanType";
            inputLoanType.Size = new Size(210, 36);
            inputLoanType.TabIndex = 19;
            // 
            // outputMemberIDLoan
            // 
            outputMemberIDLoan.AutoSize = true;
            outputMemberIDLoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputMemberIDLoan.Location = new Point(765, 103);
            outputMemberIDLoan.Name = "outputMemberIDLoan";
            outputMemberIDLoan.Size = new Size(143, 28);
            outputMemberIDLoan.TabIndex = 18;
            outputMemberIDLoan.Text = "Member ID: ___";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(6, 212);
            label5.Name = "label5";
            label5.Size = new Size(987, 46);
            label5.TabIndex = 15;
            label5.Text = "Loan Details";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 282);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 14;
            label4.Text = "Amount (PHP):";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(162, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 38);
            textBox1.TabIndex = 13;
            // 
            // btnValidate
            // 
            btnValidate.AutoSize = true;
            btnValidate.BackColor = Color.Teal;
            btnValidate.ForeColor = Color.Transparent;
            btnValidate.Location = new Point(583, 88);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(163, 56);
            btnValidate.TabIndex = 8;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = false;
            // 
            // labelSuffix
            // 
            labelSuffix.AutoSize = true;
            labelSuffix.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSuffix.Location = new Point(501, 38);
            labelSuffix.Name = "labelSuffix";
            labelSuffix.Size = new Size(69, 28);
            labelSuffix.TabIndex = 7;
            labelSuffix.Text = "Suffix :";
            // 
            // inputSuffixLoan
            // 
            inputSuffixLoan.Location = new Point(585, 33);
            inputSuffixLoan.Name = "inputSuffixLoan";
            inputSuffixLoan.Size = new Size(187, 38);
            inputSuffixLoan.TabIndex = 6;
            // 
            // labelLName
            // 
            labelLName.AutoSize = true;
            labelLName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLName.Location = new Point(13, 143);
            labelLName.Name = "labelLName";
            labelLName.Size = new Size(112, 28);
            labelLName.TabIndex = 5;
            labelLName.Text = "Last Name :";
            // 
            // inputLNameLoan
            // 
            inputLNameLoan.Location = new Point(157, 138);
            inputLNameLoan.Name = "inputLNameLoan";
            inputLNameLoan.Size = new Size(281, 38);
            inputLNameLoan.TabIndex = 4;
            // 
            // labelMiddleName
            // 
            labelMiddleName.AutoSize = true;
            labelMiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMiddleName.Location = new Point(13, 93);
            labelMiddleName.Name = "labelMiddleName";
            labelMiddleName.Size = new Size(140, 28);
            labelMiddleName.TabIndex = 3;
            labelMiddleName.Text = "Middle Name :";
            // 
            // inputMNameLoan
            // 
            inputMNameLoan.Location = new Point(157, 88);
            inputMNameLoan.Name = "inputMNameLoan";
            inputMNameLoan.Size = new Size(281, 38);
            inputMNameLoan.TabIndex = 2;
            // 
            // labelFName
            // 
            labelFName.AutoSize = true;
            labelFName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFName.Location = new Point(13, 38);
            labelFName.Name = "labelFName";
            labelFName.Size = new Size(115, 28);
            labelFName.TabIndex = 1;
            labelFName.Text = "First Name :";
            labelFName.Click += label4_Click;
            // 
            // inputFNameLoan
            // 
            inputFNameLoan.Location = new Point(157, 33);
            inputFNameLoan.Name = "inputFNameLoan";
            inputFNameLoan.Size = new Size(281, 38);
            inputFNameLoan.TabIndex = 0;
            // 
            // tabPay
            // 
            tabPay.BackColor = Color.MediumAquamarine;
            tabPay.Controls.Add(panel6);
            tabPay.Controls.Add(tableLayoutPanel2);
            tabPay.Controls.Add(label11);
            tabPay.Controls.Add(label6);
            tabPay.Controls.Add(button1);
            tabPay.Controls.Add(label7);
            tabPay.Controls.Add(textBox2);
            tabPay.Controls.Add(label8);
            tabPay.Controls.Add(textBox3);
            tabPay.Controls.Add(label9);
            tabPay.Controls.Add(textBox4);
            tabPay.Controls.Add(label10);
            tabPay.Controls.Add(textBox5);
            tabPay.ForeColor = SystemColors.ActiveCaptionText;
            tabPay.Location = new Point(4, 43);
            tabPay.Name = "tabPay";
            tabPay.Size = new Size(1003, 844);
            tabPay.TabIndex = 3;
            tabPay.Text = "Pay";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Honeydew;
            panel6.Controls.Add(button5);
            panel6.Controls.Add(button4);
            panel6.Controls.Add(button3);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(label22);
            panel6.Controls.Add(textBox6);
            panel6.Controls.Add(label21);
            panel6.Controls.Add(label20);
            panel6.Controls.Add(label19);
            panel6.Controls.Add(label18);
            panel6.Controls.Add(label17);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(label15);
            panel6.Controls.Add(label14);
            panel6.Location = new Point(464, 268);
            panel6.Name = "panel6";
            panel6.Size = new Size(461, 540);
            panel6.TabIndex = 31;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = Color.Goldenrod;
            button5.ForeColor = Color.Black;
            button5.Location = new Point(185, 412);
            button5.Name = "button5";
            button5.Size = new Size(173, 41);
            button5.TabIndex = 27;
            button5.Text = "Print Receipt";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(372, 480);
            button4.Name = "button4";
            button4.Size = new Size(81, 40);
            button4.TabIndex = 26;
            button4.Text = "Next";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(14, 480);
            button3.Name = "button3";
            button3.Size = new Size(81, 40);
            button3.TabIndex = 25;
            button3.Text = "Prev";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.LightGreen;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(185, 365);
            button2.Name = "button2";
            button2.Size = new Size(148, 41);
            button2.TabIndex = 24;
            button2.Text = "Pay";
            button2.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ActiveCaptionText;
            label22.Location = new Point(14, 315);
            label22.Name = "label22";
            label22.Size = new Size(165, 32);
            label22.TabIndex = 10;
            label22.Text = "Payment Amount";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Window;
            textBox6.Location = new Point(185, 312);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(241, 38);
            textBox6.TabIndex = 9;
            textBox6.Text = "PHP. 500.00";
            // 
            // label21
            // 
            label21.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.DarkRed;
            label21.Location = new Point(14, 246);
            label21.Name = "label21";
            label21.Size = new Size(183, 32);
            label21.TabIndex = 8;
            label21.Text = "Total Due:";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(14, 82);
            label20.Name = "label20";
            label20.Size = new Size(439, 32);
            label20.TabIndex = 2;
            label20.Text = "Loan Details";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.ActiveCaptionText;
            label19.Location = new Point(243, 183);
            label19.Name = "label19";
            label19.Size = new Size(183, 32);
            label19.TabIndex = 7;
            label19.Text = "Interest:";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ActiveCaptionText;
            label18.Location = new Point(243, 120);
            label18.Name = "label18";
            label18.Size = new Size(183, 32);
            label18.TabIndex = 6;
            label18.Text = "Interest Rate:";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(14, 183);
            label17.Name = "label17";
            label17.Size = new Size(101, 32);
            label17.TabIndex = 5;
            label17.Text = "Balance:";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(14, 120);
            label16.Name = "label16";
            label16.Size = new Size(183, 32);
            label16.TabIndex = 4;
            label16.Text = "Principal Amount:";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(14, 38);
            label15.Name = "label15";
            label15.Size = new Size(111, 32);
            label15.TabIndex = 3;
            label15.Text = "Loan Type:";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(14, 10);
            label14.Name = "label14";
            label14.Size = new Size(163, 32);
            label14.TabIndex = 2;
            label14.Text = "Loan ID:";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.1812859F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.8187141F));
            tableLayoutPanel2.Controls.Add(label24, 1, 1);
            tableLayoutPanel2.Controls.Add(label23, 0, 1);
            tableLayoutPanel2.Controls.Add(label13, 1, 0);
            tableLayoutPanel2.Controls.Add(label12, 0, 0);
            tableLayoutPanel2.Location = new Point(57, 270);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(342, 107);
            tableLayoutPanel2.TabIndex = 30;
            // 
            // label24
            // 
            label24.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.ActiveCaptionText;
            label24.Location = new Point(137, 35);
            label24.Name = "label24";
            label24.Size = new Size(202, 32);
            label24.TabIndex = 3;
            label24.Text = "2024-01-01";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = SystemColors.ActiveCaptionText;
            label23.Location = new Point(3, 35);
            label23.Name = "label23";
            label23.Size = new Size(128, 32);
            label23.TabIndex = 2;
            label23.Text = "456513";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(137, 0);
            label13.Name = "label13";
            label13.Size = new Size(202, 32);
            label13.TabIndex = 1;
            label13.Text = "Loan Datetime";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(128, 32);
            label12.TabIndex = 0;
            label12.Text = "Loan ID";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(3, 204);
            label11.Name = "label11";
            label11.Size = new Size(976, 46);
            label11.TabIndex = 29;
            label11.Text = "Active Loans";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(774, 94);
            label6.Name = "label6";
            label6.Size = new Size(143, 28);
            label6.TabIndex = 28;
            label6.Text = "Member ID: ___";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Teal;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(592, 79);
            button1.Name = "button1";
            button1.Size = new Size(163, 56);
            button1.TabIndex = 27;
            button1.Text = "Validate";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(510, 29);
            label7.Name = "label7";
            label7.Size = new Size(69, 28);
            label7.TabIndex = 26;
            label7.Text = "Suffix :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(594, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 38);
            textBox2.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 134);
            label8.Name = "label8";
            label8.Size = new Size(112, 28);
            label8.TabIndex = 24;
            label8.Text = "Last Name :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(281, 38);
            textBox3.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 84);
            label9.Name = "label9";
            label9.Size = new Size(140, 28);
            label9.TabIndex = 22;
            label9.Text = "Middle Name :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(166, 79);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(281, 38);
            textBox4.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(22, 29);
            label10.Name = "label10";
            label10.Size = new Size(115, 28);
            label10.TabIndex = 20;
            label10.Text = "First Name :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(166, 24);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(281, 38);
            textBox5.TabIndex = 19;
            // 
            // tabContribute
            // 
            tabContribute.BackColor = Color.MediumAquamarine;
            tabContribute.Location = new Point(4, 43);
            tabContribute.Name = "tabContribute";
            tabContribute.Padding = new Padding(3);
            tabContribute.Size = new Size(1003, 844);
            tabContribute.TabIndex = 1;
            tabContribute.Text = "Contribute";
            // 
            // tabWithdraw
            // 
            tabWithdraw.BackColor = Color.MediumAquamarine;
            tabWithdraw.Location = new Point(4, 43);
            tabWithdraw.Name = "tabWithdraw";
            tabWithdraw.Size = new Size(1003, 844);
            tabWithdraw.TabIndex = 2;
            tabWithdraw.Text = "Withdraw";
            // 
            // tabSOA
            // 
            tabSOA.BackColor = Color.MediumAquamarine;
            tabSOA.Location = new Point(4, 43);
            tabSOA.Name = "tabSOA";
            tabSOA.Size = new Size(1003, 844);
            tabSOA.TabIndex = 4;
            tabSOA.Text = "Statement of Account";
            // 
            // panelFinanceHead
            // 
            panelFinanceHead.Controls.Add(labelFinanceTitle);
            panelFinanceHead.Controls.Add(panel3);
            panelFinanceHead.Controls.Add(panel2);
            panelFinanceHead.Controls.Add(panelAvailableFundFinance);
            panelFinanceHead.Location = new Point(3, 6);
            panelFinanceHead.Name = "panelFinanceHead";
            panelFinanceHead.Size = new Size(1093, 282);
            panelFinanceHead.TabIndex = 1;
            // 
            // labelFinanceTitle
            // 
            labelFinanceTitle.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFinanceTitle.Location = new Point(2, 16);
            labelFinanceTitle.Name = "labelFinanceTitle";
            labelFinanceTitle.Size = new Size(1088, 73);
            labelFinanceTitle.TabIndex = 2;
            labelFinanceTitle.Text = "MMC Finance";
            labelFinanceTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(731, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 147);
            panel3.TabIndex = 9;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, 67);
            label1.Name = "label1";
            label1.Size = new Size(323, 28);
            label1.TabIndex = 2;
            label1.Text = "(PHP)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 88);
            label2.Name = "label2";
            label2.Size = new Size(322, 34);
            label2.TabIndex = 1;
            label2.Text = "Total Amount of Active Loans";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(0, -1);
            label3.Name = "label3";
            label3.Size = new Size(325, 100);
            label3.TabIndex = 0;
            label3.Text = "800.00";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelPHPFinance);
            panel2.Controls.Add(labelTotalActiveLoans);
            panel2.Controls.Add(outputTotalAmountofActiveLoans);
            panel2.Location = new Point(385, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 147);
            panel2.TabIndex = 8;
            // 
            // labelPHPFinance
            // 
            labelPHPFinance.BackColor = Color.Transparent;
            labelPHPFinance.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPHPFinance.Location = new Point(-1, 67);
            labelPHPFinance.Name = "labelPHPFinance";
            labelPHPFinance.Size = new Size(323, 28);
            labelPHPFinance.TabIndex = 2;
            labelPHPFinance.Text = "(PHP)";
            labelPHPFinance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalActiveLoans
            // 
            labelTotalActiveLoans.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTotalActiveLoans.Location = new Point(0, 88);
            labelTotalActiveLoans.Name = "labelTotalActiveLoans";
            labelTotalActiveLoans.Size = new Size(322, 34);
            labelTotalActiveLoans.TabIndex = 1;
            labelTotalActiveLoans.Text = "Total Amount of Active Loans";
            labelTotalActiveLoans.TextAlign = ContentAlignment.MiddleCenter;
            labelTotalActiveLoans.Click += label5_Click;
            // 
            // outputTotalAmountofActiveLoans
            // 
            outputTotalAmountofActiveLoans.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputTotalAmountofActiveLoans.ForeColor = Color.Red;
            outputTotalAmountofActiveLoans.Location = new Point(0, -1);
            outputTotalAmountofActiveLoans.Name = "outputTotalAmountofActiveLoans";
            outputTotalAmountofActiveLoans.Size = new Size(325, 100);
            outputTotalAmountofActiveLoans.TabIndex = 0;
            outputTotalAmountofActiveLoans.Text = "800.00";
            outputTotalAmountofActiveLoans.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelAvailableFundFinance
            // 
            panelAvailableFundFinance.BorderStyle = BorderStyle.FixedSingle;
            panelAvailableFundFinance.Controls.Add(labelPHPFinance1);
            panelAvailableFundFinance.Controls.Add(labelTotalAvailableFundFinance);
            panelAvailableFundFinance.Controls.Add(outputAvailableFundFinance);
            panelAvailableFundFinance.Location = new Point(43, 102);
            panelAvailableFundFinance.Name = "panelAvailableFundFinance";
            panelAvailableFundFinance.Size = new Size(321, 147);
            panelAvailableFundFinance.TabIndex = 7;
            // 
            // labelPHPFinance1
            // 
            labelPHPFinance1.BackColor = Color.Transparent;
            labelPHPFinance1.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPHPFinance1.Location = new Point(-1, 67);
            labelPHPFinance1.Name = "labelPHPFinance1";
            labelPHPFinance1.Size = new Size(323, 28);
            labelPHPFinance1.TabIndex = 2;
            labelPHPFinance1.Text = "(PHP)";
            labelPHPFinance1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalAvailableFundFinance
            // 
            labelTotalAvailableFundFinance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTotalAvailableFundFinance.Location = new Point(0, 88);
            labelTotalAvailableFundFinance.Name = "labelTotalAvailableFundFinance";
            labelTotalAvailableFundFinance.Size = new Size(322, 34);
            labelTotalAvailableFundFinance.TabIndex = 1;
            labelTotalAvailableFundFinance.Text = "Total Available Fund";
            labelTotalAvailableFundFinance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // outputAvailableFundFinance
            // 
            outputAvailableFundFinance.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputAvailableFundFinance.ForeColor = Color.Red;
            outputAvailableFundFinance.Location = new Point(0, -1);
            outputAvailableFundFinance.Name = "outputAvailableFundFinance";
            outputAvailableFundFinance.Size = new Size(325, 100);
            outputAvailableFundFinance.TabIndex = 0;
            outputAvailableFundFinance.Text = "800.00";
            outputAvailableFundFinance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.Location = new Point(9, 315);
            panel4.Name = "panel4";
            panel4.Size = new Size(1081, 938);
            panel4.TabIndex = 3;
            // 
            // tabPageMembers
            // 
            tabPageMembers.Location = new Point(4, 47);
            tabPageMembers.Name = "tabPageMembers";
            tabPageMembers.Padding = new Padding(3);
            tabPageMembers.Size = new Size(1100, 897);
            tabPageMembers.TabIndex = 2;
            tabPageMembers.Text = "Members";
            tabPageMembers.UseVisualStyleBackColor = true;
            // 
            // tabPageSystemSettings
            // 
            tabPageSystemSettings.Location = new Point(4, 47);
            tabPageSystemSettings.Name = "tabPageSystemSettings";
            tabPageSystemSettings.Size = new Size(1100, 897);
            tabPageSystemSettings.TabIndex = 3;
            tabPageSystemSettings.Text = "System Settings";
            tabPageSystemSettings.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 953);
            Controls.Add(tabMainApp);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MMC System";
            tabMainApp.ResumeLayout(false);
            tabPageDashboard.ResumeLayout(false);
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            tableWeekDues.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelAvailableFund.ResumeLayout(false);
            panelTotalMembers.ResumeLayout(false);
            panelCollectibleInterest.ResumeLayout(false);
            panelContributions.ResumeLayout(false);
            panelActiveLoan.ResumeLayout(false);
            tabPageFinance.ResumeLayout(false);
            tabFinance.ResumeLayout(false);
            tabLoan.ResumeLayout(false);
            tabLoan.PerformLayout();
            tabPay.ResumeLayout(false);
            tabPay.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panelFinanceHead.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panelAvailableFundFinance.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMainApp;
        private TabPage tabPageDashboard;
        private TabPage tabPageFinance;
        private Panel panelDashboard;
        private Label outputDatetime;
        private Label labelDashboardTitle;
        private Label labelAsOf;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelTotalMembers;
        private Label labelTotalActiveMembers;
        private Label outputTotalActiveMembers;
        private Panel panelCollectibleInterest;
        private Label labelPHP3;
        private Label labelTotalCollectibleInterest;
        private Label outputCollectibleInterest;
        private Panel panelContributions;
        private Label labelPHP2;
        private Label labelOutputTotalContributions;
        private Label labelTotalContributions;
        private Panel panelActiveLoan;
        private Label labelPHP;
        private Label labelTotalLoan;
        private Label outputTotalLoan;
        private TabPage tabPageMembers;
        private TabPage tabPageSystemSettings;
        private TableLayoutPanel tableWeekDues;
        private Label labelStatus;
        private Label labelDueDate;
        private Label labelAmountDue;
        private Label labelLoanAmount;
        private Label labelMemberName;
        private Label labelLoanID;
        private Label outputWeekDuesTo;
        private Label labelTo;
        private Label outputWeeklyDuesFrom;
        private Label labelFrom;
        private Label labelWeeklyDues;
        private Panel panelAvailableFund;
        private Label labelPHP5;
        private Label labelAvailableFund;
        private Label outputAvailableFund;
        private Panel panel1;
        private Label labelPHP6;
        private Label labelTotalDividends;
        private Label outputTotalDividendsReleased;
        private Panel panelFinanceHead;
        private Panel panelAvailableFundFinance;
        private Label labelPHPFinance1;
        private Label labelTotalAvailableFundFinance;
        private Label outputAvailableFundFinance;
        private Panel panel2;
        private Label labelPHPFinance;
        private Label labelTotalActiveLoans;
        private Label outputTotalAmountofActiveLoans;
        private Label labelFinanceTitle;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TabControl tabFinance;
        private TabPage tabLoan;
        private TabPage tabContribute;
        private TabPage tabWithdraw;
        private TabPage tabPay;
        private TabPage tabSOA;
        private Label labelFName;
        private TextBox inputFNameLoan;
        private Panel panel4;
        private Button btnValidate;
        private Label labelSuffix;
        private TextBox inputSuffixLoan;
        private Label labelLName;
        private TextBox inputLNameLoan;
        private Label labelMiddleName;
        private TextBox inputMNameLoan;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private Label labelLoanType;
        private ComboBox inputLoanType;
        private Label outputMemberIDLoan;
        private TextBox outputInterestRateLoan;
        private Label labelInterestRate;
        private Button btnConfirmLoan;
        private Label labelLoanVoucher;
        private Button btnCancelLoan;
        private Panel panel5;
        private Button btnPrintLoanVoucher;
        private Label label11;
        private Label label6;
        private Button button1;
        private Label label7;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox4;
        private Label label10;
        private TextBox textBox5;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private Label label13;
        private Label label12;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label22;
        private TextBox textBox6;
        private Label label21;
        private Label label20;
        private Label label19;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label24;
        private Label label23;
    }
}