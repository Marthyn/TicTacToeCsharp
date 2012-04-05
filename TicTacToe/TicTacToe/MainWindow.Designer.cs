namespace TicTacToe
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gameSettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.veld0 = new System.Windows.Forms.Button();
            this.veld1 = new System.Windows.Forms.Button();
            this.veld2 = new System.Windows.Forms.Button();
            this.veld3 = new System.Windows.Forms.Button();
            this.veld4 = new System.Windows.Forms.Button();
            this.veld5 = new System.Windows.Forms.Button();
            this.veld6 = new System.Windows.Forms.Button();
            this.veld7 = new System.Windows.Forms.Button();
            this.veld8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.p1namelbl = new System.Windows.Forms.Label();
            this.p2namelbl = new System.Windows.Forms.Label();
            this.p1wins = new System.Windows.Forms.Label();
            this.p2wins = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.p1ties = new System.Windows.Forms.Label();
            this.p1losses = new System.Windows.Forms.Label();
            this.p2ties = new System.Windows.Forms.Label();
            this.p2losses = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentplayerlbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.OptionsMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGame);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameSettingsMenu});
            this.OptionsMenu.Name = "OptionsMenu";
            this.OptionsMenu.Size = new System.Drawing.Size(61, 20);
            this.OptionsMenu.Text = "Options";
            // 
            // gameSettingsMenu
            // 
            this.gameSettingsMenu.Name = "gameSettingsMenu";
            this.gameSettingsMenu.Size = new System.Drawing.Size(150, 22);
            this.gameSettingsMenu.Text = "Game Settings";
            this.gameSettingsMenu.Click += new System.EventHandler(this.gameSettingsMenu_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayMenu,
            this.AboutMenu});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpMenu.Text = "Help";
            // 
            // howToPlayMenu
            // 
            this.howToPlayMenu.Name = "howToPlayMenu";
            this.howToPlayMenu.Size = new System.Drawing.Size(138, 22);
            this.howToPlayMenu.Text = "How to play";
            this.howToPlayMenu.Click += new System.EventHandler(this.howToPlayMenu_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(138, 22);
            this.AboutMenu.Text = "About";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // veld0
            // 
            this.veld0.Location = new System.Drawing.Point(13, 28);
            this.veld0.Name = "veld0";
            this.veld0.Size = new System.Drawing.Size(81, 75);
            this.veld0.TabIndex = 1;
            this.veld0.Text = "-";
            this.veld0.UseVisualStyleBackColor = true;
            this.veld0.Click += new System.EventHandler(this.play);
            // 
            // veld1
            // 
            this.veld1.Location = new System.Drawing.Point(100, 28);
            this.veld1.Name = "veld1";
            this.veld1.Size = new System.Drawing.Size(81, 75);
            this.veld1.TabIndex = 2;
            this.veld1.Text = "-";
            this.veld1.UseVisualStyleBackColor = true;
            this.veld1.Click += new System.EventHandler(this.play);
            // 
            // veld2
            // 
            this.veld2.Location = new System.Drawing.Point(187, 28);
            this.veld2.Name = "veld2";
            this.veld2.Size = new System.Drawing.Size(81, 75);
            this.veld2.TabIndex = 3;
            this.veld2.Text = "-";
            this.veld2.UseVisualStyleBackColor = true;
            this.veld2.Click += new System.EventHandler(this.play);
            // 
            // veld3
            // 
            this.veld3.Location = new System.Drawing.Point(13, 109);
            this.veld3.Name = "veld3";
            this.veld3.Size = new System.Drawing.Size(81, 75);
            this.veld3.TabIndex = 4;
            this.veld3.Text = "-";
            this.veld3.UseVisualStyleBackColor = true;
            this.veld3.Click += new System.EventHandler(this.play);
            // 
            // veld4
            // 
            this.veld4.Location = new System.Drawing.Point(100, 109);
            this.veld4.Name = "veld4";
            this.veld4.Size = new System.Drawing.Size(81, 75);
            this.veld4.TabIndex = 5;
            this.veld4.Text = "-";
            this.veld4.UseVisualStyleBackColor = true;
            this.veld4.Click += new System.EventHandler(this.play);
            // 
            // veld5
            // 
            this.veld5.Location = new System.Drawing.Point(187, 109);
            this.veld5.Name = "veld5";
            this.veld5.Size = new System.Drawing.Size(81, 75);
            this.veld5.TabIndex = 6;
            this.veld5.Text = "-";
            this.veld5.UseVisualStyleBackColor = true;
            this.veld5.Click += new System.EventHandler(this.play);
            // 
            // veld6
            // 
            this.veld6.Location = new System.Drawing.Point(13, 190);
            this.veld6.Name = "veld6";
            this.veld6.Size = new System.Drawing.Size(81, 75);
            this.veld6.TabIndex = 7;
            this.veld6.Text = "-";
            this.veld6.UseVisualStyleBackColor = true;
            this.veld6.Click += new System.EventHandler(this.play);
            // 
            // veld7
            // 
            this.veld7.Location = new System.Drawing.Point(100, 190);
            this.veld7.Name = "veld7";
            this.veld7.Size = new System.Drawing.Size(81, 75);
            this.veld7.TabIndex = 8;
            this.veld7.Text = "-";
            this.veld7.UseVisualStyleBackColor = true;
            this.veld7.Click += new System.EventHandler(this.play);
            // 
            // veld8
            // 
            this.veld8.Location = new System.Drawing.Point(187, 190);
            this.veld8.Name = "veld8";
            this.veld8.Size = new System.Drawing.Size(81, 75);
            this.veld8.TabIndex = 9;
            this.veld8.Text = "-";
            this.veld8.UseVisualStyleBackColor = true;
            this.veld8.Click += new System.EventHandler(this.play);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Results";
            // 
            // p1namelbl
            // 
            this.p1namelbl.AutoSize = true;
            this.p1namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1namelbl.Location = new System.Drawing.Point(290, 67);
            this.p1namelbl.Name = "p1namelbl";
            this.p1namelbl.Size = new System.Drawing.Size(11, 13);
            this.p1namelbl.TabIndex = 11;
            this.p1namelbl.Text = "-";
            // 
            // p2namelbl
            // 
            this.p2namelbl.AutoSize = true;
            this.p2namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2namelbl.Location = new System.Drawing.Point(419, 67);
            this.p2namelbl.Name = "p2namelbl";
            this.p2namelbl.Size = new System.Drawing.Size(11, 13);
            this.p2namelbl.TabIndex = 12;
            this.p2namelbl.Text = "-";
            // 
            // p1wins
            // 
            this.p1wins.AutoSize = true;
            this.p1wins.Location = new System.Drawing.Point(336, 80);
            this.p1wins.Name = "p1wins";
            this.p1wins.Size = new System.Drawing.Size(16, 13);
            this.p1wins.TabIndex = 13;
            this.p1wins.Text = "0 ";
            // 
            // p2wins
            // 
            this.p2wins.AutoSize = true;
            this.p2wins.Location = new System.Drawing.Point(477, 80);
            this.p2wins.Name = "p2wins";
            this.p2wins.Size = new System.Drawing.Size(13, 13);
            this.p2wins.TabIndex = 14;
            this.p2wins.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Wins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Wins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ties";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ties";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Losses";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Losses";
            // 
            // p1ties
            // 
            this.p1ties.AutoSize = true;
            this.p1ties.Location = new System.Drawing.Point(336, 93);
            this.p1ties.Name = "p1ties";
            this.p1ties.Size = new System.Drawing.Size(13, 13);
            this.p1ties.TabIndex = 21;
            this.p1ties.Text = "0";
            // 
            // p1losses
            // 
            this.p1losses.AutoSize = true;
            this.p1losses.Location = new System.Drawing.Point(336, 106);
            this.p1losses.Name = "p1losses";
            this.p1losses.Size = new System.Drawing.Size(13, 13);
            this.p1losses.TabIndex = 22;
            this.p1losses.Text = "0";
            // 
            // p2ties
            // 
            this.p2ties.AutoSize = true;
            this.p2ties.Location = new System.Drawing.Point(477, 93);
            this.p2ties.Name = "p2ties";
            this.p2ties.Size = new System.Drawing.Size(13, 13);
            this.p2ties.TabIndex = 23;
            this.p2ties.Text = "0";
            // 
            // p2losses
            // 
            this.p2losses.AutoSize = true;
            this.p2losses.Location = new System.Drawing.Point(477, 106);
            this.p2losses.Name = "p2losses";
            this.p2losses.Size = new System.Drawing.Size(13, 13);
            this.p2losses.TabIndex = 24;
            this.p2losses.Text = "0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.currentplayerlbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 274);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(565, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel1.Text = "Current Player:";
            // 
            // currentplayerlbl
            // 
            this.currentplayerlbl.Name = "currentplayerlbl";
            this.currentplayerlbl.Size = new System.Drawing.Size(12, 17);
            this.currentplayerlbl.Text = "-";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 296);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.p2losses);
            this.Controls.Add(this.p2ties);
            this.Controls.Add(this.p1losses);
            this.Controls.Add(this.p1ties);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p2wins);
            this.Controls.Add(this.p1wins);
            this.Controls.Add(this.p2namelbl);
            this.Controls.Add(this.p1namelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.veld8);
            this.Controls.Add(this.veld7);
            this.Controls.Add(this.veld6);
            this.Controls.Add(this.veld5);
            this.Controls.Add(this.veld4);
            this.Controls.Add(this.veld3);
            this.Controls.Add(this.veld2);
            this.Controls.Add(this.veld1);
            this.Controls.Add(this.veld0);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem howToPlayMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button veld0;
        private System.Windows.Forms.Button veld1;
        private System.Windows.Forms.Button veld2;
        private System.Windows.Forms.Button veld3;
        private System.Windows.Forms.Button veld4;
        private System.Windows.Forms.Button veld5;
        private System.Windows.Forms.Button veld6;
        private System.Windows.Forms.Button veld7;
        private System.Windows.Forms.Button veld8;
        private System.Windows.Forms.ToolStripMenuItem gameSettingsMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label p1namelbl;
        private System.Windows.Forms.Label p2namelbl;
        private System.Windows.Forms.Label p1wins;
        private System.Windows.Forms.Label p2wins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label p1ties;
        private System.Windows.Forms.Label p1losses;
        private System.Windows.Forms.Label p2ties;
        private System.Windows.Forms.Label p2losses;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel currentplayerlbl;
    }
}

