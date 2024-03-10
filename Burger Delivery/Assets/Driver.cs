using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float speedBoost = 20f;
    [SerializeField] float speedBump = 5f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
   void OnCollisionEnter2D(Collision2D collision)
    {
            moveSpeed = speedBump;
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Booster")
        {
            moveSpeed = speedBoost;
        }

    }
}
