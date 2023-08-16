using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise4 : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    private float startTime;
    private float lengthTwoPoint;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        lengthTwoPoint = Vector3.Distance(startPoint.position, endPoint.position);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 center = (startPoint.position + endPoint.position) * .5f;
        center -= new Vector3(0, 1, 0);
        Vector3 riseRelCenter = startPoint.position - center;
        Vector3 setRelCenter = endPoint.position - center;
        float fracComplete = (Time.time - startTime) / 1f;
        transform.position = Vector3.Slerp(riseRelCenter, setRelCenter, fracComplete);
    }
}
