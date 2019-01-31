namespace ListViewController
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.listViewMail = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.getNameOfItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.getEmailAddressOfTheSelectedUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getTheAgeOfSelectedUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsOfTheUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name : ";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(660, 66);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 15);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-Mail : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 63);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(500, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(151, 111);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(500, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(715, 62);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(140, 23);
            this.txtAge.TabIndex = 2;
            // 
            // listViewMail
            // 
            this.listViewMail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewMail.ContextMenuStrip = this.contextMenuStripListView;
            this.listViewMail.FullRowSelect = true;
            this.listViewMail.GridLines = true;
            this.listViewMail.Location = new System.Drawing.Point(30, 155);
            this.listViewMail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewMail.MultiSelect = false;
            this.listViewMail.Name = "listViewMail";
            this.listViewMail.Size = new System.Drawing.Size(900, 307);
            this.listViewMail.TabIndex = 3;
            this.listViewMail.UseCompatibleStateImageBehavior = false;
            this.listViewMail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 456;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Age";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E-Mail";
            this.columnHeader3.Width = 345;
            // 
            // contextMenuStripListView
            // 
            this.contextMenuStripListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getNameOfItemToolStripMenuItem,
            this.getEmailAddressOfTheSelectedUserToolStripMenuItem,
            this.getTheAgeOfSelectedUserToolStripMenuItem,
            this.detailsOfTheUserToolStripMenuItem});
            this.contextMenuStripListView.Name = "contextMenuStripListView";
            this.contextMenuStripListView.Size = new System.Drawing.Size(277, 114);
            // 
            // getNameOfItemToolStripMenuItem
            // 
            this.getNameOfItemToolStripMenuItem.Name = "getNameOfItemToolStripMenuItem";
            this.getNameOfItemToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.getNameOfItemToolStripMenuItem.Text = "Get Name Of Item";
            this.getNameOfItemToolStripMenuItem.Click += new System.EventHandler(this.getNameOfItemToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(673, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // getEmailAddressOfTheSelectedUserToolStripMenuItem
            // 
            this.getEmailAddressOfTheSelectedUserToolStripMenuItem.Name = "getEmailAddressOfTheSelectedUserToolStripMenuItem";
            this.getEmailAddressOfTheSelectedUserToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.getEmailAddressOfTheSelectedUserToolStripMenuItem.Text = "Get Email Address of the Selected User";
            this.getEmailAddressOfTheSelectedUserToolStripMenuItem.Click += new System.EventHandler(this.getEmailAddressOfTheSelectedUserToolStripMenuItem_Click);
            // 
            // getTheAgeOfSelectedUserToolStripMenuItem
            // 
            this.getTheAgeOfSelectedUserToolStripMenuItem.Name = "getTheAgeOfSelectedUserToolStripMenuItem";
            this.getTheAgeOfSelectedUserToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.getTheAgeOfSelectedUserToolStripMenuItem.Text = "Get the Age Of Selected User";
            this.getTheAgeOfSelectedUserToolStripMenuItem.Click += new System.EventHandler(this.getTheAgeOfSelectedUserToolStripMenuItem_Click);
            // 
            // detailsOfTheUserToolStripMenuItem
            // 
            this.detailsOfTheUserToolStripMenuItem.Name = "detailsOfTheUserToolStripMenuItem";
            this.detailsOfTheUserToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.detailsOfTheUserToolStripMenuItem.Text = "Details Of The User";
            this.detailsOfTheUserToolStripMenuItem.Click += new System.EventHandler(this.detailsOfTheUserToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 477);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listViewMail);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "ListView Control";
            this.contextMenuStripListView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ListView listViewMail;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListView;
        private System.Windows.Forms.ToolStripMenuItem getNameOfItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getEmailAddressOfTheSelectedUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getTheAgeOfSelectedUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsOfTheUserToolStripMenuItem;
    }
}

