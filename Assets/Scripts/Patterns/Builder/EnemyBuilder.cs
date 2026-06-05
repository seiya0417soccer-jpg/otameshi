public class EnemyBuilder
{
    private string _name = "Enemy";
    private int _health = 100;
    private float _speed = 2f;
    private int _damage = 10;

    public EnemyBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public EnemyBuilder SetHealth(int health)
    {
        _health = health;
        return this;
    }

    public EnemyBuilder SetSpeed(float speed)
    {
        _speed = speed;
        return this;
    }

    public EnemyBuilder SetDamage(int damage)
    {
        _damage = damage;
        return this;
    }

    public EnemyData Build()
    {
        return new EnemyData(_name, _health, _speed, _damage);
    }
}