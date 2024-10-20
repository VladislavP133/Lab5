using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
      
        Console.OutputEncoding = Encoding.UTF8;

        // Створюємо кішку
        Tvarina myCat = new Kishka { Name = "Мурка", Age = 3 };
        // Створюємо собаку
        Tvarina myDog = new Sobaka { Name = "Бобік", Age = 5 };

        // Виводимо інформацію про кішку
        string catInfo = $"{myCat.Name}, {myCat.Age} років, порода: {myCat.Poroda()}";
        Console.WriteLine(catInfo);
        myCat.Golos();

        // Виводимо інформацію про собаку
        string dogInfo = $"{myDog.Name}, {myDog.Age} років, порода: {myDog.Poroda()}";
        Console.WriteLine(dogInfo);
        myDog.Golos();

        // Записуємо інформацію про кота у файл
        string catFilePath = "cat_info.txt"; 
        using (var writer = new StreamWriter(catFilePath, false, Encoding.UTF8))
        {
            writer.WriteLine(catInfo);
        }
        Console.WriteLine($"Інформація про кота успішно записана у файл {catFilePath}.");

        // Записуємо інформацію про собаку у файл
        string dogFilePath = "dog_info.txt";
        using (var writer = new StreamWriter(dogFilePath, false, Encoding.UTF8))
        {
            writer.WriteLine(dogInfo);
        }
        Console.WriteLine($"Інформація про собаку успішно записана у файл {dogFilePath}.");
    }
}
