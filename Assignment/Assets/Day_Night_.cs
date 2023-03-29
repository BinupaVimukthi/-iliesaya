using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day_Night_ : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Greater))
        {
            transform.Rotate(0, 0, 1 * speed);
        }
        if (Input.GetKeyDown(KeyCode.Less))
        {
            transform.Rotate(0, 0,- 1 * speed);
        }

    }
}
