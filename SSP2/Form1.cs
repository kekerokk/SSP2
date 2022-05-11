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
        private int round = 1, stavka = 100;
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
        private void StavkaChanged()
        {
            if(round == 1)
            {
                stavka = 100;
                Stavka.Text = "100";
            }
            else
            {
                int TwelwProcent = 
                stavka = Convert.ToInt32(Stavka.Text);
                int PP = Convert.ToInt32(PlayerPoints.Text);
                if((stavka <= stavka/(PP/100) && (stavka >=)
            }
        }
    }
}
