using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using StringSaving.SSFactory;
using StringSaving.SSFactory.StringSaverFactories;


namespace StringSaving
{
    class Menu
    {
        public static void ShowMenu()
        {

            Console.WriteLine("=================================");
            Console.WriteLine("String Saving");
            Console.WriteLine("=================================");
            Console.WriteLine("1.Duplicate to Console");
            Console.WriteLine("2.Save to file");
            Console.WriteLine("3.Exit");
            Console.WriteLine("=================================");
        }

        public static string ReciveInputString()
        {
            string inputString;
            Console.Write($"Enter string: ");
            try
            {
                inputString = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong Data Type");
                inputString = ReciveInputString();
            }

            return inputString;
        }

        public static StringSaverFactory GetFactory(StringSavingTypes saverType) //прочитать про паттерн абстрактная фабрика и применить
        {
            StringSaverFactory factory;

            switch (saverType)
            {
                case StringSavingTypes.ConsoleSaver:
                    factory = new ConsoleSaverFactory();
                    break;
                case StringSavingTypes.FileSaver:
                    factory = new FileSaverFactory();
                    break;
                default:
                    throw new InvalidDataException("Wrong operator type");
            }

            return factory;
        }

        public static void Select()
        {

            var yes = 0;
            ShowMenu();

            try
            {
                while (yes == 0)
                {
                    Console.Clear();
                    ShowMenu();
                    Console.Write("Enter your choice: ");
                    var choice = int.Parse(Console.ReadLine()); //лучше использовать TryParse и убрать try catch

                    if (choice == 3)
                    {
                        Environment.Exit(0);
                    }

                    var inputeString = ReciveInputString(); //rename GetInputString
                    var factory = GetFactory((StringSavingTypes)choice);
                    factory.Create().Save(inputeString);
                    Console.Write("\nContinue? Press 0 to continue:");
                    yes = int.Parse(Console.ReadLine());
                }

            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
