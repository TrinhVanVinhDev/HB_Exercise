using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PrintLogKeyDown();
    }

    private void PrintLogKeyDown()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
        } else if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B");
        } else if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("C");
        }
    }

    //private void OnGUI()
    //{
    //    Event e = Event.current;
    //    if (e.type == EventType.KeyDown)
    //    {
    //        if (Input.GetKeyDown(e.keyCode))
    //        {
    //            Debug.Log("Down: " + e.keyCode);
    //        }
    //    }
    //    else if (e.type == EventType.KeyUp)
    //    {
    //        if (Input.GetKeyUp(e.keyCode))
    //        {
    //            Debug.Log("Up: " + e.keyCode);
    //        }
    //    }
    //}
}
