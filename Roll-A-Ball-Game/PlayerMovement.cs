using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
      private Rigidbody rb;
      private int score;
      private float movementX;
      private float movementY;


    public float speed = 0;


    public TextMeshProUGUI countText;


    public GameObject winTextObject;

    void Start()
    {

        rb = GetComponent<Rigidbody>();


        score = 0;


        SetCountText();

        winTextObject.SetActive(false);
    }


    void OnMove(InputValue movementValue)
    {
      
        Vector2 movementVector = movementValue.Get<Vector2>();

        
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

  
    private void FixedUpdate()
    {
        
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

    
        rb.AddForce(movement * speed);
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("PickUp"))
        {

            other.gameObject.SetActive(false);


            score = score + 1;

            SetCountText();
        }
    }

  
    void SetCountText()
    {
    
        countText.text = "Score: " + score.ToString();

        if (score >= 20)
        {
   
            winTextObject.SetActive(true);
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
          
            Destroy(gameObject);
            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";
        }
    }
}
