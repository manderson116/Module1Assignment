namespace Module1Assignment;

public class AnimalInput
{
    public static void NewAnimal(List<ITalkable> zoo)
    {
        string animal = "";
        string name = "";
        string special = "";
        while (animal.ToUpper() != "QUIT")
        {
            Console.WriteLine("Enter a new animal type: \n" +
                              "\"Dog\"\n" +
                              "\"Cat\"\n" +
                              "\"Teacher\"\n" +
                              "\"QUIT\" to stop");
            animal = Console.ReadLine();
            
            if (animal.ToUpper() == "QUIT")
                break;
            
            switch (animal.ToUpper())
            {
                case "DOG":
                {
                    Console.WriteLine("Enter a name: ");
                    name = Console.ReadLine();
                    
                    while (special.ToUpper() != "Y" && special.ToUpper() != "N")
                    {
                        Console.WriteLine("Are they friendly? Y/N ");
                        special = Console.ReadLine();
                        
                        if (special.ToUpper() != "Y" && special.ToUpper() != "N")
                            Console.WriteLine("Invalid input!");
                    }
                    
                    zoo.Add(new Dog(name, special.Equals("Y")));
                    
                    name = "";
                    special = "";
                    break;
                }
                case "CAT":
                {
                    Console.WriteLine("Enter a name: ");
                    name = Console.ReadLine();

                    bool isValidInt = false;
                    while (!isValidInt)
                    {
                        Console.WriteLine("Enter # of mouses killed: ");
                        special = Console.ReadLine();

                        if (int.TryParse(special, out int num))
                            isValidInt = true;
                        else
                            Console.WriteLine("Invalid input!");
                    }
                    
                    zoo.Add(new Cat(name, int.Parse(special)));
                    
                    name = "";
                    special = "";
                    break;
                }
                case "TEACHER":
                {
                    Console.WriteLine("Enter a name: ");
                    name = Console.ReadLine();

                    bool isValidInt = false;
                    while (!isValidInt)
                    {
                        Console.WriteLine("Enter age: ");
                        special = Console.ReadLine();
                        
                        if (int.TryParse(special, out int num))
                            isValidInt = true;
                        else
                            Console.WriteLine("Invalid input!");
                    }
                    
                    zoo.Add(new Teacher(name, int.Parse(special)));
                    
                    name = "";
                    special = "";
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid input!");
                    break;
                }
            }
        }
    }
}