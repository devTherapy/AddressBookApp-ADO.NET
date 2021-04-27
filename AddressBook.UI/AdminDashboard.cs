using System;
using System.Windows.Forms;
using AddressBook.Core;

namespace AddressBook.UI
{
    /// <summary>
    /// Major form for logged in user 
    /// </summary>
    public partial class AdminDashboard : Form
    {
        private readonly string _id;
        private readonly int _userRoleId;
        private readonly string _email;
        private readonly IUserRepository _userRepository;
        public AdminDashboard(string id, int userRoleId, string email, IUserRepository userRepository)
        {
            InitializeComponent();
            _id = id;
            _userRoleId = userRoleId;
            _email = email;
            _userRepository = userRepository;

        }

        private void UpdateAddress_Click(object sender, EventArgs e)
        {
            var addressForm = new ChangeAddress(_id, _userRepository);
            addressForm.ShowDialog();
        }

        private void UpdatePhone_Click(object sender, EventArgs e)
        {
            var phoneForm = new ChangePhoneNumber(_id, _userRepository);
            phoneForm.ShowDialog();
        }

        private void UpdateSocials_Click(object sender, EventArgs e)
        {
            var socialsForm = new AddSocialMedia(_id, _userRepository);
            socialsForm.ShowDialog();

        }

        private async void ViewAllUsers_Click(object sender, EventArgs e)
        {
            // show all users
            label1.Hide();

            richTextBox1.Text = await  _userRepository.GetAllUsers(_userRoleId);



        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // disable view all users if user is not admin.
            if (_userRoleId != 0)
            {
                ViewAllUsers.Visible = false;
            }
            
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void ViewDetails_Click(object sender, EventArgs e)
        {
            var user = await _userRepository.GetUser(_email);

            label1.Text = user.ToString();


        }

    }
}
