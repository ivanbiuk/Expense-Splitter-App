
namespace ExpenseSplitter
{
    partial class CreateListPopup
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
            this.lblListName = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.listNameTextBox = new System.Windows.Forms.TextBox();
            this.lblMembers = new System.Windows.Forms.Label();
            this.lblAddMember = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.newMemberTextBox = new System.Windows.Forms.TextBox();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.createListButton = new System.Windows.Forms.Button();
            this.membersListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblListName
            // 
            this.lblListName.AutoSize = true;
            this.lblListName.Location = new System.Drawing.Point(180, 98);
            this.lblListName.Name = "lblListName";
            this.lblListName.Size = new System.Drawing.Size(73, 17);
            this.lblListName.TabIndex = 0;
            this.lblListName.Text = "List name:";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(180, 134);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(69, 17);
            this.lblCurrency.TabIndex = 1;
            this.lblCurrency.Text = "Currency:";
            // 
            // listNameTextBox
            // 
            this.listNameTextBox.Location = new System.Drawing.Point(260, 98);
            this.listNameTextBox.Name = "listNameTextBox";
            this.listNameTextBox.Size = new System.Drawing.Size(213, 22);
            this.listNameTextBox.TabIndex = 2;
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Location = new System.Drawing.Point(541, 114);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(70, 17);
            this.lblMembers.TabIndex = 5;
            this.lblMembers.Text = "Members:";
            // 
            // lblAddMember
            // 
            this.lblAddMember.AutoSize = true;
            this.lblAddMember.Location = new System.Drawing.Point(180, 210);
            this.lblAddMember.Name = "lblAddMember";
            this.lblAddMember.Size = new System.Drawing.Size(90, 17);
            this.lblAddMember.TabIndex = 7;
            this.lblAddMember.Text = "New Member";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(180, 241);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(49, 17);
            this.lblMemberName.TabIndex = 8;
            this.lblMemberName.Text = "Name:";
            // 
            // newMemberTextBox
            // 
            this.newMemberTextBox.Location = new System.Drawing.Point(260, 238);
            this.newMemberTextBox.Name = "newMemberTextBox";
            this.newMemberTextBox.Size = new System.Drawing.Size(180, 22);
            this.newMemberTextBox.TabIndex = 9;
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.Location = new System.Drawing.Point(288, 266);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(120, 23);
            this.buttonAddMember.TabIndex = 10;
            this.buttonAddMember.Text = "Add member";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP",
            "AUD",
            "HRK"});
            this.currencyComboBox.Location = new System.Drawing.Point(260, 131);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(121, 24);
            this.currencyComboBox.TabIndex = 11;
            // 
            // createListButton
            // 
            this.createListButton.Location = new System.Drawing.Point(300, 376);
            this.createListButton.Name = "createListButton";
            this.createListButton.Size = new System.Drawing.Size(173, 36);
            this.createListButton.TabIndex = 12;
            this.createListButton.Text = "Create List";
            this.createListButton.UseVisualStyleBackColor = true;
            this.createListButton.Click += new System.EventHandler(this.createListButton_Click);
            // 
            // membersListView
            // 
            this.membersListView.HideSelection = false;
            this.membersListView.Location = new System.Drawing.Point(544, 144);
            this.membersListView.Name = "membersListView";
            this.membersListView.Size = new System.Drawing.Size(187, 145);
            this.membersListView.TabIndex = 13;
            this.membersListView.UseCompatibleStateImageBehavior = false;
            this.membersListView.View = System.Windows.Forms.View.List;
            // 
            // CreateListPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.membersListView);
            this.Controls.Add(this.createListButton);
            this.Controls.Add(this.currencyComboBox);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.newMemberTextBox);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.lblAddMember);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.listNameTextBox);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblListName);
            this.Name = "CreateListPopup";
            this.Text = "CreateListPopup";
            this.Load += new System.EventHandler(this.CreateListPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListName;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox listNameTextBox;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Label lblAddMember;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox newMemberTextBox;
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.Button createListButton;
        private System.Windows.Forms.ListView membersListView;
    }
}