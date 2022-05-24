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
        /*private int check = 1, stavka = 100, round = 1,PlayerWins,OpponentWins,PlayerRoundsWins,OpponentRoundsWins;
        private bool On = false;
        private double Bonus;
        Random rand = new Random();*/
        private Controller __controller;

        public Form1(Controller controller)
        {
            InitializeComponent();
            Form F2 = new Form2();
            F2.Show(this);
            __controller = controller;
        }
        //LeaderBoard LB = new LeaderBoard();

        private void Form1_Enter(object sender, EventArgs e)
        {
            NickName.Text = StaticData.Nick;
        }

        public void DoStavky(int playerStavka,int opponentStavka,int opponentPoints,int playerPoints)
        {
            Stavka.Text = $"{Convert.ToString(playerStavka)}";
            Stavka.ReadOnly = false;
            Stavka.Enabled = false;
            PlayerPoints.Text = Convert.ToString(playerPoints - playerStavka);
            StavkaPlayer.Text = $"{playerStavka}";
            OpponentPoints.Text = Convert.ToString(opponentPoints - opponentStavka);
            StavkaOpponenta.Text = $"{opponentStavka}";
            OnnEnable();
            button7.Enabled = false;
            MiddleText.Text = "VS";
        }
        public void ErrorStavka(int minStavka,int maxStavka)
        {
            StavkaError.Text = $"Ваша ставка слишком большая или маленькая.\nМинимальная:{minStavka}\nМаксимальная:{maxStavka}";
        }

        public void button7_Click(object sender, EventArgs e)
        {
            int playerStavka = Convert.ToInt32(PlayerStavka.Text);
            int playerPoints = Convert.ToInt32(PlayerPoints.Text);
            int opponentPoints = Convert.ToInt32(OpponentPoints.Text);
            __controller.stavkaDoes(playerStavka,playerPoints,opponentPoints);

            else
            {
                stavka = Convert.ToInt32(Stavka.Text);
                
                int PP = Convert.ToInt32(PlayerPoints.Text);
                int OP = Convert.ToInt32(OpponentPoints.Text);

                if (stavka >= PP / 100 * 20 && stavka <= PP / 100 * 40)
                {
                    StavkaPlayer.Text = $"{stavka}";
                    PlayerPoints.Text = Convert.ToString(Convert.ToInt32(PlayerPoints.Text) - stavka);
                    Stavka.ReadOnly = false;
                    Stavka.Enabled = false;
                    // ИИ противника
                    StavkaOpponenta.Text = Convert.ToString(rand.Next(OP / 100 * 20, OP / 100 * 40));
                    OpponentPoints.Text = Convert.ToString(Convert.ToInt32(OpponentPoints.Text) - Convert.ToInt32(StavkaOpponenta.Text));
                    button7.Enabled = false;
                    check++;
                    OnnEnable();
                    MiddleText.Text = "VS";
                }
                else
                {
                    StavkaError.Text = $"Ваша ставка слишком большая или маленькая.\nМинимальная:{PP/100*20}\nМаксимальная:{PP/100*40}";
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
            OpponentScore.Text = Convert.ToString(OpponentWins);
            MiddleText.Text = "Проигрышь...";

            StavkaPlayer.Text= $"0";

            OpponentPoints.Text = $"{Convert.ToInt16(OpponentPoints.Text) + (stavka + Convert.ToInt16(StavkaOpponenta.Text)) * (1 + Bonus)}";
            StavkaOpponenta.Text = "0";
            if (PlayerWins == 3 || OpponentWins == 3)
                FinishRound();
            else
                NextBut.Visible = true;
        }
        private void PlayerWin()
        {
            int SP = Convert.ToInt32(PlayerStavka.Text);
            int SO = Convert.ToInt32(StavkaOpponenta.Text);
            PlayerWins++;
            CheckStavok();
            PlayerScore.Text = Convert.ToString(PlayerWins);
            MiddleText.Text = "Победа!";

            if(SP>SO)
                PlayerPoints.Text = $"{Convert.ToInt16(PlayerPoints.Text) + (stavka + Convert.ToInt16(StavkaOpponenta.Text))*(1+Bonus)}";
            StavkaPlayer.Text = $"0";

            StavkaOpponenta.Text = "0";
            if(PlayerWins == 3 || OpponentWins == 3)
                FinishRound();
            else
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(check>1)
                Stavka.Text = Convert.ToString(Convert.ToInt32(PlayerPoints.Text) / 100 * 20);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(check>1)
                Stavka.Text = Convert.ToString(Convert.ToInt32(PlayerPoints.Text) / 100 * 40);
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            ChooseSSP(3);
        }

        private void NextBut_Click(object sender, EventArgs e)
        {
            NextBut.Text = "Следующая разыгровка";
                labelStavka.Text = "Введите ставку:";
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

        private void FinishRound()
        {
            if (PlayerWins > OpponentWins)
            {
                MiddleText.Text = $"В {round} раунде побеждает {StaticData.Nick}!";
                check = 1;
                round++;
                PlayerRoundsWins++;
                PlayerScore.Text = "0";
                OpponentScore.Text = "0";
                PlayerWins = 0;
                OpponentWins = 0;

                if (PlayerRoundsWins == 1)
                    PlayerSumPointsRound1.Text = PlayerPoints.Text;
                else if (PlayerRoundsWins == 2)
                    PlayerSumPointsRound2.Text = PlayerPoints.Text;
                else if (PlayerRoundsWins == 3)
                {
                    PlayerSumPointsRound3.Text = PlayerPoints.Text;
                    MiddleText.Text = $"Поздравляем, вы выиграли игру!\nВаш суммарный счет:{Convert.ToInt32(PlayerSumPointsRound1.Text) + Convert.ToInt32(PlayerSumPointsRound2.Text) + Convert.ToInt32(PlayerSumPointsRound3.Text)}";
                    OffVisible();
                    return;
                }

                PlayerPoints.Text = "1000";
                OpponentPoints.Text = "1000";
                Stavka.Text = "200";
                NextBut.Text = "Начать следующий раунд";
                NextBut.Visible = true;
            }
            else
            {
                MiddleText.Text = $"В {round} раунде побеждает РООБОТ_БОТ!";
                check = 1;
                round++;
                OpponentRoundsWins++;
                PlayerScore.Text = "0";
                OpponentScore.Text = "0";
                PlayerWins = 0;
                OpponentWins = 0;

                if (OpponentRoundsWins == 1)
                    OpponentSumPointsRound1.Text = OpponentPoints.Text;
                else if (OpponentRoundsWins == 2)
                    OpponentSumPointsRound2.Text = OpponentPoints.Text;
                else if (OpponentRoundsWins == 3)
                {
                    OpponentSumPointsRound3.Text = PlayerPoints.Text;
                    MiddleText.Text = $"Увы, вы проиграли игру.\nСуммарный счет РООБОТа_БОТа:{Convert.ToInt32(OpponentSumPointsRound1.Text) + Convert.ToInt32(OpponentSumPointsRound2.Text) + Convert.ToInt32(OpponentSumPointsRound3.Text)}";
                    OffVisible();
                    return;
                }

                PlayerPoints.Text = "1000";
                OpponentPoints.Text = "1000";
                Stavka.Text = "200";
                NextBut.Text = "Начать следующий раунд";
                NextBut.Visible = true;
            }
        }

        private void CheckStavok()
        {
            if(PlayerStavka.Text != StavkaOpponenta.Text)
            {
                int SP = Convert.ToInt16(PlayerStavka.Text);
                int SO = Convert.ToInt16(StavkaOpponenta.Text);
                if (SP > SO)
                    Bonus = SO / SP;
                else
                    Bonus = SP / SO;
                if (Bonus > 0.5f)
                    Bonus = 0.5;
            }
        }

        private void StavkaDoes(object sender, EventArgs e)
        {

        }
    }
}
