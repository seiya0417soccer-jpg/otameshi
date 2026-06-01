using UnityEngine;

public enum EnemyType
{
    Goblin,
    Orc
}

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private GameObject _goblinPrefab;
    [SerializeField] private GameObject _orcPrefab;

    public IEnemy CreateEnemy(EnemyType type, Vector3 position)
    {
        GameObject prefab = type switch
        {
            EnemyType.Goblin => _goblinPrefab,
            EnemyType.Orc => _orcPrefab,
            _ => throw new System.ArgumentException($"Unknown type: {type}")
        };

        var instance = Instantiate(prefab, position, Quaternion.identity);
        return instance.GetComponent<IEnemy>();
    }
}