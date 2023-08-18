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

    private Transform[] arr;
    private Transform tranfromRandom;

    void Start()
    {

        arr = new Transform[] { APoint, BPoint, CPoint, DPoint };
        tranfromRandom = RandomPoint(arr);
    }

    // Update is called once per frame
    void Update()
    {
        transformObj.transform.position = Vector3.MoveTowards(transform.position, tranfromRandom.position, speed * Time.deltaTime);
        if (Vector3.Distance(transformObj.transform.position, tranfromRandom.position) <= 0.1)
        {
            tranfromRandom = RandomPoint(arr);
        }
    }

    private Transform RandomPoint(Transform[] arr)
    {
        int indexPosition = Random.Range(0, arr.Length);
        return arr[indexPosition];
    }
}