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
string GAbilityType = "";
string GAbilityBtn = "";

string[] agents = {"Jett","Raze", "Reyna", "Neon", "Phoenix", "Yoru", "Gekko",
    "Sova", "Fade", "Kayo","Skye", "Breach", "Cypher", "Sage", "Killjoy",
    "Chamber", "Omen", "Viper", "Harbor", "Brimstone", "Astra"};
string[] abilities = {"Incendiary", "Sky smoke", "Stim beacon", "Orbital strike", "Curveball", "Hot hands", "Blaze", "Run it back", "Slow orb", "Healing orb",
    "Barrier orb", "Resurrection", "Shock bolt", "Recon bolt", "Owl drone", "Hunter´s fury", "Poison cloud", "Toxic screen", "Snake bite", "Viper´s pit",
 "Cyber cage", "Spycam", "Trapwire", "Neural theft", "Devour", "Dismiss", "Leer", "Empress", 
"Alarmbot", "Turret", "Nanoswarm", "Lockdown", "Flashpoint", "Fault line","Aftershock", "Rolling thunder", "Paranoia", "Dark cover", "Shrouded step", "From the shadows","Updraft",
    "Dash", "Cloudburst", "Blade storm", "Blast pack", "Paint shells", "Boombot", "Showstopper", "Trailblazer", "Guiding light", "Regrowth", "Seekers", "Blindside", "Gatecrash",
    "Fakeout", "Dimensional drift", "Nova pulse", "Nebula", "Gravity well", "Cosmic divide", "Flash/Drive", "Zero/Point", "Frag/Ment", "Null/Cmd", "Headhunter", "Rendezvous",
    "Trademark", "Tour de force", "Relay bolt", "High gear", "Fast lane", "Overdrive", "Seize", "Haunt", "Prowler", "Nightfall", "Cove", "High tide", "Cascade", "Reckoning",
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
            Thread.Sleep(1000);
            choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("GG!")
                    .PageSize(10)
                    .HighlightStyle(highlightColor)
                    .AddChoices(new[] {
           "Menu", "Exit"
                    }));
            if (choice == "Menu")
            {
                goto Menu;
            }
            else if(choice == "Exit")
            {
                goto exit;
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
    hadanaAbilita = abilities[nahodnyindex];
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
    else if (hadanaAbilita == "Devour")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Dismiss")
    {
        AbilityType = "Mobility";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Leer")
    {
        AbilityType = "Flash";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Empress")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Alarmbot")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Turret")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Nanoswarm")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Lockdown")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Flashpoint")
    {
        AbilityType = "Flash";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Fault line")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Aftershock")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Rolling thunder")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Paranoia")
    {
        AbilityType = "Flash";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Dark cover")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Shrouded step")
    {
        AbilityType = "Mobility";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "From the shadows")
    {
        AbilityType = "Mobility";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Updraft")
    {
        AbilityType = "Mobility";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Dash")
    {
        AbilityType = "Mobility";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Cloudburst")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Blade storm")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Blast pack")
    {
        AbilityType = "Mobility";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Paint shells")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Boom bot")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Showstopper")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Trailblazer")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Guiding light")
    {
        AbilityType = "Flash";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Regrowth")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Seekers")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Blindside")
    {
        AbilityType = "Flash";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Gatecrash")
    {
        AbilityType = "Mobility";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Fakeout")
    {
        AbilityType = "Flash";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Dimensional drift")
    {
        AbilityType = "Mobility";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Nova pulse")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Nebula")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Gravity well")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Cosmic divide")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Flash/Drive")
    {
        AbilityType = "Flash";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Zero/Point")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Frag/Ment")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Null/Cmd")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Headhunter")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Rendezvous")
    {
        AbilityType = "Mobility";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Trademark")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Tour de force")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Relay bolt")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "High gear")
    {
        AbilityType = "Mobility";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Fast lane")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Overdrive")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Seize")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Haunt")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Prowler")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Nightfall")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Cove")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "High tide")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Cascade")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Reckoning")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "X";
    }
    else if (hadanaAbilita == "Wingman")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "Q";
    }
    else if (hadanaAbilita == "Dizzy")
    {
        AbilityType = "Flash";
        AbilityBtn = "E";
    }
    else if (hadanaAbilita == "Moshpit")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "C";
    }
    else if (hadanaAbilita == "Thrash")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "X";
    }
    while(true)
    {
        if (odhadAbility == "Incendiary")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Sky smoke")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Stim beacon")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Orbital strike")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Curveball")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Hot hands")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Blaze")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Run it back")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Slow orb")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Healing orb")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Barrier orb")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Resurrection")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Shock bolt")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Recon bolt")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Owl drone")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Hunter´s fury")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Poison cloud")
        {
            GAbilityType = "Smoke/Vision blocl";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Toxic screen")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Snake bite")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Viper´s pit")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Cyber cage")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Spycam")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Trapwire")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Neural theft")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Devour")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Dismiss")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Leer")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Empress")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Alarmbot")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Turret")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Nanoswarm")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Lockdown")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Flashpoint")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Fault line")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Aftershock")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Rolling thunder")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Paranoia")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Dark cover")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Shrouded step")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "From the shadows")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Updraft")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Dash")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Cloudburst")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Blade storm")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Blast pack")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Paint shells")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Boom bot")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Showstopper")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Trailblazer")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "Q";
        }
        else if (hadanaAbilita == "Guiding light")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Regrowth")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Seekers")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Blindside")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Gatecrash")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Fakeout")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Dimensional drift")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Nova pulse")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Nebula")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Gravity well")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Cosmic divide")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Flash/Drive")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Zero/Point")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Frag/Ment")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Null/Cmd")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Headhunter")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Rendezvous")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Trademark")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Tour de force")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Relay bolt")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "High gear")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Fast lane")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Overdrive")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Seize")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Haunt")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Prowler")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Nightfall")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Cove")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "High tide")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Cascade")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Reckoning")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "X";
        }
        else if (odhadAbility == "Wingman")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "Q";
        }
        else if (odhadAbility == "Dizzy")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "E";
        }
        else if (odhadAbility == "Moshpit")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "C";
        }
        else if (odhadAbility == "Thrash")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "X";
        }
        odhadAbility = Console.ReadLine();
        if (odhadAbility == hadanaAbilita)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ability type: {AbilityType}");
            Thread.Sleep(100);
            Console.WriteLine($"Ability Button: {AbilityBtn}");
            choice = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("GG!")
            .PageSize(10)
            .HighlightStyle(highlightColor)
            .AddChoices(new[] {
           "Menu", "Exit"
            }));
        }
        else
        {
            Console.WriteLine("nn");
        }
    }
}
exit:
Console.WriteLine("To bylo moc ez.... Myslim že je čas nerfnout Chambera.");