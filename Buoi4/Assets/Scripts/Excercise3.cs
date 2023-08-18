using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise3 : MonoBehaviour
{
    [SerializeField] private Transform transformObj;
    [SerializeField] private Transform APoint;
    [SerializeField] private Transform BPoint;
    [SerializeField] private Transform CPoint;
    [SerializeField] private Transform DPoint;

    public float speed = 5f;
    private bool resetPoint = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //moving to right 3 point
        if (transformObj.transform.position.x <= 5 && transformObj.transform.position.y == 0 && transformObj.transform.position.z == 0)
        {
            transformObj.transform.position = Vector3.MoveTowards(transform.position, BPoint.position, speed * Time.deltaTime);

            resetPoint = false;
        }
        if (transformObj.transform.position.x == 5 && transformObj.transform.position.y <= 5 && transformObj.transform.position.z == 0)
        {
            transformObj.transform.position = Vector3.MoveTowards(transform.position, CPoint.position, speed * Time.deltaTime);
        }
        if (transformObj.transform.position.y == 5 && transformObj.transform.position.y == 5 && transformObj.transform.position.z <= 5)
        {
            transformObj.transform.position = Vector3.MoveTowards(transform.position, DPoint.position, speed * Time.deltaTime);
        }
        if (resetPoint)
        {
            transformObj.transform.position = Vector3.MoveTowards(transform.position, APoint.position, speed * Time.deltaTime);
        }
        if (transformObj.transform.position.z == 5 && transformObj.transform.position.y == 5 && transformObj.transform.position.z == 5)
        {
            resetPoint = true;
        }
        if (transformObj.transform.position.z == 0 && transformObj.transform.position.y == 0 && transformObj.transform.position.z == 0)
        {
            resetPoint = false;
        }

    }
}