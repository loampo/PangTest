using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public BallManager BallManager;
    public UIManager UIManager;
    public ProjectilePool ProjectilePool;
    public static GameManager instance;
    private float _timer;

    private void Start()
    {
        instance = this;
        _timer = 0;
    }

    private void Update()
    {
        if (Time.timeScale == 1) TimerRunning();

        UIManager.TimerStart(_timer);
    }

    public void NextLevel()
    {
        _timer = 0;
    }

    public void TimerRunning()
    {
        _timer += Time.deltaTime;
    }

    public void RestartCurrentScene()
    {
        _timer = 0;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void ResumeScene()
    {
        UIManager.Pause();
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}
