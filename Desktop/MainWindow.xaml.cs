using System.Windows;
using Desktop.Repository;
using Entities;

namespace Desktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            var wind = new MainEmpty();
            wind.Show();
            Hide();
        }
        

        private void ButtonEnter(object sender, RoutedEventArgs e)
        {
            var Email = Validator.ValidEmail(TextBoxEmail.Text);
            var Password = Validator.ValidPass(TextBoxPassword.Text);
            
            if (Email != null)
            {
                MessageBox.Show(Email);
            }
            if (Password != null)
            {
                MessageBox.Show(Password);
            }

            if (Email == null && Password == null)
            {
                var loginUser = UserRepository.LoginUser(new UserModel("", TextBoxEmail.Text, TextBoxPassword.Text));
                if (loginUser != null)
                {
                    var wind = new MainEmpty();
                    wind.Show();
                    Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пользователь не зарегестрирован!");
                }
            }
        }

        private void ButtonRegist(object sender, RoutedEventArgs e)
        {
            var wind = new Registration();
            wind.Show();
            Hide();
            this.Close();
        }

    }
}