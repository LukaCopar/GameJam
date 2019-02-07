using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    float rd;
    public int hp = 5;
    public GameObject player;
    Vector3 pPos;
    public float rad = 7f;
    public float speed = 0.1f;
    Ray path;
    public GameObject oxy;
    // Start is called before the first frame update
    void Start()
    {
        rd = Random.Range(0.0f, 1.0f);
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
        if(hp <= 0)
        {
            Debug.Log(rd);
            
            if(rd >= 0.75f)
            {
                Instantiate(oxy, transform.position, transform.rotation);
            }
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(pPos.x - transform.position.x, pPos.y - transform.position.y) * 2000);
            Timer.instance.timeLeft -= Timer.instance.time/14;
        }
    }
}
