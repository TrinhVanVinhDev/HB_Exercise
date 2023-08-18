using System.Collections;
using UnityEngine;

public class Excercise10 : MonoBehaviour
{
    [SerializeField] private Transform transformObj;

    public float speed = 5f;
    private bool movingLeft = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //moving to right and to left
        if (!movingLeft)
        {
            transformObj.transform.position = Vector3.MoveTowards(transform.position, new Vector3(5, 0, 0), speed * Time.deltaTime);
            if (transformObj.transform.position.x == 5)
            {
                movingLeft = true;
            }
        }
        else if (movingLeft)
        {
            transformObj.transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), speed * Time.deltaTime);
            if (transformObj.transform.position.x == 0)
            {
                StartCoroutine(IEDelayTime());
            }
        }

    }

    private IEnumerator IEDelayTime()
    {
        float times = Mathf.Round(Random.Range(1f, 2f));
        yield return new WaitForSeconds(times);
        movingLeft = false;
    }
}
