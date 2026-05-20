using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using R3;

public class RankingViewModel
{
    private readonly RankingRepository _repository;

    public ReactiveProperty<List<PlayerScore>> Rankings { get; } = new();
    public ReactiveProperty<RankingState> State { get; } = new();

    public RankingViewModel(RankingRepository repository)
    {
        _repository = repository;
    }

    public async UniTask LoadAsync()
    {
        State.Value = new LoadingState();

        try
        {
            Rankings.Value = await _repository.GetRankingAsync();
            State.Value = new SuccessState();
        }
        catch
        {
            State.Value = new ErrorState("Žæ“¾‚ÉŽ¸”s‚µ‚Ü‚µ‚½");
        }
    }
}