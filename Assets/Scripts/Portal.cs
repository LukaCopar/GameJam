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
    public Animator anim;

    private int St_Lvlou = 3;

    string jeboTeBog;
    string jeboTeBog2;

    int start = 0;
    void Start()
    {
        instanciate = this;
        anim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.Score1.Game++;
        player.active = false;
        start = 1;
        anim.Play("zoom");

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
                if(Score.Score1.Game+1 <= St_Lvlou)
                {
                    jeboTeBog = "Lvl. " +  (Score.Score1.Game+1).ToString();
                    jeboTeBog2 = "Lvl. " +  (Score.Score1.Game).ToString();
                }
                else
                {
                    jeboTeBog = "Menu";
                    jeboTeBog2 = "Lvl. " + St_Lvlou.ToString();
                }
                Debug.Log(jeboTeBog + "   1");
                Debug.Log(jeboTeBog2);
                SceneManager.UnloadSceneAsync(jeboTeBog2);
                SceneManager.LoadScene(jeboTeBog, LoadSceneMode.Additive);
                Score.Score1.konc = false;
                time_zajle = 0;
                
            }
            
        }
    }
}
