using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour
{
    private MomentumMovement momv1, momv2;

    private GameObject obg1, obg2;
    public GameObject cam1, cam2;

    
    // Start is called before the first frame update
    void Start()
    {
        obg1 = GameObject.FindGameObjectWithTag("Player");
        obg2 = GameObject.FindGameObjectWithTag("Player2");
        momv1 = obg1.GetComponent<MomentumMovement>();
        momv2 = obg2.GetComponent<MomentumMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            momv1.enabled = false;
            cam1.SetActive(false);
            momv2.enabled = true;
            cam2.SetActive(true);

        }

        if (Input.GetKey(KeyCode.Backspace))
        {
            momv2.enabled = false;
            cam2.SetActive(false);
            momv1.enabled = true;
            cam1.SetActive(true);

        }
    }
}
