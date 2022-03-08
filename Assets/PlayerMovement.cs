using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    bool canJump = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * 10 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * 10 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * 10 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * 10 * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 200, 0));
            canJump = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        canJump = true;
    }
}
