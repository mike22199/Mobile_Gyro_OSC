using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    public GameObject speaker1;
    public GameObject speaker2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //speaker1.GetComponent<AudioSource>().panStereo += 0.01f;
            Debug.Log("A");
            speaker1.GetComponent<AudioSource>().volume += 0.001f;
            speaker2.GetComponent<AudioSource>().volume -= 0.001f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
            speaker1.GetComponent<AudioSource>().volume -= 0.001f;
            speaker2.GetComponent<AudioSource>().volume += 0.001f;
        }
    }
}
