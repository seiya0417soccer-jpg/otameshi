using System.Collections.Generic;
using Cysharp.Threading.Tasks;

public class FakeRankingApiClient : IRankingApiClient
{
    public async UniTask<List<PlayerScore>> GetRankingAsync()
    {
        await UniTask.Delay(500);

        return new List<PlayerScore>
        {
            new PlayerScore("TestPlayer1", 9999),
            new PlayerScore("TestPlayer2", 8888),
            new PlayerScore("TestPlayer3", 7777),
        };
    }
}