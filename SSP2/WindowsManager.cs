namespace SSP2
{
    public class WindowsManager
    {
        public Form1 _form1;
        public Form2 _form2;

        private Controller _controller;

        public WindowsManager(Controller controller)
        {   
            _controller = controller;
        }
        public void CreateUser(string text)
        {
            _controller.createUser(text);
        }
        public void OpenTable()
        {
            Form3 form3 = new Form3();
            form3.Show();
            form3.Activate();
        }
    }
}
