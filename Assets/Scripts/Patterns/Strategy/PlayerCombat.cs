using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    private IAttackStrategy _strategy;

    public void SetStrategy(IAttackStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Attack()
    {
        if (_strategy == null)
        {
            Debug.Log("戦略がセットされていません！");
            return;
        }
        _strategy.Attack();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) SetStrategy(new SwordAttack());
        if (Input.GetKeyDown(KeyCode.Alpha2)) SetStrategy(new BowAttack());
        if (Input.GetKeyDown(KeyCode.Alpha3)) SetStrategy(new MagicAttack());
        if (Input.GetKeyDown(KeyCode.Space)) Attack();
    }
    void Start()
    {
        Debug.Log("PlayerCombat起動！");
    }
}