using Newtonsoft.Json;

[System.Serializable]
public class PlayerScore
{
    [JsonProperty("name")]
    private string _name;

    [JsonProperty("score")]
    private int _score;

    public string Name => _name;
    public int Score => _score;

    public PlayerScore(string name, int score)
    {
        _name = name;
        _score = score;
    }
}