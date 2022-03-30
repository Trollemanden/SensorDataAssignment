using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVWriter
{
    string path;

    public CSVWriter(string filename)
    {
        path = Application.persistentDataPath + "/" + filename + ".csv";
    }

    

    public void WriteCSV(List<Vector3> data)
    {
        TextWriter sw = new StreamWriter(path, true);
        sw.WriteLine("x;y;z");

        foreach (Vector3 acc in data)
        {
            sw.WriteLine($"{acc.x};{acc.y};{acc.z}");
        }
        sw.Close();
    }





    // liste med quaternion værdier, konverter til en ny liste af accelerometer værdier. 
    // brug vector3 da det er det som accelerometer bruger


    
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
