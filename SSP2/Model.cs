using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSP2.Model
{
    public class Model
    {
        public Action<int,int,int,int> OnStavkaDoes;

        private int check = 1, round = 1, PlayerWins, OpponentWins, PlayerRoundsWins, OpponentRoundsWins, PlayerPoints,OpponentPoints,PlayerStavka,OpponentStavka;
        private bool On = false;
        private double Bonus;
        Random rand = new Random();


        public void StavkaDoes(int playerStavka,int playerPoints, int opponentPoints)
        {
            PlayerStavka = playerStavka;
            PlayerPoints = playerPoints;
            OpponentPoints = opponentPoints;
            if (check == 1)
            {
                PlayerStavka = 200;
                OpponentStavka = 200;
                
                check++;
                OnStavkaDoes?.Invoke(PlayerStavka, OpponentStavka, PlayerPoints, OpponentPoints);
            }
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
                    StavkaError.Text = $"Ваша ставка слишком большая или маленькая.\nМинимальная:{PP / 100 * 20}\nМаксимальная:{PP / 100 * 40}";
                }
            }
        }
    }
}
