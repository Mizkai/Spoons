using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthplayer : MonoBehaviour
{
    //Health
    public int maxHealth = 15;
    public int minHealth = 0;
    public int currentHealth;
    //Hunger
    public int maxHunger = 15;
    public int minHunger = 0;
    public int currentHunger;
    //Social
    public int maxSocial = 15;
    public int minSocial = 0;
    public int currentSocial;
    //Work
    public int maxWork = 15;
    public int minWork = 0;
    public int currentWork;


    public Bars healthBar;
    public Bars hungerBar;
    public Bars socialBar;
    public Bars workBar;

    public DialogueManager dialogueManager;

    // Start is called before the first frame update
    void Start()
    {
        //Health
        currentHealth = minHealth;
        healthBar.SetMinHealth(minHealth);
        //Hunger
        currentHunger = minHunger;
        hungerBar.SetMinHunger(minHunger);
        //Social
        currentSocial = minSocial;
        socialBar.SetMinSocial(minSocial);
        //Work
        currentWork = minWork;
        workBar.SetMinWork(minWork);
    }

    // Update is called once per frame
    void Update()
    {
        //This will increase the bars

        //+1
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Recover(1);
        }
        // //+3
        //   if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     Recover(3);
        // }
        // //+5
        //   if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     Recover(5);
        // }
        // //+8
        //   if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     Recover(8);
        // }
        
    //    if (currentHealth == maxHealth)
    //    {
    //     Debug.Log("Yay, You maxed out Health");
    //    }
    }
 
    void Recover(int heal)
    {
        //health
        currentHealth += heal;
        healthBar.SetHealth(currentHealth);
        //hunger
        currentHunger += heal;
        hungerBar.SetHealth(currentHunger);
        //social
        currentSocial += heal;
        socialBar.SetHealth(currentSocial);
        //Work
        currentWork += heal;
        workBar.SetHealth(currentWork);
    }
}
