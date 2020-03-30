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
            this.SuspendLayout();
            // 
            // SearchTextLbl
            // 
            this.SearchTextLbl.AutoSize = true;
            this.SearchTextLbl.Location = new System.Drawing.Point(18, 20);
            this.SearchTextLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchTextLbl.Name = "SearchTextLbl";
            this.SearchTextLbl.Size = new System.Drawing.Size(74, 13);
            this.SearchTextLbl.TabIndex = 0;
            this.SearchTextLbl.Text = "Szukany tekst";
            // 
            // ReplaceToLbl
            // 
            this.ReplaceToLbl.AutoSize = true;
            this.ReplaceToLbl.Location = new System.Drawing.Point(18, 79);
            this.ReplaceToLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReplaceToLbl.Name = "ReplaceToLbl";
            this.ReplaceToLbl.Size = new System.Drawing.Size(57, 13);
            this.ReplaceToLbl.TabIndex = 1;
            this.ReplaceToLbl.Text = "Zamień na";
            // 
            // SearchTextTB
            // 
            this.SearchTextTB.Location = new System.Drawing.Point(21, 47);
            this.SearchTextTB.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTextTB.Name = "SearchTextTB";
            this.SearchTextTB.Size = new System.Drawing.Size(553, 20);
            this.SearchTextTB.TabIndex = 2;
            // 
            // ReplaceToTB
            // 
            this.ReplaceToTB.Location = new System.Drawing.Point(21, 106);
            this.ReplaceToTB.Margin = new System.Windows.Forms.Padding(2);
            this.ReplaceToTB.Name = "ReplaceToTB";
            this.ReplaceToTB.Size = new System.Drawing.Size(553, 20);
            this.ReplaceToTB.TabIndex = 3;
            // 
            // PathTB
            // 
            this.PathTB.Enabled = false;
            this.PathTB.Location = new System.Drawing.Point(19, 263);
            this.PathTB.Margin = new System.Windows.Forms.Padding(2);
            this.PathTB.Name = "PathTB";
            this.PathTB.Size = new System.Drawing.Size(555, 20);
            this.PathTB.TabIndex = 5;
            // 
            // WithoutPathRB
            // 
            this.WithoutPathRB.AutoSize = true;
            this.WithoutPathRB.Checked = true;
            this.WithoutPathRB.Location = new System.Drawing.Point(21, 185);
            this.WithoutPathRB.Margin = new System.Windows.Forms.Padding(2);
            this.WithoutPathRB.Name = "WithoutPathRB";
            this.WithoutPathRB.Size = new System.Drawing.Size(129, 17);
            this.WithoutPathRB.TabIndex = 6;
            this.WithoutPathRB.TabStop = true;
            this.WithoutPathRB.Text = "W folderze z aplikacją";
            this.WithoutPathRB.UseVisualStyleBackColor = true;
            this.WithoutPathRB.CheckedChanged += new System.EventHandler(this.WithoutPathRB_CheckedChanged);
            // 
            // WithPathRB
            // 
            this.WithPathRB.AutoSize = true;
            this.WithPathRB.Location = new System.Drawing.Point(21, 227);
            this.WithPathRB.Margin = new System.Windows.Forms.Padding(2);
            this.WithPathRB.Name = "WithPathRB";
            this.WithPathRB.Size = new System.Drawing.Size(97, 17);
            this.WithPathRB.TabIndex = 7;
            this.WithPathRB.Text = "Wskaż ścieżkę";
            this.WithPathRB.UseVisualStyleBackColor = true;
            this.WithPathRB.CheckedChanged += new System.EventHandler(this.WithPathRB_CheckedChanged);
            // 
            // ReplaceBtn
            // 
            this.ReplaceBtn.Location = new System.Drawing.Point(21, 309);
            this.ReplaceBtn.Name = "ReplaceBtn";
            this.ReplaceBtn.Size = new System.Drawing.Size(103, 32);
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
            this.AllDirectoriesTB.Location = new System.Drawing.Point(21, 145);
            this.AllDirectoriesTB.Name = "AllDirectoriesTB";
            this.AllDirectoriesTB.Size = new System.Drawing.Size(96, 17);
            this.AllDirectoriesTB.TabIndex = 9;
            this.AllDirectoriesTB.Text = "Z podfolderami";
            this.AllDirectoriesTB.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.AllDirectoriesTB);
            this.Controls.Add(this.ReplaceBtn);
            this.Controls.Add(this.WithPathRB);
            this.Controls.Add(this.WithoutPathRB);
            this.Controls.Add(this.PathTB);
            this.Controls.Add(this.ReplaceToTB);
            this.Controls.Add(this.SearchTextTB);
            this.Controls.Add(this.ReplaceToLbl);
            this.Controls.Add(this.SearchTextLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}

