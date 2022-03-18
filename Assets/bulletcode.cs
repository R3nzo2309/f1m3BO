using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcode : MonoBehaviour
{
    public object bullet;
    public float bulletspeed = 20;
    private bool clicked = false;
    public Transform playerTransform;
    private bool hallo = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            clicked = true;


        }
        if (clicked)
        {
            transform.Translate(playerTransform.forward * Time.deltaTime * bulletspeed);
        }
    }
}
