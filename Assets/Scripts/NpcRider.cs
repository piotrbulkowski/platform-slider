using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcRider : MonoBehaviour
{
    private float movementSpeed = 0.06f;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(transform.position.x * movementSpeed * Time.deltaTime, 0.0f, 0.0f);
    }
}
