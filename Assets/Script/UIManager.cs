using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreNumber;
    [SerializeField] private TextMeshProUGUI _timeNumber;
    [SerializeField] private TextMeshProUGUI _levelNumber;
    [SerializeField] private TextMeshProUGUI _highScoreNumber;
    [SerializeField] private TextMeshProUGUI _modeText;
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private GameObject _PausePanel;

    public void TimerStart(float timer)
    {
        int time = Mathf.RoundToInt(timer);
        _timeNumber.text = time.ToString();
    }

    public void Pause()
    {
        if (!_PausePanel.gameObject.activeInHierarchy)
        {
            Time.timeScale = 0;
            _PausePanel.gameObject.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            _PausePanel.gameObject.SetActive(false);
        }
    }
}
