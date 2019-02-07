using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHandling : MonoBehaviour
{

    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.tag)
        {
            case "OxygenPickup":
                Score.Score1.timeLeft += Score.Score1.time/10f;
                if(Score.Score1.timeLeft > Score.Score1.time)
                {
                    Score.Score1.timeLeft = Score.Score1.time;
                }
                break;
            case "shoes":
                PlayerMovement.instance.speed *= 1.2f;
                Portal.instanciate.playerSpeed = PlayerMovement.instance.speed;
            break;
            case "EnemyPickup":
                Instantiate(enemy, collision.transform.position, collision.transform.rotation);
                break;
        }
    }
}
