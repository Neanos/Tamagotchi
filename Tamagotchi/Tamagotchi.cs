using System;
using System.Collections.Generic;

public class Tamagotchi
{
    int hunger;
    int boredom;
    bool isAlive = true;
    private List<string> words = new List<string>() { "Hi" };
    Random generator = new Random();
    Random generator2 = new Random();
    Random generator3 = new Random();
    int attraper;
    public string? name;

    public void Feed()
    {
        Console.WriteLine($"{name} eats and is less hungry.");
        hunger -= 2;
        Console.ReadLine();

    }

    public void Hi()
    {
        int wordNum = generator.Next(words.Count);
        Console.WriteLine($"{name} says {words[wordNum]}");
        ReduceBoredom();

    }

    public void Teach(string word)
    {
        Console.WriteLine($"{name} learns {word}");
        words.Add(word);
        ReduceBoredom();
        Console.ReadLine();

    }

    public void Tick()
    {
        hunger++;
        boredom++;

        if (hunger > 10)
        {
            isAlive = false;
        }

        if (boredom > 10)
        {
            isAlive = false;
        }

    }

    public void PrintStats()
    {
        Console.WriteLine($"Name: {name}: Hunger: {hunger} Boredom: {boredom}  Vocabulary: {words.Count}");

    }

    public bool GetAlive()
    {
        return isAlive;
    }

    public void Ball()
    {
        int attraper = generator2.Next(2);
        if (attraper == 0)
        {
            Console.WriteLine($"{name} catches the ball!");
        }

        if (attraper == 1)
        {
            Console.WriteLine($"{name} misses the ball");
        }

        ReduceBoredom();

    }

    public void Dog()
    {
        int dog = generator3.Next(20);

        if (dog == 0)
        {
            Console.WriteLine($"Oh no! {name} didn't out run the dog!");
            isAlive = false;
        }
        else
        {
            Console.WriteLine($"{name} managed to out run the dog and got away. This time.");
            isAlive = true;
            ReduceBoredom();
        }

    }

    protected void ReduceBoredom()
    {
        boredom -= 2;
        Console.WriteLine($"{name} is now less bored!");
        Console.ReadLine();
    }


}

