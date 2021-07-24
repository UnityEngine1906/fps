using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject pause1;
    private bool ispause = false;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && ispause == false)
        {
            Cursor.lockState = CursorLockMode.None;
            ispause = true;
            Time.timeScale = 0;
            pause1.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.R) && ispause == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            ispause = false;
            Time.timeScale = 1;
            pause1.SetActive(false);
        }
    }
}
