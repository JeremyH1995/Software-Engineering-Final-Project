
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
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(61, 92);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(148, 87);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(241, 92);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(148, 87);
            this.btnManager.TabIndex = 1;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // frmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 281);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnClient);
            this.Name = "frmCreate";
            this.Text = "Create";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnManager;
    }
}