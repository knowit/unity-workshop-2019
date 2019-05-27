using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ScoreText;
    public GameObject WinnerText;

    public int MaxScore = 3;

    private int _score = 0;

    void Start()
    {
        UpdateUI();
    }

    public void AddScore()
    {
        _score += 1;
        UpdateUI();
    }

    private void UpdateUI()
    {
        ScoreText.GetComponent<Text>().text = $"Score: {_score}";
        WinnerText.SetActive(_score == MaxScore);
    }
}
