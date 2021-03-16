using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public int Speed = 1;

    void Update()
    {
        float xAxisValue = (Input.GetAxis("Horizontal") * Speed) / 50;
        float zAxisValue = (Input.GetAxis("Vertical") * Speed) / 50;

        transform.position = new Vector3(transform.position.x + xAxisValue, transform.position.y, transform.position.z + zAxisValue);
    }
}
