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
            int playerStavka = Convert.ToInt32(Stavka.Text);
            int playerPoints = Convert.ToInt32(PlayerPoints.Text);
            int opponentPoints = Convert.ToInt32(OpponentPoints.Text);
            __controller.stavkaDoes(playerStavka,playerPoints,opponentPoints);
        }

        public void ChooseSSP(int Choose, int BotChoose)
        {
            if (Choose == 1 && BotChoose == 1) //ничья камни
            {
                Scissors.Visible = false;
                Paper.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                Rock.Enabled = false;
                button6.Enabled = false;
                __controller.result("Ничья!");
            }
            if (Choose == 2 && BotChoose == 2) //ничья ножницы
            {
                Rock.Visible = false;
                Paper.Visible = false;
                button4.Visible = false;
                button6.Visible = false;
                Scissors.Enabled = false;
                button5.Enabled = false;
                __controller.result("Ничья!");
            }
            if (Choose == 3 && BotChoose == 3) //ничья бумага
            {
                Scissors.Visible = false;
                Rock.Visible = false;

                button6.Visible = false;
                button5.Visible = false;

                Paper.Enabled = false;
                button4.Enabled = false;
                __controller.result("Ничья!");
            }

            if (Choose == 1 && BotChoose == 2) // Камень и ножницы
            {
                Scissors.Visible = false;
                Paper.Visible = false;

                button6.Visible = false;
                button4.Visible = false;

                Rock.Enabled = false;
                button4.Enabled = false;
                __controller.result("Выигрышь!");
            }
            if (Choose == 2 && BotChoose == 3) // ножницы и бумага
            {
                Rock.Visible = false;
                Paper.Visible = false;

                button6.Visible = false;
                button5.Visible = false;

                Scissors.Enabled = false;
                button5.Enabled = false;
                __controller.result("Выигрышь!");
            }
            if (Choose == 3 && BotChoose == 1) // бумага и камень
            {
                Scissors.Visible = false;
                Rock.Visible = false;

                button5.Visible = false;
                button4.Visible = false;

                Paper.Enabled = false;
                button6.Enabled = false;
                __controller.result("Выигрышь!");
            }

            if (Choose == 1 && BotChoose == 3) // Камень и бумага
            {
                Scissors.Visible = false;
                Paper.Visible = false;

                button5.Visible = false;
                button6.Visible = false;

                Rock.Enabled = false;
                button4.Enabled = false;
                __controller.result("Проигрышь!");
            }
            if (Choose == 2 && BotChoose == 1) // ножницы и камень
            {
                Rock.Visible = false;
                Paper.Visible = false;

                button5.Visible = false;
                button4.Visible = false;

                Scissors.Enabled = false;
                button6.Enabled = false;
                __controller.result("Проигрышь!");
            }
            if (Choose == 3 && BotChoose == 2) // бумага и ножницы
            {
                Scissors.Visible = false;
                Rock.Visible = false;

                button4.Visible = false;
                button6.Visible = false;

                Paper.Enabled = false;
                button5.Enabled = false;
                __controller.result("Проигрышь!");
            }

            return;
        }

        public void Result(int playerStavka,int opponentStavka,int playerPoints, int opponentPoints, string middleText,int PlayerWins,int OpponentWins)
        {
            MiddleText.Text = middleText;
            labelStavka.Text = "Введите ставку:";

            PlayerPoints.Text = Convert.ToString(playerPoints);
            StavkaPlayer.Text = Convert.ToString(playerStavka);
            Stavka.Text = Convert.ToString(playerStavka);

            OpponentPoints.Text = Convert.ToString(opponentPoints);
            StavkaOpponenta.Text = Convert.ToString(opponentStavka);

            OpponentScore.Text = Convert.ToString(OpponentWins);
            PlayerScore.Text = Convert.ToString(PlayerWins);

            NextBut.Visible = true;
        }

        private void Rock_Click(object sender, EventArgs e)
        {
            __controller.sspchoosen(1);
        }
        private void Scissors_Click(object sender, EventArgs e)
        {
            __controller.sspchoosen(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stavka.Text = $"{__controller.maxstavka()}";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Stavka.Text = $"{__controller.minstavka()}";
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            __controller.sspchoosen(3);
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

        public void FinishRound(int RoundsWins, string middleText,string playerOropponent)
        {
            if (playerOropponent == "player")
            {
                MiddleText.Text = $"{middleText}";
                PlayerScore.Text = "0";
                OpponentScore.Text = "0";

                if (RoundsWins == 1)
                    PlayerSumPointsRound1.Text = PlayerPoints.Text;
                else if (RoundsWins == 2)
                    PlayerSumPointsRound2.Text = PlayerPoints.Text;
                else if (RoundsWins == 3)
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
                MiddleText.Text = $"{middleText}";
                PlayerScore.Text = "0";
                OpponentScore.Text = "0";

                if (RoundsWins == 1)
                    OpponentSumPointsRound1.Text = OpponentPoints.Text;
                else if (RoundsWins == 2)
                    OpponentSumPointsRound2.Text = OpponentPoints.Text;
                else if (RoundsWins == 3)
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
        private void StavkaDoes(object sender, EventArgs e)
        {

        }
    }
}
