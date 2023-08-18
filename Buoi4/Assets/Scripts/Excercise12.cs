using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise12 : MonoBehaviour
{
    [SerializeField] private Transform APoint;
    [SerializeField] private Transform BPoint;

    [SerializeField] private float speed;

    private bool printLogs = true;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, BPoint.position, speed * Time.deltaTime);
        if (printLogs && Vector3.Distance(transform.position, BPoint.position) <= 0.1)
        {
            Debug.Log("Complete");
            printLogs = false;
        }
    }
}
