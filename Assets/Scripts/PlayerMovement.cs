using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Animator anim;
    public float speed;
    private Vector3 dir;
    public static PlayerMovement instance;
    bool right = false;
    // Start is called before the first frame update
    void Start()
    {
        dir = new Vector3();
        instance = this;
        speed = Portal.instanciate.playerSpeed;
    }


    // Update is called once per frame
    void Update()
    {
        dir = new Vector3(0, 0, 0);
        if(Input.GetKey(KeyCode.A))
        {
            dir.x = -speed;
            if (right)
            {
                Flip();
            }
            anim.Play("walk_horizontal");
        }
        else if (Input.GetKey(KeyCode.W))
        {
            dir.y = speed;
            anim.Play("walk_up_pl");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            dir.y = -speed;
            anim.Play("walk_down_pl");

        }
        else if (Input.GetKey(KeyCode.D))
        {
            dir.x = speed;
            if(!right)
            {
                Flip();
            }
            anim.Play("walk_horizontal");

        }
        else
        {
            anim.Play("idle_pl");
        }
        this.gameObject.transform.position = this.gameObject.transform.position + dir;

    }

    void Flip()
    {
        right = !right;
        Vector3 scaler = anim.transform.localScale;
        scaler.x *= -1;
        anim.transform.localScale = scaler;
    }
}
