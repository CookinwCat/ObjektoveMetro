using ObjektoveMetroú;
using Spectre.Console;

var highlightColor = new Style().Foreground(Color.Red1);

string[] poleLinkaA = { "Nemocnice Motol", "Petřiny", "Nádraží Veleslavní", "Bořislavka", "Dejvická", "Hradčanská", "Malostranská", "Staroměstská",
          "Můstek", "Muzeum", "Náměstí míru", "Jiřího z Poděbrad", "Flora", "Želivského", "Strašnická", "Skalka", "Depo Hostivař" };
string[] poleLinkaB = { "Zličín", "Stodůlky", "Luka", "Lužiny", "Hůrka", "Nové Butovice", "Jinonice", "Radlická", "Smíchovské nádraží", "Anděl", "Karlovo náměstí",
          "Národní třída", "Můstek", "Náměstí Republiky", "Florenc", "Křížova", "Invalidovna", "Českomoravská", "Vysočasnská", "Kolbenova", "Hloubětín", "Rajská zahrada", "Černý Most"};
string[] poleLinkaC = {"Letňany", "Prosek", "Střížkov", "Ládví", "Kobylisy", "Nádraží Holešovice", "Vltavská", "Florenc", "Hlavní nádraží", "Muzeum",
          "I. P. Pavlova", "Vyšehrad", "Pražského povstání", "Pankrác", "Budějovická", "Kačerov", "Roztyly", "Chodov", "Opatov", "Háje"};
string[] poleLinkaD = { "Depo Písnice", "Písnice", "Libuš", "Nové Dvory", "Nemocnice Krč", "Nádraží Krč", "Olbrachtova", "Pankrác", "Náměstí Bratří Synků", "Náměstí Míru"};
string volba;

        volba = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Jakou linku chceš?")
        .PageSize(10)
        .HighlightStyle(highlightColor)
        .AddChoices(new[] {
           "Linka A", "Linka B", "Linka C", "Linka D"
        }));

if (volba == "Linka A")
{
    LinkaMetra LinkaA = new LinkaMetra() { Linka = "Linka A", Barva = "zelená", Aktivni = true, Stanice = poleLinkaA };
    LinkaA.NastavLinku();
    volba = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
             .Title("Co chceš udělat?")
            .PageSize(10)
            .HighlightStyle(highlightColor)
            .AddChoices(new[] {
           "Vypiš všechny stanice", "Vypiš první a poslední", "Čas cesty"
            }));
    if(volba == "Vypiš všechny stanice")
    {
        LinkaA.VypisStanice();
    }
    else if(volba == "Vypiš první a poslední")
    {
        LinkaA.FirstLast();
    }
    else if(volba == "Čas cesty")
    {
        LinkaA.CasCesty();
    }
}
else if(volba == "Linka B")
{
    LinkaMetra LinkaB = new LinkaMetra() { Linka = "Linka B", Barva = "žlutá", Aktivni = true, Stanice = poleLinkaB };
    LinkaB.NastavLinku();
    volba = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
             .Title("Co chceš udělat?")
            .PageSize(10)
            .HighlightStyle(highlightColor)
            .AddChoices(new[] {
           "Všechny stanice", "První a poslední", "Čas cesty"
            }));
    if (volba == "Všechny stanice")
    {
        LinkaB.VypisStanice();
    }
    else if (volba == "První a poslední")
    {
        LinkaB.FirstLast();
    }
    else if (volba == "Čas cesty")
    {
        LinkaB.CasCesty();
    }
}
else if(volba == "Linka C")
{
    LinkaMetra LinkaC = new LinkaMetra() { Linka = "Linka C", Barva = "červená", Aktivni = true, Stanice = poleLinkaC };
    LinkaC.NastavLinku();
    volba = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
             .Title("Co chceš udělat?")
            .PageSize(10)
            .HighlightStyle(highlightColor)
            .AddChoices(new[] {
           "Všechny stanice", "První a poslední", "Čas cesty"
            }));
    if (volba == "Všechny stanice")
    {
        LinkaC.VypisStanice();
    }
    else if (volba == "První a poslední")
    {
        LinkaC.FirstLast();
    }
    else if (volba == "Čas cesty")
    {
        LinkaC.CasCesty();
    }
}
else if(volba == "Linka D")
{
    LinkaMetra LinkaD = new LinkaMetra() { Linka = "Linka D", Barva = "modrá", Aktivni = true, Stanice = poleLinkaD };
        LinkaD.NastavLinku();
    volba = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
             .Title("Co chceš udělat?")
            .PageSize(10)
            .HighlightStyle(highlightColor)
            .AddChoices(new[] {
           "Všechny stanice", "První a poslední", "Čas cesty"
            }));
    if (volba == "Všechny stanice")
    {
        LinkaD.VypisStanice();
    }
    else if (volba == "První a poslední")
    {
        LinkaD.FirstLast();
    }
    else if (volba == "Čas cesty")
    {
        LinkaD.CasCesty();
    }
}