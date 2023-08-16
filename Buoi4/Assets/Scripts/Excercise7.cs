using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise7 : MonoBehaviour
{
    [SerializeField] private Transform transformObj;
    [SerializeField] private Transform APoint;
    [SerializeField] private Transform BPoint;
    [SerializeField] private Transform CPoint;
    [SerializeField] private Transform DPoint;

    [SerializeField] private float speed = 5f;

    private bool moving = true;
    private Transform[] arr;

    void Start()
    {

        arr = new Transform[] { APoint, BPoint, CPoint, DPoint };
        RandomPoint();
    }

    // Update is called once per frame
    void Update()
    {
        //moving to right 3 point
        //if (transformObj.transform.position.x <= 5 && transformObj.transform.position.y == 0 && transformObj.transform.position.z == 0)
        //{
        //    transformObj.transform.position = Vector3.MoveTowards(transform.position, new Vector3(BPoint.position.x, BPoint.position.y, BPoint.position.z), speed * Time.deltaTime);
        //}
        //if (transformObj.transform.position.x == 5 && transformObj.transform.position.y <= 5 && transformObj.transform.position.z == 0)
        //{
        //    transformObj.transform.position = Vector3.MoveTowards(transform.position, new Vector3(CPoint.position.x, CPoint.position.y, CPoint.position.z), speed * Time.deltaTime);
        //}
        //if (transformObj.transform.position.y == 5 && transformObj.transform.position.y == 5 && transformObj.transform.position.z <= 5)
        //{
        //    transformObj.transform.position = Vector3.MoveTowards(transform.position, new Vector3(DPoint.position.x, DPoint.position.y, DPoint.position.z), speed * Time.deltaTime);
        //}
        //if (moving)
        //{
        //    transformObj.transform.position = Vector3.MoveTowards(transform.position, arr[indexPositionRandom].position, speed * Time.deltaTime);
        //    if (transformObj.transform.position <= arr[indexPositionRandom].position)
        //    {
        //        moving = false;
        //    }
        //}
    }

    private void RandomPoint()
    {
        int indexPositionRandom = Random.Range(0, arr.Length);
    }
}
