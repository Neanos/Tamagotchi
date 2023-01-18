// Skapar en ny instans av klassen Tamagotchi
Tamagotchi t1 = new Tamagotchi();

//Tillåter spelaren att döpa sin tamagotchi och lagrar det till senare användning
Console.WriteLine("Please name your tamagotchi");
t1.name = Console.ReadLine();

Console.WriteLine($"{t1.name}");

//Den här loopen körs så länge bool variabeln isAlive är true
while (t1.GetAlive() == true)
{
    //Ger spelaren alternativ till aktiviteter den kan göra med sin tamagotchi 
    Console.Clear();
    t1.PrintStats();
    Console.WriteLine($"What would you like to do with {t1.name} today?");
    Console.WriteLine($"1) Feed {t1.name}");
    Console.WriteLine($"2) Teach {t1.name} a new word");
    Console.WriteLine($"3) Talk to {t1.name}");
    Console.WriteLine($"4) Throw ball with {t1.name}");
    Console.WriteLine($"5) Play with {t1.name} and a dog");
    Console.WriteLine("6) Create a new baby tamagotchi");
    Console.WriteLine("7) Do nothing");

    //Lagrar spelarens svar och kör en if satas beroende på vad spelaren skrivit in
    string? action = Console.ReadLine();
    if (action == "1")
    {
        t1.Feed();
    }

    if (action == "2")
    {
        Console.WriteLine("What word?");
        string? word = Console.ReadLine();
        if (word?.Length > 0)
        {
            t1.Teach(word);
        }
    }

    if (action == "3")
    {
        t1.Hi();
        Console.ReadLine();
    }

    if (action == "4")
    {
        t1.Ball();
        Console.ReadLine();
    }

    if (action == "5")
    {
        t1.Dog();
        Console.ReadLine();
    }

    if (action == "6")
    {
        Console.Clear();
        BabyTamagotchi bt1 = new BabyTamagotchi();

        Console.WriteLine("Please name your baby");
        bt1.name = Console.ReadLine();
        Console.WriteLine($"You have named your baby {bt1.name}");

        Console.ReadLine();
        action = "";
        while (bt1.GetAlive() == true && action != "6")
        {
            Console.Clear();
            bt1.PrintStats();
            Console.WriteLine($"What would you like to do with {bt1.name} today?");
            Console.WriteLine($"1) Feed {bt1.name}");
            Console.WriteLine($"2) Teach {bt1.name} a new word");
            Console.WriteLine($"3) Talk to {bt1.name}");
            Console.WriteLine($"4) Throw ball with {bt1.name}");
            Console.WriteLine($"5) Play with {bt1.name} and a dog");
            Console.WriteLine($"6) Go back to {t1.name} and delete {bt1.name}");
            Console.WriteLine("7) Do nothing");
            action = Console.ReadLine();

            if (action == "1")
            {
                bt1.Feed();
            }

            if (action == "2")
            {
                Console.WriteLine("What word?");
                string? word = Console.ReadLine();
                if (word?.Length > 0)
                {
                    bt1.Teach(word);
                }
            }

            if (action == "3")
            {
                bt1.Hi();
                Console.ReadLine();
            }

            if (action == "4")
            {
                bt1.Ball();
                Console.ReadLine();
            }

            if (action == "5")
            {
                bt1.Dog();
                Console.ReadLine();
            }

            if (action == "7")
            {
                Console.WriteLine("Doing nothing");
            }

            if (action == "printstats")
            {
                bt1.PrintStats();
                Console.ReadLine();
            }


            Console.ReadLine();
            bt1.Tick();
        }

    }

    if (action == "7")
    {
        Console.WriteLine("Doing nothing");
    }

    if (action == "printstats")
    {
        t1.PrintStats();
        Console.ReadLine();
    }

    t1.Tick();
}

Console.WriteLine($"Oh no! {t1.name} died!");
Console.WriteLine("Press Enter to quit.");

Console.ReadLine();
