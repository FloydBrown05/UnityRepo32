using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Levelmanager : MonoBehaviour
{

    void Update()
    
        
        {
        if(Input.GetMouseButtonDown(0))
        {
            LoadNextLevel();
        }
        }
    
    public void LoadNextLevel()
    {
        SceneManager.LoadScene("SCENE2");
    }
}



