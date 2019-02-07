using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject player;
    Vector3 pPos;
    public float rad = 7f;
    public float speed = 0.1f;
    Ray path;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        pPos = player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        pPos = player.transform.position;
        path = new Ray(transform.position, pPos);
        if(Vector3.Distance(transform.position, pPos) < rad)
        {
            transform.position = Vector3.MoveTowards(transform.position, pPos, speed);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(pPos.x - transform.position.x, pPos.y - transform.position.y) * 2000);
            Score.Score1.timeLeft -= Score.Score1.time /14;
        }
    }
}
