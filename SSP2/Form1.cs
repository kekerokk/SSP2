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
        private int check = 1, stavka = 100, round;
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
            EventManager.OnChoosedSSP += ChooseSSP;
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
                PlayerStavka.Text = $"{PlayerStavka.Text}{stavka}";
                OpponentPoints.Text = Convert.ToString(Convert.ToInt32(OpponentPoints.Text) - stavka);
                OpponentStavka.Text = $"{OpponentStavka.Text}{stavka}";
                Onn();
                button7.Enabled = false;
            }
            else
            {
                stavka = Convert.ToInt32(Stavka.Text);
                
                int PP = Convert.ToInt32(PlayerPoints.Text);
                int OP = Convert.ToInt32(OpponentPoints.Text);
                if (stavka >= PP / 100 * 20 && stavka <= PP / 100 * 50)
                {
                    PlayerStavka.Text = $"{PlayerStavka.Text}{stavka}";
                    PlayerPoints.Text = Convert.ToString(Convert.ToInt32(PlayerPoints.Text) - stavka);
                    Stavka.ReadOnly = false;
                    Stavka.Enabled = false;
                    // ИИ противника
                    OpponentStavka.Text = Convert.ToString(rand.Next(OP / 100 * 20, OP / 100 * 50));
                    OpponentPoints.Text = Convert.ToString(Convert.ToInt32(OpponentPoints) - Convert.ToInt32(OpponentStavka));
                    button7.Enabled = false;
                    Onn();
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
            if(Choose == 1 && BotChoose == 1)
            {
                Scissors.Visible = false;
                Paper.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                Rock.Enabled = false;
                button6.Enabled = false;
                Draw();
            }
        }

        private void Draw()
        {
            MiddleText.Text = "Ничья!";
            Rounds.Text = $"{Convert.ToInt16(Rounds.Text) + 1}";
            labelStavka.Text = "Введите ставку:";

            PlayerPoints.Text = $"{Convert.ToInt16(PlayerPoints.Text) + stavka}";
            PlayerStavka.Text = $"0";

            OpponentPoints.Text = $"{Convert.ToInt16(OpponentPoints.Text) + Convert.ToInt16(OpponentStavka.Text)}";
            OpponentStavka.Text = "0";
            NextBut.Visible = true;
        }

        private void Rock_Click(object sender, EventArgs e)
        {
            EventManager.OnChoosedSSP?.Invoke(1);
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            EventManager.OnChoosedSSP?.Invoke(2);
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            EventManager.OnChoosedSSP?.Invoke(3);
        }

        private void Onn()
        {
                Rock.Visible = true;
                Scissors.Visible = true;
                Paper.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                Rock.Enabled = true;
                Scissors.Enabled = true;
                Paper.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;

        }
        private void Off()
        {
            Rock.Visible = false;
            Scissors.Visible = false;
            Paper.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            Rock.Enabled = false;
            Scissors.Enabled = false;
            Paper.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }
    }
}
