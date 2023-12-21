using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject slider;
    public float a;
    public float Pan;
    public AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a = slider.GetComponent<Slider>().value;
        Pan = map(a,0,1,-1,1);
        AS.GetComponent<AudioSource>().panStereo = Pan;
    }

    float map(float value, float fromLow, float fromHigh, float toLow, float toHigh)
    {
        return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
    }
}
