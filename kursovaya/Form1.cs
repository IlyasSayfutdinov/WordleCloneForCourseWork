using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.IO;

namespace kursovaya
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitializeLetterTextBoxes();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changeThoughtWord();
        }

        private Label[,] letters;

        public void InitializeLetterTextBoxes()
        {
            letters = new Label[,]
            {
                { letter11, letter12, letter13, letter14, letter15 },
                { letter21, letter22, letter23, letter24, letter25 },
                { letter31, letter32, letter33, letter34, letter35 },
                { letter41, letter42, letter43, letter44, letter45 },
                { letter51, letter52, letter53, letter54, letter55 },
                { letter61, letter62, letter63, letter64, letter65 }
            };
        }

        public string thoughtWord = "     ";
        public string enteredWord = "     ";
        public int gsd = 0;
        public int unGsd = 0;
        public void changeThoughtWord()
        {
            var rand = new Random();
            int randomWordNum = rand.Next(2301);
            string pathWords = "..\\..\\words.txt";
            string[] words = File.ReadAllLines(pathWords);
            thoughtWord = words[randomWordNum];
        }

        public bool wordIsInList()
        {
            string pathWords = "..\\..\\words.txt";
            string[] words = File.ReadAllLines(pathWords);
            for(int i = 0; i < 2300; i++)
            {
                if (words[i] == enteredWord) { return true; }
                
            }
            return false;
        }



        public void reset()
        {
            activeLetterNum = 0;
            var panelsWithTag = Controls.OfType<Panel>().Where(panel => panel.Tag != null && panel.Tag.ToString() == "Panels");

            foreach (var panel in panelsWithTag)
            {
                panel.BackColor = Color.Silver;
            }

            foreach (Label letter in letters)
            {
                letter.Text = "";
            }
        }

        public int activeLetterNum = 1;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (activeLetterNum == 1)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter11.Text = "";
                    enteredWord = enteredWord.Remove(0, 1).Insert(0, " ");
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter11.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(0, 1).Insert(0, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 2)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter12.Text = "";
                    enteredWord = enteredWord.Remove(0, 1).Insert(1, " ");
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter12.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(1, 1).Insert(1, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 3)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter13.Text = "";
                    activeLetterNum--;
                    enteredWord = enteredWord.Remove(1, 1).Insert(2, " ");
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter13.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(2, 1).Insert(2, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 4)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter14.Text = "";
                    activeLetterNum--;
                    enteredWord = enteredWord.Remove(2, 1).Insert(3, " ");
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter14.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(3, 1).Insert(3, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 5)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter15.Text = "";
                    activeLetterNum--;
                    enteredWord = enteredWord.Remove(3, 1).Insert(4, " ");
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter15.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(4, 1).Insert(4, e.KeyCode.ToString());
                }
            }
            else if (activeLetterNum == 6)
            {
                if (e.KeyCode == Keys.Back)
                {
                    enteredWord = enteredWord.Remove(3, 1).Insert(4, " ");
                    letter21.Text = "";
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter21.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(0, 1).Insert(0, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 7)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter22.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter22.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(1, 1).Insert(1, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 8)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter23.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter23.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(2, 1).Insert(2, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 9)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter24.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter24.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(3, 1).Insert(3, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 10)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter25.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter25.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(4, 1).Insert(4, e.KeyCode.ToString());
                }
            }
            else if (activeLetterNum == 11)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter31.Text = "";
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter31.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(0, 1).Insert(0, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 12)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter32.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter32.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(1, 1).Insert(1, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 13)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter33.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter33.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(2, 1).Insert(2, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 14)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter34.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter34.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(3, 1).Insert(3, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 15)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter35.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter35.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(4, 1).Insert(4, e.KeyCode.ToString());
                }
            }
            else if (activeLetterNum == 16)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter41.Text = "";
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter41.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(0, 1).Insert(0, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 17)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter42.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter42.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(1, 1).Insert(1, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 18)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter43.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter43.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(2, 1).Insert(2, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 19)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter44.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter44.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(3, 1).Insert(3, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 20)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter45.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter45.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(4, 1).Insert(4, e.KeyCode.ToString());
                }
            }
            else if (activeLetterNum == 21)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter51.Text = "";
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter51.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(0, 1).Insert(0, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 22)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter52.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter52.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(1, 1).Insert(1, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 23)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter53.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter53.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(2, 1).Insert(2, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 24)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter54.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter54.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(3, 1).Insert(3, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 25)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter55.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter55.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(4, 1).Insert(4, e.KeyCode.ToString());
                }
            }
            else if (activeLetterNum == 26)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter61.Text = "";
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter61.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(0, 1).Insert(0, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 27)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter62.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter62.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(1, 1).Insert(1, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 28)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter63.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter63.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(2, 1).Insert(2, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 29)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter64.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter64.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(3, 1).Insert(3, e.KeyCode.ToString());
                    activeLetterNum++;
                }
            }
            else if (activeLetterNum == 30)
            {
                if (e.KeyCode == Keys.Back)
                {
                    letter65.Text = "";
                    activeLetterNum--;
                }
                else if (e.KeyCode != Keys.Enter)
                {
                    letter65.Text = e.KeyCode.ToString();
                    enteredWord = enteredWord.Remove(4, 1).Insert(4, e.KeyCode.ToString());
                }
            }
            //ввод 1 первой строчки
            if (e.KeyCode == Keys.Enter && activeLetterNum == 5 && wordIsInList())
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((enteredWord.Substring(i, 1) == thoughtWord.Substring(j, 1)))
                        { 
                            if(i == 0){panel1.BackColor = Color.Yellow;}
                            if(i == 1){panel2.BackColor = Color.Yellow;}
                            if(i == 2){panel3.BackColor = Color.Yellow;}
                            if(i == 3){panel4.BackColor = Color.Yellow;}
                            if(i == 4){panel5.BackColor = Color.Yellow;}
                        }
                    }
                    if ((enteredWord.Substring(i, 1) == thoughtWord.Substring(i, 1)))
                    {
                        if (i == 0)
                        {
                            panel1.BackColor = Color.Green;
                        }
                        else if (i == 1)
                        {
                            panel2.BackColor = Color.Green;
                        }
                        else if (i == 2)
                        {
                            panel3.BackColor = Color.Green;
                        }
                        else if (i == 3)
                        {
                            panel4.BackColor = Color.Green;
                        }
                        else if (i == 4)
                        {
                            panel5.BackColor = Color.Green;
                        }
                    }
                    
                }
                if(panel1.BackColor == panel2.BackColor && panel2.BackColor == panel3.BackColor  && panel3.BackColor == panel4.BackColor && panel4.BackColor == panel5.BackColor && panel5.BackColor == Color.Green)
                {
                    gsd++;
                    guessed.Text = gsd.ToString();
                    DialogResult result = MessageBox.Show($"Вы отгадали слово {thoughtWord} \nСледующее слово?", "Вы отгадали слово!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                    if(result == DialogResult.Yes) 
                    {
                        changeThoughtWord();
                        reset();

                    }
                    else { reset(); }
                }

                activeLetterNum++;
                enteredWord = "     ";
            }
            else if (e.KeyCode == Keys.Enter && activeLetterNum == 5 && !wordIsInList()) { MessageBox.Show("такого слова нет в словаре"); }
                //ввод 2 второй строчки
            if (e.KeyCode == Keys.Enter && activeLetterNum == 10 && wordIsInList())
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((enteredWord.Substring(i, 1) == thoughtWord.Substring(j, 1)))
                        {
                            if (i == 0) { panel6.BackColor = Color.Yellow; }
                            if (i == 1) { panel7.BackColor = Color.Yellow; }
                            if (i == 2) { panel8.BackColor = Color.Yellow; }
                            if (i == 3) { panel9.BackColor = Color.Yellow; }
                            if (i == 4) { panel10.BackColor = Color.Yellow; }
                        }
                    }
                    if ((enteredWord.Substring(i, 1) == thoughtWord.Substring(i, 1)))
                    {
                        if (i == 0)
                        {
                            panel6.BackColor = Color.Green;
                        }
                        else if (i == 1)
                        {
                            panel7.BackColor = Color.Green;
                        }
                        else if (i == 2)
                        {
                            panel8.BackColor = Color.Green;
                        }
                        else if (i == 3)
                        {
                            panel9.BackColor = Color.Green;
                        }
                        else if (i == 4)
                        {
                            panel10.BackColor = Color.Green;
                        }
                    }

                }
                if (panel6.BackColor == panel7.BackColor && panel7.BackColor == panel8.BackColor && panel8.BackColor == panel9.BackColor && panel9.BackColor == panel10.BackColor && panel10.BackColor == Color.Green)
                {
                    gsd++;
                    guessed.Text = gsd.ToString();
                    DialogResult result = MessageBox.Show($"Вы отгадали слово {thoughtWord} \nСледующее слово?", "Вы отгадали слово!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                    if (result == DialogResult.Yes)
                    {
                        changeThoughtWord();
                        reset();
                    }
                    else { reset(); }
                }

                activeLetterNum++;
                enteredWord = "     ";
            }
            else if (e.KeyCode == Keys.Enter && activeLetterNum == 10 && !wordIsInList()) { MessageBox.Show("такого слова нет в словаре"); }
            //ввод 3 третьей строчки
            if (e.KeyCode == Keys.Enter && activeLetterNum == 15 && wordIsInList())
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((enteredWord.Substring(i, 1) == thoughtWord.Substring(j, 1)))
                        {
                            if (i == 0) { panel11.BackColor = Color.Yellow; }
                            if (i == 1) { panel12.BackColor = Color.Yellow; }
                            if (i == 2) { panel13.BackColor = Color.Yellow; }
                            if (i == 3) { panel14.BackColor = Color.Yellow; }
                            if (i == 4) { panel15.BackColor = Color.Yellow; }
                        }
                    }
                    if ((enteredWord.Substring(i, 1) == thoughtWord.Substring(i, 1)))
                    {
                        if (i == 0)
                        {
                            panel11.BackColor = Color.Green;
                        }
                        else if (i == 1)
                        {
                            panel12.BackColor = Color.Green;
                        }
                        else if (i == 2)
                        {
                            panel13.BackColor = Color.Green;
                        }
                        else if (i == 3)
                        {
                            panel14.BackColor = Color.Green;
                        }
                        else if (i == 4)
                        {
                            panel15.BackColor = Color.Green;
                        }
                    }

                }
                if (panel11.BackColor == panel12.BackColor && panel12.BackColor == panel13.BackColor && panel13.BackColor == panel14.BackColor && panel14.BackColor == panel15.BackColor && panel15.BackColor == Color.Green)
                {
                    gsd++;
                    guessed.Text = gsd.ToString();
                    DialogResult result = MessageBox.Show($"Вы отгадали слово {thoughtWord} \nСледующее слово?", "Вы отгадали слово!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                    if (result == DialogResult.Yes)
                    {
                        changeThoughtWord();
                        reset();

                    }
                    else { reset(); }
                }

                activeLetterNum++;
                enteredWord = "     ";
            }
            else if (e.KeyCode == Keys.Enter && activeLetterNum == 15 && !wordIsInList()) { MessageBox.Show("такого слова нет в словаре"); }
            //ввод 4 четвертой строчки
            if (e.KeyCode == Keys.Enter && activeLetterNum == 20 && wordIsInList())
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((enteredWord.Substring(i, 1) == thoughtWord.Substring(j, 1)))
                        {
                            if (i == 0) { panel16.BackColor = Color.Yellow; }
                            if (i == 1) { panel17.BackColor = Color.Yellow; }
                            if (i == 2) { panel18.BackColor = Color.Yellow; }
                            if (i == 3) { panel19.BackColor = Color.Yellow; }
                            if (i == 4) { panel20.BackColor = Color.Yellow; }
                        }
                    }
                    if ((enteredWord.Substring(i, 1) == thoughtWord.Substring(i, 1)))
                    {
                        if (i == 0)
                        {
                            panel16.BackColor = Color.Green;
                        }
                        else if (i == 1)
                        {
                            panel17.BackColor = Color.Green;
                        }
                        else if (i == 2)
                        {
                            panel18.BackColor = Color.Green;
                        }
                        else if (i == 3)
                        {
                            panel19.BackColor = Color.Green;
                        }
                        else if (i == 4)
                        {
                            panel20.BackColor = Color.Green;
                        }
                    }

                }
                if (panel16.BackColor == panel17.BackColor && panel17.BackColor == panel18.BackColor && panel18.BackColor == panel19.BackColor && panel19.BackColor == panel20.BackColor && panel20.BackColor == Color.Green)
                {
                    gsd++;
                    guessed.Text = gsd.ToString();
                    DialogResult result = MessageBox.Show($"Вы отгадали слово {thoughtWord} \nСледующее слово?", "Вы отгадали слово!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                    if (result == DialogResult.Yes)
                    {
                        changeThoughtWord();
                        reset();
                    }
                    else { reset(); }
                }

                activeLetterNum++;
                enteredWord = "     ";
            }
            else if (e.KeyCode == Keys.Enter && activeLetterNum == 20 && !wordIsInList()) { MessageBox.Show("такого слова нет в словаре"); }
            //ввод 5 строчки
            if (e.KeyCode == Keys.Enter && activeLetterNum == 25 && wordIsInList())
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((enteredWord.Substring(i, 1) == thoughtWord.Substring(j, 1)))
                        {
                            if (i == 0) { panel21.BackColor = Color.Yellow; }
                            if (i == 1) { panel22.BackColor = Color.Yellow; }
                            if (i == 2) { panel23.BackColor = Color.Yellow; }
                            if (i == 3) { panel24.BackColor = Color.Yellow; }
                            if (i == 4) { panel25.BackColor = Color.Yellow; }
                        }
                    }
                    if ((enteredWord.Substring(i, 1) == thoughtWord.Substring(i, 1)))
                    {
                        if (i == 0)
                        {
                            panel21.BackColor = Color.Green;
                        }
                        else if (i == 1)
                        {
                            panel22.BackColor = Color.Green;
                        }
                        else if (i == 2)
                        {
                            panel23.BackColor = Color.Green;
                        }
                        else if (i == 3)
                        {
                            panel24.BackColor = Color.Green;
                        }
                        else if (i == 4)
                        {
                            panel25.BackColor = Color.Green;
                        }
                    }

                }
                if (panel21.BackColor == panel22.BackColor && panel22.BackColor == panel23.BackColor && panel23.BackColor == panel24.BackColor && panel24.BackColor == panel25.BackColor && panel25.BackColor == Color.Green)
                {
                    gsd++;
                    guessed.Text = gsd.ToString();
                    DialogResult result = MessageBox.Show($"Вы отгадали слово {thoughtWord} \nСледующее слово?", "Вы отгадали слово!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                    if (result == DialogResult.Yes)
                    {
                        changeThoughtWord();
                        reset();
                    }
                    else { reset(); }
                }

                activeLetterNum++;
                enteredWord = "     ";
            }
            else if (e.KeyCode == Keys.Enter && activeLetterNum == 25 && !wordIsInList()) { MessageBox.Show("такого слова нет в словаре"); }
            //ввод 6 строчки
            if (e.KeyCode == Keys.Enter && activeLetterNum == 30 && wordIsInList())
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((enteredWord.Substring(i, 1) == thoughtWord.Substring(j, 1)))
                        {
                            if (i == 0) { panel26.BackColor = Color.Yellow; }
                            if (i == 1) { panel27.BackColor = Color.Yellow; }
                            if (i == 2) { panel28.BackColor = Color.Yellow; }
                            if (i == 3) { panel29.BackColor = Color.Yellow; }
                            if (i == 4) { panel30.BackColor = Color.Yellow; }
                        }
                    }
                    if ((enteredWord.Substring(i, 1) == thoughtWord.Substring(i, 1)))
                    {
                        if (i == 0)
                        {
                            panel26.BackColor = Color.Green;
                        }
                        else if (i == 1)
                        {
                            panel27.BackColor = Color.Green;
                        }
                        else if (i == 2)
                        {
                            panel28.BackColor = Color.Green;
                        }
                        else if (i == 3)
                        {
                            panel29.BackColor = Color.Green;
                        }
                        else if (i == 4)
                        {
                            panel30.BackColor = Color.Green;
                        }
                    }

                }
                if (panel26.BackColor == panel27.BackColor && panel27.BackColor == panel28.BackColor && panel28.BackColor == panel29.BackColor && panel29.BackColor == panel30.BackColor && panel30.BackColor == Color.Green)
                {
                    gsd++;
                    guessed.Text = gsd.ToString();
                    DialogResult result = MessageBox.Show($"Вы отгадали слово {thoughtWord} \nСледующее слово?", "Вы отгадали слово!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                    if (result == DialogResult.Yes)
                    {
                        changeThoughtWord();
                        reset();
                    }
                    else { reset(); }
                }
                else
                {
                    unGsd++;
                    unGuessed.Text = unGsd.ToString();
                    DialogResult result = MessageBox.Show($"Вы не отгадали слово {thoughtWord} \nСледующее слово?", "Вы не отгадали слово(((", MessageBoxButtons.YesNo, MessageBoxIcon.Error); ;
                    if (result == DialogResult.Yes)
                    {
                        changeThoughtWord();
                        reset();
                    }
                    else { reset(); }
                }

                activeLetterNum++;
                enteredWord = "     ";
            }
            else if (e.KeyCode == Keys.Enter && activeLetterNum == 30 && !wordIsInList()) { MessageBox.Show("такого слова нет в словаре"); }
            else if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }

}
