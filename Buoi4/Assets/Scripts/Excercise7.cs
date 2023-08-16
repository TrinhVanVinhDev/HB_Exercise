using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise7 : MonoBehaviour
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
        if (transformObj.transform.position.z >= 5 && transformObj.transform.position.y == 5 && transformObj.transform.position.z == 5)
        {
            Vector3 positionRandom = new Vector3(Random.Range(6f,10f), 5f, 5f);
            transformObj.transform.position = Vector3.MoveTowards(transform.position, positionRandom, speed * Time.deltaTime);
            Debug.Log(positionRandom);
        }
    }
}
