using TMPro;
using UnityEngine;

public sealed class ScoreCountar : MonoBehaviour
{
    public static ScoreCountar Instance { get; private set; }

    private int _score;

    public int Score
    {
        get
        {
            return _score;
        }
        set
        {
            if(_score == value) return;

            _score = value;
            
            scoreText.SetText($"Очки: {_score}");
        }
    }

    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        Instance = this;
    }
}
