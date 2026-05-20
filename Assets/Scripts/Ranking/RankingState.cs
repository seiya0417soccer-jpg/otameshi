public abstract class RankingState
{
    public abstract void Handle(RankingViewModel viewModel);
}

public class LoadingState : RankingState
{
    public override void Handle(RankingViewModel viewModel)
    {
        UnityEngine.Debug.Log("“Ç‚İ‚İ’†...");
    }
}

public class SuccessState : RankingState
{
    public override void Handle(RankingViewModel viewModel)
    {
        UnityEngine.Debug.Log("æ“¾¬Œ÷I");
    }
}

public class ErrorState : RankingState
{
    private readonly string _message;

    public ErrorState(string message)
    {
        _message = message;
    }

    public override void Handle(RankingViewModel viewModel)
    {
        UnityEngine.Debug.Log($"ƒGƒ‰[: {_message}");
    }
}