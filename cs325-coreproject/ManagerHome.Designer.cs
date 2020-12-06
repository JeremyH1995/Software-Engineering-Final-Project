
namespace cs325_coreproject
{
    partial class ManagerHome
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
            this.Logout = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.EmpListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(12, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(233, 209);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(109, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add Employee";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button3_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(233, 238);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(109, 23);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit Employee";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.button4_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(233, 267);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(109, 23);
            this.Remove.TabIndex = 4;
            this.Remove.Text = "Remove Employee";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // EmpListBox
            // 
            this.EmpListBox.FormattingEnabled = true;
            this.EmpListBox.Location = new System.Drawing.Point(233, 108);
            this.EmpListBox.Name = "EmpListBox";
            this.EmpListBox.Size = new System.Drawing.Size(109, 95);
            this.EmpListBox.TabIndex = 5;
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmpListBox);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Logout);
            this.Name = "ManagerHome";
            this.Text = "ManagerHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.ListBox EmpListBox;
    }
}