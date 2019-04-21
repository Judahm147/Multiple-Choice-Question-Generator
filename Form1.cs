using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Multiple_Choice_Trivia_Question_Generator
{
    public partial class Form1 : Form
    {
        string fullQuestionString;
        string questionString;
        string descriptionString;
        string choiceOneString;
        string choiceTwoString;
        string choiceThreeString;
        string choiceFourString;
        bool isQuestionValid = false;
        bool isDescriptionValid = false;
        bool isChoiceOneValid = false;
        bool isChoiceTwoValid = false;
        bool isChoiceThreeValid = false;
        bool isChoiceFourValid = false;
        bool isABCD_Selected = false;
        bool isEntryValid = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            //To do - Input check for all fields to be entered otherwise, abort
            string fileName = "C:/Users/Home/source/repos/Multiple Choice Trivia Question Generator/Multiple Choice Trivia Question Generator/Questions list.txt";
            

            if (!(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked))
            {
                isABCD_Selected = false;
                MessageBox.Show("Answer's radio button not selected");
            }
            else
            {                
                isABCD_Selected = true;
                checkIfValid();
            }
            

            if (isEntryValid)
            {
                using (StreamWriter streamWriter = new StreamWriter(fileName, true))
                {
                    string answerNumber = "1";
                    if (radioButton1.Checked)
                        answerNumber = "1";
                    else if (radioButton2.Checked)
                        answerNumber = "2";
                    else if (radioButton3.Checked)
                        answerNumber = "3";
                    else
                        answerNumber = "4";
                    streamWriter.Write('\n');
                    streamWriter.WriteLine(questionString);
                    streamWriter.WriteLine(answerNumber);
                    streamWriter.WriteLine(descriptionString);
                    streamWriter.WriteLine(choiceOneString);
                    streamWriter.WriteLine(choiceTwoString);
                    streamWriter.WriteLine(choiceThreeString);
                    streamWriter.WriteLine(choiceFourString);
                }
                MessageBox.Show("Question added: \n" + questionString);
            }
            else
                MessageBox.Show("Entry not valid");

            
        }

        private void clearTwo_Click(object sender, EventArgs e)
        {
            Clear_B();
        }

        private void choiceThree_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearOne_Click(object sender, EventArgs e)
        {
            Clear_A();
        }

        private void choiceOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearThree_Click(object sender, EventArgs e)
        {
            Clear_C();
        }

        private void clearDescription_Click(object sender, EventArgs e)
        {
            ClearDescriptionText();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            choiceFourString = choiceFour.Text.Trim();
            if (choiceFourString.Length == 0)
            {
                isChoiceFourValid = false;
                isEntryValid = false;
                MessageBox.Show("Option D entry is empty");
                choiceFour.BackColor = Color.OrangeRed;
            }
            else
            {
                isChoiceFourValid = true;
                choiceFour.BackColor = Color.YellowGreen;
                if (radioButton4.Checked)
                    choiceFour.BackColor = Color.LawnGreen;
            }
                
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            ClearQuestionText();
            ClearDescriptionText();
            Clear_A();
            Clear_B();
            Clear_C();
            Clear_D();
            radioButton1.Checked = true;
        }

        private void ClearQuestionText()
        {
            questionText.Clear();
            questionText.BackColor = Color.White;
        }

        private void ClearDescriptionText()
        {
            descriptionText.Clear();
            descriptionText.BackColor = Color.White;
        }

        private void Clear_A()
        {
            choiceOne.Clear();
            choiceOne.BackColor = Color.White;
        }

        private void Clear_B()
        {
            choiceTwo.Clear();
            choiceTwo.BackColor = Color.White;
        }

        private void Clear_C()
        {
            choiceThree.Clear();
            choiceThree.BackColor = Color.White;
        }

        private void Clear_D()
        {
            choiceFour.Clear();
            choiceFour.BackColor = Color.White;
        }

        private void clearFour_Click(object sender, EventArgs e)
        {
            Clear_D();
        }

        private void clearQuestion_Click(object sender, EventArgs e)
        {
            ClearQuestionText();
        }

        private void updateQuestion_Click(object sender, EventArgs e)
        {
            questionString = questionText.Text.Trim();
            if (questionString.Length == 0)
            {
                isQuestionValid = false;
                isEntryValid = false;
                MessageBox.Show("Question entry is empty");
                questionText.BackColor = Color.OrangeRed;
            }
            else
            {
                isQuestionValid = true;
                questionText.BackColor = Color.YellowGreen;
            }
        }

        private void updateAnswer_Click(object sender, EventArgs e)
        {
            descriptionString = descriptionText.Text.Trim();
            if (descriptionString.Length == 0)
            {
                isDescriptionValid = false;
                isEntryValid = false;
                MessageBox.Show("Answer Description entry is empty");
                descriptionText.BackColor = Color.OrangeRed;
            }
            else
            {
                isDescriptionValid = true;
                descriptionText.BackColor = Color.YellowGreen;
            }
        }

        private void updateOne_Click(object sender, EventArgs e)
        {
            choiceOneString = choiceOne.Text.Trim();
            if (choiceOneString.Length == 0)
            {
                isChoiceOneValid = false;
                isEntryValid = false;
                MessageBox.Show("Option A entry is empty");
                choiceOne.BackColor = Color.OrangeRed;
            }
            else
            {
                isChoiceOneValid = true;
                choiceOne.BackColor = Color.YellowGreen;
                if (radioButton1.Checked)
                    choiceOne.BackColor = Color.LawnGreen;
            }
        }

        private void updateTwo_Click(object sender, EventArgs e)
        {
            choiceTwoString = choiceTwo.Text.Trim();
            if (choiceTwoString.Length == 0)
            {
                isChoiceTwoValid = false;
                isEntryValid = false;
                MessageBox.Show("Option B entry is empty");
                choiceTwo.BackColor = Color.OrangeRed;
            }
            else
            {
                isChoiceTwoValid = true;
                choiceTwo.BackColor = Color.YellowGreen;
                if (radioButton2.Checked)
                    choiceTwo.BackColor = Color.LawnGreen;
            }
        }

        private void updateThree_Click(object sender, EventArgs e)
        {
            choiceThreeString = choiceThree.Text.Trim();
            if (choiceThreeString.Length == 0)
            {
                isChoiceThreeValid = false;
                isEntryValid = false;
                MessageBox.Show("Option C entry is empty");
                choiceThree.BackColor = Color.OrangeRed;
            }
            else
            {
                isChoiceThreeValid = true;
                choiceThree.BackColor = Color.YellowGreen;
                if (radioButton3.Checked)
                    choiceThree.BackColor = Color.LawnGreen;
            }
        }

        private void updateFullQuestion()
        {
            
        }

        private void checkIfValid()
        {
            if(isQuestionValid && isDescriptionValid && isChoiceOneValid && isChoiceTwoValid && isChoiceThreeValid
                && isChoiceFourValid)
            {
                isEntryValid = true;
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}