using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise8 : MonoBehaviour
{
    [SerializeField] private Transform APoint;
    [SerializeField] private Transform BPoint;

    // Movement speed in units per second.
    [SerializeField] private float speed = 5.0F;

    private bool movingLeft = true;
    private float randomTime;

    void Update()
    {
        StartCoroutine(IEDelayTime(1));
    }

    private IEnumerator IEDelayTime(float time)
    {
        if (!movingLeft)
        {
            transform.position = Vector3.MoveTowards(transform.position, BPoint.position, speed * Time.deltaTime);
        }
        if (movingLeft)
        {
            transform.position = Vector3.MoveTowards(transform.position, APoint.position, speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, BPoint.position) <= 0.1)
        {
            yield return new WaitForSeconds(randomTime);
            movingLeft = true;
        }
        else if (Vector3.Distance(transform.position, APoint.position) <= 0.1)
        {
            movingLeft = false;
        }
    }

}