using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CammeraMovement : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    public Transform target;
    public float smoothTime = 0.001F;
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        offset = transform.position - player.transform.position;

    }

    void LateUpdate()
    {
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 0, -10));
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition,ref velocity, smoothTime);
    }
}
