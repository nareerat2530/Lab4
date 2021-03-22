
namespace WinFormsApp_LanguageTraining
{
    partial class NewListForm
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
            this.Titellabel = new System.Windows.Forms.Label();
            this.NewlisttextBox = new System.Windows.Forms.TextBox();
            this.Languagelabel = new System.Windows.Forms.Label();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Okbutton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titellabel
            // 
            this.Titellabel.AutoSize = true;
            this.Titellabel.Location = new System.Drawing.Point(12, 21);
            this.Titellabel.Name = "Titellabel";
            this.Titellabel.Size = new System.Drawing.Size(29, 15);
            this.Titellabel.TabIndex = 0;
            this.Titellabel.Text = "Title";
            // 
            // NewlisttextBox
            // 
            this.NewlisttextBox.Location = new System.Drawing.Point(13, 54);
            this.NewlisttextBox.Name = "NewlisttextBox";
            this.NewlisttextBox.Size = new System.Drawing.Size(181, 23);
            this.NewlisttextBox.TabIndex = 1;
            this.NewlisttextBox.TextChanged += new System.EventHandler(this.NewlistTextBox_TextChanged);
            // 
            // Languagelabel
            // 
            this.Languagelabel.AutoSize = true;
            this.Languagelabel.Location = new System.Drawing.Point(13, 95);
            this.Languagelabel.Name = "Languagelabel";
            this.Languagelabel.Size = new System.Drawing.Size(67, 15);
            this.Languagelabel.TabIndex = 2;
            this.Languagelabel.Text = "Languages:";
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(13, 293);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 4;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(119, 293);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(75, 23);
            this.Okbutton.TabIndex = 5;
            this.Okbutton.Text = "OK";
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 113);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 174);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Language1\r\nLanguage2";
            // 
            // NewListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 328);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Languagelabel);
            this.Controls.Add(this.NewlisttextBox);
            this.Controls.Add(this.Titellabel);
            this.Name = "NewListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewListForm";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titellabel;
        private System.Windows.Forms.TextBox NewlisttextBox;
        private System.Windows.Forms.Label Languagelabel;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Okbutton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox textBox1;
    }
}