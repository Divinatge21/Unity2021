using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float omega;
   
    private float delta;

    public float amp = 0.0f; //величина размаха
    public float g = 9.8f;
    //public float speed = 0.0f;
    //public float massa = 0.0f;
    public float startLocation = 0.0f;
    public float L = 0.0f; //длина нити



    // Start is called before the first frame update
    void Start()
    {
        

        omega = Mathf.Sqrt(g/ L);

        delta = Mathf.Asin(startLocation);

        transform.position = new Vector3(Mathf.Sin(delta) * amp, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time * omega + delta) * amp, 0, 0);
    }
}
