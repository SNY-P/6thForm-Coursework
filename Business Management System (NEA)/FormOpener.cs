using System.Windows.Forms;

namespace Business_Management_System__NEA_
{
    class FormOpener
    {
        public void OpenLoginForm()
        {
            Application.Run(new LoginForm());
        }

        public void OpenStreamlineWindow()
        {
            Application.Run(new StreamlineWindow());
        }

        public void OpenWelcomeForm()
        {
            Application.Run(new Welcome_Page());
        }

        public void OpenError()
        {
            Application.Run(new ErrorForm());
        }
    }
}