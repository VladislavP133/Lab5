public interface IAnimal
{
    void Golos();  // Метод для звуку тварини
    string Poroda();  // Метод для повернення породи
    string Name { get; set; }  // Властивість для імені
    int Age { get; set; }  // Властивість для віку
}
