using System.Collections.Generic;
using Cysharp.Threading.Tasks;

public interface IRankingApiClient
{
    UniTask<List<PlayerScore>> GetRankingAsync();
}