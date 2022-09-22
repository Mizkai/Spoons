using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bars : MonoBehaviour
{
    public Slider slider;

    //Health
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void SetMinHealth(int health)
    {
        slider.minValue = health;
        slider.value = health;
    }
    public void SetHealth(int health)
    {
        slider.value = health;
    }

        
    //hunger
    public void SetMaxHunger(int hunger)
    {
        slider.maxValue = hunger;
        slider.value = hunger;
    }
    public void SetMinHunger(int hunger)
    {
        slider.minValue = hunger;
        slider.value = hunger;
    }
    public void SetHunger(int hunger)
    {
        slider.value = hunger;
    }

    //social
    public void SetMaxSocial(int social)
    {
        slider.maxValue = social;
        slider.value = social;
    }
    public void SetMinSocial(int social)
    {
        slider.minValue = social;
        slider.value = social;
    }
    public void SetSocial(int social)
    {
        slider.value = social;
    }

    //work
    public void SetMaxWork(int work)
    {
        slider.maxValue = work;
        slider.value = work;
    }
    public void SetMinWork(int work)
    {
        slider.minValue = work;
        slider.value = work;
    }
    public void SetWork(int work)
    {
        slider.value = work;
    }
}
