namespace CtrlHForFilenames
{
    partial class MainForm
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
            this.SearchTextLbl = new System.Windows.Forms.Label();
            this.ReplaceToLbl = new System.Windows.Forms.Label();
            this.SearchTextTB = new System.Windows.Forms.TextBox();
            this.ReplaceToTB = new System.Windows.Forms.TextBox();
            this.PathTB = new System.Windows.Forms.TextBox();
            this.WithoutPathRB = new System.Windows.Forms.RadioButton();
            this.WithPathRB = new System.Windows.Forms.RadioButton();
            this.ReplaceBtn = new System.Windows.Forms.Button();
            this.AllDirectoriesTB = new System.Windows.Forms.CheckBox();
            this.SelectDirectoryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchTextLbl
            // 
            this.SearchTextLbl.AutoSize = true;
            this.SearchTextLbl.Location = new System.Drawing.Point(24, 25);
            this.SearchTextLbl.Name = "SearchTextLbl";
            this.SearchTextLbl.Size = new System.Drawing.Size(96, 17);
            this.SearchTextLbl.TabIndex = 0;
            this.SearchTextLbl.Text = "Szukany tekst";
            // 
            // ReplaceToLbl
            // 
            this.ReplaceToLbl.AutoSize = true;
            this.ReplaceToLbl.Location = new System.Drawing.Point(24, 97);
            this.ReplaceToLbl.Name = "ReplaceToLbl";
            this.ReplaceToLbl.Size = new System.Drawing.Size(75, 17);
            this.ReplaceToLbl.TabIndex = 1;
            this.ReplaceToLbl.Text = "Zamień na";
            // 
            // SearchTextTB
            // 
            this.SearchTextTB.Location = new System.Drawing.Point(28, 58);
            this.SearchTextTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTextTB.Name = "SearchTextTB";
            this.SearchTextTB.Size = new System.Drawing.Size(736, 22);
            this.SearchTextTB.TabIndex = 2;
            // 
            // ReplaceToTB
            // 
            this.ReplaceToTB.Location = new System.Drawing.Point(28, 130);
            this.ReplaceToTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReplaceToTB.Name = "ReplaceToTB";
            this.ReplaceToTB.Size = new System.Drawing.Size(736, 22);
            this.ReplaceToTB.TabIndex = 3;
            // 
            // PathTB
            // 
            this.PathTB.Enabled = false;
            this.PathTB.Location = new System.Drawing.Point(25, 324);
            this.PathTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PathTB.Name = "PathTB";
            this.PathTB.Size = new System.Drawing.Size(739, 22);
            this.PathTB.TabIndex = 5;
            // 
            // WithoutPathRB
            // 
            this.WithoutPathRB.AutoSize = true;
            this.WithoutPathRB.Checked = true;
            this.WithoutPathRB.Location = new System.Drawing.Point(28, 228);
            this.WithoutPathRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WithoutPathRB.Name = "WithoutPathRB";
            this.WithoutPathRB.Size = new System.Drawing.Size(167, 21);
            this.WithoutPathRB.TabIndex = 6;
            this.WithoutPathRB.TabStop = true;
            this.WithoutPathRB.Text = "W folderze z aplikacją";
            this.WithoutPathRB.UseVisualStyleBackColor = true;
            this.WithoutPathRB.CheckedChanged += new System.EventHandler(this.WithoutPathRB_CheckedChanged);
            // 
            // WithPathRB
            // 
            this.WithPathRB.AutoSize = true;
            this.WithPathRB.Location = new System.Drawing.Point(28, 279);
            this.WithPathRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WithPathRB.Name = "WithPathRB";
            this.WithPathRB.Size = new System.Drawing.Size(122, 21);
            this.WithPathRB.TabIndex = 7;
            this.WithPathRB.Text = "Wskaż ścieżkę";
            this.WithPathRB.UseVisualStyleBackColor = true;
            this.WithPathRB.CheckedChanged += new System.EventHandler(this.WithPathRB_CheckedChanged);
            // 
            // ReplaceBtn
            // 
            this.ReplaceBtn.Location = new System.Drawing.Point(28, 380);
            this.ReplaceBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReplaceBtn.Name = "ReplaceBtn";
            this.ReplaceBtn.Size = new System.Drawing.Size(137, 39);
            this.ReplaceBtn.TabIndex = 8;
            this.ReplaceBtn.Text = "Zamień";
            this.ReplaceBtn.UseVisualStyleBackColor = true;
            this.ReplaceBtn.Click += new System.EventHandler(this.ReplaceBtn_Click);
            // 
            // AllDirectoriesTB
            // 
            this.AllDirectoriesTB.AutoSize = true;
            this.AllDirectoriesTB.Checked = true;
            this.AllDirectoriesTB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllDirectoriesTB.Location = new System.Drawing.Point(28, 178);
            this.AllDirectoriesTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AllDirectoriesTB.Name = "AllDirectoriesTB";
            this.AllDirectoriesTB.Size = new System.Drawing.Size(125, 21);
            this.AllDirectoriesTB.TabIndex = 9;
            this.AllDirectoriesTB.Text = "Z podfolderami";
            this.AllDirectoriesTB.UseVisualStyleBackColor = true;
            // 
            // SelectDirectoryBtn
            // 
            this.SelectDirectoryBtn.Enabled = false;
            this.SelectDirectoryBtn.Location = new System.Drawing.Point(199, 273);
            this.SelectDirectoryBtn.Name = "SelectDirectoryBtn";
            this.SelectDirectoryBtn.Size = new System.Drawing.Size(141, 33);
            this.SelectDirectoryBtn.TabIndex = 10;
            this.SelectDirectoryBtn.Text = "Wybierz folder";
            this.SelectDirectoryBtn.UseVisualStyleBackColor = true;
            this.SelectDirectoryBtn.Click += new System.EventHandler(this.SelectDirectoryBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectDirectoryBtn);
            this.Controls.Add(this.AllDirectoriesTB);
            this.Controls.Add(this.ReplaceBtn);
            this.Controls.Add(this.WithPathRB);
            this.Controls.Add(this.WithoutPathRB);
            this.Controls.Add(this.PathTB);
            this.Controls.Add(this.ReplaceToTB);
            this.Controls.Add(this.SearchTextTB);
            this.Controls.Add(this.ReplaceToLbl);
            this.Controls.Add(this.SearchTextLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ctrl+H dla nazw plików";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchTextLbl;
        private System.Windows.Forms.Label ReplaceToLbl;
        private System.Windows.Forms.TextBox SearchTextTB;
        private System.Windows.Forms.TextBox ReplaceToTB;
        private System.Windows.Forms.TextBox PathTB;
        private System.Windows.Forms.RadioButton WithoutPathRB;
        private System.Windows.Forms.RadioButton WithPathRB;
        private System.Windows.Forms.Button ReplaceBtn;
        private System.Windows.Forms.CheckBox AllDirectoriesTB;
        private System.Windows.Forms.Button SelectDirectoryBtn;
    }
}

