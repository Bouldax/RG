using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;

    // Set Health Bar UI current health to specified value
    public void SetHealth(int health)
    {
        healthSlider.value = health;
    }

    // Set Health Bar UI maximum health to specified value
    public void SetMaxHealth(int health)
    {
        healthSlider.maxValue = health;
        SetHealth(health);
    }
}
