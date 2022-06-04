using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propeller : MonoBehaviour{
    
    public Pilot script;
    public float angVel;

    // Start is called before the first frame update
    void Start(){
        // angVel = script.speed;
    }

    // Update is called once per frame
    void Update(){
        angVel = script.speed;
        transform.Rotate(angVel*Time.deltaTime*10, 0, 0);
    }
}