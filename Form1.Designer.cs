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
            this.SuspendLayout();
            // 
            // choiceOne
            // 
            this.choiceOne.Location = new System.Drawing.Point(47, 244);
            this.choiceOne.Multiline = true;
            this.choiceOne.Name = "choiceOne";
            this.choiceOne.Size = new System.Drawing.Size(336, 52);
            this.choiceOne.TabIndex = 0;
            this.choiceOne.TextChanged += new System.EventHandler(this.choiceOne_TextChanged);
            // 
            // choiceTwo
            // 
            this.choiceTwo.Location = new System.Drawing.Point(47, 389);
            this.choiceTwo.Multiline = true;
            this.choiceTwo.Name = "choiceTwo";
            this.choiceTwo.Size = new System.Drawing.Size(336, 52);
            this.choiceTwo.TabIndex = 1;
            // 
            // choiceThree
            // 
            this.choiceThree.Location = new System.Drawing.Point(641, 247);
            this.choiceThree.Multiline = true;
            this.choiceThree.Name = "choiceThree";
            this.choiceThree.Size = new System.Drawing.Size(336, 52);
            this.choiceThree.TabIndex = 2;
            this.choiceThree.TextChanged += new System.EventHandler(this.choiceThree_TextChanged);
            // 
            // choiceFour
            // 
            this.choiceFour.Location = new System.Drawing.Point(641, 392);
            this.choiceFour.Multiline = true;
            this.choiceFour.Name = "choiceFour";
            this.choiceFour.Size = new System.Drawing.Size(336, 52);
            this.choiceFour.TabIndex = 3;
            // 
            // questionText
            // 
            this.questionText.Location = new System.Drawing.Point(47, 68);
            this.questionText.Multiline = true;
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(336, 77);
            this.questionText.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Question";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(641, 63);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(336, 77);
            this.descriptionText.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(638, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Answer Description";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(487, 574);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(175, 41);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(887, 574);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(175, 41);
            this.clearAllButton.TabIndex = 13;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // clearOne
            // 
            this.clearOne.Location = new System.Drawing.Point(308, 302);
            this.clearOne.Name = "clearOne";
            this.clearOne.Size = new System.Drawing.Size(75, 23);
            this.clearOne.TabIndex = 14;
            this.clearOne.Text = "Clear";
            this.clearOne.UseVisualStyleBackColor = true;
            this.clearOne.Click += new System.EventHandler(this.clearOne_Click);
            // 
            // clearTwo
            // 
            this.clearTwo.Location = new System.Drawing.Point(308, 447);
            this.clearTwo.Name = "clearTwo";
            this.clearTwo.Size = new System.Drawing.Size(75, 23);
            this.clearTwo.TabIndex = 15;
            this.clearTwo.Text = "Clear";
            this.clearTwo.UseVisualStyleBackColor = true;
            this.clearTwo.Click += new System.EventHandler(this.clearTwo_Click);
            // 
            // clearThree
            // 
            this.clearThree.Location = new System.Drawing.Point(902, 302);
            this.clearThree.Name = "clearThree";
            this.clearThree.Size = new System.Drawing.Size(75, 23);
            this.clearThree.TabIndex = 16;
            this.clearThree.Text = "Clear";
            this.clearThree.UseVisualStyleBackColor = true;
            this.clearThree.Click += new System.EventHandler(this.clearThree_Click);
            // 
            // clearFour
            // 
            this.clearFour.Location = new System.Drawing.Point(902, 450);
            this.clearFour.Name = "clearFour";
            this.clearFour.Size = new System.Drawing.Size(75, 23);
            this.clearFour.TabIndex = 17;
            this.clearFour.Text = "Clear";
            this.clearFour.UseVisualStyleBackColor = true;
            this.clearFour.Click += new System.EventHandler(this.clearFour_Click);
            // 
            // clearQuestion
            // 
            this.clearQuestion.Location = new System.Drawing.Point(308, 151);
            this.clearQuestion.Name = "clearQuestion";
            this.clearQuestion.Size = new System.Drawing.Size(75, 23);
            this.clearQuestion.TabIndex = 18;
            this.clearQuestion.Text = "Clear";
            this.clearQuestion.UseVisualStyleBackColor = true;
            this.clearQuestion.Click += new System.EventHandler(this.clearQuestion_Click);
            // 
            // clearDescription
            // 
            this.clearDescription.Location = new System.Drawing.Point(902, 151);
            this.clearDescription.Name = "clearDescription";
            this.clearDescription.Size = new System.Drawing.Size(75, 23);
            this.clearDescription.TabIndex = 19;
            this.clearDescription.Text = "Clear";
            this.clearDescription.UseVisualStyleBackColor = true;
            this.clearDescription.Click += new System.EventHandler(this.clearDescription_Click);
            // 
            // updateQuestion
            // 
            this.updateQuestion.Location = new System.Drawing.Point(47, 151);
            this.updateQuestion.Name = "updateQuestion";
            this.updateQuestion.Size = new System.Drawing.Size(75, 23);
            this.updateQuestion.TabIndex = 20;
            this.updateQuestion.Text = "Update";
            this.updateQuestion.UseVisualStyleBackColor = true;
            this.updateQuestion.Click += new System.EventHandler(this.updateQuestion_Click);
            // 
            // updateAnswer
            // 
            this.updateAnswer.Location = new System.Drawing.Point(641, 151);
            this.updateAnswer.Name = "updateAnswer";
            this.updateAnswer.Size = new System.Drawing.Size(75, 23);
            this.updateAnswer.TabIndex = 21;
            this.updateAnswer.Text = "Update";
            this.updateAnswer.UseVisualStyleBackColor = true;
            this.updateAnswer.Click += new System.EventHandler(this.updateAnswer_Click);
            // 
            // updateOne
            // 
            this.updateOne.Location = new System.Drawing.Point(47, 302);
            this.updateOne.Name = "updateOne";
            this.updateOne.Size = new System.Drawing.Size(75, 23);
            this.updateOne.TabIndex = 22;
            this.updateOne.Text = "Update";
            this.updateOne.UseVisualStyleBackColor = true;
            this.updateOne.Click += new System.EventHandler(this.updateOne_Click);
            // 
            // updateTwo
            // 
            this.updateTwo.Location = new System.Drawing.Point(47, 447);
            this.updateTwo.Name = "updateTwo";
            this.updateTwo.Size = new System.Drawing.Size(75, 23);
            this.updateTwo.TabIndex = 23;
            this.updateTwo.Text = "Update";
            this.updateTwo.UseVisualStyleBackColor = true;
            this.updateTwo.Click += new System.EventHandler(this.updateTwo_Click);
            // 
            // updateThree
            // 
            this.updateThree.Location = new System.Drawing.Point(641, 305);
            this.updateThree.Name = "updateThree";
            this.updateThree.Size = new System.Drawing.Size(75, 23);
            this.updateThree.TabIndex = 24;
            this.updateThree.Text = "Update";
            this.updateThree.UseVisualStyleBackColor = true;
            this.updateThree.Click += new System.EventHandler(this.updateThree_Click);
            // 
            // updateFour
            // 
            this.updateFour.Location = new System.Drawing.Point(641, 450);
            this.updateFour.Name = "updateFour";
            this.updateFour.Size = new System.Drawing.Size(75, 23);
            this.updateFour.TabIndex = 25;
            this.updateFour.Text = "Update";
            this.updateFour.UseVisualStyleBackColor = true;
            this.updateFour.Click += new System.EventHandler(this.button6_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(47, 221);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 17);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(47, 366);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(32, 17);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "B";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(641, 224);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(32, 17);
            this.radioButton3.TabIndex = 28;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "C";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(641, 369);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(33, 17);
            this.radioButton4.TabIndex = 29;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "D";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 627);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

