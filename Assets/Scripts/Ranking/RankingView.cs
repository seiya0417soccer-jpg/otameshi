using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using R3;
using TMPro;
using UnityEngine;

public class RankingView : MonoBehaviour
{
    [SerializeField] private Transform _entryContainer;
    [SerializeField] private GameObject _entryPrefab;

    private RankingViewModel _viewModel;

    public void Initialize(RankingViewModel viewModel)
    {
        _viewModel = viewModel;

        _viewModel.Rankings.Subscribe(rankings =>
        {
            UpdateView(rankings);
        }).AddTo(this);

        _viewModel.State.Subscribe(state =>
        {
            if (state == null) return;
            state.Handle(_viewModel);
        }).AddTo(this);
    }

    private void UpdateView(List<PlayerScore> rankings)
    {
        foreach (Transform child in _entryContainer)
        {
            Destroy(child.gameObject);
        }

        if (rankings == null) return;

        for (int i = 0; i < rankings.Count; i++)
        {
            var entry = Instantiate(_entryPrefab, _entryContainer);
            var text = entry.GetComponent<TextMeshProUGUI>();
            text.text = $"No.{i + 1}  {rankings[i].Name}  {rankings[i].Score}pts";
        }
    }

    public async UniTaskVoid OnClickRefresh()
    {
        await _viewModel.LoadAsync();
    }
}