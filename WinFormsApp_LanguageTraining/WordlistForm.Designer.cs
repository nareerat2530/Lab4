namespace WinFormsApp_LanguageTraining
{
    partial class WordlistForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddWordbutton = new System.Windows.Forms.Button();
            this.Removebutton = new System.Windows.Forms.Button();
            this.Practicebutton = new System.Windows.Forms.Button();
            this.NewListbutton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.Listlabel = new System.Windows.Forms.Label();
            this.WorddataGridView = new System.Windows.Forms.DataGridView();
            this.WordCountlabel = new System.Windows.Forms.Label();
            this.WorldCounttextBox = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WorddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddWordbutton
            // 
            this.AddWordbutton.Location = new System.Drawing.Point(327, 400);
            this.AddWordbutton.Name = "AddWordbutton";
            this.AddWordbutton.Size = new System.Drawing.Size(80, 23);
            this.AddWordbutton.TabIndex = 0;
            this.AddWordbutton.Text = "Add word";
            this.AddWordbutton.UseVisualStyleBackColor = true;
            this.AddWordbutton.Click += new System.EventHandler(this.AddWordbutton_Click);
            // 
            // Removebutton
            // 
            this.Removebutton.Location = new System.Drawing.Point(413, 401);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(75, 23);
            this.Removebutton.TabIndex = 1;
            this.Removebutton.Text = "Remove word";
            this.Removebutton.UseVisualStyleBackColor = true;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // Practicebutton
            // 
            this.Practicebutton.Location = new System.Drawing.Point(494, 401);
            this.Practicebutton.Name = "Practicebutton";
            this.Practicebutton.Size = new System.Drawing.Size(75, 23);
            this.Practicebutton.TabIndex = 2;
            this.Practicebutton.Text = "Practice";
            this.Practicebutton.UseVisualStyleBackColor = true;
            this.Practicebutton.Click += new System.EventHandler(this.Practicebutton_Click);
            // 
            // NewListbutton
            // 
            this.NewListbutton.Location = new System.Drawing.Point(230, 401);
            this.NewListbutton.Name = "NewListbutton";
            this.NewListbutton.Size = new System.Drawing.Size(91, 23);
            this.NewListbutton.TabIndex = 3;
            this.NewListbutton.Text = "Add new list";
            this.NewListbutton.UseVisualStyleBackColor = true;
            this.NewListbutton.Click += new System.EventHandler(this.NewListbutton_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(12, 102);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(146, 229);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // Listlabel
            // 
            this.Listlabel.AutoSize = true;
            this.Listlabel.Location = new System.Drawing.Point(12, 59);
            this.Listlabel.Name = "Listlabel";
            this.Listlabel.Size = new System.Drawing.Size(33, 15);
            this.Listlabel.TabIndex = 5;
            this.Listlabel.Text = "Lists:";
            // 
            // WorddataGridView
            // 
            this.WorddataGridView.AllowUserToAddRows = false;
            this.WorddataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WorddataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.WorddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorddataGridView.Location = new System.Drawing.Point(230, 102);
            this.WorddataGridView.Name = "WorddataGridView";
            this.WorddataGridView.RowHeadersVisible = false;
            this.WorddataGridView.RowTemplate.Height = 25;
            this.WorddataGridView.Size = new System.Drawing.Size(512, 280);
            this.WorddataGridView.TabIndex = 6;
            // 
            // WordCountlabel
            // 
            this.WordCountlabel.AutoSize = true;
            this.WordCountlabel.Location = new System.Drawing.Point(570, 71);
            this.WordCountlabel.Name = "WordCountlabel";
            this.WordCountlabel.Size = new System.Drawing.Size(71, 15);
            this.WordCountlabel.TabIndex = 7;
            this.WordCountlabel.Text = "word count:";
            // 
            // WorldCounttextBox
            // 
            this.WorldCounttextBox.Location = new System.Drawing.Point(661, 63);
            this.WorldCounttextBox.Name = "WorldCounttextBox";
            this.WorldCounttextBox.Size = new System.Drawing.Size(81, 23);
            this.WorldCounttextBox.TabIndex = 8;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(575, 401);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 9;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(667, 401);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // WordlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.WorldCounttextBox);
            this.Controls.Add(this.WordCountlabel);
            this.Controls.Add(this.WorddataGridView);
            this.Controls.Add(this.Listlabel);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.NewListbutton);
            this.Controls.Add(this.Practicebutton);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.AddWordbutton);
            this.Name = "WordlistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language training";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorddataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddWordbutton;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.Button Practicebutton;
        private System.Windows.Forms.Button NewListbutton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label Listlabel;
        private System.Windows.Forms.DataGridView WorddataGridView;
        private System.Windows.Forms.Label WordCountlabel;
        private System.Windows.Forms.TextBox WorldCounttextBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button ExitButton;
    }
}