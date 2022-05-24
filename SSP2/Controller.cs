using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSP2;

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
    }
}
