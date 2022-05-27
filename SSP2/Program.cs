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
            WindowsManager windowsManager = new WindowsManager(controller);
            Form1 form1 = new Form1(controller, windowsManager);
            _model.OnStavkaDoes += form1.DoStavky;
            _model.OnErrorStavka += form1.ErrorStavka;
            _model.OnSSPChoosen += form1.ChooseSSP;
            _model.OnErrorStavka += form1.ErrorStavka;
            _model.OnResult += form1.Result;
            _model.OnFinishedChecks += form1.FinishRound;
            Application.Run(form1);
        }
    }
}
