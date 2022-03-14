using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SpawnManager spawnManager;
    public ItemManager itemManager;
    public GameObject Cover;

    int score;
    public Text ScoreText;
    void Start()
    {
        EventManager.EnemyDieEvent += OnEnemyDie;
    }

    public void OnClickStartButton()
    {
        Cover.SetActive(false);
        StartCoroutine(spawnManager.SpawnRandom());
        itemManager.SpawnRandom();
    }

    public void OnEnemyDie()
    {
        score++;
        ScoreText.text = String.Format("Score : {0}",score);
    }

    void Update()
    {
        
    }
}
