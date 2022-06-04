using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class Explosion : MonoBehaviour
{
    public GameObject ExpEffect;
    public AudioSource SoundEffect;
    private bool f; 
    public float delay = 1f;
    float countdown;
    // Start is called before the first frame update
    void Start()
    {
        f = true;
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        float altitude = Terrain.activeTerrain.SampleHeight(transform.position);
        if (altitude > transform.position.y)
        {
          
            // SoundEffect.Play();
           
            Instantiate(ExpEffect, transform.position, transform.rotation);
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            SceneManager.LoadScene (2);
              
        }
        
    }
}
