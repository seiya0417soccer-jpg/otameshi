namespace Patterns.Singleton
{
    using UnityEngine;

    /// <summary>
    /// Singletonの動作を確認するためのテスト用スクリプト
    /// 適当な空のGameObjectにアタッチして使う
    /// </summary>
    public class SingletonTester : MonoBehaviour
    {
        // スペースキーを押すたびにスコアを加算する
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // SingletonScoreManagerを「直接生成せず」呼び出している点に注目
                SingletonScoreManager.Instance.AddScore(10);
            }
        }
    }
}