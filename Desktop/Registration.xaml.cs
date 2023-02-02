using System.Windows;
using Desktop.Repository;
using Entities;

// using Entities.Models;

namespace Desktop
{
    public partial class Registration
    {
        public Registration()
        {
            InitializeComponent();
            Manager.RegistrationWindow = this;
        }

        private void Button_Register(object sender, RoutedEventArgs e)
        {
            var Name = Validator.ValidName(TextBoxName.Text);
            var Email = Validator.ValidEmail(TextBoxEmail.Text);
            var Password = Validator.ValidPass(TextBoxPassword.Text);
            var Repeat = Validator.ValidRepeat(TextBoxPassword.Text, TextBoxRepeat.Text);
            if (Name != null)
            {
                MessageBox.Show(Name);
            }
            if (Email != null)
            {
                MessageBox.Show(Email);
            }
            if (Password != null)
            {
                MessageBox.Show(Password);
            }
            if (Password != Repeat)
            {
                MessageBox.Show(Repeat);
            }

            if (Name == null && Email == null && Password == null && Repeat == null)
            {   var RegistrationUser = UserRepository.RegistrationUser(new UserModel(TextBoxName.Text, TextBoxEmail.Text, TextBoxPassword.Text));
                if (RegistrationUser != null)
                {
                    var wind = new MainEmpty();
                    wind.Show();
                    Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Такой пользователь уже существет");
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var wind = new MainWindow();
            wind.Show();
            Hide();
            this.Close();
        }
    }
}