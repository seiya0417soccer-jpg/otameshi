using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public class RankingApiClient : IRankingApiClient
{
    private readonly string _baseUrl;

    public RankingApiClient(string baseUrl)
    {
        _baseUrl = baseUrl;
    }

    public async UniTask<List<PlayerScore>> GetRankingAsync()
    {
        using var request = UnityWebRequest.Get($"{_baseUrl}/ranking");
        request.certificateHandler = new BypassCertificate();
        await request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError($"ランキング取得失敗: {request.error}");
            return new List<PlayerScore>();
        }
        Debug.Log($"レスポンス: {request.downloadHandler.text}");

        var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<PlayerScore>>(request.downloadHandler.text);
        return list ?? new List<PlayerScore>();
    }

    [System.Serializable]
    private class RankingWrapper
    {
        public List<PlayerScore> items;
    }
}