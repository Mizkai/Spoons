using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnHit : MonoBehaviour
{
    AudioSource m_audioSource;     //Which AudioSource are we using, set this in the inspector on the script

    public AudioClip coinSound;

    public AudioClip heartSound;

    void Start() 
    {
        if (m_audioSource ==null)
            {
                    m_audioSource = GetComponent<AudioSource>();
            }
    }
    
    
    void TryPlaySound(GameObject collidingObj)
    {
        // if (collidingObj.tag == "Player") //is the object we collided with is a player
        // {
        //     coinSource.Play();         //play the AudioSource 
        //     Debug.Log("Played sound");
        // }

        if (collidingObj.tag == "coin")
        {
            m_audioSource.PlayOneShot(coinSound);
        }

        else if (collidingObj.tag == "heart")
        {
            m_audioSource.PlayOneShot(heartSound);
        }
    }

    #region Collision Detection
    void OnTriggerEnter(Collider other)
    {
        TryPlaySound(other.gameObject);
    }

    void OnCollisionEnter(Collision other)
    {
        TryPlaySound(other.gameObject);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        TryPlaySound(col.gameObject);
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        TryPlaySound(other.gameObject);
    }
    #endregion

}
