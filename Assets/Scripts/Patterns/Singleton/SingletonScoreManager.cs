namespace Patterns.Singleton
{
    using UnityEngine;

    /// <summary>
    /// スコアを管理するマネージャー
    /// Singletonを継承するだけで「ゲーム全体で1個」を保証できる
    /// </summary>
    public class SingletonScoreManager : Singleton<SingletonScoreManager>
    {
        // 現在のスコア
        private int _score;

        // 外部から読み取り専用でスコアを見られるようにする
        public int Score => _score;

        // スコアを加算するメソッド
        public void AddScore(int amount)
        {
            _score += amount;
            Debug.Log($"スコア加算：+{amount} 合計：{_score}");
        }

        // Awakeを上書きしたい場合はoverrideで親の処理も呼ぶ
        protected override void Awake()
        {
            // 親クラス（Singleton）のAwake処理を必ず呼ぶ
            base.Awake();

            Debug.Log("SingletonScoreManagerが起動しました");
        }
    }
}