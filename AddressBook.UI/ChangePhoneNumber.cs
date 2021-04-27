using System;
using System.Windows.Forms;
using AddressBook.Commons;
using AddressBook.Core;
using NLog;

namespace AddressBook.UI
{
    /// <summary>
    /// Form for all changes to phone number
    /// </summary>
    public partial class ChangePhoneNumber : Form
    {
        private readonly string _userId;
        private readonly IUserRepository _userRepository;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public ChangePhoneNumber(string id, IUserRepository userRepository)
        {
            InitializeComponent();
            _userId = id;
            _userRepository = userRepository;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddPhone_Click(object sender, EventArgs e)
        {
            try
            {
                var inputPhoneText = Utilities.ValidatePhoneNumber(AddBox.Text);
                var row = _userRepository.AddPhoneNumber(_userId, inputPhoneText);
                MessageBox.Show(row == 1 ? "Phone Number have been added" : "Unable to add Phone Number");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                logger.Warn(exception.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var inputPhoneText = Utilities.ValidatePhoneNumber(DeleteBox.Text);
                var row = _userRepository.DeletePhoneNumber(_userId, inputPhoneText);
                MessageBox.Show(row == 1 ? "Phone number have been deleted" : "Unable to delete Number");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                logger.Warn(exception.Message);
            }
        }

        private void UpdateNumberBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var oldNumberPhoneText = Utilities.ValidatePhoneNumber(OldNumberBox.Text);
                var newNumberPhoneText = Utilities.ValidatePhoneNumber(NewNumberBox.Text);

                var row = _userRepository.UpdatePhoneNumber(_userId, oldNumberPhoneText, newNumberPhoneText);
                MessageBox.Show("Phone Number have been updated");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                logger.Warn(exception.Message);
            }
        }
    }
}
