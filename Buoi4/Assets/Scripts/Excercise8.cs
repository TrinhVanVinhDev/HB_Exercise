using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise8 : MonoBehaviour
{
    [SerializeField] private Transform APoint;
    [SerializeField] private Transform BPoint;


    // Movement speed in units per second.
    public float speed = 1.0F;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;

    private bool oneTime = true;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(APoint.position, BPoint.position);
    }

    // Update is called once per frame
    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fractionOfJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(APoint.position, BPoint.position, fractionOfJourney);
        if(transform.position.x == BPoint.position.x)
        {
            startTime = Time.time;
            transform.position = Vector3.Lerp(BPoint.position, APoint.position, fractionOfJourney);
        }
    }

    private IEnumerable IEDelayTime(float time)
    {
        yield return new WaitForSeconds(time);
    }

}
