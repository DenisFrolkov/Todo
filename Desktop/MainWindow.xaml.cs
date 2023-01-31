using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.CurrentWindow = this;
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            var wind = new MainEmpty();
            wind.Show();
            Manager.CurrentWindow.Hide();

            //Back

            Manager.CurrentWindow.Show();
            this.Close();

            // var PassBox = Validator.ValidPass(ValidPass.Text);
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

            if (Email == null && Password == null )
            {
                var wind = new MainEmpty();
                wind.Show();
                Hide();
            }
        }

        private void ButtonRegist(object sender, RoutedEventArgs e)
        {
            var wind = new Registration();
            wind.Show();
            Hide();
        }
    }
}