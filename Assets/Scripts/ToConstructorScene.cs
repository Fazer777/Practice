using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToConstructorScene : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("ConstructorCar");
    }
}
