using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
   [Header("Cue")]
   [SerializeField] private GameObject cue;

   [Header("Ink JSON")]
   [SerializeField] private TextAsset inkJSON;

   private bool playerInRange;

   private void Awake() 
   {
    playerInRange = false;
    cue.SetActive(false); 
   }

  private void Update() 
   {
    if (playerInRange)
    {
        cue.SetActive(true);
        if (Input.GetKey(KeyCode.F)) //(InputManager.GetInstance().GetInteractPressed())
        {
            Debug.Log(inkJSON.text);
        }
    }
    else
    {
        cue.SetActive(false);
    }
   }

   private void OnTriggerEnter2D(Collider2D collider)
   {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
   }

   private void OnTriggerExit2D(Collider2D collider) 
   {
     if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
   }
}
