using System;
using System.Windows.Forms;
using AddressBook.Commons;
using AddressBook.Core;
using NLog;

namespace AddressBook.UI
{
    /// <summary>
    /// Registration Form, first form to be instantiated
    /// </summary>
    public partial class Address : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthRepository _authRepository;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Address(IUserRepository userRepository, IAuthRepository authRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _authRepository = authRepository;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                var inputFirstNameText = Utilities.ValidateName(FirstNameBox.Text);
                var inputLastNameText = Utilities.ValidateName(LastNameBox.Text);
                var inputEmailText = Utilities.ValidateEmail(EmailBox.Text);
                var inputPasswordText = Utilities.ValidatePassword(PasswordBox.Text);
                var inputRoleText = Utilities.ValidateInput(RoleBox.Text);
                var inputRoleNumber = inputRoleText == "Admin" ? 0 : 1;
                var inputMainPhoneNumber = Utilities.ValidatePhoneNumber(MainPhoneBox.Text);


                
                _authRepository.CheckStoreForEmail(inputEmailText);

                _userRepository.AddUser(inputFirstNameText, inputLastNameText, inputEmailText, 
                    inputPasswordText, inputRoleNumber, inputMainPhoneNumber);

                _authRepository.StoreAuthWithStreamWriter(inputEmailText, inputPasswordText);
                MessageBox.Show("You have been registered");

                var authTuple = await _authRepository.LogInWithStreamReader(inputEmailText, inputPasswordText);

                if (authTuple.Item4)
                {
                    // send to next menu
                    var mainDashboard = new AdminDashboard(authTuple.Item1, authTuple.Item2, authTuple.Item3,
                    _userRepository);
                    mainDashboard.ShowDialog();
                }
                else
                {
                    // show input error
                    MessageBox.Show("Error Logging In");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Error(ex.Message);
            }

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(_userRepository, _authRepository);
            loginForm.ShowDialog();
        }

    }
}
