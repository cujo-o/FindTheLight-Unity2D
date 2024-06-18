using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{
    public Transform[] points;
    public float moveSpeed;
    private int pointIndex;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[pointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (pointIndex <= points.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, points[pointIndex].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == points[pointIndex].transform.position)
            {
                pointIndex += 1;
            }

            if (pointIndex == points.Length) // Remove this if it should keep looping, here it will stop at the last point.
            {
                pointIndex = 0;
            }
        }
    }


}
