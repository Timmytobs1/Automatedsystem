class Program
{
    static void Main()
    {
        bool[] passangerSit = new bool[10]; //{true,true,0,0,0,0,0,0,0}
 
 
        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Enter 1 for first class");
            Console.WriteLine("Enter 2 for economy class");
 
            int.TryParse(Console.ReadLine(), out int type);
 
            if (type == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (passangerSit[i] == false)
                    {
                        passangerSit[i] = true;
                        Console.WriteLine($"First Class: Seat {i + 1}");
                        break;
                    }
                    if (passangerSit[4] == true)
                    {
                        Console.WriteLine("Do you want to be placed in economy class");
                        int.TryParse(Console.ReadLine(), out int option);
 
                        if (option == 1)
                        {
                            for (int y = 5; y < 10; y++)
                            {
                                if (passangerSit[y] == false)
                                {
                                    passangerSit[y] = true;
                                    Console.WriteLine($"Economy Class: Seat {y + 1}");
                                    break;
                                }
                                if (passangerSit[9] == true)
                                {
                                    Console.WriteLine("The next flight is in 3 hours");
                                    break;
                                }
                            }
                        }
                        break;
                    }
 
                }
 
 
            }
            else if (type == 2)
            {
                for (int i = 5; i < 10; i++)
                {
                    if (passangerSit[i] == false)
                    {
                        passangerSit[i] = true;
                        Console.WriteLine($"Economy Class: Seat {i + 1}");
                        break;
                    }
                    if (passangerSit[9] == true)
                    {
                        Console.WriteLine("The next flight is in 3 hours");
                        break;
                    }
                }
 
            }
 
 
        }
 
    }
 
}
 