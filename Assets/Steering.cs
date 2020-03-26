using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steering : MonoBehaviour
{
    float horizontalSpeed = 1.0f;
    float verticalSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(v, h, 0);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 1);
        }
        
        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.Translate(0, 0, 0);
        }
    }
}
