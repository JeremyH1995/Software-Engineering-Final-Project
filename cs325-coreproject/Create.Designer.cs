
namespace cs325_coreproject
{
    partial class frmCreate
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
            this.btnClient = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(46, 75);
            this.btnClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(111, 71);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(181, 75);
            this.btnManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(111, 71);
            this.btnManager.TabIndex = 1;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(272, 193);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // frmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 228);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnClient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCreate";
            this.Text = "Create";
            this.Load += new System.EventHandler(this.frmCreate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnBack;
    }
}