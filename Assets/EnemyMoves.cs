using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoves : MonoBehaviour
{
    
    public Vector3 Velocity = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        float randomY = Random.Range(4f, 7f);
        Velocity = new Vector3(randomY, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Velocity * Time.deltaTime;
        if (transform.position.x < -5f)
        {
            Velocity.x *= -1;
        }
        if (transform.position.x > 5f)
        {
            Velocity.x *= -1;
        }
        if (transform.position.z < 0.5f)
        {
            Velocity.z *= -1;
        }
        if (transform.position.z > 5f)
        {
            Velocity.z *= -1;
        }
    }
}
