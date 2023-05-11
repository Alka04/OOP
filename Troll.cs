class Enemy
{
    private int trollhp;

    public int Trollhp
    {
        get { return trollhp; }
    }
    public virtual void TrollTakeDamage(int amount)
    {
        trollhp -= amount;
    }

    public Enemy(int hp)
    {
        trollhp = hp;
    }
}

class Troll : Enemy
{
    private int trollhp;

    public int Trollhp
    {
        get { return trollhp; }
    }
    public override void TrollTakeDamage(int amount)
    {
        trollhp -= amount;
    }

    public Troll (int hp) : base(hp)
    {
        trollhp = hp;
    }
}