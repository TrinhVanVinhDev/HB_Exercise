using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise6 : MonoBehaviour
{
    [SerializeField] private Transform transformObj;

    public float speed = 5f;

    private float step = 1f;
    private Vector3 endPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            endPoint = new Vector3(transform.position.x, transform.position.y + step, 0f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            endPoint = new Vector3(transform.position.x, transform.position.y - step, 0f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            endPoint = new Vector3(transform.position.x + step, transform.position.y, 0f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            endPoint = new Vector3(transform.position.x - step, transform.position.y, 0f);
        }
        transformObj.transform.position = Vector3.MoveTowards(transform.position, endPoint, speed * Time.deltaTime);
    }
}
