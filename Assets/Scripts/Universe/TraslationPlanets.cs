using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraslationPlanets : MonoBehaviour
{
    [Header("Traslación de los planetas")]
    public GameObject b; //Sun
    GameObject[] planets;

    [Header("Traslación de la luna y la tierra:")]
    public GameObject moon;
    public GameObject earth;
    readonly float G = 10f;

    private float m1;
    private float m2;
    private float rMoon;
    private float r;
    private float angleZ;

    void Start()
    {
        planets = GameObject.FindGameObjectsWithTag("Planet");
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

        foreach (GameObject a in planets)
        {
            if (!a.Equals(b))
            {
                m1 = a.GetComponent<Rigidbody>().mass;
                m2 = b.GetComponent<Rigidbody>().mass;
                r = Vector3.Distance(a.transform.position, b.transform.position);
                    
                a.GetComponent<Rigidbody>().AddForce((b.transform.position - a.transform.position).normalized *
                    (G * (m1 * m2) / (r * r)));
            }
        }

        m1 = moon.GetComponent<Rigidbody>().mass;
        m2 = earth.GetComponent<Rigidbody>().mass;
        moon.GetComponent<Rigidbody>().AddForce((earth.transform.position - moon.transform.position).normalized *
                 (G * (m1 * m2) / (rMoon * rMoon)));
        
    }

    void initialVelocity()
    {

        foreach (GameObject a in planets)
        {
            if (!a.Equals(b))
            {
                m1 = b.GetComponent<Rigidbody>().mass;
                r = Vector3.Distance(a.transform.position, b.transform.position);
                angleZ = a.transform.eulerAngles.z;

                a.transform.LookAt(b.transform);
                a.GetComponent<Rigidbody>().velocity += a.transform.right * Mathf.Sqrt((G * m1) / r);
                a.transform.Rotate(0, 0, angleZ);
            }
        }

        m1 = earth.GetComponent<Rigidbody>().mass;
        rMoon = Vector3.Distance(moon.transform.position, earth.transform.position);

        moon.transform.LookAt(earth.transform);
        moon.GetComponent<Rigidbody>().velocity += moon.transform.right * Mathf.Sqrt((G * m1) / rMoon);

    }
}
