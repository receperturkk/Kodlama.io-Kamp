using Steam.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        User loginUser = new User();
        User newUser = new User();
        User user = new User();
        user.TcNo = "12345678910";
        user.FirstName = "Recep Kadir";
        user.LastName = "Ertürk";
        user.UserName = "ichbinshadow";
        user.PassWord = "12345678";

        Login(loginUser, newUser, user);

        static void Login(User loginUser, User newUser, User user)
        {
            Console.WriteLine("*** STEAM'E HOŞGELDİNİZ ***");
            Console.WriteLine("1-GİRİŞ YAP");
            Console.WriteLine("2-KAYIT OL");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Tc No: ");
                    loginUser.TcNo = Console.ReadLine();
                    Console.WriteLine("Adınız: ");
                    loginUser.FirstName = Console.ReadLine();
                    Console.WriteLine("Soyadınız: ");
                    loginUser.LastName = Console.ReadLine();
                    Console.WriteLine("Kullanıcı adınız: ");
                    loginUser.UserName = Console.ReadLine();
                    Console.WriteLine("Şifreniz: ");
                    loginUser.PassWord = Console.ReadLine();

                    if (user.TcNo == loginUser.TcNo &&
                        user.FirstName == loginUser.FirstName &&
                        user.LastName == loginUser.LastName &&
                        user.UserName == loginUser.UserName &&
                        user.PassWord == loginUser.PassWord)
                    {
                        Console.WriteLine("oyunlar gelicek");
                    }
                    else
                    {
                        Login(loginUser, newUser, user);
                    }
                    break;
                case "2":
                    Console.WriteLine("Tc No: ");
                    newUser.TcNo = Console.ReadLine();
                    Console.WriteLine("Adınız: ");
                    newUser.FirstName = Console.ReadLine();
                    Console.WriteLine("Soyadınız: ");
                    newUser.LastName = Console.ReadLine();
                    Console.WriteLine("Kullanıcı adınız: ");
                    newUser.UserName = Console.ReadLine();
                    Console.WriteLine("Şifreniz: ");
                    newUser.PassWord = Console.ReadLine();
                    break;
            }
        }
    }
}