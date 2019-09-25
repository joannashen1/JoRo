using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Options : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Space pressed");
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R pressed");
            SceneManager.LoadScene(0);
        }

        //if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    SceneManager.LoadScene(1);
        //}
    }
}
