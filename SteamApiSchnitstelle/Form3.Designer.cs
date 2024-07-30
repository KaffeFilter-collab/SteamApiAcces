namespace SteamApiSchnitstelle
{
    partial class fmGameList
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
            this.rtbListOfGames = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbListOfGames
            // 
            this.rtbListOfGames.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.rtbListOfGames.BackColor = System.Drawing.SystemColors.Window;
            this.rtbListOfGames.CausesValidation = false;
            this.rtbListOfGames.Location = new System.Drawing.Point(-7, -2);
            this.rtbListOfGames.Name = "rtbListOfGames";
            this.rtbListOfGames.ReadOnly = true;
            this.rtbListOfGames.Size = new System.Drawing.Size(818, 456);
            this.rtbListOfGames.TabIndex = 0;
            this.rtbListOfGames.Text = "";
            // 
            // fmGameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbListOfGames);
            this.Name = "fmGameList";
            this.Text = "List of your games";
            this.ResumeLayout(false);

        }
         System.Windows.Forms.RichTextBox rtbListOfGames;

        #endregion
    }
}