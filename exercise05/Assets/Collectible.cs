using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Collectible : MonoBehaviour
{
    float score;
    public TextMeshProUGUI scoreText;
    public GameObject particleEffect;
    public AudioSource munch;
    //public var destroyDelay = 3.0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Brushes: " + score;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("collectible"))
        {
            score += 1;
            Instantiate(particleEffect, other.gameObject.transform.position, other.gameObject.transform.rotation);
            munch.Play();
            Destroy(other.gameObject);
            //DestroyParticles();
        }
    }

    //function DestroyParticles()
    //{
    //    yield WaitForSeconds(destroyDelay);
    //    Destroy(particleEffect)
    //}
}