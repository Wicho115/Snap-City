using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public int score;
    public Transform Player;
    public TextMeshProUGUI scoreText;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void GameOver()
    {
        panel.SetActive(true);
        scoreText.text = "Score: " + score;
    }
  
}
