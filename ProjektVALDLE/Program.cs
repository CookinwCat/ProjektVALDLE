using Spectre.Console;
#region ProgramSetup

var Astra = new Style().Foreground(Color.Purple_2);
var Jett = new Style().Foreground(Color.DarkTurquoise);
var Raze = new Style().Foreground(Color.DarkOrange3_1);
var Reyna = new Style().Foreground(Color.MediumOrchid1);
var Neon = new Style().Foreground(Color.CornflowerBlue);
var Phoenix = new Style().Foreground(Color.Orange3);
var Yoru = new Style().Foreground(Color.DarkBlue);
var Gekko = new Style().Foreground(Color.Green3_1);
var Sova = new Style().Foreground(Color.DeepSkyBlue1);
var Fade = new Style().Foreground(Color.Purple4);
var Kayo = new Style().Foreground(Color.DarkBlue);
var Skye = new Style().Foreground(Color.Chartreuse3_1);
var Breach = new Style().Foreground(Color.Orange4_1);
var Cypher = new Style().Foreground(Color.Grey37);
var Sage = new Style().Foreground(Color.Turquoise2);
var Killjoy = new Style().Foreground(Color.Yellow1);
var Chamber = new Style().Foreground(Color.Gold3_1);
var Omen = new Style().Foreground(Color.Blue);
var Viper = new Style().Foreground(Color.Green4);
var Harbor = new Style().Foreground(Color.DeepSkyBlue3);
var Brimstone = new Style().Foreground(Color.OrangeRed1);
var Deadlock = new Style().Foreground(Color.RoyalBlue1);

DateTime time = DateTime.Now;
int den = time.Day;

if(!File.Exists("datum.txt"))
{
    File.WriteAllText("datum.txt", time.ToString());
}
string precteneDatum = File.ReadAllText("datum.txt");
File.WriteAllText("datum.txt", time.ToString());
DateTime prectenyCas = DateTime.Parse(precteneDatum);

if(!File.Exists("streak.txt"))
{
    File.WriteAllText("streak.txt", "1");
}
if(den >= prectenyCas.Day + 2)
{
    File.WriteAllText("streak.txt", "0");
}
if(den != prectenyCas.Day)
{ 
    string obsahTxt = File.ReadAllText("streak.txt");
    int streacik = Convert.ToInt32(obsahTxt);
    streacik++;
    File.WriteAllText("streak.txt", streacik.ToString());
}
if(den == prectenyCas.Day)
{
    Console.WriteLine("Kys nigga");
}
File.WriteAllText("datum.txt", time.ToString());

string releaseDate = "";
string role = "";
string Narodnost = "";
string GreleaseDate = "";
string Grole = "";
string GNarodnost = "";
string gender = "";
string Ggender = "";
string choice;
int nahodnyindex;
string gamemode;
string AbilityType = "";
string AbilityBtn = "";
string hadanaAbilita;
string odhadAbility = "";
string GAbilityType = "";
string GAbilityBtn = "";
int AbilityCost = 0;
int GAbilityCost = 0;

string[] agents = {"Jett","Raze", "Reyna", "Neon", "Phoenix", "Yoru", "Gekko",
    "Sova", "Fade", "Kayo","Skye", "Breach", "Cypher","Deadlock", "Sage", "Killjoy",
    "Chamber", "Omen", "Viper", "Harbor", "Brimstone", "Astra"};
string[] abilities = {"Incendiary", "Sky smoke", "Stim beacon", "Orbital strike", "Curveball", "Hot hands", "Blaze", "Run it back", "Slow orb", "Healing orb",
    "Barrier orb", "Resurrection", "Shock bolt", "Recon bolt", "Owl drone", "Hunter´s fury", "Poison cloud", "Toxic screen", "Snake bite", "Viper´s pit",
 "Cyber cage", "Spycam", "Trapwire", "Neural theft", "Devour", "Dismiss", "Leer", "Empress", 
"Alarmbot", "Turret", "Nanoswarm", "Lockdown", "Flashpoint", "Fault line","Aftershock", "Rolling thunder", "Paranoia", "Dark cover", "Shrouded step", "From the shadows","Updraft",
    "Dash", "Cloudburst", "Blade storm", "Blast pack", "Paint shells", "Boombot", "Showstopper", "Trailblazer", "Guiding light", "Regrowth", "Seekers", "Blindside", "Gatecrash",
    "Fakeout", "Dimensional drift", "Nova pulse", "Nebula", "Gravity well", "Cosmic divide", "Flash/Drive", "Zero/Point", "Frag/Ment", "Null/Cmd", "Headhunter", "Rendezvous",
    "Trademark", "Tour de force", "Relay bolt", "High gear", "Fast lane", "Overdrive", "Seize", "Haunt", "Prowler", "Nightfall", "Cove", "High tide", "Cascade", "Reckoning",
    "Wingman", "Dizzy", "Moshpit", "Thrash"};
#endregion
AnsiConsole.Markup($"[Red1]               VALDLE![/]");
Console.WriteLine("");
Console.ForegroundColor= ConsoleColor.White;

Menu:
var highlightColor = new Style().Foreground(Color.Red1);
gamemode = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("The place of unlimitedly limited choices!")
        .PageSize(10)
        .HighlightStyle(highlightColor)
        .AddChoices(new[] {
           "Agent guesser", "Ability guesser", "Streak", "End"
        }));
Console.Clear();

#region agents
if (gamemode == "Agent guesser")
{
    Random generatorCisel = new();
    nahodnyindex = generatorCisel.Next(agents.Length);
    Console.Clear();
    string hadanyAgent = agents[nahodnyindex];

    if (hadanyAgent == "Jett")
    {
        releaseDate = "Beta";
        role = "Duelist";
        Narodnost = "South Korea";
        gender = "Woman";
    }
    else if (hadanyAgent == "Raze")
    {
        releaseDate = "1.0";
        role = "Duelist";
        Narodnost = "Brazil";
        gender = "Woman";
    }
    else if (hadanyAgent == "Reyna")
    {
        releaseDate = "1.0";
        role = "Duelist";
        Narodnost = "Mexico";
        gender = "Woman";
    }
    else if (hadanyAgent == "Neon")
    {
        releaseDate = "4.0";
        role = "Duelist";
        Narodnost = "Philippines";
        gender = "Woman";
    }
    else if (hadanyAgent == "Phoenix")
    {
        releaseDate = "Beta";
        role = "Duelist";
        Narodnost = "GB";
        gender = "Male";
    }
    else if (hadanyAgent == "Yoru")
    {
        releaseDate = "2.0";
        role = "Duelist";
        Narodnost = "Japan";
        gender = "Male";
    }
    else if (hadanyAgent == "Gekko")
    {
        releaseDate = "6.04";
        role = "Initiator";
        Narodnost = "USA";
        gender = "Male";
    }
    else if (hadanyAgent == "Sova")
    {
        releaseDate = "Beta";
        role = "Initiator";
        Narodnost = "Russsia";
        gender = "Male";
    }
    else if (hadanyAgent == "Fade")
    {
        releaseDate = "4.08";
        role = "Initiator";
        Narodnost = "Turkey";
        gender = "Woman";
    }
    else if (hadanyAgent == "Kayo")
    {
        releaseDate = "3.0";
        role = "Initiator";
        Narodnost = "Alternative Earth";
        gender = "Male";
    }
    else if (hadanyAgent == "Skye")
    {
        releaseDate = "1.11";
        role = "Initiator";
        Narodnost = "Australia";
        gender = "Woman";
    }
    else if (hadanyAgent == "Breach")
    {
        releaseDate = "Beta";
        role = "Initiator";
        Narodnost = "Sweden";
        gender = "Male";
    }
    else if (hadanyAgent == "Cypher")
    {
        releaseDate = "Beta";
        role = "Sentinel";
        Narodnost = "Morocco";
        gender = "Male";
    }
    else if (hadanyAgent == "Sage")
    {
        releaseDate = "Beta";
        role = "Sentinel";
        Narodnost = "China";
        gender = "Woman";
    }
    else if (hadanyAgent == "Killjoy")
    {
        releaseDate = "1.05";
        role = "Sentinel";
        Narodnost = "Germany";
        gender = "Woman";
    }
    else if (hadanyAgent == "Chamber")
    {
        releaseDate = "3.10";
        role = "Sentinel";
        Narodnost = "France";
        gender = "Male";
    }
    else if (hadanyAgent == "Omen")
    {
        releaseDate = "Beta";
        role = "Controller";
        Narodnost = "Unknown";
        gender = "Male";
    }
    else if (hadanyAgent == "Viper")
    {
        releaseDate = "Beta";
        role = "Controller";
        Narodnost = "USA";
        gender = "Woman";
    }
    else if (hadanyAgent == "Harbor")
    {
        releaseDate = "5.08";
        role = "Controller";
        Narodnost = "India";
        gender = "Male";
    }
    else if (hadanyAgent == "Brimstone")
    {
        releaseDate = "Beta";
        role = "Controller";
        Narodnost = "USA";
        gender = "Male";
    }
    else if (hadanyAgent == "Astra")
    {
        releaseDate = "2.04";
        role = "Controller";
        Narodnost = "Ghana";
        gender = "Woman";
    }
    else if (hadanyAgent == "Deadlock")
    {
        releaseDate = "7.0";
        role = "Sentinel";
        Narodnost = "Norway";
        gender = "Woman";
    }

    #region AgentGuesser
    while (true)
    {
        AnsiConsole.Markup($"[Red1]               VALDLE![/]");
        Console.WriteLine("");
        string odhadAgenta = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Your guess?")
.PageSize(10)
.HighlightStyle(highlightColor)
.AddChoices(new[] {
           "Jett","Raze", "Reyna", "Neon", "Phoenix", "Yoru", "Gekko",
    "Sova", "Fade", "Kayo","Skye", "Breach", "Cypher","Deadlock", "Sage", "Killjoy",
    "Chamber", "Omen", "Viper", "Harbor", "Brimstone", "Astra", "Menu"
}));
        if (odhadAgenta == "Jett")
        {
            GreleaseDate = "Beta";
            Grole = "Duelist";
            GNarodnost = "South Korea";
            Ggender = "Woman";
        }
        else if (odhadAgenta == "Raze")
        {
            GreleaseDate = "1.0";
            Grole = "Duelist";
            GNarodnost = "Brazil";
            Ggender = "Woman";
        }
        else if (odhadAgenta == "Reyna")
        {
            GreleaseDate = "1.0";
            Grole = "Duelist";
            GNarodnost = "Mexico";
            Ggender = "Woman";
        }
        else if (odhadAgenta == "Neon")
        {
            GreleaseDate = "4.0";
            Grole = "Duelist";
            GNarodnost = "Philippines";
            Ggender = "Woman";
        }
        else if (odhadAgenta == "Phoenix")
        {
            GreleaseDate = "Beta";
            Grole = "Duelist";
            GNarodnost = "GB";
            Ggender = "Male";
        }
        else if (odhadAgenta == "Yoru")
        {
            GreleaseDate = "2.0";
            Grole = "Duelist";
            GNarodnost = "Japan";
            Ggender = "Male";
        }
        else if (odhadAgenta == "Gekko")
        {
            GreleaseDate = "6.04";
            Grole = "Initiator";
            GNarodnost = "USA";
            Ggender = "Male";
        }
        else if (odhadAgenta == "Sova")
        {
            GreleaseDate = "Beta";
            Grole = "Initiator";
            GNarodnost = "Russia";
            Ggender = "Male";
        }
        else if (odhadAgenta == "Fade")
        {
            GreleaseDate = "4.08";
            Grole = "Initiator";
            GNarodnost = "Turkey";
            Ggender = "Woman";
        }
        else if (odhadAgenta == "Kayo")
        {
            GreleaseDate = "3.0";
            Grole = "Initiator";
            GNarodnost = "Alternative Earth";
            Ggender = "Male";
        }
        else if (odhadAgenta == "Skye")
        {
            GreleaseDate = "1.11";
            Grole = "Initiator";
            GNarodnost = "Australia";
            Ggender = "Woman";
        }
        else if (odhadAgenta == "Breach")
        {
            GreleaseDate = "Beta";
            Grole = "Initiator";
            GNarodnost = "Sweden";
            Ggender = "Male";
        }
        else if (odhadAgenta == "Cypher")
        {
            GreleaseDate = "Beta";
            Grole = "Sentinel";
            GNarodnost = "Morocco";
            Ggender = "Male";
        }
        else if (odhadAgenta == "Sage")
        {
            GreleaseDate = "Beta";
            Grole = "Sentinel";
            GNarodnost = "China";
            Ggender = "Woman";
        }
        else if (odhadAgenta == "Killjoy")
        {
            GreleaseDate = "1.05";
            Grole = "Sentinel";
            GNarodnost = "Germany";
            Ggender = "Woman";
        }
        else if (odhadAgenta == "Chamber")
        {
            GreleaseDate = "3.10";
            Grole = "Sentinel";
            GNarodnost = "France";
            Ggender = "Male";
        }
        else if (odhadAgenta == "Omen")
        {
            GreleaseDate = "Beta";
            Grole = "Controller";
            GNarodnost = "Unknown";
            Ggender = "Male";
        }
        else if (odhadAgenta == "Viper")
        {
            GreleaseDate = "Beta";
            Grole = "Controller";
            GNarodnost = "USA";
            Ggender = "Woman";
        }
        else if (odhadAgenta == "Harbor")
        {
            GreleaseDate = "5.08";
            Grole = "Controller";
            GNarodnost = "India";
            Ggender = "Male";
        }
        else if (odhadAgenta == "Brimstone")
        {
            GreleaseDate = "Beta";
            Grole = "Controller";
            GNarodnost = "USA";
            Ggender = "Male";
        }
        else if (odhadAgenta == "Astra")
        {
            GreleaseDate = "2.04";
            Grole = "Controller";
            GNarodnost = "Ghana";
            Ggender = "Woman";
        }
        else if (odhadAgenta == "Deadlock")
        {
            GreleaseDate = "7.0";
            Grole = "Sentinel";
            GNarodnost = "Norway";
            Ggender = "Woman";
        }
        else if (odhadAgenta == "Menu")
        {
            goto Menu;
        }
        if (odhadAgenta == hadanyAgent)
        {
                AnsiConsole.Markup($"[Lime]Release date {GreleaseDate}[/]");
                Console.WriteLine("");
                Thread.Sleep(100);
                AnsiConsole.Markup($"[Lime]Role {Grole}[/]");
                Console.WriteLine("");
                Thread.Sleep(100);
                AnsiConsole.Markup($"[Lime]Nationality {GNarodnost}[/]");
                Console.WriteLine("");
                Thread.Sleep(100);
                AnsiConsole.Markup($"[Lime]Gender {Ggender}[/]");
                Console.WriteLine("");
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
                Console.Clear();
            if (choice == "Menu")
            {
                goto Menu;
            }
            else if (choice == "Exit")
            {
                goto exit;
            }
        }
        else
        {
            if (releaseDate == GreleaseDate)
            {
                AnsiConsole.Markup($"[Lime]Release date {GreleaseDate}[/]");
                Console.WriteLine("");
            }
            else
            {
                AnsiConsole.Markup($"[Red1]Release date {GreleaseDate}[/]");
                Console.WriteLine("");
            }
            Thread.Sleep(100);
            if (role == Grole)
            {
                AnsiConsole.Markup($"[Lime]Role {Grole}[/]");
                Console.WriteLine("");
            }
            else
            {
                AnsiConsole.Markup($"[Red1]Role {Grole}[/]");
                Console.WriteLine("");
            }
            Thread.Sleep(100);
            if (Narodnost == GNarodnost)
            {
                AnsiConsole.Markup($"[Lime]Nationality {GNarodnost}[/]");
                Console.WriteLine("");
            }
            else
            {
                AnsiConsole.Markup($"[Red1]Nationality {GNarodnost}[/]");
                Console.WriteLine("");
            }
            Thread.Sleep(100);
            if (gender == Ggender)
            {
                AnsiConsole.Markup($"[Lime]Gender {Ggender}[/]");
                Console.WriteLine("");
            }
            else
            {
                AnsiConsole.Markup($"[Red1]Gender {Ggender}[/]");
                Console.WriteLine("");
            }
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
#endregion
#endregion
#region Ability
else if (gamemode == "Ability guesser")
{
    Random generatorCisel = new ();
    nahodnyindex = generatorCisel.Next(abilities.Length);
    hadanaAbilita = abilities[nahodnyindex];
    if (hadanaAbilita == "Incendiary")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "Q";
        AbilityCost = 250;
    }
    else if (hadanaAbilita == "Sky smoke")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "E";
        AbilityCost = 100;
    }
    else if (hadanaAbilita == "Stim beacon")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "C";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Orbital strike")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "X";
        AbilityCost = 7;
    }
    else if (hadanaAbilita == "Curveball")
    {
        AbilityType = "Flash";
        AbilityBtn = "Q";
        AbilityCost = 250;
    }
    else if (hadanaAbilita == "Hot hands")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Blaze")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "C";
        AbilityCost = 150;
    }
    else if (hadanaAbilita == "Run it back")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "X";
        AbilityCost = 6;

    }
    else if (hadanaAbilita == "Slow orb")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "Q";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Healing orb")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Barrier orb")
    {
        AbilityType = "Movement block";
        AbilityBtn = "C";
        AbilityCost = 400;
    }
    else if (hadanaAbilita == "Resurrection")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "X";
        AbilityCost = 8;
    }
    else if (hadanaAbilita == "Shock bolt")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "Q";
        AbilityCost = 150;
    }
    else if (hadanaAbilita == "Recon bolt")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Owl drone")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "C";
        AbilityCost = 400;
    }
    else if (hadanaAbilita == "Hunter´s fury")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "X";
        AbilityCost = 8;
    }
    else if (hadanaAbilita == "Poison cloud")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "Q";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Toxic screen")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Snake bite")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "C";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Viper´s pit")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "X";
        AbilityCost = 8;
    }
    else if (hadanaAbilita == "Cyber cage")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "Q";
        AbilityCost = 100;
    }
    else if (hadanaAbilita == "Spycam")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Trapwire")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "C";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Neural theft")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "X";
        AbilityCost = 6;
    }
    else if (hadanaAbilita == "Devour")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "Q";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Dismiss")
    {
        AbilityType = "Mobility";
        AbilityBtn = "E";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Leer")
    {
        AbilityType = "Flash";
        AbilityBtn = "C";
        AbilityCost = 250;
    }
    else if (hadanaAbilita == "Empress")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "X";
        AbilityCost = 6;
    }
    else if (hadanaAbilita == "Alarmbot")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "Q";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Turret")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Nanoswarm")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "C";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Lockdown")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "X";
        AbilityCost = 8;
    }
    else if (hadanaAbilita == "Flashpoint")
    {
        AbilityType = "Flash";
        AbilityBtn = "Q";
        AbilityCost = 250;
    }
    else if (hadanaAbilita == "Fault line")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Aftershock")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "C";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Rolling thunder")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "X"; 
        AbilityCost = 8;
    }
    else if (hadanaAbilita == "Paranoia")
    {
        AbilityType = "Flash";
        AbilityBtn = "Q";
        AbilityCost = 250;
    }
    else if (hadanaAbilita == "Dark cover")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "E";
        AbilityCost = 150;
    }
    else if (hadanaAbilita == "Shrouded step")
    {
        AbilityType = "Mobility";
        AbilityBtn = "C";
        AbilityCost = 100;
    }
    else if (hadanaAbilita == "From the shadows")
    {
        AbilityType = "Mobility";
        AbilityBtn = "X";
        AbilityCost = 7;
    }
    else if (hadanaAbilita == "Updraft")
    {
        AbilityType = "Mobility";
        AbilityBtn = "Q";
        AbilityCost = 150;
    }
    else if (hadanaAbilita == "Dash")
    {
        AbilityType = "Mobility";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Cloudburst")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "C";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Blade storm")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "X";
        AbilityCost = 7;
    }
    else if (hadanaAbilita == "Blast pack")
    {
        AbilityType = "Mobility";
        AbilityBtn = "Q";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Paint shells")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Boom bot")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "C";
        AbilityCost = 300;
    }
    else if (hadanaAbilita == "Showstopper")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "X";
        AbilityCost = 8;
    }
    else if (hadanaAbilita == "Trailblazer")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "Q";
        AbilityCost = 300;
    }
    else if (hadanaAbilita == "Guiding light")
    {
        AbilityType = "Flash";
        AbilityBtn = "E";
        AbilityCost = 250;
    }
    else if (hadanaAbilita == "Regrowth")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "C";
        AbilityCost = 150;
    }
    else if (hadanaAbilita == "Seekers")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "X";
        AbilityCost = 7;
    }
    else if (hadanaAbilita == "Blindside")
    {
        AbilityType = "Flash";
        AbilityBtn = "Q";
        AbilityCost = 250;
    }
    else if (hadanaAbilita == "Gatecrash")
    {
        AbilityType = "Mobility";
        AbilityBtn = "E";
        AbilityCost = 150;
    }
    else if (hadanaAbilita == "Fakeout")
    {
        AbilityType = "Flash";
        AbilityBtn = "C";
        AbilityCost = 100;
    }
    else if (hadanaAbilita == "Dimensional drift")
    {
        AbilityType = "Mobility";
        AbilityBtn = "X";
        AbilityCost = 7;
    }
    else if (hadanaAbilita == "Nova pulse")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "Q";
        AbilityCost = 150;
    }
    else if (hadanaAbilita == "Nebula")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "E";
        AbilityCost = 150;
    }
    else if (hadanaAbilita == "Gravity well")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "C";
        AbilityCost = 150;
    }
    else if (hadanaAbilita == "Cosmic divide")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "X";
        AbilityCost = 7;
    }
    else if (hadanaAbilita == "Flash/Drive")
    {
        AbilityType = "Flash";
        AbilityBtn = "Q";
        AbilityCost = 250;
    }
    else if (hadanaAbilita == "Zero/Point")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Frag/Ment")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "C";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Null/Cmd")
    {
        AbilityType = "Heal/Buff";
        AbilityBtn = "X";
        AbilityCost = 8;
    }
    else if (hadanaAbilita == "Headhunter")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "Q";
        AbilityCost = 150;
    }
    else if (hadanaAbilita == "Rendezvous")
    {
        AbilityType = "Mobility";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Trademark")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "C";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Tour de force")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "X";
        AbilityCost = 8;
    }
    else if (hadanaAbilita == "Relay bolt")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "Q";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "High gear")
    {
        AbilityType = "Mobility";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Fast lane")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "C";
        AbilityCost = 300;
    }
    else if (hadanaAbilita == "Overdrive")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "X";
        AbilityCost = 7;
    }
    else if (hadanaAbilita == "Seize")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "Q";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Haunt")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Prowler")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "C";
        AbilityCost = 250;
    }
    else if (hadanaAbilita == "Nightfall")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "X";
        AbilityCost = 8;
    }
    else if (hadanaAbilita == "Cove")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "Q";
        AbilityCost = 350;
    }
    else if (hadanaAbilita == "High tide")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Cascade")
    {
        AbilityType = "Smoke/Vision block";
        AbilityBtn = "C";
        AbilityCost = 150;
    }
    else if (hadanaAbilita == "Reckoning")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "X";
        AbilityCost = 7;
    }
    else if (hadanaAbilita == "Wingman")
    {
        AbilityType = "Info gather/Reveal";
        AbilityBtn = "Q";
        AbilityCost = 300;
    }
    else if (hadanaAbilita == "Dizzy")
    {
        AbilityType = "Flash";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Moshpit")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "C";
        AbilityCost = 250;
    }
    else if (hadanaAbilita == "Thrash")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "X";
        AbilityCost = 7;
    }
    else if (hadanaAbilita == "GravNet")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "C";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Sonic Sensor")
    {
        AbilityType = "Stun/Debuff";
        AbilityBtn = "Q";
        AbilityCost = 200;
    }
    else if (hadanaAbilita == "Barrier Mesh")
    {
        AbilityType = "Movement block";
        AbilityBtn = "E";
        AbilityCost = 0;
    }
    else if (hadanaAbilita == "Annihilation")
    {
        AbilityType = "Molly/Dmg dealing";
        AbilityBtn = "X";
        AbilityCost = 7;
    }
    #region Agentprep
    while (true)
    {
        AnsiConsole.Markup($"[Red1]               VALDLE![/]");
        Console.WriteLine("");
    Agents:
        choice = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Your guess?")
        .PageSize(10)
        .HighlightStyle(highlightColor)
        .AddChoices(new[] {
           "Jett","Raze", "Reyna", "Neon", "Phoenix", "Yoru", "Gekko",
    "Sova", "Fade", "Kayo","Skye", "Breach", "Cypher","Deadlock", "Sage", "Killjoy",
    "Chamber", "Omen", "Viper", "Harbor", "Brimstone", "Astra", "Menu"
        }));
        if (choice == "Jett")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Jett)
.AddChoices(new[] {
           "Updraft","Dash", "Cloudburst", "Blade storm", "Zpátky"
}));
        }
        else if (choice == "Raze")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Raze)
.AddChoices(new[] {
           "Blast pack","Paint shells", "Boom bot", "Showstopper", "Zpátky"
}));
        }
        else if (choice == "Reyna")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Reyna)
.AddChoices(new[] {
           "Devour","Dismiss", "Leer", "Empress", "Zpátky"
}));
        }
        else if (choice == "Neon")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Neon)
.AddChoices(new[] {
           "Relay bolt","High gear", "Fast lane", "Overdrive", "Zpátky"
}));
        }
        else if (choice == "Phoenix")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Phoenix)
.AddChoices(new[] {
           "Curveball","Hot hands", "Blaze", "Run it back", "Zpátky"
}));
        }
        else if (choice == "Yoru")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Yoru)
.AddChoices(new[] {
           "Blindside","Gatecrash", "Fakeout", "Dimensional drift", "Zpátky"
}));
        }
        else if (choice == "Gekko")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Gekko)
.AddChoices(new[] {
           "Wingman","Dizzy", "Moshpit", "Thrash", "Zpátky"
}));
        }
        else if (choice == "Sova")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Sova)
.AddChoices(new[] {
           "Shock bolt","Recon bolt", "Owl drone", "Hunter´s fury", "Zpátky"
}));
        }
        else if (choice == "Fade")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Fade)
.AddChoices(new[] {
           "Seize","Haunt", "Prowler", "Nightfall", "Zpátky"
}));
        }
        else if (choice == "Kayo")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Kayo)
.AddChoices(new[] {
           "Flash/Drive","Zero/Point", "Frag/Ment", "Null/Cmd", "Zpátky"
}));
        }
        else if (choice == "Skye")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Skye)
.AddChoices(new[] {
           "Trailblazer","Guiding light", "Regrowth", "Seekers", "Zpátky"
}));
        }
        else if (choice == "Breach")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Breach)
.AddChoices(new[] {
           "Flashpoint","Fault line", "Aftershock", "Rolling thunder", "Zpátky"
}));
        }
        else if (choice == "Cypher")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Cypher)
.AddChoices(new[] {
           "Cyber cage","Spycam", "Trapwire", "Neural theft", "Zpátky"
}));
        }
        else if (choice == "Deadlock")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Deadlock)
.AddChoices(new[] {
           "Sonic Sensor", "Barrier Mesh", "GravNet", "Annihilation", "Zpátky"
}));
        }
        else if (choice == "Sage")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Sage)
.AddChoices(new[] {
           "Slow orb","Healing orb", "Barrier orb", "Resurrection", "Zpátky"
}));
        }
        else if (choice == "Killjoy")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Killjoy)
.AddChoices(new[] {
           "Alarmbot","Turret", "Nanoswarm", "Lockdown", "Zpátky"
}));
        }
        else if (choice == "Chamber")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Chamber)
.AddChoices(new[] {
           "Headhunter","Rendezvous", "Trademark", "Tour de force", "Zpátky"
}));
        }
        else if (choice == "Omen")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Omen)
.AddChoices(new[] {
           "Paranoia","Dark cover", "Shrouded step", "From the shadows", "Zpátky"
}));
        }
        else if (choice == "Viper")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Viper)
.AddChoices(new[] {
           "Poison cloud","Toxic screen", "Snake bite", "Viper´s pit", "Zpátky"
}));
        }
        else if (choice == "Harbor")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Harbor)
.AddChoices(new[] {
           "Cove","High tide", "Cascade", "Reckoning", "Zpátky"
}));
        }
        else if (choice == "Brimstone")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Brimstone)
.AddChoices(new[] {
           "Incendiary","Sky smoke", "Stim beacon", "Orbital strike", "Zpátky"
}));
        }
        else if (choice == "Astra")
        {
            odhadAbility = AnsiConsole.Prompt(
new SelectionPrompt<string>()
.Title("Ability?")
.PageSize(10)
.HighlightStyle(Astra)
.AddChoices(new[] {
           "Nova pulse","Nebula", "Gravity well", "Cosmic divide", "Zpátky"
}));
        }
        else if (choice == "Menu")
        {
            goto Menu;
        }
        #endregion


        if (odhadAbility == "Incendiary")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "Q";
            GAbilityCost = 250;
        }
        else if (odhadAbility == "Sky smoke")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "E";
            GAbilityCost = 100;
        }
        else if (odhadAbility == "Stim beacon")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "C";
            GAbilityCost = 200;

        }
        else if (odhadAbility == "Orbital strike")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "X";
            GAbilityCost = 7;
        }
        else if (odhadAbility == "Curveball")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "Q";
            GAbilityCost = 250;
        }
        else if (odhadAbility == "Hot hands")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Blaze")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "C";
            GAbilityCost = 150;
        }
        else if (odhadAbility == "Run it back")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "X";
            GAbilityCost = 6;
        }
        else if (odhadAbility == "Slow orb")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "Q";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Healing orb")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Barrier orb")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "C";
            GAbilityCost = 400;
        }
        else if (odhadAbility == "Resurrection")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "X";
            GAbilityCost = 8;
        }
        else if (odhadAbility == "Shock bolt")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "Q";
            GAbilityCost = 150;
        }
        else if (odhadAbility == "Recon bolt")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Owl drone")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "C";
            GAbilityCost = 400;
        }
        else if (odhadAbility == "Hunter´s fury")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "X";
            GAbilityCost = 8;
        }
        else if (odhadAbility == "Poison cloud")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "Q";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Toxic screen")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Snake bite")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "C";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Viper´s pit")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "X";
            GAbilityCost = 8;
        }
        else if (odhadAbility == "Cyber cage")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "Q";
            GAbilityCost = 100;
        }
        else if (odhadAbility == "Spycam")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Trapwire")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "C";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Neural theft")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "X";
            GAbilityCost = 6;
        }
        else if (odhadAbility == "Devour")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "Q";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Dismiss")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "E";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Leer")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "C";
            GAbilityCost = 250;
        }
        else if (odhadAbility == "Empress")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "X";
            GAbilityCost = 6;
        }
        else if (odhadAbility == "Alarmbot")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "Q";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Turret")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Nanoswarm")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "C";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Lockdown")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "X";
            GAbilityCost = 8;
        }
        else if (odhadAbility == "Flashpoint")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "Q";
            GAbilityCost = 250;
        }
        else if (odhadAbility == "Fault line")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Aftershock")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "C";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Rolling thunder")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "X";
            GAbilityCost = 8;
        }
        else if (odhadAbility == "Paranoia")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "Q";
            GAbilityCost = 250;
        }
        else if (odhadAbility == "Dark cover")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "E";
            GAbilityCost = 150;
        }
        else if (odhadAbility == "Shrouded step")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "C";
            GAbilityCost = 100;
        }
        else if (odhadAbility == "From the shadows")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "X";
            GAbilityCost = 7;
        }
        else if (odhadAbility == "Updraft")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "Q";
            GAbilityCost = 150;
        }
        else if (odhadAbility == "Dash")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Cloudburst")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "C";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Blade storm")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "X";
            GAbilityCost = 7;
        }
        else if (odhadAbility == "Blast pack")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "Q";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Paint shells")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Boom bot")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "C";
            GAbilityCost = 300;
        }
        else if (odhadAbility == "Showstopper")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "X";
            GAbilityCost = 8;
        }
        else if (odhadAbility == "Trailblazer")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "Q";
            GAbilityCost = 300;
        }
        else if (hadanaAbilita == "Guiding light")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "E";
            GAbilityCost = 250;
        }
        else if (odhadAbility == "Regrowth")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "C";
            GAbilityCost = 150;
        }
        else if (odhadAbility == "Seekers")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "X";
            GAbilityCost = 7;
        }
        else if (odhadAbility == "Blindside")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "Q";
            GAbilityCost = 250;
        }
        else if (odhadAbility == "Gatecrash")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "E";
            GAbilityCost = 150;
        }
        else if (odhadAbility == "Fakeout")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "C";
            GAbilityCost = 100;
        }
        else if (odhadAbility == "Dimensional drift")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "X";
            GAbilityCost = 7;
        }
        else if (odhadAbility == "Nova pulse")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "Q";
            GAbilityCost = 150;
        }
        else if (odhadAbility == "Nebula")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "E";
            GAbilityCost = 150;
        }
        else if (odhadAbility == "Gravity well")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "C";
            GAbilityCost = 150;
        }
        else if (odhadAbility == "Cosmic divide")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "X";
            GAbilityCost = 7;
        }
        else if (odhadAbility == "Flash/Drive")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "Q";
            GAbilityCost = 250;
        }
        else if (odhadAbility == "Zero/Point")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Frag/Ment")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "C";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Null/Cmd")
        {
            GAbilityType = "Heal/Buff";
            GAbilityBtn = "X";
            GAbilityCost = 8;
        }
        else if (odhadAbility == "Headhunter")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "Q";
            GAbilityCost = 150;
        }
        else if (odhadAbility == "Rendezvous")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Trademark")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "C";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Tour de force")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "X";
            GAbilityCost = 8;
        }
        else if (odhadAbility == "Relay bolt")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "Q";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "High gear")
        {
            GAbilityType = "Mobility";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Fast lane")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "C";
            GAbilityCost = 300;
        }
        else if (odhadAbility == "Overdrive")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "X";
            GAbilityCost = 7;
        }
        else if (odhadAbility == "Seize")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "Q";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Haunt")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Prowler")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "C";
            GAbilityCost = 250;
        }
        else if (odhadAbility == "Nightfall")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "X";
            GAbilityCost = 8;
        }
        else if (odhadAbility == "Cove")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "Q";
            GAbilityCost = 350;
        }
        else if (odhadAbility == "High tide")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Cascade")
        {
            GAbilityType = "Smoke/Vision block";
            GAbilityBtn = "C";
            GAbilityCost = 150;
        }
        else if (odhadAbility == "Reckoning")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "X";
            GAbilityCost = 7;
        }
        else if (odhadAbility == "Wingman")
        {
            GAbilityType = "Info gather/Reveal";
            GAbilityBtn = "Q";
            GAbilityCost = 300;
        }
        else if (odhadAbility == "Dizzy")
        {
            GAbilityType = "Flash";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Moshpit")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "C";
            GAbilityCost = 250;
        }

        else if (odhadAbility == "Thrash")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "X";
            GAbilityCost = 7;
        }
        else if (odhadAbility == "GravNet")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "C";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Sonic Sensor")
        {
            GAbilityType = "Stun/Debuff";
            GAbilityBtn = "Q";
            GAbilityCost = 200;
        }
        else if (odhadAbility == "Barrier Mesh")
        {
            GAbilityType = "Movement block";
            GAbilityBtn = "E";
            GAbilityCost = 0;
        }
        else if (odhadAbility == "Annihilation")
        {
            GAbilityType = "Molly/Dmg dealing";
            GAbilityBtn = "X";
            GAbilityCost = 7;
        }
        else if (odhadAbility == "Zpátky")
        {
            goto Agents;
        }

        #region AbilityGuesser
        if (odhadAbility == hadanaAbilita)
        {
            AnsiConsole.Markup($"[Lime]Type {GAbilityType}[/]");
            Console.WriteLine("");
            Thread.Sleep(100);
            AnsiConsole.Markup($"[Lime]Button {GAbilityBtn}[/]");
            Console.WriteLine("");
            Thread.Sleep(100);
            AnsiConsole.Markup($"[Lime]Cost {GAbilityCost}[/]");
            Console.WriteLine("");
            choice = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("GG!")
            .PageSize(10)
            .HighlightStyle(highlightColor)
            .AddChoices(new[] {
           "Menu", "Exit"
            }));
            Console.Clear();
            if(choice == "Menu")
            {
                goto Menu;
            }
            else
            {
                goto exit;
            }
        }
        else
        {
            if(AbilityType == GAbilityType)
            {
                AnsiConsole.Markup($"[Lime]Type {GAbilityType}[/]");
                Console.WriteLine("");
            }
            else
            {
                AnsiConsole.Markup($"[Red1]Type {GAbilityType}[/]");
                Console.WriteLine("");
            }
            if(AbilityBtn == GAbilityBtn)
            {
                AnsiConsole.Markup($"[Lime]Button {GAbilityBtn}[/]");
                Console.WriteLine("");
            }
            else
            {
                AnsiConsole.Markup($"[Red1]Button {GAbilityBtn}[/]");
                Console.WriteLine("");

            }
            if(AbilityCost== GAbilityCost)
            {
                AnsiConsole.Markup($"[Lime]Cost {GAbilityCost}[/]");
                Console.WriteLine("");
            }
            else
            {
                AnsiConsole.Markup($"[Red1]Cost {GAbilityCost}[/]");
                Console.WriteLine("");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
#endregion
#endregion
else if (gamemode == "Streak")
    {
    AnsiConsole.Markup($"[Red1]               VALDLE![/]");
    Console.WriteLine("");

        if (File.Exists("streak.txt") && File.Exists("datum.txt"))
        {

        string prectenyStreak = File.ReadAllText("streak.txt");

            AnsiConsole.Markup($"[purple_2]Your current streak is {prectenyStreak}![/]");
        }
        Console.ReadKey();
        goto Menu;

   }
exit:
Console.WriteLine("That was too easy..... I think its time to nerf Chamber.");