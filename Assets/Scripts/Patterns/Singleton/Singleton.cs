namespace Patterns.Singleton
{
    using UnityEngine;

    /// <summary>
    /// Singletonパターンの汎用ベースクラス
    /// Tを継承したMonoBehaviourは、これを継承するだけで
    /// 「ゲーム全体で1個しか存在しない」ことが保証される
    /// </summary>
    /// <typeparam name="T">Singleton化したいクラス自身の型</typeparam>
    public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        // ゲーム全体でただ1つだけ保持する自分自身の参照
        private static T _instance;

        // 外部からはこのInstanceを通してアクセスする
        public static T Instance
        {
            get
            {
                // まだインスタンスを持っていない場合
                if (_instance == null)
                {
                    // シーン内に既にTがあれば、それを使う
                    _instance = FindObjectOfType<T>();

                    // シーン内にも存在しない場合は新しく生成する
                    if (_instance == null)
                    {
                        GameObject obj = new GameObject(typeof(T).Name);
                        _instance = obj.AddComponent<T>();
                    }
                }

                return _instance;
            }
        }

        // Awakeで「自分が最初の1人かどうか」を判定する
        protected virtual void Awake()
        {
            if (_instance == null)
            {
                // 自分が最初のインスタンスなら登録する
                _instance = this as T;

                // シーンを切り替えても破棄されないようにする
                DontDestroyOnLoad(gameObject);
            }
            else if (_instance != this)
            {
                // 既に別のインスタンスが存在する場合、自分（重複）は破棄する
                Destroy(gameObject);
            }
        }
    }
}