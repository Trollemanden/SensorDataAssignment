using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{ 
    bool IsPressed = false;
    private CSVWriter writer;
    private List<Vector3> data = new List<Vector3>();
    private void Start()
    {
        writer = new CSVWriter("test1");   
    }
    private void Update()
    {
        if (IsPressed)
        {
            data.Add(Input.acceleration);
        }
        else if(data.Count > 0)
        {
        writer.WriteCSV(data);
            data.Clear();
        }
    }
    public void OnClickButton()
    {
        if (IsPressed)
        {
            IsPressed = false;
        }
        else
        { 
        IsPressed=true;
        }
    }
}
