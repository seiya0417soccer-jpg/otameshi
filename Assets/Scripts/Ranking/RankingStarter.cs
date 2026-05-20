using Cysharp.Threading.Tasks;
using VContainer;
using VContainer.Unity;

public class RankingStarter : IStartable
{
    private readonly RankingViewModel _viewModel;
    private readonly RankingView _rankingView;

    [Inject]
    public RankingStarter(RankingViewModel viewModel, RankingView rankingView)
    {
        _viewModel = viewModel;
        _rankingView = rankingView;
    }

    public void Start()
    {
        LoadRanking().Forget();
    }

    private async UniTask LoadRanking()
    {
        _rankingView.Initialize(_viewModel);

        var command = new LoadRankingCommand(_viewModel);
        await command.ExecuteAsync();
    }
}