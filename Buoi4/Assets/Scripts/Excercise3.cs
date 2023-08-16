using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise3 : MonoBehaviour
{
    [SerializeField] private Transform transformObj;

    public float speed = 5f;

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
            transformObj.transform.position = Vector3.MoveTowards(transform.position, new Vector3(5f, 0f, 0f), speed * Time.deltaTime);
        }
        if (transformObj.transform.position.x == 5 && transformObj.transform.position.y <= 5 && transformObj.transform.position.z == 0)
        {
            transformObj.transform.position = Vector3.MoveTowards(transform.position, new Vector3(5f, 5f, 0f), speed * Time.deltaTime);
        }
        if (transformObj.transform.position.y == 5 && transformObj.transform.position.y == 5 && transformObj.transform.position.z <= 5)
        {
            transformObj.transform.position = Vector3.MoveTowards(transform.position, new Vector3(5f, 5f, 5f), speed * Time.deltaTime);
        }
        if (transformObj.transform.position.z == 5 && transformObj.transform.position.y == 5 && transformObj.transform.position.z == 5)
        {
            transformObj.transform.position = new Vector3(0,0,0);
        }
    }
}
