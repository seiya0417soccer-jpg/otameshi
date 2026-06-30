namespace Patterns.Singleton
{
    using UnityEngine;

    /// <summary>
    /// シーン切り替え後にスコアが保持されているか確認するためのスクリプト
    /// </summary>
    public class ScoreChecker : MonoBehaviour
    {
        private void Start()
        {
            // シーンが切り替わった後でもInstance経由でアクセスできるか確認
            Debug.Log($"シーン切り替え後のスコア：{SingletonScoreManager.Instance.Score}");
        }
    }
}