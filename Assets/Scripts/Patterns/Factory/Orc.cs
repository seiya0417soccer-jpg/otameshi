using UnityEngine;

public class Orc : MonoBehaviour, IEnemy
{
    public void Attack()
    {
        Debug.Log("オークが攻撃！");
    }
}