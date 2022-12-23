using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Snek_Movement : MonoBehaviour
{
    public GameObject Snek;
    [SerializeField]
    private float velocityOfSnek = 13;
    [SerializeField]
    private float rotationSpeed = 100;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        Vector2 movementDirection = new Vector2(HorizontalInput,0);
        if (movementDirection != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            Snek.transform.rotation = Quaternion.RotateTowards(Snek.transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            Debug.Log(Snek.transform.rotation);
        }
        else
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward,new Vector2(0,0));
            Snek.transform.rotation = Quaternion.RotateTowards(Snek.transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
