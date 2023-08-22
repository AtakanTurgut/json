namespace FormsApp
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
            this.gbNewRegister = new System.Windows.Forms.GroupBox();
            this.btnNewRegister = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtWebsiteAddress = new System.Windows.Forms.TextBox();
            this.lblWebsiteAddress = new System.Windows.Forms.Label();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbNewRegister.SuspendLayout();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNewRegister
            // 
            this.gbNewRegister.Controls.Add(this.btnRefresh);
            this.gbNewRegister.Controls.Add(this.btnNewRegister);
            this.gbNewRegister.Controls.Add(this.txtDescription);
            this.gbNewRegister.Controls.Add(this.lblDescription);
            this.gbNewRegister.Controls.Add(this.txtPassword);
            this.gbNewRegister.Controls.Add(this.lblPassword);
            this.gbNewRegister.Controls.Add(this.txtUserName);
            this.gbNewRegister.Controls.Add(this.lblUserName);
            this.gbNewRegister.Controls.Add(this.txtWebsiteAddress);
            this.gbNewRegister.Controls.Add(this.lblWebsiteAddress);
            this.gbNewRegister.Location = new System.Drawing.Point(12, 12);
            this.gbNewRegister.Name = "gbNewRegister";
            this.gbNewRegister.Size = new System.Drawing.Size(267, 310);
            this.gbNewRegister.TabIndex = 0;
            this.gbNewRegister.TabStop = false;
            this.gbNewRegister.Text = "New Registration";
            // 
            // btnNewRegister
            // 
            this.btnNewRegister.Location = new System.Drawing.Point(9, 281);
            this.btnNewRegister.Name = "btnNewRegister";
            this.btnNewRegister.Size = new System.Drawing.Size(171, 23);
            this.btnNewRegister.TabIndex = 4;
            this.btnNewRegister.Text = "Add New Register";
            this.btnNewRegister.UseVisualStyleBackColor = true;
            this.btnNewRegister.Click += new System.EventHandler(this.btnNewRegister_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(9, 192);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(252, 84);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 173);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(9, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 121);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(9, 88);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(252, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 69);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(76, 16);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // txtWebsiteAddress
            // 
            this.txtWebsiteAddress.Location = new System.Drawing.Point(9, 37);
            this.txtWebsiteAddress.Name = "txtWebsiteAddress";
            this.txtWebsiteAddress.Size = new System.Drawing.Size(252, 22);
            this.txtWebsiteAddress.TabIndex = 0;
            // 
            // lblWebsiteAddress
            // 
            this.lblWebsiteAddress.AutoSize = true;
            this.lblWebsiteAddress.Location = new System.Drawing.Point(6, 18);
            this.lblWebsiteAddress.Name = "lblWebsiteAddress";
            this.lblWebsiteAddress.Size = new System.Drawing.Size(111, 16);
            this.lblWebsiteAddress.TabIndex = 0;
            this.lblWebsiteAddress.Text = "Website Address";
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.grdList);
            this.gbList.Location = new System.Drawing.Point(298, 12);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(706, 310);
            this.gbList.TabIndex = 1;
            this.gbList.TabStop = false;
            this.gbList.Text = "Registration List";
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdList.Location = new System.Drawing.Point(3, 18);
            this.grdList.Name = "grdList";
            this.grdList.ReadOnly = true;
            this.grdList.RowHeadersWidth = 51;
            this.grdList.RowTemplate.Height = 24;
            this.grdList.Size = new System.Drawing.Size(700, 289);
            this.grdList.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(186, 281);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 336);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.gbNewRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passwords";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbNewRegister.ResumeLayout(false);
            this.gbNewRegister.PerformLayout();
            this.gbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewRegister;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtWebsiteAddress;
        private System.Windows.Forms.Label lblWebsiteAddress;
        private System.Windows.Forms.Button btnNewRegister;
        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.Button btnRefresh;
    }
}

