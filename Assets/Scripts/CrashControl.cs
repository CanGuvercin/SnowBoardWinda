using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashControl : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("NextScene",2f);
        }

    }

    public void NextScene()
    {
        SceneManager.LoadScene(0);
    }

}
