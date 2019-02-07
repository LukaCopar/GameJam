using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public Text timer;
    public Image progressBar;
    public static Timer instance;
    public GameObject player;
    float FillAmount;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        

        if(Score.Score1.timeLeft < 0)
        {
            timer.text = "Game Over!";
            timer.color = Color.red;
            GameOver();
        }
        FillAmount = Score.Score1.timeLeft / Score.Score1.time;
        progressBar.fillAmount = FillAmount;


    }

    private void GameOver()
    {
        player.active = false;
        if (Score.Score1.timeLeft < -1)
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }

    }
}
