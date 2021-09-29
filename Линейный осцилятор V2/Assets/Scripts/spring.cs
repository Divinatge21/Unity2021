using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spring : MonoBehaviour
{
    private float omega; 
    private float amp ; //величина размаха
    private float alpha;

    public float kof = 0.4f;
    public float speed = 0.0f;
    public float massa = 0.0f;
    public  float startLocation = 0.0f;



    // Start is called before the first frame update
    void Start()
    {
        amp = Mathf.Sqrt(startLocation * startLocation + (speed*speed/kof*kof));

        omega = Mathf.Sqrt(massa/kof);

        alpha = Mathf.Atan(startLocation * kof / speed);

        transform.position = new Vector3(Mathf.Sin(alpha) * amp, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time * omega + alpha) * amp, 0, 0);
    }
}
