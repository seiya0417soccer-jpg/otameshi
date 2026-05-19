using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using R3;

public class RankingViewModel
{
    private readonly RankingRepository _repository;

    public ReactiveProperty<List<PlayerScore>> Rankings { get; } = new();
    public ReactiveProperty<bool> IsLoading { get; } = new(false);

    public RankingViewModel(RankingRepository repository)
    {
        _repository = repository;
    }

    public async UniTask LoadAsync()
    {
        IsLoading.Value = true;
        Rankings.Value = await _repository.GetRankingAsync();
        IsLoading.Value = false;
    }
}