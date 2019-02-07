using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score_Show : MonoBehaviour
{

    public Text text;

    float score;
    float supak = 1;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            if (Score.Score1.timeLeft > 0)
            {
                if(supak == 1)
                {
                    supak = 0;
                    score = ((Score.Score1.Score_Real % 10) * 100000) * ((Score.Score1.timeLeft / Score.Score1.time) + 1) + 2000000;
                    text.text = "Score: " + score.ToString();
                }
                
            }
            
        }
        catch (System.Exception)
        {

        }
    }
}
