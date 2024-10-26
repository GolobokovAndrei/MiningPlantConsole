using System;
using MiningPlantConsole;
using Password;
using MiningPlantConsole.Model;

namespace MiningPlantConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for input
            Console.WriteLine("Создание новой учетной записи для пользователя");
            Console.Write("Введите имя пользователя (логин): ");
            string username = Console.ReadLine();

            Console.Write("Введите пароль пользователя: ");
            string password = Console.ReadLine();

            // Hash the password
            HashPassword hashPassword = new HashPassword();
            string hashedPassword = hashPassword.GetHashedPassword(password);
            Console.WriteLine($"Хешированный пароль: {hashedPassword}");

            Users newUser = new Users
            {
                UserLogin = username,
                UserPassword = hashedPassword,
            };

            Helper helper = new Helper();
            try
            {
                helper.CreateUser(newUser);
                Console.WriteLine("Учетная запись добавлена");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при добавлении учетной записи: {ex.Message}");
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
