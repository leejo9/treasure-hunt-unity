using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * speed, 36)+ 50 , transform.position.z);
    }
}
