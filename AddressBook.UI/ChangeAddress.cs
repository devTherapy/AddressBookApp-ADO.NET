using System;
using System.Windows.Forms;
using AddressBook.Commons;
using AddressBook.Core;
using NLog;

namespace AddressBook.UI
{
    /// <summary>
    /// Form to execute all changes to addresses
    /// </summary>
    public partial class ChangeAddress : Form
    {
        private readonly string _userId;
        private readonly IUserRepository _userRepository;
        private static Logger logger = LogManager.GetCurrentClassLogger();


        public ChangeAddress(string id, IUserRepository userRepository)
        {
            InitializeComponent();
            _userId = id;
            _userRepository = userRepository;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddAddressBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if ( _userRepository.CheckForAddress(_userId))
                {
                    MessageBox.Show("You already have an address, consider updating it");
                }
                else
                {
                    var inputStreet = Utilities.ValidateInput(StreetBox.Text);
                    var inputCity = Utilities.ValidateInput(CityBox.Text);
                    var inputState = Utilities.ValidateInput(StateBox.Text);
                    var inputZipCode = Utilities.ValidateInput(ZipCodeBox.Text);
                    var inputCountry = Utilities.ValidateInput(CountryBox.Text);

                    var row = _userRepository.AddAddress(_userId, inputStreet, inputCity, inputState,
                        inputZipCode, inputCountry);
                    MessageBox.Show(row == 1 ? "Address have been added" : "Unable to Add Address");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                logger.Warn(exception.Message);
                
            }
        }

        private void UpdateAddressBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var inputStreet = Utilities.ValidateInput(StreetBox.Text);
                var inputCity = Utilities.ValidateInput(CityBox.Text);
                var inputState = Utilities.ValidateInput(StateBox.Text);
                var inputZipCode = Utilities.ValidateInput(ZipCodeBox.Text);
                var inputCountry = Utilities.ValidateInput(CountryBox.Text);

                var row = _userRepository.UpdateAddress(_userId, inputStreet, inputCity, inputState,
                    inputZipCode, inputCountry);
                MessageBox.Show(row == 1 ? "Address have been updated" : "Unable to update Address");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                logger.Warn(exception.Message);
            }

        }

        private void ChangeAddress_Load(object sender, EventArgs e)
        {
            // check if user already have address, make add address invisible;
            if ( _userRepository.CheckForAddress(_userId))
            {
                AddAddressBtn.Visible = false;
            }
        }
    }
}
