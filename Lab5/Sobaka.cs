using System;

public class Sobaka : Tvarina
{
    public override string Poroda()
    {
        return "Собака";
    }

    public override void Golos()
    {
        Console.WriteLine("Собака: Гав!");
    }
}
