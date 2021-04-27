using System;
using System.Windows.Forms;
using AddressBook.Commons;
using AddressBook.Core;
using NLog;

namespace AddressBook.UI
{/// <summary>
/// Form to add social media links
/// </summary>
    public partial class AddSocialMedia : Form
    {
        private readonly string _userId;
        private readonly IUserRepository _userRepository;
        private static Logger logger = LogManager.GetCurrentClassLogger();


        public AddSocialMedia(string id, IUserRepository userRepository)
        {
            InitializeComponent();
            _userId = id;
            _userRepository = userRepository;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose(); // destroys the instance of this component
        }

        private void AddMedia_Click(object sender, EventArgs e)
        {
            try
            {
                var inputLink = Utilities.ValidateInput(LinkBox.Text);
                var row = _userRepository.AddSocialMediaHandles(_userId, inputLink);
                // use rows affected to show if process was completed siuccessfully
                MessageBox.Show(row == 1 ? "Link have been added" : "Unable to add Link"); 
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                logger.Warn(exception.Message);
            }
        }
    }
}
