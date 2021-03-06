using System;

namespace ZOO

{
    class Program
    {
        static void Main()
        {
            
            GroundAnimal elephant = new GroundAnimal() { Name = "Слон", Size = "Гигантский", Feeding = "растительность", Sound = "У-в-в-вф!" };
            Birds bird = new Birds() { Name = "Воробей", Size = "маленький", Feeding = "червячки", Sound = "Чик чирик!" };
            WaterAnimal fish = new WaterAnimal() { Name = "Карась", Feeding = "водоросли", Size = "маленький", Sound = "Буль буль" };
            Animal lion = new Predator() { Name = "Лев", ObFeeding = bird, Size = "большой", Sound = "Р-р-р-р-р" };

            GroundAnimal kenguru = new GroundAnimal() { Name = "Кенгуру", Size = "Средний", Feeding = "Австралийская растительность", Sound = "Прыг прыг" };
            Animal[] animalСommunity = new Animal[] { fish, bird, lion, elephant, kenguru };
            ZooCustomer Person = new ZooCustomer();
            lion.Eat(kenguru);
            Console.WriteLine("Добро пожаловать в Виртуальный Зоопарк Приднестровья!");
            Console.WriteLine("Как Вас зовут?");

            string CustomerName = Console.ReadLine();
            Console.WriteLine($"Здравствуйте {CustomerName}, Заходите и выбирайте на кого посмотреть .. или покормить ");

            Console.WriteLine(" Для продолжения нажмите Enter, для выхода нажмите  x");
            while (Console.ReadLine() != "x")
            {
                Console.WriteLine("Введите пожалуйста животное из списка..");
                foreach (var item in animalСommunity)
                {
                    Console.WriteLine(Convert.ToString($" {item.Name}"));

                }
                Console.WriteLine(" Всех");
                string inputAnimal = Console.ReadLine();

                foreach (var strAnimal in animalСommunity)
                {

                    if (inputAnimal != "" && inputAnimal == strAnimal.Name)
                    {
                        Console.WriteLine("Что будем..  Кормить или Смотреть?..Введите пожалуйста.");
                        string action = Console.ReadLine();

                        if (action != "" && action == "Кормить" || action == "кормить")
                        {
                            Person.Feed(strAnimal);
                        }
                        else if (action != "" && action == "Смотреть" || action == "смотреть")
                        {
                            Person.Watch(strAnimal);
                        }


                    }
                    else if (inputAnimal != "" && inputAnimal.Equals("Всех", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Что будем ..  Кормить или Смотреть?..Введите пожалуйста.");
                        string action = Console.ReadLine();
                        if (action != "" && action == "Кормить" || action == "кормить")
                        {
                            Person.FeedAll(animalСommunity);
                            break;
                        }
                        else if (action != "" && action == "Смотреть" || action == "смотреть")
                        {
                            Person.WatchAll(animalСommunity);
                            break;
                        }
                    }
                    else
                    {
                        //Пропустить
                    }
                }
            } 







        }
    }
}
