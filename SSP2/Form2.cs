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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Activate();
            Rules.Text = "Правила:\r\n1.Играется как в обычные камень-ножницы-бумага.\r\n"+
                "2.У игрока и у бота, либо у другого игрока, есть очки в количестве 1000. В каждом раунде все делают ставку: 10% от очков - минимум и 30% от очков - максимум\r\n" +
                "3.Один раунд длится до 3-х побед одного игрока. В начале раунда игроки делают депозит в размере 50 очков и играют, после могут поднять ставку, спасовать или играть дальше.\r\n" +
                "4.Выигравшим считается тот, кто выиграл 3 раунда. Очки трех выигранных раундов суммируются и отправляются в таблицу лидеров.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaticData.Nick = textBox1.Text;
            Application.OpenForms[0].Close();
        }

    }
    public static class StaticData
    {
        static Form2 form = new Form2();
        public static String Nick = form.GetName();
    }
}
