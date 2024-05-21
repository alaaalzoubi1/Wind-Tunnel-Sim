using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class NewBehaviourScript : MonoBehaviour
{
    private bool isRotate = false;
    [SerializeField] private int rotationSpeed = 10;
    [SerializeField] private AudioSource audioSource; 
    [SerializeField] private AudioClip audioClip;

    void Start()
    {
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        audioSource.clip = audioClip; 
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.M))
        {
            transform.Rotate(rotationSpeed , 0, 0);
            isRotate = true;
            
                audioSource.clip = audioClip; 
                audioSource.Play();           
            
        }

        if (isRotate == true)
        {
            transform.Rotate(rotationSpeed , 0,0);
        }
        if (Input.GetKey(KeyCode.N))
        {
            isRotate = false;
            audioSource.Stop();
        }
    }
}
