class Program
{
    public static void Main()
    {
        Player player = new Player(100);
        Troll troll = new Troll (25);
        int playerattack = 10;
        bool Trollactive = false;
        Console.WriteLine("Hello, Traveler i'm you're inner voice");
        Console.WriteLine("It seems like you've been greeted by a troll blocking your patch");
        Console.WriteLine("What will you do fight the troll or flee?");
        Console.WriteLine("Press Y if you choose to fight. Press N if you decide to flee");
        string playerinput1 = Console.ReadLine();
        if (playerinput1 == "Y")
        {
            Trollactive = true;
        }
        else if (playerinput1 == "N")
        {
            Trollactive = false;
            Console.WriteLine("Sooo, you decided to flee");
        }
        else
        {
            Console.WriteLine("You gotta pick either Y or N");
        }

        if(Trollactive == true)
        {
            Console.WriteLine("Let's fight this troll");
            Console.WriteLine("You swung you're rusty old sword at the troll and wounded it badly");
            troll.TrollTakeDamage(playerattack);
            Console.WriteLine(troll.Trollhp);
        }

    }
}