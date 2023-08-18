using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise9 : MonoBehaviour
{
    [SerializeField] private Transform APoint;
    [SerializeField] private Transform BPoint;
    [SerializeField] private float timer;

    private bool movingLeft = false;
    private float speed;
    private float journeyLength;
    private float timeLess = 0;

    private void Start()
    {

        journeyLength = Vector3.Distance(APoint.position, BPoint.position);
    }

    private void Update()
    {
        speed = journeyLength / timer;

        timeLess += Time.deltaTime;
        if (!movingLeft)
        {
            transform.position = Vector3.MoveTowards(transform.position, BPoint.position, speed * Time.deltaTime);
        }
        else if (movingLeft)
        {
            transform.position = Vector3.MoveTowards(transform.position, APoint.position, speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, BPoint.position) <= 0.1)
        {
            movingLeft = true;
            Debug.Log(timeLess);
            timeLess = 0;
        }
        else if (Vector3.Distance(transform.position, APoint.position) <= 0.1)
        {
            movingLeft = false;
            Debug.Log(timeLess);
            timeLess = 0;
        }
    }
}
