using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    public bool hasPackage = false;
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(50, 50, 50, 50);
    
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Burger" && !hasPackage)
        {
            Debug.Log("Burger collected!");
            spriteRenderer.color = hasPackageColor;
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Burger Delivered!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor; 

        }
    }
}
