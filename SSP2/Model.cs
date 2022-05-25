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
        public Action<int, int> OnSSPChoosen;
        public Action<int, int> OnErrorStavka;
        public Action<int, int, int, int, string,int,int> OnResult;
        public Action<int, string, string> OnFinishedChecks;

        private int check = 1, round = 1, PlayerWins, OpponentWins, PlayerRoundsWins, OpponentRoundsWins, PlayerPoints,OpponentPoints,PlayerStavka,OpponentStavka;
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
                PlayerPoints -= PlayerStavka;
                OpponentRoundsWins -= OpponentStavka;
                
                check++;
                OnStavkaDoes?.Invoke(PlayerStavka, OpponentStavka, PlayerPoints, OpponentPoints);
            }
            else
            {
                if (PlayerStavka >= PlayerPoints / 100 * 20 && PlayerStavka <= PlayerStavka / 100 * 40)
                {
                    PlayerStavka = playerStavka;
                    PlayerPoints = playerPoints;
                    OpponentPoints = opponentPoints;
                    OpponentStavka = rand.Next(OpponentPoints / 100 * 20, OpponentPoints / 100 * 40);

                    PlayerPoints -= PlayerStavka;
                    OpponentRoundsWins -= OpponentStavka;

                    OnStavkaDoes?.Invoke(PlayerStavka, OpponentStavka, PlayerPoints, OpponentPoints);
                }
                else
                {
                    OnErrorStavka?.Invoke(PlayerPoints / 100 * 20, PlayerPoints / 100 * 40);
                }
            }
        }
        public void SSPChoosen(int Choosen)
        {
            int BotChoose;
            BotChoose = rand.Next(1, 3);
            OnSSPChoosen?.Invoke(Choosen, BotChoose);
        }
        public void ErrorStavka()
        {
            int min = PlayerPoints / 100 * 20;
            int max = PlayerPoints / 100 * 40;
            OnErrorStavka?.Invoke(min, max);
        }
        public void Result(string middleText)
        {
            if (middleText == "Ничья!")
            {
                PlayerPoints += PlayerStavka;
                PlayerStavka = 0;
                OpponentPoints += OpponentStavka;
                OpponentStavka = 0;
            }
            if (middleText == "Выигрышь!")
            {
                PlayerPoints += PlayerStavka + OpponentStavka;
                PlayerStavka = 0;
                OpponentStavka = 0;
                PlayerWins++;
            }
            if (middleText == "Проигрышь!")
            {
                OpponentPoints += PlayerStavka + OpponentStavka;
                PlayerStavka = 0;
                OpponentStavka = 0;
                OpponentWins++;
            }
            
            if(PlayerWins == 3 || OpponentWins == 3)
            {
                if (PlayerWins > OpponentWins)
                {
                    middleText = $"В {round} раунде побеждает {StaticData.Nick}!";
                    check = 1;
                    round++;
                    PlayerRoundsWins++;
                    PlayerWins = 0;
                    OpponentWins = 0;
                    OpponentPoints = 1000;
                    PlayerPoints = 1000;

                    OnFinishedChecks?.Invoke(PlayerRoundsWins,middleText,"player");
                }
                else
                {
                    middleText = $"В {round} раунде побеждает Оппонент!";
                    check = 1;
                    round++;
                    OpponentRoundsWins++;
                    PlayerWins = 0;
                    OpponentWins = 0;
                    OpponentPoints = 1000;
                    PlayerPoints = 1000;

                    OnFinishedChecks?.Invoke(PlayerRoundsWins, middleText,"opponent");
                }
            }
            else
                OnResult?.Invoke(PlayerStavka,OpponentStavka,PlayerPoints,OpponentPoints,middleText,PlayerWins,OpponentWins);
        }
        public int minStavka()
        {
            return PlayerStavka / 100 * 20;
        }
        public int maxStavka()
        {
            return PlayerPoints / 100 * 40;
        }
    }
}
