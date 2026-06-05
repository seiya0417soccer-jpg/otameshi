using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private ObjectPool _bulletPool;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = _bulletPool.Get();
            obj.transform.position = transform.position;

            Bullet bullet = obj.GetComponent<Bullet>();
            bullet.Init(_bulletPool);
        }
    }
}