using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    float score;
    public TextMeshProUGUI scoreTMP;
    public GameObject balloonExplosion;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                if(hit.transform.gameObject.tag == "Balloon")
                {
                    score++;
                    scoreTMP.text = "Score: " + score;
                    Instantiate(balloonExplosion, hit.transform.position, Quaternion.identity);
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}
