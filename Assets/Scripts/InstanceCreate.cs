using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceCreate : MonoBehaviour
{
    public GameObject[] objects;
    public void ClickButton(int index)
    {
        switch (index)
        {
            case 0: 
                Instantiate(objects[0]);
                break;
            case 1: 
                Instantiate(objects[1]);
                break;
            case 2: 
                Instantiate(objects[2]);
                break;
            case 3:
                Instantiate(objects[3]);
                break;
            case 4:
                Instantiate(objects[4]);
                break;
            case 5:
                Instantiate(objects[5]);
                break;                                  
            default: Debug.Log("Something wrong!");
                break;
        }
    }
}
