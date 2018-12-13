using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorWave : MonoBehaviour
{
    public Color color1;
    public Color color2;
    Renderer re;
    // Use this for initialization
    void Start()
    {
        re = GetComponent<Renderer>();

    }



    void Update()
    {
        re.material.color = Color.Lerp(color1, color2, Mathf.PingPong(Time.time, 1));

    }

}
