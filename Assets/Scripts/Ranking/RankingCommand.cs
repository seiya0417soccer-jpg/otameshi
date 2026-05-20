using Cysharp.Threading.Tasks;

public interface ICommand
{
    UniTask ExecuteAsync();
}

public class LoadRankingCommand : ICommand
{
    private readonly RankingViewModel _viewModel;

    public LoadRankingCommand(RankingViewModel viewModel)
    {
        _viewModel = viewModel;
    }

    public async UniTask ExecuteAsync()
    {
        await _viewModel.LoadAsync();
    }
}