using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 pos;
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            pos.z += speed * Time.deltaTime;
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            pos.z -= speed * Time.deltaTime;
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
