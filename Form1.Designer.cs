namespace Multiple_Choice_Trivia_Question_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.choiceOne = new System.Windows.Forms.TextBox();
            this.choiceTwo = new System.Windows.Forms.TextBox();
            this.choiceThree = new System.Windows.Forms.TextBox();
            this.choiceFour = new System.Windows.Forms.TextBox();
            this.questionText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.clearOne = new System.Windows.Forms.Button();
            this.clearTwo = new System.Windows.Forms.Button();
            this.clearThree = new System.Windows.Forms.Button();
            this.clearFour = new System.Windows.Forms.Button();
            this.clearQuestion = new System.Windows.Forms.Button();
            this.clearDescription = new System.Windows.Forms.Button();
            this.updateQuestion = new System.Windows.Forms.Button();
            this.updateAnswer = new System.Windows.Forms.Button();
            this.updateOne = new System.Windows.Forms.Button();
            this.updateTwo = new System.Windows.Forms.Button();
            this.updateThree = new System.Windows.Forms.Button();
            this.updateFour = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choiceOne
            // 
            this.choiceOne.Location = new System.Drawing.Point(71, 301);
            this.choiceOne.Multiline = true;
            this.choiceOne.Name = "choiceOne";
            this.choiceOne.Size = new System.Drawing.Size(336, 52);
            this.choiceOne.TabIndex = 3;
            this.choiceOne.TextChanged += new System.EventHandler(this.choiceOne_TextChanged);
            // 
            // choiceTwo
            // 
            this.choiceTwo.Location = new System.Drawing.Point(71, 446);
            this.choiceTwo.Multiline = true;
            this.choiceTwo.Name = "choiceTwo";
            this.choiceTwo.Size = new System.Drawing.Size(336, 52);
            this.choiceTwo.TabIndex = 5;
            // 
            // choiceThree
            // 
            this.choiceThree.Location = new System.Drawing.Point(665, 304);
            this.choiceThree.Multiline = true;
            this.choiceThree.Name = "choiceThree";
            this.choiceThree.Size = new System.Drawing.Size(336, 52);
            this.choiceThree.TabIndex = 4;
            this.choiceThree.TextChanged += new System.EventHandler(this.choiceThree_TextChanged);
            // 
            // choiceFour
            // 
            this.choiceFour.Location = new System.Drawing.Point(665, 449);
            this.choiceFour.Multiline = true;
            this.choiceFour.Name = "choiceFour";
            this.choiceFour.Size = new System.Drawing.Size(336, 52);
            this.choiceFour.TabIndex = 6;
            // 
            // questionText
            // 
            this.questionText.Location = new System.Drawing.Point(71, 125);
            this.questionText.Multiline = true;
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(336, 77);
            this.questionText.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Location = new System.Drawing.Point(68, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Question";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(665, 120);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(336, 77);
            this.descriptionText.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Location = new System.Drawing.Point(662, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Answer Description";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.ForestGreen;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(487, 574);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(175, 41);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.clearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearAllButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllButton.Location = new System.Drawing.Point(887, 574);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(175, 41);
            this.clearAllButton.TabIndex = 8;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = false;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // clearOne
            // 
            this.clearOne.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clearOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearOne.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearOne.Location = new System.Drawing.Point(332, 359);
            this.clearOne.Name = "clearOne";
            this.clearOne.Size = new System.Drawing.Size(75, 23);
            this.clearOne.TabIndex = 14;
            this.clearOne.Text = "Clear";
            this.clearOne.UseVisualStyleBackColor = false;
            this.clearOne.Click += new System.EventHandler(this.clearOne_Click);
            // 
            // clearTwo
            // 
            this.clearTwo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clearTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearTwo.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTwo.Location = new System.Drawing.Point(332, 504);
            this.clearTwo.Name = "clearTwo";
            this.clearTwo.Size = new System.Drawing.Size(75, 23);
            this.clearTwo.TabIndex = 15;
            this.clearTwo.Text = "Clear";
            this.clearTwo.UseVisualStyleBackColor = false;
            this.clearTwo.Click += new System.EventHandler(this.clearTwo_Click);
            // 
            // clearThree
            // 
            this.clearThree.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clearThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearThree.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearThree.Location = new System.Drawing.Point(926, 359);
            this.clearThree.Name = "clearThree";
            this.clearThree.Size = new System.Drawing.Size(75, 23);
            this.clearThree.TabIndex = 16;
            this.clearThree.Text = "Clear";
            this.clearThree.UseVisualStyleBackColor = false;
            this.clearThree.Click += new System.EventHandler(this.clearThree_Click);
            // 
            // clearFour
            // 
            this.clearFour.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clearFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearFour.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFour.Location = new System.Drawing.Point(926, 507);
            this.clearFour.Name = "clearFour";
            this.clearFour.Size = new System.Drawing.Size(75, 23);
            this.clearFour.TabIndex = 17;
            this.clearFour.Text = "Clear";
            this.clearFour.UseVisualStyleBackColor = false;
            this.clearFour.Click += new System.EventHandler(this.clearFour_Click);
            // 
            // clearQuestion
            // 
            this.clearQuestion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clearQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearQuestion.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearQuestion.Location = new System.Drawing.Point(332, 208);
            this.clearQuestion.Name = "clearQuestion";
            this.clearQuestion.Size = new System.Drawing.Size(75, 23);
            this.clearQuestion.TabIndex = 18;
            this.clearQuestion.Text = "Clear";
            this.clearQuestion.UseVisualStyleBackColor = false;
            this.clearQuestion.Click += new System.EventHandler(this.clearQuestion_Click);
            // 
            // clearDescription
            // 
            this.clearDescription.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clearDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearDescription.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearDescription.Location = new System.Drawing.Point(926, 208);
            this.clearDescription.Name = "clearDescription";
            this.clearDescription.Size = new System.Drawing.Size(75, 23);
            this.clearDescription.TabIndex = 19;
            this.clearDescription.Text = "Clear";
            this.clearDescription.UseVisualStyleBackColor = false;
            this.clearDescription.Click += new System.EventHandler(this.clearDescription_Click);
            // 
            // updateQuestion
            // 
            this.updateQuestion.BackColor = System.Drawing.Color.SpringGreen;
            this.updateQuestion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateQuestion.FlatAppearance.BorderSize = 3;
            this.updateQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateQuestion.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateQuestion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateQuestion.Location = new System.Drawing.Point(71, 208);
            this.updateQuestion.Name = "updateQuestion";
            this.updateQuestion.Size = new System.Drawing.Size(75, 23);
            this.updateQuestion.TabIndex = 20;
            this.updateQuestion.Text = "Update";
            this.updateQuestion.UseVisualStyleBackColor = false;
            this.updateQuestion.Click += new System.EventHandler(this.updateQuestion_Click);
            // 
            // updateAnswer
            // 
            this.updateAnswer.BackColor = System.Drawing.Color.SpringGreen;
            this.updateAnswer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateAnswer.FlatAppearance.BorderSize = 3;
            this.updateAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateAnswer.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAnswer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateAnswer.Location = new System.Drawing.Point(665, 208);
            this.updateAnswer.Name = "updateAnswer";
            this.updateAnswer.Size = new System.Drawing.Size(75, 23);
            this.updateAnswer.TabIndex = 21;
            this.updateAnswer.Text = "Update";
            this.updateAnswer.UseVisualStyleBackColor = false;
            this.updateAnswer.Click += new System.EventHandler(this.updateAnswer_Click);
            // 
            // updateOne
            // 
            this.updateOne.BackColor = System.Drawing.Color.SpringGreen;
            this.updateOne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateOne.FlatAppearance.BorderSize = 3;
            this.updateOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateOne.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateOne.Location = new System.Drawing.Point(71, 359);
            this.updateOne.Name = "updateOne";
            this.updateOne.Size = new System.Drawing.Size(75, 23);
            this.updateOne.TabIndex = 22;
            this.updateOne.Text = "Update";
            this.updateOne.UseVisualStyleBackColor = false;
            this.updateOne.Click += new System.EventHandler(this.updateOne_Click);
            // 
            // updateTwo
            // 
            this.updateTwo.BackColor = System.Drawing.Color.SpringGreen;
            this.updateTwo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateTwo.FlatAppearance.BorderSize = 3;
            this.updateTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateTwo.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTwo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateTwo.Location = new System.Drawing.Point(71, 504);
            this.updateTwo.Name = "updateTwo";
            this.updateTwo.Size = new System.Drawing.Size(75, 23);
            this.updateTwo.TabIndex = 23;
            this.updateTwo.Text = "Update";
            this.updateTwo.UseVisualStyleBackColor = false;
            this.updateTwo.Click += new System.EventHandler(this.updateTwo_Click);
            // 
            // updateThree
            // 
            this.updateThree.BackColor = System.Drawing.Color.SpringGreen;
            this.updateThree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateThree.FlatAppearance.BorderSize = 3;
            this.updateThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateThree.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateThree.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateThree.Location = new System.Drawing.Point(665, 362);
            this.updateThree.Name = "updateThree";
            this.updateThree.Size = new System.Drawing.Size(75, 23);
            this.updateThree.TabIndex = 24;
            this.updateThree.Text = "Update";
            this.updateThree.UseVisualStyleBackColor = false;
            this.updateThree.Click += new System.EventHandler(this.updateThree_Click);
            // 
            // updateFour
            // 
            this.updateFour.BackColor = System.Drawing.Color.SpringGreen;
            this.updateFour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateFour.FlatAppearance.BorderSize = 3;
            this.updateFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateFour.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateFour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateFour.Location = new System.Drawing.Point(665, 507);
            this.updateFour.Name = "updateFour";
            this.updateFour.Size = new System.Drawing.Size(75, 23);
            this.updateFour.TabIndex = 25;
            this.updateFour.Text = "Update";
            this.updateFour.UseVisualStyleBackColor = false;
            this.updateFour.Click += new System.EventHandler(this.button6_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.radioButton1.Location = new System.Drawing.Point(71, 274);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 24);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.radioButton2.Location = new System.Drawing.Point(71, 419);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 24);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "B";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.radioButton3.Location = new System.Drawing.Point(665, 277);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(36, 24);
            this.radioButton3.TabIndex = 28;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "C";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.radioButton4.Location = new System.Drawing.Point(665, 422);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(36, 24);
            this.radioButton4.TabIndex = 29;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "D";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.Crimson;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.SeaShell;
            this.buttonQuit.Location = new System.Drawing.Point(1025, 12);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(37, 36);
            this.buttonQuit.TabIndex = 30;
            this.buttonQuit.Text = "X";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(154, 22);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(593, 42);
            this.label2.TabIndex = 32;
            this.label2.Text = "Multiple-Choice Questions Generator";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 627);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.updateFour);
            this.Controls.Add(this.updateThree);
            this.Controls.Add(this.updateTwo);
            this.Controls.Add(this.updateOne);
            this.Controls.Add(this.updateAnswer);
            this.Controls.Add(this.updateQuestion);
            this.Controls.Add(this.clearDescription);
            this.Controls.Add(this.clearQuestion);
            this.Controls.Add(this.clearFour);
            this.Controls.Add(this.clearThree);
            this.Controls.Add(this.clearTwo);
            this.Controls.Add(this.clearOne);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.choiceFour);
            this.Controls.Add(this.choiceThree);
            this.Controls.Add(this.choiceTwo);
            this.Controls.Add(this.choiceOne);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Choice Question Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox choiceOne;
        private System.Windows.Forms.TextBox choiceTwo;
        private System.Windows.Forms.TextBox choiceThree;
        private System.Windows.Forms.TextBox choiceFour;
        private System.Windows.Forms.TextBox questionText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button clearOne;
        private System.Windows.Forms.Button clearTwo;
        private System.Windows.Forms.Button clearThree;
        private System.Windows.Forms.Button clearFour;
        private System.Windows.Forms.Button clearQuestion;
        private System.Windows.Forms.Button clearDescription;
        private System.Windows.Forms.Button updateQuestion;
        private System.Windows.Forms.Button updateAnswer;
        private System.Windows.Forms.Button updateOne;
        private System.Windows.Forms.Button updateTwo;
        private System.Windows.Forms.Button updateThree;
        private System.Windows.Forms.Button updateFour;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label label2;
    }
}

