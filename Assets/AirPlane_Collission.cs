using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlane_Collission_yellow : MonoBehaviour
{
    public Sprite normal;
    public Sprite conflict;
    public Sprite danger;
    public SpriteRenderer render;


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.CompareTag("AirPlane"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = conflict;
        }

        if (collider.transform.CompareTag("DangerZone"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = danger;
        }

    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        
            this.gameObject.GetComponent<SpriteRenderer>().sprite = normal;
        
    }

}
