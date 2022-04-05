using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CodeForKogel : MonoBehaviour
{
    public float bulletspeed = 40;
    private bool clicked = false;
    public Transform playerTransform;
    public Vector3 userDirection = Vector3.right;


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
            transform.Translate(userDirection * bulletspeed * Time.deltaTime);

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
