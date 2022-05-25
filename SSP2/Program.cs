using System;
using System.Windows.Forms;

namespace SSP2
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Model.Model _model = new Model.Model();
            Controller controller = new Controller(_model);
            Form1 form1 = new Form1(controller);
            _model.OnStavkaDoes += form1.DoStavky;
            _model.OnErrorStavka += form1.ErrorStavka;
            _model.OnSSPChoosen += form1.ChooseSSP;
            _model.OnErrorStavka += form1.ErrorStavka;
            _model.OnResult += form1.Result;
            Application.Run(form1);
        }
    }
}
