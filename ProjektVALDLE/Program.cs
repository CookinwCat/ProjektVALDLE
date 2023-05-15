//Streak momentálně nicht worken
//Abilitky jsou jen v poli 
using Spectre.Console;

string releaseDate = "";
string role = "";
string Narodnost = "";
string GreleaseDate = "";
string Grole = "";
string GNarodnost = "";
string gender = "";
string Ggender = "";
string choice;
int Streak = 0;
string choice2;
int nahodnyindex = 0;
string gamemode = "";
string AbilityType = "";
string AbilityBtn = "";
string hadanaAbilita = "";
string odhadAbility = "";

string[] agents = {"Jett","Raze", "Reyna", "Neon", "Phoenix", "Yoru", "Gekko",
    "Sova", "Fade", "Kayo","Skye", "Breach", "Cypher", "Sage", "Killjoy",
    "Chamber", "Omen", "Viper", "Harbor", "Brimstone", "Astra"};
string[] abilities = {"Incendiary", "Sky smoke", "Stim beacon", "Orbital strike", "Curveball", "Hot hands", "Blaze", "Run it back", "Slow orb", "Healing orb",
    "Barrier orb", "Resurrection", "Shock bolt", "Recon bolt", "Owl drone", "Hunter´s fury", "Poison cloud", "Toxic screen", "Snake bite", "Viper´s pit",
 "Cyber cage", "Spycam", "Trapwire", "Neural theft", "Devour", "Dismiss", "Leer", "Empress", 
"Alarmbot", "Turret", "Nanoswarm", "Lockdown", "Flashpoint", "Fault line","Aftershock", "Rolling thunder", "Paranoia", "Dark cover", "Shrouded step", "From the shadows","Updraft",
    "Dash", "Cloudburst", "Blade storm", "Blast pack", "Paint shells", "Boombot", "Showstopper", "Trailblazer", "Guiding light", "Regrowth", "Seekers", "Blindside", "Gatecrash",
    "Fakeout", "Dimensional drift", "Nova pulse", "Nebula", "Gravity well", "Cosmic divide", "Flash/Drive", "Zero/Point", "Frag/Ment", "Null/Cmd", "Headhunter", "Rendezvous",
    "Trademark", "Tour De Force", "Relay bolt", "High gear", "Fast lane", "Overdrive", "Seize", "Haunt", "Prowler", "Nightfall", "Cove", "High tide", "Cascade", "Reckoning",
    "Wingman", "Dizzy", "Moshpit", "Thrash"};
Console.ForegroundColor = Color.Red1;
Console.WriteLine("VALDLE!");
Console.ForegroundColor= ConsoleColor.White;

Menu:
var highlightColor = new Style().Foreground(Color.Red1);
gamemode = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Chceš hádat agenty nebo abilitky?")
        .PageSize(10)
        .HighlightStyle(highlightColor)
        .AddChoices(new[] {
           "Agenty", "Abilitky"
        }));

if (gamemode == "Agenty")
{
    Random generatorCisel = new Random();
    nahodnyindex = generatorCisel.Next(agents.Length);
    Console.Clear();
    string hadanyAgent = agents[nahodnyindex];
    if (hadanyAgent == "Jett")
    {
        releaseDate = "Beta";
        role = "Duelist";
        Narodnost = "Jižní Korea";
        gender = "žena";
    }
    else if (hadanyAgent == "Raze")
    {
        releaseDate = "1.0";
        role = "Duelist";
        Narodnost = "Brazílie";
        gender = "žena";
    }
    else if (hadanyAgent == "Reyna")
    {
        releaseDate = "1.0";
        role = "Duelist";
        Narodnost = "Mexico";
        gender = "žena";
    }
    else if (hadanyAgent == "Neon")
    {
        releaseDate = "4.0";
        role = "Duelist";
        Narodnost = "Filipíny";
        gender = "žena";
    }
    else if (hadanyAgent == "Phoenix")
    {
        releaseDate = "Beta";
        role = "Duelist";
        Narodnost = "Británie";
        gender = "muž";
    }
    else if (hadanyAgent == "Yoru")
    {
        releaseDate = "2.0";
        role = "Duelist";
        Narodnost = "Japonsko";
        gender = "muž";
    }
    else if (hadanyAgent == "Gekko")
    {
        releaseDate = "6.04";
        role = "Initiator";
        Narodnost = "USA";
        gender = "muž";
    }
    else if (hadanyAgent == "Sova")
    {
        releaseDate = "Beta";
        role = "Initiator";
        Narodnost = "Rusko";
        gender = "muž";
    }
    else if (hadanyAgent == "Fade")
    {
        releaseDate = "4.08";
        role = "Initiator";
        Narodnost = "Turecko";
        gender = "žena";
    }
    else if (hadanyAgent == "Kayo")
    {
        releaseDate = "3.0";
        role = "Initiator";
        Narodnost = "Alternative Earth";
        gender = "muž";
    }
    else if (hadanyAgent == "Skye")
    {
        releaseDate = "1.11";
        role = "Initiator";
        Narodnost = "Austrálie";
        gender = "žena";
    }
    else if (hadanyAgent == "Breach")
    {
        releaseDate = "Beta";
        role = "Initiator";
        Narodnost = "Švédsko";
        gender = "muž";
    }
    else if (hadanyAgent == "Cypher")
    {
        releaseDate = "Beta";
        role = "Sentinel";
        Narodnost = "Maroko";
        gender = "muž";
    }
    else if (hadanyAgent == "Sage")
    {
        releaseDate = "Beta";
        role = "Sentinel";
        Narodnost = "Čína";
        gender = "žena";
    }
    else if (hadanyAgent == "Killjoy")
    {
        releaseDate = "1.05";
        role = "Sentinel";
        Narodnost = "Německo";
        gender = "žena";
    }
    else if (hadanyAgent == "Chamber")
    {
        releaseDate = "3.10";
        role = "Sentinel";
        Narodnost = "Francie";
        gender = "muž";
    }
    else if (hadanyAgent == "Omen")
    {
        releaseDate = "Beta";
        role = "Controller";
        Narodnost = "Unknown";
        gender = "muž";
    }
    else if (hadanyAgent == "Viper")
    {
        releaseDate = "Beta";
        role = "Controller";
        Narodnost = "USA";
        gender = "žena";
    }
    else if (hadanyAgent == "Harbor")
    {
        releaseDate = "5.08";
        role = "Controller";
        Narodnost = "Indie";
        gender = "muž";
    }
    else if (hadanyAgent == "Brimstone")
    {
        releaseDate = "Beta";
        role = "Controller";
        Narodnost = "USA";
        gender = "muž";
    }
    else if (hadanyAgent == "Astra")
    {
        releaseDate = "2.04";
        role = "Controller";
        Narodnost = "Ghana";
        gender = "žena";
    }

    while (true)
    {
        Console.WriteLine("Tvuj guess?");
        string odhadAgenta = Console.ReadLine();
        if (odhadAgenta == "Jett")
        {
            GreleaseDate = "Beta";
            Grole = "Duelist";
            GNarodnost = "Jižní Korea";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Raze")
        {
            GreleaseDate = "1.0";
            Grole = "Duelist";
            GNarodnost = "Brazílie";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Reyna")
        {
            GreleaseDate = "1.0";
            Grole = "Duelist";
            GNarodnost = "Mexico";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Neon")
        {
            GreleaseDate = "4.0";
            Grole = "Duelist";
            GNarodnost = "Filipíny";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Phoenix")
        {
            GreleaseDate = "Beta";
            Grole = "Duelist";
            GNarodnost = "Británie";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Yoru")
        {
            GreleaseDate = "2.0";
            Grole = "Duelist";
            GNarodnost = "Japonsko";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Gekko")
        {
            GreleaseDate = "6.04";
            Grole = "Initiator";
            GNarodnost = "USA";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Sova")
        {
            GreleaseDate = "Beta";
            Grole = "Initiator";
            GNarodnost = "Rusko";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Fade")
        {
            GreleaseDate = "4.08";
            Grole = "Initiator";
            GNarodnost = "Turecko";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Kayo")
        {
            GreleaseDate = "3.0";
            Grole = "Initiator";
            GNarodnost = "Alternative Earth";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Skye")
        {
            GreleaseDate = "1.11";
            Grole = "Initiator";
            GNarodnost = "Austrálie";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Breach")
        {
            GreleaseDate = "Beta";
            Grole = "Initiator";
            GNarodnost = "Švédsko";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Cypher")
        {
            GreleaseDate = "Beta";
            Grole = "Sentinel";
            GNarodnost = "Maroko";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Sage")
        {
            GreleaseDate = "Beta";
            Grole = "Sentinel";
            GNarodnost = "Čína";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Killjoy")
        {
            GreleaseDate = "1.05";
            Grole = "Sentinel";
            GNarodnost = "Německo";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Chamber")
        {
            GreleaseDate = "3.10";
            Grole = "Sentinel";
            GNarodnost = "Francie";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Omen")
        {
            GreleaseDate = "Beta";
            Grole = "Controller";
            GNarodnost = "Unknown";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Viper")
        {
            GreleaseDate = "Beta";
            Grole = "Controller";
            GNarodnost = "USA";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Harbor")
        {
            GreleaseDate = "5.08";
            Grole = "Controller";
            GNarodnost = "Indie";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Brimstone")
        {
            GreleaseDate = "Beta";
            Grole = "Controller";
            GNarodnost = "USA";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Astra")
        {
            GreleaseDate = "2.04";
            Grole = "Controller";
            GNarodnost = "Ghana";
            Ggender = "žena";
        }
        if (odhadAgenta == hadanyAgent)
        {
            if (releaseDate == GreleaseDate)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Release date {GreleaseDate}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Release date {GreleaseDate}");
            }
            Thread.Sleep(100);
            if (role == Grole)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Role {Grole}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Role {Grole}");
            }
            Thread.Sleep(100);
            if (Narodnost == GNarodnost)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Národnost {GNarodnost}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Národnost {GNarodnost}");
            }
            Thread.Sleep(100);
            if (gender == Ggender)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Pohlaví {Ggender}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Pohlaví {Ggender}");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("GG!");
            Thread.Sleep(1000);
            Console.WriteLine("1)Menu\n2)exit");
            choice2 = Console.ReadLine();
            if (choice2 == "1")
            {
                Console.Clear();
                goto Menu;
            }
            else if (choice2 == "2")
            {
                Console.Clear();
                goto exit;
            }
            else
            {
                Console.WriteLine("?;-;");
            }
        }
        else
        {
            if(releaseDate == GreleaseDate)
            { 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Release date {GreleaseDate}");
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine($"Release date {GreleaseDate}");
            }
            Thread.Sleep(100);
            if(role == Grole)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Role {Grole}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Role {Grole}");
            }
            Thread.Sleep(100);
            if (Narodnost == GNarodnost)
            {
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine($"Národnost {GNarodnost}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Národnost {GNarodnost}");
            }
            Thread.Sleep(100);
            if (gender == Ggender)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Pohlaví {Ggender}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Pohlaví {Ggender}");
            }
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
else if(gamemode == "Abilitky")
{
    Random generatorCisel = new Random();
    nahodnyindex = generatorCisel.Next(abilities.Length);
    if (hadanaAbilita == "Incendiary")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Sky smoke")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Stim beacon")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Orbital strike")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Curveball")
    {
        AbilityType = "Flash";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Hot hands")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Blaze")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Run it back")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Slow orb")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Healing orb")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Barrier orb")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Resurrection")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Shock bolt")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Recon bolt")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Owl drone")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Hunter´s fury")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Poison cloud")
    {
        AbilityType = "Smoke/Vision blocl";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Toxic screen")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Snake bite")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Viper´s pit")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Cyber cage")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Spycam")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Trapwire")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Neural theft")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "X";
    }
}
exit:
Console.WriteLine("To bylo moc ez.... Myslim že je čas nerfnout Chambera.");