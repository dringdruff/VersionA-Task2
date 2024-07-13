namespace VersionA_Task2
{
    partial class Form1
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
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.rowAmountLabel = new System.Windows.Forms.Label();
            this.rowAmountInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(616, 616);
            this.pictureBoxDisplay.TabIndex = 2;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(649, 438);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(116, 23);
            this.drawButton.TabIndex = 3;
            this.drawButton.Text = "Draw Hand Bags";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(649, 467);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(116, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(649, 496);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rowAmountLabel
            // 
            this.rowAmountLabel.AutoSize = true;
            this.rowAmountLabel.Location = new System.Drawing.Point(662, 101);
            this.rowAmountLabel.Name = "rowAmountLabel";
            this.rowAmountLabel.Size = new System.Drawing.Size(91, 13);
            this.rowAmountLabel.TabIndex = 6;
            this.rowAmountLabel.Text = "Number Of Rows:";
            // 
            // rowAmountInput
            // 
            this.rowAmountInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rowAmountInput.Location = new System.Drawing.Point(649, 126);
            this.rowAmountInput.Name = "rowAmountInput";
            this.rowAmountInput.Size = new System.Drawing.Size(116, 20);
            this.rowAmountInput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 640);
            this.Controls.Add(this.rowAmountInput);
            this.Controls.Add(this.rowAmountLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label rowAmountLabel;
        private System.Windows.Forms.TextBox rowAmountInput;
    }
}

