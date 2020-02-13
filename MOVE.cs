using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Time.deltaTime, 0);

        if (transform.position.y == 4)
            transform.position = new Vector3 (0f, 0f, 0f);
        GameObject.Find("Yegor").transform.localScale += new Vector3(-0.02f, -0.06f, -0.02f);
    }

}