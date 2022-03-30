using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    public float thresh = 3;
    public TMPro.TMP_Text text;
    private bool trigger = false;

    void Update()
    {
        if (Input.acceleration.magnitude > thresh)
        {
            if (!trigger)
            {
                trigger = true;
            }
        }
        else if (trigger)
        {
            trigger = false;
        }
        if (text)
            text.text = "Acceleration " + Input.acceleration.ToString();
    }
}

