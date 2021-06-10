using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_game
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;






        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 10;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correctAnswer)
            {
                score++;
                
            }
            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Kraj kviza" + Environment.NewLine +
                    "Odgovorio si na " + score + " pitanja tacno." + Environment.NewLine +
                    " Vas procenat je " + percentage + "%" + Environment.NewLine +
                    " Klikni na ok da igras ponovo"



                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }


            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch(qnum)
            {

                case 1:
                    pictureBox1.Image = Properties.Resources.volga;

                    lblQuestion.Text = " Koja je najduza reka u Evropi?";

                    button1.Text = "Volga";
                    button2.Text = "Dunav";
                    button3.Text = "Sava";
                    button4.Text = "Po";

                    correctAnswer = 1;
                    
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.tri_klisure;

                    lblQuestion.Text = " Koja je najveca hidroelektrana na svetu?";

                    button1.Text = "Djerdap";
                    button2.Text = "Tri Klisure";
                    button3.Text = "Itaipu";
                    button4.Text = "Huverova brana, SAD";

                    correctAnswer = 2;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.rio;

                    lblQuestion.Text = "Gde se nalazi najveci spomenik Isusa Hrista?";

                    button1.Text = "Brazil";
                    button2.Text = "Argentina";
                    button3.Text = "Indija";
                    button4.Text = "Francuska";

                    correctAnswer = 1;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.kruševac;

                    lblQuestion.Text = " Glavni grad Srbije krajem 14 veka bio je?";

                    button1.Text = "Novi Sad";
                    button2.Text = "Beograd";
                    button3.Text = "Krusevac";
                    button4.Text = "Nis";

                    correctAnswer = 3;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.Pancicev_vrh;

                    lblQuestion.Text = "Najvisi vrh u Srbiji je?";

                    button1.Text = "Crni vrh";
                    button2.Text = "Jankov kamen";
                    button3.Text = "Pancicev vrh";
                    button4.Text = "Zboriste";

                    correctAnswer = 3;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.monako;

                    lblQuestion.Text = " Glavni grad Monaka je?";

                    button1.Text = "Paris";
                    button2.Text = "Amsterdam";
                    button3.Text = "Brisel";
                    button4.Text = "Monako";

                    correctAnswer = 4;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.newyork;

                    lblQuestion.Text = " Sediste robne marke Calvin Clein je?";

                    button1.Text = "NewYork";
                    button2.Text = "Paris";
                    button3.Text = "Berlin";
                    button4.Text = "London";

                    correctAnswer = 1;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.gandi;

                    lblQuestion.Text = " Iz koje drzave je Mahatma Gandi?";

                    button1.Text = "Kina";
                    button2.Text = "Indija";
                    button3.Text = "Vijetnam";
                    button4.Text = "Japan";

                    correctAnswer = 2;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.Fujifilm;

                    lblQuestion.Text = " Zemlja porekla Fujifilm kompanije je?";

                    button1.Text = "Japan";
                    button2.Text = "Kina";
                    button3.Text = "Juzna Koreja";
                    button4.Text = "Kanada";

                    correctAnswer = 1;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.berlin;

                    lblQuestion.Text = "Koja zivotinja je simbol Berlina?";

                    button1.Text = "Tigar";
                    button2.Text = "Vuk";
                    button3.Text = "Medved";
                    button4.Text = "Zec";

                    correctAnswer = 3;

                    break;

            }

        }





    }
}
