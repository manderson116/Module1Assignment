Step #1

The program creates a "zoo" array list, and creates Bean, Charlie, and Stacy Read using the Dog, Cat, and Teacher classes.
Each zoo entry receives a name from the zoo.add() method, as well as a hardcoded catchphrase from inside each class. They also have variables and methods defined for "friendly", "mousesKilled", and "age" respectively, but they aren't used in the main method.
The program first uses the printOut() method to print each zoo entry's name and catchphrase to the console, and write them into the "outFile", animals.txt.
Then it reads from the "inFile", which is also animals.txt, which prints it to the console again.
Then it goes through each line in a new FileInput, which is still animals.txt, and prints them individually to the console a third time.
