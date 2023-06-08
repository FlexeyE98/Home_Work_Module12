namespace Module12
{
    public class Program
    {
        public delegate void MyDelegate();
        static void Main(string[] args)
        {
            User user = new User();
            Console.Write("Введите ваше имя ");
            user.Name = Console.ReadLine();
            string greetings = "Привет " + user.Name;
            if (user.IsPremium == true)
                return;
            else
            {
                User.ShowAds();

            }
        }
    }
}