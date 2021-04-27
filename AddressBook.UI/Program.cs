using System;
using System.Windows.Forms;
using AddressBook.Core;

namespace AddressBook.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ServicesConfig.Initialize();
            IUserRepository userRepo= ServicesConfig.userRepository;
            IAuthRepository authRepo = ServicesConfig.authRepository;


            Application.Run(new Address(userRepo, authRepo));
        }
    }
}
