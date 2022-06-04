using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pilot : MonoBehaviour
{
    public float tor = 10f;
    public float vel = 20f;
    public float speed ;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 z = transform.position - transform.forward*70.0f + Vector3.up*30.0f;
        Camera.main.transform.position = z;
        Camera.main.transform.LookAt(transform.position + transform.forward*30.0f);

       
        // float curr_speed ;
        float prop = speed*speed;
        transform.position += transform.forward*Time.deltaTime*vel;
        float h = Input.GetAxis("Horizontal")*prop*Time.deltaTime*2;

        // float v = Input.GetAxis("Vertical")*tor*Time.deltaTime;
        if(Input.GetKey("space"))
        {
           if (speed<200.0f)speed = speed + 20.0f*Time.deltaTime;
        }
        else
        {
           
            if (speed>10.0f)
            {
                if (Input.GetKey(KeyCode.LeftShift)) speed = speed - 10.0f*Time.deltaTime;
                else{
                    speed -= 2.0f*Time.deltaTime;
                }
            } 

        }
        transform.position += transform.forward*Time.deltaTime*speed;
        // rb.AddTorque(0, 0, -h);
        transform.Rotate(Input.GetAxis("Vertical")*Time.deltaTime*40.0f, 0.0f, -Input.GetAxis("Horizontal")*Time.deltaTime*speed);
       
       if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
