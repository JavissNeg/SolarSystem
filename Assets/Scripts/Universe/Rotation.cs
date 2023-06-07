using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    float rotationSoeed = 50f;
    public string wise = "left";

    void Start()
    {

    }

    void Update()
    {
        
        if (wise == "left")
            transform.Rotate(0f, rotationSoeed * Time.deltaTime, 0f);    //transform.Rotate((Vector3.back * rotationSoeed) * Time.deltaTime);

        if (wise == "right")
            transform.Rotate(0f, -1 * rotationSoeed * Time.deltaTime, 0f);
        
    }

}
