namespace Kysely
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa visailuun!");
            Console.WriteLine("Syötä vastaukset muodossa true / false");
            Console.Write("Aloita kirjoittamalla nimesi: ");
            string nimi = Console.ReadLine();
            nimi = TarkistaNimi(nimi);

            Kisa kisa = new Kisa();
            kisa.LisääKysymys("Onko tämä lisätty kysymys?", true);
            var kysymystenMäärä = 10;
            kisa.TehdäänKysely(kysymystenMäärä, nimi);  
        }

        static string TarkistaNimi(string nimi)
        {
            while (String.IsNullOrWhiteSpace(nimi))
            {
                Console.WriteLine("Kirjoita jokin nimi:");
                string input2 = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input2))
                {
                    nimi = input2;
                }
            }
            return nimi;    
        }
    }
}