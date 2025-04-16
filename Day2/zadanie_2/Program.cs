using System;

namespace AnimalHierarchy
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "The animal name cannot be null.");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Animal name: {Name}");
        }
    }

    public class Mammal : Animal
    {
        public string FurType { get; set; }

        public Mammal(string name, string furType) : base(name)
        {
            FurType = furType ?? throw new ArgumentNullException(nameof(furType), "Fur type cannot be null.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Fur type: {FurType}");
        }
    }

    public class Artiodactyl : Mammal
    {
        public int NumberOfHooves { get; set; }

        public Artiodactyl(string name, string furType, int numberOfHooves) : base(name, furType)
        {
            NumberOfHooves = numberOfHooves;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Number of hooves: {NumberOfHooves}");
        }
    }

    public class Bird : Animal
    {
        public string FeatherColor { get; set; }

        public Bird(string name, string featherColor) : base(name)
        {
            FeatherColor = featherColor ?? throw new ArgumentNullException(nameof(featherColor), "Feather color cannot be null.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Feather color: {FeatherColor}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the type of animal:");
            Console.WriteLine("1 - Mammal");
            Console.WriteLine("2 - Artiodactyl");
            Console.WriteLine("3 - Bird");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            Animal animal;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the name of the mammal:");
                    string mammalName = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("Enter the type of fur:");
                    string furType = Console.ReadLine() ?? string.Empty;
                    animal = new Mammal(mammalName, furType);
                    break;

                case 2:
                    Console.WriteLine("Enter the name of the artiodactyl:");
                    string artiodactylName = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("Enter the type of fur:");
                    string artiodactylFur = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("Enter the number of hooves:");
                    int numberOfHooves;
                    if (!int.TryParse(Console.ReadLine(), out numberOfHooves))
                    {
                        numberOfHooves = 0;
                    }
                    animal = new Artiodactyl(artiodactylName, artiodactylFur, numberOfHooves);
                    break;

                case 3:
                    Console.WriteLine("Enter the name of the bird:");
                    string birdName = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("Enter the feather color:");
                    string featherColor = Console.ReadLine() ?? string.Empty;
                    animal = new Bird(birdName, featherColor);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.WriteLine("\nAnimal information:");
            animal.ShowInfo();
        }
    }
}

