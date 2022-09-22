

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class Spoons : MonoBehaviour

{

    public int spoons = 1;

    public Image[] SpoonImages;

    // Start is called before the first frame update

    void Start()

    {

        UpdateSpoons();

    }

    void UpdateSpoons()

    {

        // turn off the image component in each 'spoonImage'

        foreach (Image spoonImage in SpoonImages)

        {

            spoonImage.enabled = false;

        }

        //Turns on a number of spoons equal to 'spoons'

        for (int i = 0; i < SpoonImages.Length; i++)

        {

            if (spoons-1 >= i)

            {

                SpoonImages[i].enabled = true;

            }

        }

    }

}

