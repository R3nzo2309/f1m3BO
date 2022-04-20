using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public float speed = 4.0f;
    public Transform Follow;
    private bool clicked = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
            clicked = true;
        }

        if (clicked)
        {
            transform.position = Vector3.MoveTowards(transform.position, Follow.position, speed * Time.deltaTime);

        }
    }
}


