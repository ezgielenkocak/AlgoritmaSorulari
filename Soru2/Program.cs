using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Soru2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userName = "admin";
            string password = "123";


            Console.WriteLine("Kullanıcı adınızı giriniz");
            string _userName = Console.ReadLine();

            Console.WriteLine("Şifrenizi giriniz");
            string _password = Console.ReadLine();

            if (userName.Equals(_userName))
            {
                Console.WriteLine("Giriş başarılı");
                if (_userName.Equals(userName) && !_password.Equals(password))
                {
                    Console.WriteLine("Şifre Hatalı");
                }
            }

            else
            {
                Console.WriteLine("Böyle bir kullanıcı bulunamadı. Kayıt olmak için 2' ye basınız");
                int kayit = int.Parse(Console.ReadLine());
                if (kayit == 2)
                {
                    UserOperation register = new UserOperation();
                    register.Useregister();


                }
            }
        }


    }
    public class UserOperation
    {
        List<string> listUser = new List<string>();
        List<string> listPassword = new List<string>();
        public void Useregister()
        {
            Console.WriteLine("Kayıt Ekranına Hoşgeldiniz");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Kullanıcı Adınızı Giriniz");
            string user = Console.ReadLine();

            Console.WriteLine("Şifrenizi");
            string pass = Console.ReadLine();

            Console.WriteLine($"Kullanıcı adınız: {user} Şifreniz:{pass} \n Kayıt işlemini tamamlamak için 1'e basınız");
            int kayitTamam = int.Parse(Console.ReadLine());

            if (kayitTamam == 1)
            {
                Console.WriteLine("Kayıt işlemi başarılı");

                listUser.Add(user);
                listPassword.Add(pass);

                Console.WriteLine("Login ekranına dönmek için 1' e basınız");
                string loginUser = Console.ReadLine();
                if (loginUser.Equals("1"))
                {
                    Login();
                }
            }

        }

        public void Login()
        {
            Console.WriteLine("Kullanıcı Adınızı giriniz");
            string userCheck = Console.ReadLine();

            if (listUser.Contains(userCheck))
            {
                Console.WriteLine("Şifrenizi giriniz");
                string passCheck = Console.ReadLine();
                if (listPassword.Contains(passCheck))
                {
                    Console.WriteLine("Kullanıcı adı ve şifre doğru. Giriş başarılı");
                }
                else
                {
                    Console.WriteLine("Şifre hatalı");
                }

            }


            else
            {
                Console.WriteLine("Böyle bir kullanıcı bulunamadı");
            }
        }
    }
}


