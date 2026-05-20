using System;
using System.Collections.Generic;

// 発行者
public class RankingPublisher
{
    private List<Action> _subscribers = new List<Action>();

    private int _score;
    public int Score
    {
        get => _score;
        set
        {
            _score = value;
            NotifyAll(); // 変わったら全員に通知
        }
    }

    public void Subscribe(Action callback)
    {
        _subscribers.Add(callback);
    }

    private void NotifyAll()
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber();
        }
    }
}

// 購読者
public class RankingSubscriber
{
    private RankingPublisher _publisher;

    public RankingSubscriber(RankingPublisher publisher)
    {
        _publisher = publisher;
        _publisher.Subscribe(OnScoreChanged); // チャンネル登録
    }

    private void OnScoreChanged()
    {
        UnityEngine.Debug.Log($"スコアが変わった！: {_publisher.Score}");
    }
}