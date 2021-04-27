using System;
using System.Windows.Forms;
using AddressBook.Core;

namespace AddressBook.UI
{
    /// <summary>
    /// Log in form
    /// </summary>
    public partial class LoginForm : Form
    {
        private readonly IAuthRepository _authRepository;
        private readonly IUserRepository _userRepository;

        public LoginForm(IUserRepository userRepository, IAuthRepository authRepository)
        {
            InitializeComponent();
            _authRepository = authRepository;
            _userRepository = userRepository;
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var inputEmail = EmailBox.Text;
            var inputPassword = PasswordBox.Text;

            var authTuple = await _authRepository.LogInWithStreamReader(inputEmail, inputPassword);

            if (authTuple.Item4)
            {
                // send to next menu
                var mainDashboard = new AdminDashboard(authTuple.Item1, authTuple.Item2, authTuple.Item3,
                    _userRepository);
                mainDashboard.ShowDialog();
                this.Dispose();
            }
            else
            {
                // show input error
                MessageBox.Show("Error Logging In");
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // show reg form
            this.Close();
        }
    }
}
