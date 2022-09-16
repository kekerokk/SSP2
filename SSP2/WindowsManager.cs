using System.ComponentModel;
using System.Windows.Forms;

namespace SSP2
{
    public class WindowsManager
    {
        public Form1 _form1;
        public Form2 _form2;

        private Controller _controller;
        private FormForDataGrid ffdg;

        public WindowsManager(Controller controller)
        {   
            _controller = controller;
            ffdg = new FormForDataGrid();
        }
        public void CreateUser(string text)
        {
            _controller.createUser(text);
        }
        public void OpenTable()
        {
            GetResultsFromBD()

        }
        public void GetResultsFromBD(BindingList<DB.Player> blPS)
        {
            //FormForDataGrid dgForm = new FormForDataGrid(blPS);
            ffdg.StartDataGrid(blPS);
            ffdg.ShowDialog();
        }
    }
}
