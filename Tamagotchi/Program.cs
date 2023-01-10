
Tamagotchi t1 = new Tamagotchi();
BabyTamagotchi bt1 = new BabyTamagotchi();

Console.WriteLine("Please name your tamagotchi");
bt1.name = Console.ReadLine();

Console.WriteLine($"{bt1.name}");

bt1.Dog();

/* while(t1.GetAlive() == true)
{
    Console.Clear();
    t1.PrintStats();
    Console.WriteLine($"What would you like to do with {t1.name} today?");
    Console.WriteLine($"1) Feed {t1.name}");
    Console.WriteLine($"2) Teach {t1.name} a new word");
    Console.WriteLine($"3) Talk to {t1.name}");
    Console.WriteLine($"4) Throw ball with {t1.name}");
    Console.WriteLine($"5) Play with {t1.name} and a dog");
    Console.WriteLine("6) Do nothing");

    string? action = Console.ReadLine();
    if(action == "1"){
        t1.Feed();
    }

    if(action == "2"){
        Console.WriteLine("What word?");
        string? word = Console.ReadLine();
        if(word?.Length > 0) {
            t1.Teach(word);
        }
    }

    if(action == "3"){
        t1.Hi();
        Console.ReadLine();
    }

    if(action == "4")
    {
        t1.Ball();
        Console.ReadLine();
    }

    if(action =="5")
    {
        t1.Dog();
        Console.ReadLine();
    }

   if(action == "6"){
       Console.WriteLine("Doing nothing");
    }
    
    if(action == "printstats"){
        t1.PrintStats();
        Console.ReadLine();
    }

    t1.Tick();
}
 */
/* Console.WriteLine($"Oh no! {t1.name} died!");
Console.WriteLine("Press Enter to quit."); */

Console.ReadLine();
