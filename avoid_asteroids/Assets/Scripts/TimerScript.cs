using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private float timeStart = 0;
    [SerializeField] private Text scoreText;
    public PlayerDeath PlayerDeath;
    void Start()
    {
        scoreText.text = timeStart.ToString();
    }

    void Update()
    {
        if (PlayerDeath.isDead) {
            timeStart += 0;
            scoreText.text = "Score:" + Mathf.Round(timeStart).ToString();
        } else {
            timeStart += Time.deltaTime;
            scoreText.text = "Score:" + Mathf.Round(timeStart).ToString();}
    }
}
