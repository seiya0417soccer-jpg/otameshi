using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private EnemyFactory _factory;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            var enemy = _factory.CreateEnemy(EnemyType.Goblin, Vector3.zero);
            enemy.Attack();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            var enemy = _factory.CreateEnemy(EnemyType.Orc, Vector3.zero);
            enemy.Attack();
        }
    }
}