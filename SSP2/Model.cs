﻿using System;

namespace SSP2.Model
{
    public class Model
    {
        public Action<int, int, int, int> OnStavkaDoes;
        public Action<int, int> OnSSPChoosen;
        public Action<int, int> OnErrorStavka;
        public Action<int, int, int, int, string, int, int> OnResult;
        public Action<int, string, string, int, int, int> OnFinishedChecks;

        public int check = 1,choosenSSP, round = 1, PlayerWins, OpponentWins, PlayerRoundsWins, OpponentRoundsWins, PlayerPoints, OpponentPoints, PlayerStavka, OpponentStavka,playerEndPoints,opponentEndPoints;
        public string userName;
        Random rand = new Random();



        public void StavkaDoes(int playerStavka, int playerPoints, int opponentPoints)
        {
            PlayerStavka = playerStavka;
            PlayerPoints = playerPoints;
            OpponentPoints = opponentPoints;
            if (check == 1)
            {
                PlayerStavka = 200;
                OpponentStavka = 200;
                PlayerPoints -= PlayerStavka;
                OpponentPoints -= OpponentStavka;

                OnStavkaDoes?.Invoke(PlayerStavka, OpponentStavka, PlayerPoints, OpponentPoints);
            }
            else
            {
                if (PlayerStavka >= PlayerPoints / 100 * 20 && PlayerStavka <= PlayerPoints / 100 * 40)
                {
                    OpponentStavka = rand.Next(OpponentPoints / 100 * 20, OpponentPoints / 100 * 40);

                    PlayerPoints -= PlayerStavka;
                    OpponentPoints -= OpponentStavka;

                    OnStavkaDoes?.Invoke(PlayerStavka, OpponentStavka, OpponentPoints, PlayerPoints);
                }
                else
                {
                    OnErrorStavka?.Invoke(PlayerPoints / 100 * 20, PlayerPoints / 100 * 40);
                }
            }
        }
        public void StavkaDoesForTest(int playerStavka, int playerPoints, int opponentPoints,int Choose, int BotChoose)
        {
            PlayerStavka = playerStavka;
            PlayerPoints = playerPoints;
            OpponentPoints = opponentPoints;
            if (check == 1)
            {
                PlayerStavka = 200;
                OpponentStavka = 200;
                PlayerPoints -= PlayerStavka;
                OpponentPoints -= OpponentStavka;

                Result(Choose, BotChoose);
            }
            else
            {
                if (PlayerStavka >= PlayerPoints / 100 * 20 && PlayerStavka <= PlayerPoints / 100 * 40)
                {
                    OpponentStavka = rand.Next(OpponentPoints / 100 * 20, OpponentPoints / 100 * 40);

                    PlayerPoints -= PlayerStavka;
                    OpponentPoints -= OpponentStavka;

                    
                }
                else
                {
                    
                }
            }
        }

        public void SetUserName(string text)
        {
            userName = text;
        }

        public void SSPChoosen(int Choosen)
        {
            choosenSSP = Choosen;
            check++;
            int BotChoose;
            BotChoose = rand.Next(1, 3);
            OnSSPChoosen?.Invoke(Choosen, BotChoose);
        }
        public void PlayerWin()
        {
            
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

            if (PlayerWins == 3 || OpponentWins == 3)
            {
                playerEndPoints = PlayerPoints;
                opponentEndPoints = OpponentPoints;

                if (PlayerWins > OpponentWins)
                {
                    middleText = $"В {round} раунде побеждает {userName}!";
                    check = 1;
                    round++;
                    PlayerRoundsWins++;
                    PlayerWins = 0;
                    OpponentWins = 0;
                    OpponentPoints = 1000;
                    PlayerPoints = 1000;

                    OnFinishedChecks?.Invoke(PlayerRoundsWins, middleText, "player", round, playerEndPoints,opponentEndPoints);
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

                    OnFinishedChecks?.Invoke(OpponentRoundsWins, middleText, "opponent", round, playerEndPoints,opponentEndPoints);
                }
            }
            else
                OnResult?.Invoke(PlayerStavka, OpponentStavka, PlayerPoints, OpponentPoints, middleText, PlayerWins, OpponentWins);
        }
        public void Result(int Choose, int BotChoose)
        {
            if (Choose == BotChoose)
            {
                PlayerPoints += PlayerStavka;
                PlayerStavka = 0;
                OpponentPoints += OpponentStavka;
                OpponentStavka = 0;

            }
            if (Choose == 1 && BotChoose == 2) // Камень и ножницы
            {
                PlayerPoints += PlayerStavka + OpponentStavka;
                PlayerStavka = 0;
                OpponentStavka = 0;
                PlayerWins++;
            }
            if (Choose == 2 && BotChoose == 3) // ножницы и бумага
            {
                PlayerPoints += PlayerStavka + OpponentStavka;
                PlayerStavka = 0;
                OpponentStavka = 0;
                PlayerWins++;
            }
            if (Choose == 3 && BotChoose == 1) // бумага и камень
            {
                PlayerPoints += PlayerStavka + OpponentStavka;
                PlayerStavka = 0;
                OpponentStavka = 0;
                PlayerWins++;
            }

            if (Choose == 1 && BotChoose == 3) // Камень и бумага
            {
                OpponentPoints += PlayerStavka + OpponentStavka;
                PlayerStavka = 0;
                OpponentStavka = 0;
                OpponentWins++;
            }
            if (Choose == 2 && BotChoose == 1) // ножницы и камень
            {
                OpponentPoints += PlayerStavka + OpponentStavka;
                PlayerStavka = 0;
                OpponentStavka = 0;
                OpponentWins++;
            }
            if (Choose == 3 && BotChoose == 2) // бумага и ножницы
            {
                OpponentPoints += PlayerStavka + OpponentStavka;
                PlayerStavka = 0;
                OpponentStavka = 0;
                OpponentWins++;
            }
        }
        public int minStavka()
        {
            return PlayerPoints / 100 * 20;
        }
        public int maxStavka()
        {
            return PlayerPoints / 100 * 40;
        }

        public int UpCheck()
        {
            check++;
            return check;
        }
    }
}
