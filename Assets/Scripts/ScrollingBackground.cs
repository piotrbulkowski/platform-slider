using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-5 * Time.deltaTime, 0);

        if(transform.position.x < -20f)
        {
            transform.position = new Vector3(20f, transform.position.y);
        }
    }
}
