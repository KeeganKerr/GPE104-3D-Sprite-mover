using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UiManager : MonoBehaviour
{
    public TMP_Text lives;
    public TMP_Text bottomText;
    public TMP_Text health;
    private Health healthData;
   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthData = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLives();
        UpdateScore();
        UpdateHealth();
    }


    void UpdateLives()
    {
        lives.text= "Live:" + healthData.lives;
    }

    void UpdateHealth()
    {
        health.text= "Health:" + healthData.currentHealth;
    }

    void UpdateScore()
    {
        bottomText.text= "Score:" + GameManager.instance.score;
    }
}
