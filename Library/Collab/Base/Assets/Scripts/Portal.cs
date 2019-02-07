using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Portal : MonoBehaviour
{

    public Camera camera;
    public GameObject  player;
    public string Scene;
    float time = 10f;
    float time_zajle = 0;
    public float playerSpeed = 0.2f;
    public static Portal instanciate;

    float fov = 1000;

    int start = 0;
    void Start()
    {
        instanciate = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.active = false;
        start = 1;
        

    }
    void Update()
    {

        
        time -= Time.deltaTime;
        if (start == 1)
        {


            
            if (time_zajle == 0)
            {
                time_zajle = time;
            }
            if (time <= time_zajle - 1.5f)
            {
                Debug.Log(Score.Score1.Game);
                if (Score.Score1.Game == 0)
                {
                    SceneManager.UnloadSceneAsync("Lvl. 1");
                }
                if(Score.Score1.Game > 1)
                {

                }
                else
                {
                    SceneManager.LoadScene(Scene, LoadSceneMode.Additive);
                }

                Score.Score1.konc = false;
                Score.Score1.Game++;
                
            }
            
        }
    }
}
