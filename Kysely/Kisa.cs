namespace Kysely
{
    internal class Kisa
    {
        //property
        public List<Kysymys> Kysymykset { get; set; }

        //constructori
        public Kisa()
        {
            Kysymykset = new List<Kysymys>();
            var k1 = new Kysymys("Onko Buenos Aires Argentiinan pääkaupunki?", true);
            var k2 = new Kysymys("Onko Pariisi Euroopassa?", true);
            var k3 = new Kysymys("Onko maailma pyöreä?", true);
            var k4 = new Kysymys("Onko vuodessa 360 päivää?", false);
            var k5 = new Kysymys("Onko Helsingissä yli 1 miljoona asukasta?", false);
            var k6 = new Kysymys("Onko Ruotsi Suomen naapurimaa?", true);
            var k7 = new Kysymys("Onko tunnissa 3600 sekuntia?", true);
            var k8 = new Kysymys("Onko kettu suurempi kuin norsu?", false);
            var k9 = new Kysymys("Tekevätkö mehiläiset hunajaa?", true);
            var k10 = new Kysymys("Onko joulupukki olemassa?", true);
            var k11 = new Kysymys("Onko auringonkukka punainen?", false);
            var k12 = new Kysymys("Onko Sauli Niinistö Suomen presidentti?", true);
            var k13 = new Kysymys("Onko Antti Holma Suomen kansallisaarre?", true);
            var k14 = new Kysymys("Nouseeko aurinko lännestä?", false);
            var k15 = new Kysymys("Toimiiko tämä luokka?", true);

            Kysymykset.Add(k1);
            Kysymykset.Add(k2);
            Kysymykset.Add(k3);
            Kysymykset.Add(k4);
            Kysymykset.Add(k5);
            Kysymykset.Add(k6);
            Kysymykset.Add(k7);
            Kysymykset.Add(k8);
            Kysymykset.Add(k9);
            Kysymykset.Add(k10);
            Kysymykset.Add(k11);
            Kysymykset.Add(k12);
            Kysymykset.Add(k13);
            Kysymykset.Add(k14);
            Kysymykset.Add(k15);
        }

        //metodit
        public void LisääKysymys(string kys, bool vast)
        {
            Kysymykset.Add(new Kysymys(kys, vast));
        }

        public List<Kysymys> SekoitaLista(List<Kysymys> Kysymykset)
        {
            Random rnd = new Random();
            List<Kysymys> sekoitetutKysymykset = Kysymykset.OrderBy(i => rnd.Next()).ToList();
            return sekoitetutKysymykset;
        }

        public void TehdäänKysely(int kysymystenMäärä=5, string nimi="N/A")
        {
            List<Kysymys> sekoitetutKysymykset = SekoitaLista(Kysymykset);
            var oikeatVastaukset = 0;
            for (int i = 0; i < kysymystenMäärä; i++)
            {
                Console.WriteLine(sekoitetutKysymykset[i].Kys);
                var input = Console.ReadLine().ToLower();
                bool vastaus;
                bool onkoBool = bool.TryParse(input, out vastaus);
                while (onkoBool == false)
                {
                    Console.WriteLine("vain 'true' tai 'false':");
                    string input2 = Console.ReadLine();
                    if (bool.TryParse(input2, out vastaus) == true)
                    {
                        onkoBool = true;
                    }
                }
                if (vastaus.Equals(sekoitetutKysymykset[i].Vast))
                {
                    oikeatVastaukset++;
                }
            }
            TulostaVastaus(oikeatVastaukset, kysymystenMäärä, nimi);
        }

        public static void TulostaVastaus(int oikeatVastaukset, int kysymystenMäärä, string nimi)
        {
            if (oikeatVastaukset >= kysymystenMäärä / 2)
            {
                Console.WriteLine($"Hyvin meni {nimi}! Tuloksesi on {oikeatVastaukset}/{kysymystenMäärä}.");
            }
            else
            {
                Console.WriteLine($"Voisi mennä paremminkin {nimi}! Tuloksesi on {oikeatVastaukset}/{kysymystenMäärä}.");
            }
        }
    }
}
