using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise2 : MonoBehaviour
{
    [SerializeField] private Transform transformObj;

    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moving to right
        transformObj.transform.position = Vector3.MoveTowards(transform.position, new Vector3(5, 0, 0), speed * Time.deltaTime);
        if (transformObj.transform.position.x == 5)
        {
            transformObj.transform.position = new Vector3(0,0,0);
        }
    }
}
