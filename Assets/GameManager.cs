using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ScoreText;
    public GameObject WinnerText;
    public SceneAsset GameScene;
    public bool IsGameScene = true; 

    public int MaxScore = 3;

    private int _score = 0;

    void Start()
    {
        if (IsGameScene) UpdateUI();
    }

    public void AddScore()
    {
        _score += 1;
        UpdateUI();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(GameScene.name);
    }

    private void UpdateUI()
    {
        ScoreText.GetComponent<Text>().text = $"Score: {_score}";
        WinnerText.SetActive(_score == MaxScore);
    }
}
