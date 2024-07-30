namespace SteamApiSchnitstelle
{
    partial class FsStartpage
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbtcontent = new System.Windows.Forms.RichTextBox();
            this.btnGoRight = new System.Windows.Forms.Button();
            this.btnGoLeft = new System.Windows.Forms.Button();
            this.lblGameName = new System.Windows.Forms.Label();
            this.btnOpenSettings = new System.Windows.Forms.Button();
            this.lblPlayerCount = new System.Windows.Forms.Label();
            this.btnYourGames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(544, 41);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(61, 68);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 1;
            this.lblDatum.Text = "Datum";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(61, 96);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // rbtcontent
            // 
            this.rbtcontent.Location = new System.Drawing.Point(67, 142);
            this.rbtcontent.Name = "rbtcontent";
            this.rbtcontent.Size = new System.Drawing.Size(460, 238);
            this.rbtcontent.TabIndex = 3;
            this.rbtcontent.Text = "";
            // 
            // btnGoRight
            // 
            this.btnGoRight.Location = new System.Drawing.Point(506, 386);
            this.btnGoRight.Name = "btnGoRight";
            this.btnGoRight.Size = new System.Drawing.Size(21, 23);
            this.btnGoRight.TabIndex = 4;
            this.btnGoRight.Text = ">";
            this.btnGoRight.UseVisualStyleBackColor = true;
            this.btnGoRight.Click += new System.EventHandler(this.btnGoRight_Click);
            // 
            // btnGoLeft
            // 
            this.btnGoLeft.Location = new System.Drawing.Point(67, 386);
            this.btnGoLeft.Name = "btnGoLeft";
            this.btnGoLeft.Size = new System.Drawing.Size(27, 23);
            this.btnGoLeft.TabIndex = 5;
            this.btnGoLeft.Text = "<";
            this.btnGoLeft.UseVisualStyleBackColor = true;
            this.btnGoLeft.Click += new System.EventHandler(this.btnGoLeft_Click);
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(61, 24);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(63, 13);
            this.lblGameName.TabIndex = 6;
            this.lblGameName.Text = "GameName";
            // 
            // btnOpenSettings
            // 
            this.btnOpenSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOpenSettings.Location = new System.Drawing.Point(544, 12);
            this.btnOpenSettings.Name = "btnOpenSettings";
            this.btnOpenSettings.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSettings.TabIndex = 7;
            this.btnOpenSettings.Text = "Settings";
            this.btnOpenSettings.UseVisualStyleBackColor = true;
            this.btnOpenSettings.Click += new System.EventHandler(this.btnOpenSettings_Click);
            // 
            // lblPlayerCount
            // 
            this.lblPlayerCount.AutoSize = true;
            this.lblPlayerCount.Location = new System.Drawing.Point(61, 126);
            this.lblPlayerCount.Name = "lblPlayerCount";
            this.lblPlayerCount.Size = new System.Drawing.Size(63, 13);
            this.lblPlayerCount.TabIndex = 8;
            this.lblPlayerCount.Text = "Playercount";
            // 
            // btnYourGames
            // 
            this.btnYourGames.Location = new System.Drawing.Point(544, 71);
            this.btnYourGames.Name = "btnYourGames";
            this.btnYourGames.Size = new System.Drawing.Size(75, 23);
            this.btnYourGames.TabIndex = 9;
            this.btnYourGames.Text = "Your Games";
            this.btnYourGames.UseVisualStyleBackColor = true;
            this.btnYourGames.Click += new System.EventHandler(this.btnYourGames_Click);
            // 
            // FsStartpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 570);
            this.Controls.Add(this.btnYourGames);
            this.Controls.Add(this.lblPlayerCount);
            this.Controls.Add(this.btnOpenSettings);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.btnGoLeft);
            this.Controls.Add(this.btnGoRight);
            this.Controls.Add(this.rbtcontent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.btnRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FsStartpage";
            this.Text = "GameChecker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox rbtcontent;
        private System.Windows.Forms.Button btnGoRight;
        private System.Windows.Forms.Button btnGoLeft;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Button btnOpenSettings;
        private System.Windows.Forms.Label lblPlayerCount;
        private System.Windows.Forms.Button btnYourGames;
    }
}

