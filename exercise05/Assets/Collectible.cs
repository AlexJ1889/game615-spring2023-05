using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Collectible : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject particleEffect;
    int score; 
    //public var destroyDelay = 3.0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            score += 1;
            SetScoreText(); 
            Instantiate(particleEffect, other.gameObject.transform.position, other.gameObject.transform.rotation);
       
            Destroy(other.gameObject, 0.25f);
            DestroyParticles();
        }
    }

    private void DestroyParticles()
    {

        Destroy(particleEffect);
    }

    void SetScoreText()
    {
        scoreText.text = "Brushes: " + score;
    }
}