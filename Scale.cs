using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    private Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scaleChange = new Vector3(-0.02f, -0.06f, -0.02f);
        transform.localScale += scaleChange;
    }
}
