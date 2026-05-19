using System.Collections.Generic;
using Cysharp.Threading.Tasks;

public class RankingRepository
{
    private readonly IRankingApiClient _apiClient;

    public RankingRepository(IRankingApiClient apiClient)
    {
        _apiClient = apiClient;
    }

    public async UniTask<List<PlayerScore>> GetRankingAsync()
    {
        return await _apiClient.GetRankingAsync();
    }
}