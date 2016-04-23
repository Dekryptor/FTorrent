namespace FTorrent
{
    partial class addTorrent
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
            this.label1 = new System.Windows.Forms.Label();
            this.torrentPathTxt = new System.Windows.Forms.TextBox();
            this.savePathTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browseOutPathBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.browseTorrentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Torrent:";
            // 
            // torrentPathTxt
            // 
            this.torrentPathTxt.Location = new System.Drawing.Point(78, 10);
            this.torrentPathTxt.Name = "torrentPathTxt";
            this.torrentPathTxt.ReadOnly = true;
            this.torrentPathTxt.Size = new System.Drawing.Size(262, 20);
            this.torrentPathTxt.TabIndex = 1;
            // 
            // savePathTxt
            // 
            this.savePathTxt.Location = new System.Drawing.Point(78, 37);
            this.savePathTxt.Name = "savePathTxt";
            this.savePathTxt.Size = new System.Drawing.Size(262, 20);
            this.savePathTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Save path:";
            // 
            // browseOutPathBtn
            // 
            this.browseOutPathBtn.Location = new System.Drawing.Point(346, 35);
            this.browseOutPathBtn.Name = "browseOutPathBtn";
            this.browseOutPathBtn.Size = new System.Drawing.Size(35, 23);
            this.browseOutPathBtn.TabIndex = 4;
            this.browseOutPathBtn.Text = "...";
            this.browseOutPathBtn.UseVisualStyleBackColor = true;
            this.browseOutPathBtn.Click += new System.EventHandler(this.browseOutPathBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(16, 63);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(365, 45);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // browseTorrentBtn
            // 
            this.browseTorrentBtn.Location = new System.Drawing.Point(347, 10);
            this.browseTorrentBtn.Name = "browseTorrentBtn";
            this.browseTorrentBtn.Size = new System.Drawing.Size(34, 23);
            this.browseTorrentBtn.TabIndex = 6;
            this.browseTorrentBtn.Text = "...";
            this.browseTorrentBtn.UseVisualStyleBackColor = true;
            this.browseTorrentBtn.Click += new System.EventHandler(this.browseTorrentBtn_Click);
            // 
            // addTorrent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 117);
            this.Controls.Add(this.browseTorrentBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.browseOutPathBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.savePathTxt);
            this.Controls.Add(this.torrentPathTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addTorrent";
            this.ShowInTaskbar = false;
            this.Text = "Add torrent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox torrentPathTxt;
        private System.Windows.Forms.TextBox savePathTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseOutPathBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button browseTorrentBtn;
    }
}