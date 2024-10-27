namespace Module1Assignment;

class Program
{
    private static readonly string FileName = "animals.txt";
    
    public static void Main(string[] args)
    {
        List<ITalkable> zoo = new List<ITalkable>();
        
        AnimalInput.NewAnimal(zoo);
        //zoo.Add(new Dog("Bean", true));
        //zoo.Add(new Cat("Charlie", 9));
        //zoo.Add(new Teacher("Stacy Read", 44));
        
        FileOutput outFile = new FileOutput(FileName);
        foreach (ITalkable thing in zoo)
        {
            PrintOut(outFile, thing);
        }
        outFile.FileClose();
        
        FileInput inFile = new FileInput(FileName);
        inFile.FileRead();
        inFile.FileClose();
        
        FileInput inData = new FileInput(FileName);
        string line;
        while ((line = inData.FileReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
    
    private static void PrintOut(FileOutput file, ITalkable p) {
        Console.WriteLine(p.GetName() + " says=" + p.Talk());
        file.FileWrite(p.GetName() + " | " + p.Talk());
    }
}