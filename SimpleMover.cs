using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMover : MonoBehaviour
{
    [SerializeField] private Transform Point1;
    [SerializeField] private Transform Point2;
    [SerializeField] private float Speed = 10f;

    private bool goingToPoint1 = false;

    // Start is called before the first frame update
    void Start()
    {
        if (Point1 == null || Point2 == null)
        {
            Debug.Log($"You forgot to provide moving points for {gameObject.name}");
            Application.Quit();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!goingToPoint1)
        {
            transform.position = Vector3.MoveTowards(transform.position, Point2.position, Speed * Time.deltaTime);
            if (transform.position == Point2.position)
            {
                goingToPoint1 = true;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, Point1.position, Speed * Time.deltaTime);
            if (transform.position == Point1.position)
            {
                goingToPoint1 = false;
            }
        }

    }
}