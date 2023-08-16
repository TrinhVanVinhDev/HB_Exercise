using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise5 : MonoBehaviour
{
    [SerializeField] private Transform transformObj;

    public float speed = 0.5f;
    private bool movingLeft = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moving to right and to left
        if(transformObj.transform.position.x <= 5 && !movingLeft)
        {
            transformObj.transform.position = Vector3.MoveTowards(transform.position, new Vector3(5, 0, 0), speed * Time.deltaTime);
            if (transformObj.transform.position.x == 5)
            {
                movingLeft = true;
            }
        }
        else
        {
            transformObj.transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), speed * Time.deltaTime);
            if (transformObj.transform.position.x == 0)
            {
                movingLeft = false;
            }
        }
    }
}
