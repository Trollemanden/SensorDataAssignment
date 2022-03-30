using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroManager : MonoBehaviour
{
    #region Instance
    private static GyroManager instance;
    public static GyroManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType <GyroManager>();
                if (instance == null)
                    {
                    instance= new GameObject ("Spawned GyroManager", typeof (GyroManager)).GetComponent<GyroManager>();
                }
            }
            return instance;
        }
        set 
        {
            instance = value; 
        }
    }
    #endregion
}
