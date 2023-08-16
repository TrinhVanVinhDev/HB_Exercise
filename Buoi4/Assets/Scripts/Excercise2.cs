using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise2 : MonoBehaviour
{
    [SerializeField] private Transform transformObj;
    [SerializeField] private Transform APoint;
    [SerializeField] private Transform BPoint;

    public float speed = 5f;
    private bool movingLeft = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moving to right
        if(!movingLeft)
        {
            transform.position = Vector3.MoveTowards(transform.position, BPoint.position, speed * Time.deltaTime);
        }
        else if (movingLeft)
        {
            transform.position = Vector3.MoveTowards(transform.position, APoint.position, speed * Time.deltaTime);
        }

        if (transform.position.x == BPoint.position.x)
        {
            movingLeft = true;
        }
        if (transform.position.x == APoint.position.x)
        {
            movingLeft = false;
        }
    }
}
