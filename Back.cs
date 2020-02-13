using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour

{
    public Vector3 startposition;
    public Vector3 endposition;
    public float i;

    void Start()
    {
        startposition = transform.position;
        endposition = new Vector3(0.03f, 1, 1);
        i = 0;
    }
    void Update()
    {

            if (transform.position == endposition)
            {
                transform.position = startposition;
                i = 0;
        }
            else
            {
            i += 0.01f;
            transform.position = Vector3.Lerp(startposition, endposition, i );
            Debug.Log(Vector3.Lerp(startposition, endposition, i));
            }
        
    }

}
