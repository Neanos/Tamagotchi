using System;

public class Tamagotchi
{
    int hunger;
    int boredom;
    bool isAlive = true;
    Random generator = new Random();
    public string name;

    public void Feed()
    {
        Console.WriteLine($"{name} eats and is less hungry.");
        hunger -= 1;

    }

    public void Hi()
    {

    }

    public void Teach(string word)
    {

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
        Console.WriteLine($"{name}: Hunger: {hunger} Boredom: {boredom} ");

    }

    public bool GetAlive()
    {
        return isAlive;
    }

    void ReduceBoredom()
    {
        boredom -= 1;
    }
}
