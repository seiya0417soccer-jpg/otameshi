namespace Patterns.Singleton
{
    using UnityEngine;
    using UnityEngine.SceneManagement;

    /// <summary>
    /// シーン切り替えのテスト用スクリプト
    /// Enterキーを押すと指定したシーンへ切り替わる
    /// </summary>
    public class SceneSwitcher : MonoBehaviour
    {
        // インスペクターから切り替え先のシーン名を設定する
        [SerializeField] private string _sceneName;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log($"シーン切り替え：{_sceneName} へ");
                SceneManager.LoadScene(_sceneName);
            }
        }
    }
}