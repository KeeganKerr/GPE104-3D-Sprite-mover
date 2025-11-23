using UnityEngine;
using UnityEngine.UI;
public class HealthBar : Health
{
    public Image healthImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public override void Start()
    {
       
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    public override void TakeDamage(float amount)
    {
        base.TakeDamage(amount);
        UpdateHealthBar();
    
    }

    public void UpdateHealthBar()
    {
        if(healthImage != null)
        {
            float fill = currentHealth / maxHealth;
            healthImage.fillAmount = fill;
        }
    }

  
}
