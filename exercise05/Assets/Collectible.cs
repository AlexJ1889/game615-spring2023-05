using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Collectible : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject particleEffect;
    public GameObject CanvasObj;

    static int score;
    //public var destroyDelay = 3.0;

    // Start is called before the first frame update
    void Start()
    {
        CanvasObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            score++;
            SetScoreText();
            Instantiate(particleEffect, this.gameObject.transform.position, this.gameObject.transform.rotation);

            Destroy(this.gameObject);

        }

        if (score >= 4)
        {
            CanvasObj.SetActive(true);
            Instantiate(CanvasObj);
        }
    }


    void SetScoreText()
    {
        scoreText.text = "Brushes: " + score;
    }
}