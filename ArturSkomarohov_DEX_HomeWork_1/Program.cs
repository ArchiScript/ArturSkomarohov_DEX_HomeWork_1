using System;

namespace ZOO

{
    class Program
    {
        static void Main(string[] args)
        {
            Birds bird = new Birds() { Name = "Воробей", Size = "маленький", Feeding = "червячки" };
            WaterAnimal fish = new WaterAnimal() { Name = "Карась", Feeding = "водоросли", Size = "маленький" };
            Predator lion = new Predator() { Name = "Лев", Feeding = "Мясо", Size = "большой" };
            Animal[] animal_community = new Animal[] { fish, bird, lion };
            
            foreach (var item in animal_community)
            { 
                item.Show();
                item.Eat();
                item.Move();
                item.Voice();
            }
        }
    }
}
