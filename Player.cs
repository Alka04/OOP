class Player
{
    private int playerHP;

    public int PlayerHP
    {
        get { return playerHP; }
    }
    public void PlayerTakeDamage(int amount)
    {
        playerHP -= amount;
    }

    public Player(int hp)
    {
        playerHP = hp;
    }
}