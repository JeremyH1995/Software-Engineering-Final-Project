namespace cs325_coreproject
{
    partial class frmCreateEmp
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
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.PrimaryContact = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.PaswordLabel = new System.Windows.Forms.Label();
            this.ddlRole = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(128, 62);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(100, 20);
            this.txtLast.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Last Name: ";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(128, 36);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "First Name: ";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(128, 114);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(100, 20);
            this.txtConfirm.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Confirm Password: ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(128, 167);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 36);
            this.btnSubmit.TabIndex = 27;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // PrimaryContact
            // 
            this.PrimaryContact.AutoSize = true;
            this.PrimaryContact.Location = new System.Drawing.Point(43, 143);
            this.PrimaryContact.Name = "PrimaryContact";
            this.PrimaryContact.Size = new System.Drawing.Size(79, 13);
            this.PrimaryContact.TabIndex = 26;
            this.PrimaryContact.Text = "Employee role: ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(128, 88);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 20;
            // 
            // PaswordLabel
            // 
            this.PaswordLabel.AutoSize = true;
            this.PaswordLabel.Location = new System.Drawing.Point(64, 91);
            this.PaswordLabel.Name = "PaswordLabel";
            this.PaswordLabel.Size = new System.Drawing.Size(59, 13);
            this.PaswordLabel.TabIndex = 19;
            this.PaswordLabel.Text = "Password: ";
            // 
            // ddlRole
            // 
            this.ddlRole.FormattingEnabled = true;
            this.ddlRole.Items.AddRange(new object[] {
            "Logistics",
            "Secretary"});
            this.ddlRole.Location = new System.Drawing.Point(128, 140);
            this.ddlRole.Name = "ddlRole";
            this.ddlRole.Size = new System.Drawing.Size(100, 21);
            this.ddlRole.TabIndex = 34;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 167);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // frmCreateEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 232);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ddlRole);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.PrimaryContact);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.PaswordLabel);
            this.Name = "frmCreateEmp";
            this.Text = "Create Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label PrimaryContact;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label PaswordLabel;
        private System.Windows.Forms.ComboBox ddlRole;
        private System.Windows.Forms.Button btnBack;
    }
}