namespace Assignment_9
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
            this.test1PromtLabel = new System.Windows.Forms.Label();
            this.test2PromptLabel = new System.Windows.Forms.Label();
            this.test3PromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.averageLabel = new System.Windows.Forms.Label();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // test1PromtLabel
            // 
            this.test1PromtLabel.AutoSize = true;
            this.test1PromtLabel.Location = new System.Drawing.Point(108, 16);
            this.test1PromtLabel.Name = "test1PromtLabel";
            this.test1PromtLabel.Size = new System.Drawing.Size(47, 16);
            this.test1PromtLabel.TabIndex = 0;
            this.test1PromtLabel.Text = "Test 1:";
            // 
            // test2PromptLabel
            // 
            this.test2PromptLabel.AutoSize = true;
            this.test2PromptLabel.Location = new System.Drawing.Point(108, 39);
            this.test2PromptLabel.Name = "test2PromptLabel";
            this.test2PromptLabel.Size = new System.Drawing.Size(47, 16);
            this.test2PromptLabel.TabIndex = 1;
            this.test2PromptLabel.Text = "Test 2:";
            // 
            // test3PromptLabel
            // 
            this.test3PromptLabel.AutoSize = true;
            this.test3PromptLabel.Location = new System.Drawing.Point(108, 62);
            this.test3PromptLabel.Name = "test3PromptLabel";
            this.test3PromptLabel.Size = new System.Drawing.Size(47, 16);
            this.test3PromptLabel.TabIndex = 2;
            this.test3PromptLabel.Text = "Test 3:";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(16, 83);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(139, 16);
            this.outputDescriptionLabel.TabIndex = 3;
            this.outputDescriptionLabel.Text = "Avaerage Test Score:";
            this.outputDescriptionLabel.Click += new System.EventHandler(this.outputDescriptionLabel_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(98, 108);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 41);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(179, 108);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 41);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 108);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(85, 41);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Average";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(161, 82);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(100, 23);
            this.averageLabel.TabIndex = 7;
            this.averageLabel.Click += new System.EventHandler(this.averageLabel_Click);
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(161, 13);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(100, 22);
            this.test1TextBox.TabIndex = 8;
            this.test1TextBox.TextChanged += new System.EventHandler(this.test1TextBox_TextChanged);
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(161, 36);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(100, 22);
            this.test2TextBox.TabIndex = 9;
            this.test2TextBox.TextChanged += new System.EventHandler(this.test2TextBox_TextChanged);
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(161, 56);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(100, 22);
            this.test3TextBox.TabIndex = 10;
            this.test3TextBox.TextChanged += new System.EventHandler(this.test3TextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 164);
            this.Controls.Add(this.test3TextBox);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test1TextBox);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.test3PromptLabel);
            this.Controls.Add(this.test2PromptLabel);
            this.Controls.Add(this.test1PromtLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test1PromtLabel;
        private System.Windows.Forms.Label test2PromptLabel;
        private System.Windows.Forms.Label test3PromptLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test3TextBox;
    }
}

