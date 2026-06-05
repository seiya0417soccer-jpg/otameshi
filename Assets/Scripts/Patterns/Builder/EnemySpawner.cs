using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    void Start()
    {
        var goblin = new EnemyBuilder()
            .SetName("Goblin")
            .SetHealth(80)
            .SetSpeed(3f)
            .SetDamage(5)
            .Build();

        var boss = new EnemyBuilder()
            .SetName("Boss")
            .SetHealth(500)
            .SetDamage(50)
            .Build();

        Debug.Log($"{goblin.Name} HP:{goblin.Health} SPD:{goblin.Speed} DMG:{goblin.Damage}");
        Debug.Log($"{boss.Name} HP:{boss.Health} SPD:{boss.Speed} DMG:{boss.Damage}");
    }
}