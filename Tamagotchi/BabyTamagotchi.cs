using System;

public class BabyTamagotchi : Tamagotchi
{
    public int Attention { get; set; }
    Random generator = new Random();

    public void GiveAttention()
    {
        Attention -= 2;

    }

    public void Dog()
    {
         int dog = generator.Next(20);

        if (dog == 0)
        {
            Console.WriteLine($"Oh no! {name} didn't out run the dog!");
            ReduceBoredom();
        }
        else
        {
            Console.WriteLine($"{name} managed to out run the dog and got away. This time.");
            ReduceBoredom();
        }
    }
}
