namespace zadanie3
{
    public static class ProgramHelpers
    {

    }

    class Program
    {
        static void Main()
        {

            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string fileName = $"users-{timestamp}.csv";

            try
            {

                using (StreamWriter writer = new StreamWriter(fileName))
                {

                    writer.WriteLine("LP,Imię,Nazwisko,Rok urodzenia");


                    Random random = new Random();
                    for (int i = 1; i <= 100; i++)
                    {
                        string imie = LosoweImie(random);
                        string nazwisko = LosoweNazwisko(random);
                        int rokUrodzenia = random.Next(1990, 2001);


                        writer.WriteLine($"{i},{imie},{nazwisko},{rokUrodzenia}");
                    }
                }

                Console.WriteLine($"Plik {fileName} został wygenerowany pomyślnie.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }
        }


        static string LosoweImie(Random random)
        {
            string[] imiona = { "Ania", "Kasia", "Basia", "Zosia" };
            return imiona[random.Next(imiona.Length)];
        }


        static string LosoweNazwisko(Random random)
        {
            string[] nazwiska = { "Kowalska", "Nowak" };
            return nazwiska[random.Next(nazwiska.Length)];
        }
    }
}