using System;
using System.Collections.Generic;

public class Tamagotchi
{
    int hunger;
    int boredom;
    bool isAlive = true;
    private List<string> words = new List<string>(){"Hi"};
    Random generator = new Random();
    public string name = "Alice";

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

        if(hunger > 10){
            isAlive = false;
        }

        if(boredom > 10){
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

    void ReduceBoredom()
    {
        boredom -= 2;
        Console.WriteLine($"{name} is now less bored!");
        Console.ReadLine();
    }
}
