public abstract class Tvarina : IGolos, IPoroda
{
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract string Poroda(); // Абстрактний метод для повернення породи

    public abstract void Golos(); // Абстрактний метод для звуку тварини
}
