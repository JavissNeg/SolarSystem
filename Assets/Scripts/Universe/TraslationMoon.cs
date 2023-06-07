using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraslationMoon : MonoBehaviour
{
    readonly float G = 10f;
    public GameObject earth;
    GameObject moon;

    void Start()
    {
        moon = GameObject.Find("Moon");
        initialVelocity();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Gravity();
    }

    void Gravity()
    {
        /*
        float m1;
        float m2;
        float d;

        for (int i = 0; i < planets.Length; i++)
        {
            GameObject a = planets[i];
            m1 = a.GetComponent<Rigidbody>().mass;
            for (int j = 0; j < planets.Length; j++)
            {
                GameObject b = planets[j];
                if (a.name != b.name)
                {
                    m2 = b.GetComponent<Rigidbody>().mass;
                    d = Vector3.Distance(a.transform.position, b.transform.position);

                    a.GetComponent<Rigidbody>().AddForce((b.transform.position - a.transform.position).normalized *
                        (G * (m1 * m2) / (d * d)));
                }
            }
        }
        */

                float m1 = moon.GetComponent<Rigidbody>().mass;
                float m2 = earth.GetComponent<Rigidbody>().mass;
                float r = Vector3.Distance(moon.transform.position, earth.transform.position);

                moon.GetComponent<Rigidbody>().AddForce((earth.transform.position - moon.transform.position).normalized *
                    (G * (m1 * m2) / (r * r)));
            

    }

    void initialVelocity()
    {
                float m2 = earth.GetComponent<Rigidbody>().mass;
                float r = Vector3.Distance(moon.transform.position, earth.transform.position);

                moon.transform.LookAt(earth.transform);

                moon.GetComponent<Rigidbody>().velocity += moon.transform.right * Mathf.Sqrt((G * m2) / r);
            
    }
}
