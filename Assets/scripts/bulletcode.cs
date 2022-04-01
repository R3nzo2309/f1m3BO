using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class bulletcode : MonoBehaviour
{
    public float bulletspeed = 40;
    private bool clicked = false;
    public Transform playerTransform;
    private bool hallo = true;
    int teller = 0;

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
            transform.Translate(Vector3.forward * Time.deltaTime * bulletspeed);
            
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
