
Tamagotchi t = new Tamagotchi();
t.name = "Henry";
t.Tick();
t.Tick();
t.Tick();
t.PrintStats();
t.Feed();
t.PrintStats();
Console.WriteLine(t.GetAlive());

Console.ReadLine();
