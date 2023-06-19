using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Image playerHealthBar;
    public float playerHealthBarFullX = 78;

    public GameObject gameOverUI;
    public GameObject levelCompleteUI;

    public PlayerController player;

    void Update()
    {

        if (playerHealthBar)
        {
            Vector2 size = playerHealthBar.rectTransform.sizeDelta;
            size.x = player.health / player.healthMax * playerHealthBarFullX;

            playerHealthBar.rectTransform.sizeDelta = size;
        }


        if(gameOverUI && player.health <= 0)
        {
            gameOverUI.SetActive(true);
        }
        else if(levelCompleteUI && ScoreManager.currentEnemyProgress == ScoreManager.targetEnemyProgress)
        {
            levelCompleteUI.SetActive(true);
        }
    }
}