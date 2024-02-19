using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject CrosshairUI;
    public GameObject Interface;

    public Movement FPC;
    public AudioSource AS;

    void Start()
    {
        FPC.GetComponent<Movement>();
        AS.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
                GameIsPaused = false;
            } else
            {
                Pause();
                GameIsPaused = false;
            }
        }
    }

    public void Resume ()
    {
        Interface.SetActive(true);
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        CrosshairUI.SetActive(true);
        FPC.enabled = true;
        AS.Play(0);
    }

    public void Pause ()
    {
        Interface.SetActive(false);
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        CrosshairUI.SetActive(false);
        FPC.enabled = false;
        AS.Pause();
    }

    public void Exit ()
    {
        SceneManager.LoadScene(0);
    }
}