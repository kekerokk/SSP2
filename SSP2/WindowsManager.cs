namespace SSP2
{
    public class WindowsManager
    {
        private Form1 _form1;
        private Form2 _form2;

        private Controller _controller;

        public WindowsManager(Controller controller)
        {
            _form1 = new Form1(this);
            _form2 = new Form2(this);
            _controller = controller;
        }
        public void CreateUser(string text)
        {
            _controller.createUser(text);
        }
    }
}
