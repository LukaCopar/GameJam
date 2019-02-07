using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public float time = 30;

    public float timeLeft;

    private float targetTime;
    public float Score_Real;
    public float cajt;

    public bool konc = true;

    public float Game = 0;

    public static Score Score1;
    private void Start()
    {
        Score1 = this;
        timeLeft = time;
        targetTime = time;
        SceneManager.LoadScene("Lvl. 1", LoadSceneMode.Additive);
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        targetTime -= Time.deltaTime;
        Score_Real = targetTime;

    }
}
