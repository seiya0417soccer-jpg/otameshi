using UnityEngine;
using VContainer;
using VContainer.Unity;

public class RankingLifetimeScope : LifetimeScope
{
    [SerializeField] private RankingView _rankingView;
    [SerializeField] private string _serverUrl = "http://localhost:32769";

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterInstance<IRankingApiClient>(new RankingApiClient(_serverUrl));
        builder.Register<RankingRepository>(Lifetime.Singleton);
        builder.Register<RankingViewModel>(Lifetime.Singleton);
        builder.RegisterInstance(_rankingView);
        builder.RegisterEntryPoint<RankingStarter>();
    }
}