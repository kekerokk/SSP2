using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSP2
{
    public partial class Form1 : Form
    {
        private int check = 1, stavka = 100, round,PlayerWins,OpponentWins;
        private bool On = false;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            Form F2 = new Form2();
            F2.Show(this);
        }
        LeaderBoard LB = new LeaderBoard();

        private void Form1_Enter(object sender, EventArgs e)
        {
            NickName.Text = StaticData.Nick;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                stavka = 200;
                Stavka.Text = "200";
                Stavka.ReadOnly = false;
                Stavka.Enabled = false;
                PlayerPoints.Text = Convert.ToString(Convert.ToInt32(PlayerPoints.Text) - stavka);
                StavkaPlayer.Text = $"{stavka}";
                OpponentPoints.Text = Convert.ToString(Convert.ToInt32(OpponentPoints.Text) - stavka);
                StavkaOpponenta.Text = $"{stavka}";
                OnnEnable();
                button7.Enabled = false;
                check++;
            }
            else
            {
                stavka = Convert.ToInt32(Stavka.Text);
                
                int PP = Convert.ToInt32(PlayerPoints.Text);
                int OP = Convert.ToInt32(OpponentPoints.Text);

                if (stavka >= PP / 100 * 20 && stavka <= PP / 100 * 50)
                {
                    StavkaPlayer.Text = $"{stavka}";
                    PlayerPoints.Text = Convert.ToString(Convert.ToInt32(PlayerPoints.Text) - stavka);
                    Stavka.ReadOnly = false;
                    Stavka.Enabled = false;
                    // ИИ противника
                    StavkaOpponenta.Text = Convert.ToString(rand.Next(OP / 100 * 20, OP / 100 * 50));
                    OpponentPoints.Text = Convert.ToString(Convert.ToInt32(OpponentPoints.Text) - Convert.ToInt32(StavkaOpponenta.Text));
                    button7.Enabled = false;
                    check++;
                    OnnEnable();
                    MiddleText.Text = "VS";
                }
                else
                {
                    StavkaError.Text = $"Ваша ставка слишком большая или маленькая.\nМинимальная:{PP/100*20}\nМаксимальная:{PP/100*50}";
                }
            }
        }

        public void ChooseSSP(int Choose)
        {
            int BotChoose;
            BotChoose = rand.Next(1, 3);
            if(Choose == 1 && BotChoose == 1) //ничья камни
            {
                Scissors.Visible = false;
                Paper.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                Rock.Enabled = false;
                button6.Enabled = false;
                Draw();
            }
            if (Choose == 2 && BotChoose == 2) //ничья ножницы
            {
                Rock.Visible = false;
                Paper.Visible = false;
                button4.Visible = false;
                button6.Visible = false;
                Scissors.Enabled = false;
                button5.Enabled = false;
                Draw();
            }
            if (Choose == 3 && BotChoose == 3) //ничья бумага
            {
                Scissors.Visible = false;
                Rock.Visible = false;

                button6.Visible = false;
                button5.Visible = false;

                Paper.Enabled = false;
                button4.Enabled = false;
                Draw();
            }

            if (Choose == 1 && BotChoose == 2) // Камень и ножницы
            {
                Scissors.Visible = false;
                Paper.Visible = false;

                button6.Visible = false;
                button4.Visible = false;

                Rock.Enabled = false;
                button4.Enabled = false;
                PlayerWin();
            }
            if (Choose == 2 && BotChoose == 3) // ножницы и бумага
            {
                Rock.Visible = false;
                Paper.Visible = false;

                button6.Visible = false;
                button5.Visible = false;

                Scissors.Enabled = false;
                button5.Enabled = false;
                PlayerWin();
            }
            if (Choose == 3 && BotChoose == 1) // бумага и камень
            {
                Scissors.Visible = false;
                Rock.Visible = false;

                button5.Visible = false;
                button4.Visible = false;

                Paper.Enabled = false;
                button6.Enabled = false;
                PlayerWin();
            }

            if (Choose == 1 && BotChoose == 3) // Камень и бумага
            {
                Scissors.Visible = false;
                Paper.Visible = false;

                button5.Visible = false;
                button6.Visible = false;

                Rock.Enabled = false;
                button4.Enabled = false;
                PlayerLose();
            }
            if (Choose == 2 && BotChoose == 1) // ножницы и камень
            {
                Rock.Visible = false;
                Paper.Visible = false;

                button5.Visible = false;
                button4.Visible = false;

                Scissors.Enabled = false;
                button6.Enabled = false;
                PlayerLose();
            }
            if (Choose == 3 && BotChoose == 2) // бумага и ножницы
            {
                Scissors.Visible = false;
                Rock.Visible = false;

                button4.Visible = false;
                button6.Visible = false;

                Paper.Enabled = false;
                button5.Enabled = false;
                PlayerLose();
            }

            return;
        }

        private void Draw()
        {
            MiddleText.Text = "Ничья!";
            labelStavka.Text = "Введите ставку:";

            PlayerPoints.Text = $"{Convert.ToInt16(PlayerPoints.Text) + stavka}";
            stavka = 0;
            StavkaPlayer.Text = $"0";

            OpponentPoints.Text = $"{Convert.ToInt32(OpponentPoints.Text) + Convert.ToInt32(StavkaOpponenta.Text)}";
            StavkaOpponenta.Text = "0";
            NextBut.Visible = true;
        }
        private void PlayerLose()
        {
            OpponentWins++;
            MiddleText.Text = "Проигрышь...";
            labelStavka.Text = "Введите ставку:";

            PlayerPoints.Text = $"{Convert.ToInt16(PlayerPoints.Text) - stavka}";
            StavkaPlayer.Text= $"0";

            OpponentPoints.Text = $"{Convert.ToInt16(OpponentPoints.Text) + stavka + Convert.ToInt16(StavkaOpponenta.Text)}";
            StavkaOpponenta.Text = "0";
            NextBut.Visible = true;
        }
        private void PlayerWin()
        {
            PlayerWins++;
            MiddleText.Text = "Победа!";
            labelStavka.Text = "Введите ставку:";

            PlayerPoints.Text = $"{Convert.ToInt16(PlayerPoints.Text) + stavka + Convert.ToInt16(StavkaOpponenta.Text)}";
            StavkaPlayer.Text = $"0";

            OpponentPoints.Text = $"{Convert.ToInt32(OpponentPoints.Text) - Convert.ToInt32(StavkaOpponenta.Text)}";
            StavkaOpponenta.Text = "0";
            NextBut.Visible = true;
        }

        private void Rock_Click(object sender, EventArgs e)
        {
            ChooseSSP(1);
        }
        private void Scissors_Click(object sender, EventArgs e)
        {
            ChooseSSP(2);
        }
        private void Paper_Click(object sender, EventArgs e)
        {
            ChooseSSP(3);
        }

        private void NextBut_Click(object sender, EventArgs e)
        {
            NextBut.Visible = false;
            OnnVisible();
            OffEnable();
            MiddleText.Text = "Делайте ставку...";
            button7.Enabled = true;
            Stavka.Enabled = true;
        }

        private void OnnVisible()
        {
                Rock.Visible = true;
                Scissors.Visible = true;
                Paper.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;

        }
        private void OnnEnable()
        {
            Rock.Enabled = true;
            Scissors.Enabled = true;
            Paper.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }
        private void OffVisible()
        {
            Rock.Visible = false;
            Scissors.Visible = false;
            Paper.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }
        private void OffEnable()
        {
            Rock.Enabled = false;
            Scissors.Enabled = false;
            Paper.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }
    }
}
