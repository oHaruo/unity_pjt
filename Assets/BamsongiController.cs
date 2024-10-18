using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BamsongiController : MonoBehaviour
{
    public static int lives = 3; // ÃÊ±â ¸ñ¼û ¼ö
    public GameObject hp1;
    public GameObject hp2;
    public GameObject hp3;

    public void LoseLife()
    {
        if (lives > 0)
        {
            lives--;
            UpdateLivesImages();
        }
    }

    public void UpdateLivesImages()
    {
        if (lives == 2)
        {
            hp3.SetActive(false);
        }
        else if (lives == 1)
        {
            hp2.SetActive(false);
        }
        else
        {
            hp1.SetActive(false);
        }
    }


    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "target")
        {
            GetComponent<ParticleSystem>().Play();
            Score.score += 1;
        }
        else
        {
            LoseLife();
        }
    }        


    void Start()
    {
        Application.targetFrameRate = 60;
        hp1 = GameObject.Find("hp-image1");
        hp2 = GameObject.Find("hp-image1 (1)");
        hp3 = GameObject.Find("hp-image1 (2)");
    }

    
    void Update()
    {
        
    }
}
