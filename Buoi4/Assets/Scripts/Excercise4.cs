using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise4 : MonoBehaviour
{
    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform endPoint;
    [SerializeField] private Transform centerPoint;

    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 center = centerPoint.position;
        center -= new Vector3(0, 1, 0);
        Vector3 riseRelCenter = startPoint.position - center;
        Vector3 setRelCenter = endPoint.position - center;
        float fracComplete = (Time.time - startTime) / 1f;
        transform.position = Vector3.Slerp(riseRelCenter, setRelCenter, fracComplete);
        transform.position += center;
    }
}