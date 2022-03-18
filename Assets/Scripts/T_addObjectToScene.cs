using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class T_addObjectToScene : MonoBehaviour
{
    public GameObject[] objects;  
    private ScrollViewAdapter scrollView;
    private ScrollView scroll;

    public void ClickButton()
    {        
        //scrollView = GameObject.Find("btnBodywork").GetComponent<ScrollViewAdapter>();
        scroll = GameObject.Find("Panel (ScrollView)").GetComponent<ScrollView>();

        //for (int i = 0; i < objects.Length; ++i)
        //{
        //    for (int j = 0; j < objects.Length; ++j)
        //    {
        //        if (scrollView.images[i].name == objects[j].name)
        //        {
        //            Instantiate(objects[i], objects[i].transform.position, Quaternion.identity);
        //            break;
        //        }
        //    }
        //}

        switch (scroll.tabIndex)
        {
            case 0: Instantiate(objects[scroll.tabIndex], objects[scroll.tabIndex].transform.position, Quaternion.identity);
                break; 
            case 1: Instantiate(objects[scroll.tabIndex], objects[scroll.tabIndex].transform.position, Quaternion.identity);
                break; 
            case 2:Instantiate(objects[scroll.tabIndex], objects[scroll.tabIndex].transform.position, Quaternion.identity);
                break;
            default:
                break;
        }
             

    }
}
