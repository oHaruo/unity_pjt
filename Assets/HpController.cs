using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpController : MonoBehaviour
{
    public static int lives = 3; // �ʱ� ��� ��
    public GameObject hp1;
    public GameObject hp2; 
    public GameObject hp3;


    public void LoseLife()
    {
        // ����� ���������� ���̰�, UI ������Ʈ
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
            else if(lives == 1)
            { 
                hp2.SetActive(false);
            }
            else
            {
                hp1.SetActive(false);
            }
    }


    // Start is called before the first frame update
    void Start()
    {
        hp1 = GameObject.Find("hp-image1");
        hp1 = GameObject.Find("hp-image1");
        hp1 = GameObject.Find("hp-image1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
