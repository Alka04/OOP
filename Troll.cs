class Troll
{
    private int trollhp;

    public int Trollhp
    {
        get { return trollhp; }
    }
    public void TrollTakeDamage(int amount)
    {
        trollhp -= amount;
    }

    public Troll(int hp)
    {
        trollhp = hp;
    }
}