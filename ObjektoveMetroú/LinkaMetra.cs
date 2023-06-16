using Spectre.Console;
using System.Security.Cryptography.X509Certificates;

namespace ObjektoveMetroú
{
    internal class LinkaMetra
    {
        public string Linka { get; set; }
        public string[] Stanice { get; set; }
        public bool Aktivni { get; set; }
        public string Barva { get; set; }

        public void VypisStanice()
        {
            if (Stanice.Length > 0)
            {
                foreach (var item in Stanice)
                {
                    if (Barva == "zelená")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (Barva == "červená")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (Barva == "žlutá")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (Barva == "modrá")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.WriteLine(item);
                }
            }
        }
        public void FirstLast()
        {
            if (Stanice.Length >= 2)
            {
                if (Barva == "zelená")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (Barva == "červená")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (Barva == "žlutá")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (Barva == "modrá")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.WriteLine(Stanice[0]);
                Console.WriteLine(Stanice[Stanice.Length-1]);
            }
        }
        public void NastavLinku()
        {
            if (Barva == "zelená")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if(Barva == "červená")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if(Barva == "žlutá")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if(Barva == "modrá")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.WriteLine($"Vítej na lince {Linka}");
        }
        public void CasCesty()
        {
            int indexprvni = 0;
            int indexdruhy = 0;
            var highlightColor = new Style().Foreground(Color.Red1);
            string volba = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Jakou linku chceš?")
                .PageSize(10)
                .HighlightStyle(highlightColor)
            .AddChoices(new[] {
           "Linka A", "Linka B", "Linka C", "Linka D"
                }));
            if(volba == "Linka A")
            {
                Console.WriteLine("Vyber 1.stanici");
                string stanice1 = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("")
                .PageSize(10)
                .HighlightStyle(highlightColor)
                 .AddChoices(new[] {
                "Nemocnice Motol", "Petřiny", "Nádraží Veleslavní", "Bořislavka", "Dejvická", "Hradčanská", "Malostranská", "Staroměstská",
                "Můstek", "Muzeum", "Náměstí míru", "Jiřího z Poděbrad", "Flora", "Želivského", "Strašnická", "Skalka", "Depo Hostivař"
             }));
                indexprvni = Array.IndexOf(Stanice, stanice1);
                Console.WriteLine("Vyber 2.stanici");
                string stanice2 = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("")
                    .PageSize(10)
                .HighlightStyle(highlightColor)
                    .AddChoices(new[] {
                "Nemocnice Motol", "Petřiny", "Nádraží Veleslavní", "Bořislavka", "Dejvická", "Hradčanská", "Malostranská", "Staroměstská",
                "Můstek", "Muzeum", "Náměstí míru", "Jiřího z Poděbrad", "Flora", "Želivského", "Strašnická", "Skalka", "Depo Hostivař"
                 }));
                indexdruhy = Array.IndexOf(Stanice, stanice2);
            }
            else if (volba == "Linka B")
            {
                Console.WriteLine("Vyber 1.stanici");
                string stanice1 = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("")
                .PageSize(10)
                .HighlightStyle(highlightColor)
                 .AddChoices(new[] {
                    "Zličín", "Stodůlky", "Luka", "Lužiny", "Hůrka", "Nové Butovice", "Jinonice", "Radlická", "Smíchovské nádraží", "Anděl", "Karlovo náměstí",
                    "Národní třída", "Můstek", "Náměstí Republiky", "Florenc", "Křížova", "Invalidovna", "Českomoravská", "Vysočasnská", "Kolbenova", "Hloubětín", "Rajská zahrada", "Černý Most"
             }));
                indexprvni = Array.IndexOf(Stanice, stanice1);
                Console.WriteLine("Vyber 2.stanici");
                string stanice2 = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("")
                    .PageSize(10)
                .HighlightStyle(highlightColor)
                    .AddChoices(new[] {
                         "Zličín", "Stodůlky", "Luka", "Lužiny", "Hůrka", "Nové Butovice", "Jinonice", "Radlická", "Smíchovské nádraží", "Anděl", "Karlovo náměstí",
                    "Národní třída", "Můstek", "Náměstí Republiky", "Florenc", "Křížova", "Invalidovna", "Českomoravská", "Vysočasnská", "Kolbenova", "Hloubětín", "Rajská zahrada", "Černý Most"
                 }));
                indexdruhy = Array.IndexOf(Stanice, stanice2);
            }
            else if (volba == "Linka C")
            {

                Console.WriteLine("Vyber 1.stanici");
                string stanice1 = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("")
                .PageSize(10)
                .HighlightStyle(highlightColor)
                 .AddChoices(new[] {
                    "Letňany", "Prosek", "Střížkov", "Ládví", "Kobylisy", "Nádraží Holešovice", "Vltavská", "Florenc", "Hlavní nádraží", "Muzeum",
                     "I. P. Pavlova", "Vyšehrad", "Pražského povstání", "Pankrác", "Budějovická", "Kačerov", "Roztyly", "Chodov", "Opatov", "Háje"
             }));
                indexprvni = Array.IndexOf(Stanice, stanice1);
                Console.WriteLine("Vyber 2.stanici");
                string stanice2 = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("")
                    .PageSize(10)
                .HighlightStyle(highlightColor)
                    .AddChoices(new[] {
                    "Letňany", "Prosek", "Střížkov", "Ládví", "Kobylisy", "Nádraží Holešovice", "Vltavská", "Florenc", "Hlavní nádraží", "Muzeum",
                     "I. P. Pavlova", "Vyšehrad", "Pražského povstání", "Pankrác", "Budějovická", "Kačerov", "Roztyly", "Chodov", "Opatov", "Háje"
                 }));
                indexdruhy = Array.IndexOf(Stanice, stanice2);
            }
            else if (volba == "Linka D")
            {
                Console.WriteLine("Vyber 1.stanici");
                string stanice1 = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("")
                .PageSize(10)
                .HighlightStyle(highlightColor)
                 .AddChoices(new[] {
                    "Depo Písnice", "Písnice", "Libuš", "Nové Dvory", "Nemocnice Krč", "Nádraží Krč", "Olbrachtova", "Pankrác", "Náměstí Bratří Synků", "Náměstí Míru"
             }));
                indexprvni = Array.IndexOf(Stanice, stanice1);
                Console.WriteLine("Vyber 2.stanici");
                string stanice2 = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("")
                    .PageSize(10)
                .HighlightStyle(highlightColor)
                    .AddChoices(new[] {
                        "Depo Písnice", "Písnice", "Libuš", "Nové Dvory", "Nemocnice Krč", "Nádraží Krč", "Olbrachtova", "Pankrác", "Náměstí Bratří Synků", "Náměstí Míru"
                 }));
                indexdruhy = Array.IndexOf(Stanice, stanice2);
            }
            int cas = Math.Abs((indexprvni - indexdruhy) * 2);
            Console.WriteLine($"Čas cesty je {cas}");
        }
        public void LinkaA()
        {
            Linka = "Linka A";
            Aktivni = true;
        }
        public void LinkaB()
        {
            
            Linka = "Linka B";
            Aktivni = true;
        }
        public void LinkaC()
        {
            Linka = "Linka C";
            Aktivni = true;
        }
        public void LinkaD()
        {
            Linka = "Linka D";
            Aktivni = false;
        }
    }
}

