using Quiz_With_Passaparola_Theme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quiz_With_Passaparola_Theme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int counter = 100;
        public int questionNo=0, correct=0, incorrect=0;
        public string[] letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private void BtAlphabet_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            LblTimer.Text = counter.ToString();
        }

        private void BtA_Click(object sender, EventArgs e)
        {
            GetQuestionAndAnswer getQueAns = new GetQuestionAndAnswer();
            var letter = sender.ToString().ToCharArray().Last();
            RtbQuestion.Text = getQueAns.GetQue(letter).ToString();
            string[] answers = getQueAns.GetAnswer(letter);
            questionNo = 1;
            LinkLblNextQue.Enabled = true;
            BtA.Enabled = false;
            BtA.BackColor = Color.Yellow;
        }
        private void BtB_Click(object sender, EventArgs e)
        {
            GetQuestionAndAnswer getQueAns = new GetQuestionAndAnswer();
            var letter = sender.ToString().ToCharArray().Last();
            RtbQuestion.Text = getQueAns.GetQue(letter).ToString();
            questionNo = 2;
            LinkLblNextQue.Enabled = true;
            BtB.Enabled = false;
            BtB.BackColor = Color.Yellow;
        }
        private void BtC_Click(object sender, EventArgs e)
        {
            GetQuestionAndAnswer getQueAns = new GetQuestionAndAnswer();
            var letter = sender.ToString().ToCharArray().Last();
            RtbQuestion.Text = getQueAns.GetQue(letter).ToString();
            questionNo = 3;
            LinkLblNextQue.Enabled = true;
            BtC.Enabled = false;
            BtC.BackColor = Color.Yellow;
        }
        private void BtD_Click(object sender, EventArgs e)
        {
            GetQuestionAndAnswer getQueAns = new GetQuestionAndAnswer();
            var letter = sender.ToString().ToCharArray().Last();
            RtbQuestion.Text = getQueAns.GetQue(letter).ToString();
            questionNo = 4;
            LinkLblNextQue.Enabled = true;
            BtD.Enabled = false;
            BtD.BackColor = Color.Yellow;
        }
        private void BtE_Click(object sender, EventArgs e)
        {
            GetQuestionAndAnswer getQueAns = new GetQuestionAndAnswer();
            var letter = sender.ToString().ToCharArray().Last();
            RtbQuestion.Text = getQueAns.GetQue(letter).ToString();
            questionNo = 5;
            LinkLblNextQue.Enabled = true;
            BtE.Enabled = false;
            BtE.BackColor = Color.Yellow;
        }
        private void BtF_Click(object sender, EventArgs e)
        {
            GetQuestionAndAnswer getQueAns = new GetQuestionAndAnswer();
            var letter = sender.ToString().ToCharArray().Last();
            RtbQuestion.Text = getQueAns.GetQue(letter).ToString();
            questionNo = 6;
            LinkLblNextQue.Enabled = true;
            BtF.Enabled = false;
            BtF.BackColor = Color.Yellow;
        }

        private void BtG_Click(object sender, EventArgs e)
        {
            GetQuestionAndAnswer getQueAns = new GetQuestionAndAnswer();
            var letter = sender.ToString().ToCharArray().Last();
            RtbQuestion.Text = getQueAns.GetQue(letter).ToString();
            questionNo = 7;
            LinkLblNextQue.Enabled = true;
            BtG.Enabled = false;
            BtG.BackColor = Color.Yellow;
        }

        private void BtH_Click(object sender, EventArgs e)
        {
            GetQuestionAndAnswer getQueAns = new GetQuestionAndAnswer();
            var letter = sender.ToString().ToCharArray().Last();
            RtbQuestion.Text = getQueAns.GetQue(letter).ToString();
            questionNo = 8;
            LinkLblNextQue.Enabled = true;
            BtH.Enabled = false;
            BtH.BackColor = Color.Yellow;
        }

        private void BtI_Click(object sender, EventArgs e)
        {
            GetQuestionAndAnswer getQueAns = new GetQuestionAndAnswer();
            var letter = sender.ToString().ToCharArray().Last();
            RtbQuestion.Text = getQueAns.GetQue(letter).ToString();
            questionNo = 9;
            LinkLblNextQue.Enabled = true;
            BtI.Enabled = false;
            BtI.BackColor = Color.Yellow;
        }

        private void BtJ_Click(object sender, EventArgs e)
        {
            GetQuestionAndAnswer getQueAns = new GetQuestionAndAnswer();
            var letter = sender.ToString().ToCharArray().Last();
            RtbQuestion.Text = getQueAns.GetQue(letter).ToString();
            questionNo = 10;
            LinkLblNextQue.Enabled = true;
            BtJ.Enabled = false;
            BtJ.BackColor = Color.Yellow;
        }
        private void BtP_Click(object sender, EventArgs e)
        {
            GetQuestionAndAnswer getQueAns = new GetQuestionAndAnswer();
            var letter = sender.ToString().ToCharArray().Last();
            RtbQuestion.Text = getQueAns.GetQue(letter).ToString();
            questionNo = 16;
            LinkLblNextQue.Enabled = true;
            BtP.Enabled = false;
            BtP.BackColor = Color.Yellow;
        }

        public void Desicion(int questionNo,bool result)
        {
            switch (questionNo)
            {
                case 1:
                    if (result)
                        BtA.BackColor=Color.Green;
                    else
                        BtA.BackColor=Color.Red;
                    break;
                case 2:
                    if (result)
                        BtB.BackColor = Color.Green;
                    else
                        BtB.BackColor = Color.Red;
                    break;
                case 3:
                    if (result)
                        BtC.BackColor = Color.Green;
                    else
                        BtC.BackColor = Color.Red;
                    break;
                case 4:
                    if (result)
                        BtD.BackColor = Color.Green;
                    else
                        BtD.BackColor = Color.Red;
                    break;
                case 5:
                    if (result)
                        BtE.BackColor = Color.Green;
                    else
                        BtE.BackColor = Color.Red;
                    break;
                case 6:
                    if (result)
                        BtF.BackColor = Color.Green;
                    else
                        BtF.BackColor = Color.Red;
                    break;
                case 7:
                    if (result)
                        BtG.BackColor = Color.Green;
                    else
                        BtG.BackColor = Color.Red;
                    break;
                case 8:
                    if (result)
                        BtH.BackColor = Color.Green;
                    else
                        BtH.BackColor = Color.Red;
                    break;
                case 9:
                    if (result)
                        BtI.BackColor = Color.Green;
                    else
                        BtI.BackColor = Color.Red;
                    break;
                case 10:
                    if (result)
                        BtJ.BackColor = Color.Green;
                    else
                        BtJ.BackColor = Color.Red;
                    break;
                case 11:
                    if (result)
                        BtK.BackColor = Color.Green;
                    else
                        BtK.BackColor = Color.Red;
                    break;
                case 12:
                    if (result)
                        BtL.BackColor = Color.Green;
                    else
                        BtL.BackColor = Color.Red;
                    break;
                case 13:
                    if (result)
                        BtM.BackColor = Color.Green;
                    else
                        BtM.BackColor = Color.Red;
                    break;
                case 14:
                    if (result)
                        BtN.BackColor = Color.Green;
                    else
                        BtN.BackColor = Color.Red;
                    break;
                case 15:
                    if (result)
                        BtO.BackColor = Color.Green;
                    else
                        BtO.BackColor = Color.Red;
                    break;
                case 16:
                    if (result)
                        BtP.BackColor = Color.Green;
                    else
                        BtP.BackColor = Color.Red;
                    break;
                case 17:
                    if (result)
                        BtQ.BackColor = Color.Green;
                    else
                        BtQ.BackColor = Color.Red;
                    break;
                case 18:
                    if (result)
                        BtR.BackColor = Color.Green;
                    else
                        BtR.BackColor = Color.Red;
                    break;
                case 19:
                    if (result)
                        BtS.BackColor = Color.Green;
                    else
                        BtS.BackColor = Color.Red;
                    break;
                case 20:
                    if (result)
                        BtT.BackColor = Color.Green;
                    else
                        BtT.BackColor = Color.Red;
                    break;
                case 21:
                    if (result)
                        BtU.BackColor = Color.Green;
                    else
                        BtU.BackColor = Color.Red;
                    break;
                case 22:
                    if (result)
                        BtV.BackColor = Color.Green;
                    else
                        BtV.BackColor = Color.Red;
                    break;
                case 23:
                    if (result)
                        BtW.BackColor = Color.Green;
                    else
                        BtW.BackColor = Color.Red;
                    break;
                case 24:
                    if (result)
                        BtX.BackColor = Color.Green;
                    else
                        BtX.BackColor = Color.Red;
                    break;
                case 25:
                    if (result)
                        BtY.BackColor = Color.Green;
                    else
                        BtY.BackColor = Color.Red;
                    break;
                case 26:
                    if (result)
                        BtZ.BackColor = Color.Green;
                    else
                        BtZ.BackColor = Color.Red;
                    break;
                default:
                    break;
            }

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            GetQuestionAndAnswer getQueAns = new GetQuestionAndAnswer();
            string[] answers = getQueAns.GetAnswer(letters[questionNo - 1].ToCharArray()[0]);
            bool result = false;
            foreach (string answer in answers)
            {
                if (RtbAnswer.Text == answer)
                {
                    result = true;
                    break;
                }
            }
            if (result == true)
                correct++;
            else
                incorrect++;
            Desicion(questionNo, result);
            LblCorrect.Text = correct.ToString();
            LblIncorrect.Text = incorrect.ToString();
            LinkLblNextQue.Enabled = false;
            LblQNo.Text = (questionNo+1).ToString();
            RtbQuestion.Text = "";
            RtbAnswer.Text = "";
        }



        private void Timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                BtAlphabet.Text = "Finish";
                DisableAll();
            }
                
            LblTimer.Text = counter.ToString();
        }
        public void DisableAll()
        {
            BtA.Enabled = false;
            BtB.Enabled = false;
            BtC.Enabled = false;
            BtD.Enabled = false;
            BtE.Enabled = false;
            BtF.Enabled = false;
            BtG.Enabled = false;
            BtH.Enabled = false;
            BtI.Enabled = false;
            BtJ.Enabled = false;
            BtK.Enabled = false;
            BtL.Enabled = false;
            BtM.Enabled = false;
            BtN.Enabled = false;
            BtO.Enabled = false;
            BtP.Enabled = false;
            BtQ.Enabled = false;
            BtR.Enabled = false;
            BtS.Enabled = false;
            BtT.Enabled = false;
            BtU.Enabled = false;
            BtV.Enabled = false;
            BtW.Enabled = false;
            BtX.Enabled = false;
            BtY.Enabled = false;
            BtZ.Enabled = false;
            RtbQuestion.Enabled = false;
            RtbAnswer.Enabled = false;
            LinkLblNextQue.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BtAlphabet.Text = "START !!";
        }
    }
}
