using System;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public int Score;

    public static Action<int> OnScoreUpdated;

    private void OnEnable()
    {
        Coin.OnCoinCollected += UpdateScore;
    }

    private void OnDisable()
    {
        Coin.OnCoinCollected -= UpdateScore;
    }

    private void UpdateScore(Coin coin)
    {
        Score += coin.coinValue;

        OnScoreUpdated?.Invoke(Score);
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
