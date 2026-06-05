using UnityEngine;

public class Bullet : MonoBehaviour
{
    private ObjectPool _pool;
    private float _speed = 10f;
    private float _lifeTime = 2f;
    private float _timer;

    public void Init(ObjectPool pool)
    {
        _pool = pool;
        _timer = _lifeTime;
    }

    void Update()
    {
        transform.position += Vector3.forward * _speed * Time.deltaTime;

        _timer -= Time.deltaTime;
        if (_timer <= 0f)
        {
            _pool.Return(gameObject);
        }
    }
}