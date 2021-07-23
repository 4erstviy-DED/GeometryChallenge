using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFlying : MonoBehaviour
{
    public float speed, tilt;
    private Vector3 target = new Vector3(0, 5.59f, -2.49f);

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target.y != 4.7f)
        {
            target.y = 4.7f;
        }
        else if (transform.position == target && target.y == 4.7f)
        {
            target.y = 5.59f;
        }
        transform.Rotate(Vector3.up * Time.deltaTime * tilt);
    }
}
