using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CodeForMissile : MonoBehaviour
{
    public float speed = 10.0f;
    public Transform follow;
    private bool clicked = false;
    public Transform playerTransform;
    public Vector3 userDirection = Vector3.right;


    // Start is called before the first frame update
    void Start()
    {
        follow = GameObject.Find("Sphere").transform;
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
            transform.position = Vector3.MoveTowards(transform.position, follow.position, speed * Time.deltaTime);

        }
        Destroy(gameObject, 2);



    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
