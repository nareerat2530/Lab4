
namespace WinFormsApp_LanguageTraining
{
    partial class PracticeForm
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
            this.EndButton = new System.Windows.Forms.Button();
            this.TranslateBox = new System.Windows.Forms.TextBox();
            this.TranslatetextBox1 = new System.Windows.Forms.TextBox();
            this.Pointlabel = new System.Windows.Forms.Label();
            this.okbutton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.Trieslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(349, 259);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(71, 20);
            this.EndButton.TabIndex = 1;
            this.EndButton.Text = "End Practice";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // TranslateBox
            // 
            this.TranslateBox.Location = new System.Drawing.Point(233, 149);
            this.TranslateBox.Name = "TranslateBox";
            this.TranslateBox.Size = new System.Drawing.Size(173, 20);
            this.TranslateBox.TabIndex = 2;
            // 
            // TranslatetextBox1
            // 
            this.TranslatetextBox1.Location = new System.Drawing.Point(211, 103);
            this.TranslatetextBox1.Name = "TranslatetextBox1";
            this.TranslatetextBox1.ReadOnly = true;
            this.TranslatetextBox1.Size = new System.Drawing.Size(235, 20);
            this.TranslatetextBox1.TabIndex = 3;
            // 
            // Pointlabel
            // 
            this.Pointlabel.AutoSize = true;
            this.Pointlabel.Location = new System.Drawing.Point(451, 16);
            this.Pointlabel.Name = "Pointlabel";
            this.Pointlabel.Size = new System.Drawing.Size(66, 13);
            this.Pointlabel.TabIndex = 5;
            this.Pointlabel.Text = "Total Points:";
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(439, 149);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(64, 20);
            this.okbutton.TabIndex = 6;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // StopButton
            // 
            this.StopButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.StopButton.Location = new System.Drawing.Point(260, 259);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(64, 20);
            this.StopButton.TabIndex = 7;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Trieslabel
            // 
            this.Trieslabel.AutoSize = true;
            this.Trieslabel.Location = new System.Drawing.Point(459, 37);
            this.Trieslabel.Name = "Trieslabel";
            this.Trieslabel.Size = new System.Drawing.Size(60, 13);
            this.Trieslabel.TabIndex = 8;
            this.Trieslabel.Text = "Total Tries:";
            this.Trieslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PracticeForm
            // 
            this.AcceptButton = this.okbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.StopButton;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.Trieslabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.Pointlabel);
            this.Controls.Add(this.TranslatetextBox1);
            this.Controls.Add(this.TranslateBox);
            this.Controls.Add(this.EndButton);
            this.Name = "PracticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PracticeForm";
            this.Load += new System.EventHandler(this.PracticeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.TextBox TranslateBox;
        private System.Windows.Forms.TextBox TranslatetextBox1;
        private System.Windows.Forms.Label Pointlabel;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label Trieslabel;
    }
}