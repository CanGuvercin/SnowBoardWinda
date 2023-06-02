using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      

public class FinishControl : MonoBehaviour
{
    [SerializeField] float magicNumber = 1f;
    [SerializeField] ParticleSystem finishEffect;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            Invoke("NextScene", magicNumber);
        }
        
    }
    public void NextScene()
    {
        SceneManager.LoadScene(0);
    }
    

}
