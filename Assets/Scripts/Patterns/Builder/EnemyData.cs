public class EnemyData
{
    public string Name { get; }
    public int Health { get; }
    public float Speed { get; }
    public int Damage { get; }

    public EnemyData(string name, int health, float speed, int damage)
    {
        Name = name;
        Health = health;
        Speed = speed;
        Damage = damage;
    }
}