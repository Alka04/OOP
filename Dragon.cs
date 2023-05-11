class Dragon
{
    private int dragonhp;

    public int Dragonhp
    {
        get { return dragonhp; }
    }
    public void DragonTakeDamage(int amount)
    {
        dragonhp -= amount;
    }

    public Dragon (int hp)
    {
        dragonhp = hp;
    }
}