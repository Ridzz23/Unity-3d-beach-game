using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public static ScoreManager instance;
    int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        instance = this;   
    }

    void Start() 
    {
        scoreText.text = score.ToString();
    }
    // Update is called once per frame
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
}
