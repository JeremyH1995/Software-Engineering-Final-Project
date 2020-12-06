
namespace cs325_coreproject
{
    partial class frmEmployeeLogin
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(181, 91);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEID
            // 
            this.txtEID.Location = new System.Drawing.Point(181, 63);
            this.txtEID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEID.Name = "txtEID";
            this.txtEID.Size = new System.Drawing.Size(100, 22);
            this.txtEID.TabIndex = 5;
            this.txtEID.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "EID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(181, 124);
            this.Submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(100, 28);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 167);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEmployeeLogin";
            this.Text = "EmployeeLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit;
    }
}