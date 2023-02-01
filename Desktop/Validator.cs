using System;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Windows.Controls;

namespace Desktop
{
    public static class Validator
    {
        public static string ValidName(string name)
        {
            if (name.Length >= 3)
            {
                return null;
            }
            else
            {
                return "Имя должно содержать не менее 3 символов";
            }
        }

        public static string ValidEmail(string mailAddress)
        {
            try
            {
                if (Regex.IsMatch(mailAddress, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {
                    return null;
                }
                else
                {
                    return "Не правильно введен email. Он должен иметь вид frolkovdenis@mail.ru";
                }
            }
            catch
            {
                return "Не правильно введен email. Он должен иметь вид frolkovdenis@mail.ru";
            }
        }

        public static string ValidPass(string password)
        {
            if (password.Length >= 6)
            {
                return null;
            }
            else
            {
                return "Пароль должен содержать не менее 6 символов";
            }
        }

        public static string ValidRepeat(string password, string repeat)
        {
            if (password == repeat && ValidPass(password) == null)
            {
                return null;
            }
            else
            {
                return "Пароли отличаются";
            }
        }
    }
}