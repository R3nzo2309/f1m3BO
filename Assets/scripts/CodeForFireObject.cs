using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeForFireObject : MonoBehaviour
{
    public GameObject bullet;
    public Rigidbody rb;
    public static int movespeed = 10;
    public static int backwards = -10;
    public Vector3 userDirection = Vector3.right;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -0.1f, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0.1f, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(userDirection * movespeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(userDirection * backwards * Time.deltaTime);
        }
    }
}
