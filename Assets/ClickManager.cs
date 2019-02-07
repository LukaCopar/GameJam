using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    private Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                if(hit.collider.tag == "Enemy")
                {
                    dir = new Vector2(Random.Range(-2500f, 2500f), Random.Range(-2500f, 2500f));
                    hit.collider.gameObject.GetComponent<EnemyFollow>().hp--;
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForce(dir);
                    Debug.Log(dir);
                }
            }
            //Debug.Log(mousePos);
            //Debug.Log(hit);
        }
    }
}
