using System.IO;

class Program
{
    public static void Main()
    {
        Player player = new Player(100);
        Troll troll = new Troll (25);
        Dragon dragon = new Dragon (5000);
        int playerattack = 10;
        int playerattack2 = 50;
        int playerattack3 = 5;
        int trollattack = 25;
        int dragonattack = 1000;
        bool Trollactive = false;
        bool Dragonactive = false;
        int points = 0;
        Console.WriteLine("Hello, Traveler i'm you're inner voice");
        Console.WriteLine("It seems like you've been greeted by a troll blocking your patch");
        Console.WriteLine("What will you do fight the troll or flee?");
        Console.WriteLine("Press Y if you choose to fight. Press N if you decide to flee");
        string playerinput1 = Console.ReadLine();
        if (playerinput1 == "Y")
        {
            Trollactive = true;
            Dragonactive = false;
            points += 10;
        }
        else if (playerinput1 == "N")
        {
            Trollactive = false;
            Dragonactive = true;
            Console.WriteLine("Sooo, you decided to flee");
            points += 5;
        }
        else
        {
            Console.WriteLine("You gotta pick either Y or N");
            return;
        }

        if(Trollactive == true)
        {
            Console.WriteLine("Let's fight this troll");
            Console.WriteLine("You swung you're rusty old sword at the troll and wounded it badly");
            troll.TrollTakeDamage(playerattack);
            points += 10;
        }
        else if (Dragonactive == true)
        {
            Console.WriteLine("You finally out ran the Troll and accidentally stumbled upon a fire breathing dragon");
            Console.WriteLine("You threw your old rusty sword as desperated as you could it hit the dragon in it's wing");
            Console.WriteLine("The dragon wasn't especially happy about you doing");
            Console.WriteLine("You feel as the room became hotter and then you saw it a fire beam rushing towards you");
            Console.WriteLine("You felt as your skin became more and more like a bbq, until you died");
            dragon.DragonTakeDamage(playerattack2);
            player.PlayerTakeDamage(dragonattack);
            return;
        }

        if (troll.Trollhp == 15)
        {
            Console.WriteLine("The Troll became very upset with you and the troll threw his dagger right at you're leg");
            player.PlayerTakeDamage(trollattack);
            Console.WriteLine("You pulled the dagger out from you're leg and to you're horror saw the Troll charging for you");
            Console.WriteLine("Will you eliminate the Troll or will you try to flee?");
            Console.WriteLine("Press Y if you choose to fight. Press N if you decide to flee");
        }
        
        string playerinput2 = Console.ReadLine();
        
        if (playerinput2 == "Y")
        {
            Console.WriteLine("You grabs your sword and the Trolls dagger and as he was charging at you, you stabbed him in his chest with the dagger and then proceeded to sliced of his head with you're sword");
            troll.TrollTakeDamage(playerattack);
            troll.TrollTakeDamage(playerattack3);
            Console.WriteLine("Congratulations you have eliminated you're first troll");
            Console.WriteLine("After all this fighting you're left with this much hp");
            Console.Write(player.PlayerHP);
            points += 50;
        }
        else if (playerinput2 == "N")
        {
            Console.WriteLine("Even with you're wounded leg");
            Console.WriteLine("You finally out ran the Troll and accidentally stumbled upon a fire breathing dragon");
            Console.WriteLine("You threw your old rusty sword as desperated as you could it hit the dragon in it's wing");
            Console.WriteLine("The dragon wasn't especially happy about you doing");
            Console.WriteLine("You feel as the room became hotter and then you saw it a fire beam rushing towards you");
            Console.WriteLine("You felt as your skin became more and more like a bbq, until you died");
            dragon.DragonTakeDamage(playerattack2);
            player.PlayerTakeDamage(dragonattack);
            points += 15;
            return;
        }
        else 
        {
            Console.WriteLine("The Troll ripped of your head with you his claws");
            points += 5;
            return;
        }

        if (player.PlayerHP <= 0)
        {
            StreamWriter sw = new StreamWriter("points.txt");
            sw.WriteLine(points);
            sw.Close();
        }
        else if (troll.Trollhp <= 0)
        {
            StreamWriter sw = new StreamWriter("points.txt");
            sw.WriteLine(points);
            sw.Close();
        }


    }
}