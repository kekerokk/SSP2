namespace SSP2
{
    public class Controller
    {
        private Model.Model __model;

        public Controller(Model.Model model)
        {
            __model = model;
        }

        internal void stavkaDoes(int playerStavka, int playerPoints, int opponentPoints)
        {
            __model.StavkaDoes(playerStavka, playerPoints, opponentPoints);
        }
        internal void sspchoosen(int choosen)
        {
            __model.SSPChoosen(choosen);
        }

        internal void createUser(string text)
        {
            __model.SetUserName(text);
        }

        internal void errorstavka()
        {
            __model.ErrorStavka();
        }
        internal void result(string middleText)
        {
            __model.Result(middleText);
        }
        internal int minstavka()
        {
            return __model.minStavka();
        }
        internal int maxstavka()
        {
            return __model.maxStavka();
        }
        internal string GetNick()
        {
            return __model.userName;
        }
    }
}
