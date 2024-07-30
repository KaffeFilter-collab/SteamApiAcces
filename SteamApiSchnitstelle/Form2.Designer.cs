namespace SteamApiSchnitstelle
{
    partial class fmSettings
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
            this.lblappid = new System.Windows.Forms.Label();
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.btnSafe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblappid
            // 
            this.lblappid.AutoSize = true;
            this.lblappid.Location = new System.Drawing.Point(27, 56);
            this.lblappid.Name = "lblappid";
            this.lblappid.Size = new System.Drawing.Size(40, 13);
            this.lblappid.TabIndex = 0;
            this.lblappid.Text = "App ID";
            // 
            // txtAppId
            // 
            this.txtAppId.Location = new System.Drawing.Point(102, 56);
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.Size = new System.Drawing.Size(175, 20);
            this.txtAppId.TabIndex = 1;
            this.txtAppId.TextChanged += new System.EventHandler(this.txtAppId_TextChanged);
            // 
            // btnSafe
            // 
            this.btnSafe.Location = new System.Drawing.Point(283, 121);
            this.btnSafe.Name = "btnSafe";
            this.btnSafe.Size = new System.Drawing.Size(75, 23);
            this.btnSafe.TabIndex = 2;
            this.btnSafe.Text = "Safe";
            this.btnSafe.UseVisualStyleBackColor = true;
            this.btnSafe.Click += new System.EventHandler(this.btnSafe_Click);
            // 
            // fmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 156);
            this.Controls.Add(this.btnSafe);
            this.Controls.Add(this.txtAppId);
            this.Controls.Add(this.lblappid);
            this.Name = "fmSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblappid;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.Button btnSafe;
    }
}