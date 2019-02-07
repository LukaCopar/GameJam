using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public float time = 40;

    public float timeLeft;

    private float targetTime;
    public float Score_Real;
    public float cajt;
    public Texture2D curs;

    public bool konc = true;

    public float Game = 1;

    public static Score Score1;
    private void Start()
    {
        Cursor.SetCursor(curs, new Vector2(0, 0), CursorMode.Auto);
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
