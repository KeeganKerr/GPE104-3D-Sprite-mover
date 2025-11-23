using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UiManager : MonoBehaviour
{

    public TMP_Text bottomText;
   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
       
        UpdateScore();
    }

  

    void UpdateScore()
    {
        bottomText.text= "Score:" + GameManager.instance.score;
    }
}
