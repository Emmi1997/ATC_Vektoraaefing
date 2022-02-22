using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AirPlane_Collission : MonoBehaviour
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

       /* if (collider.transform.CompareTag("Crash"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
       */
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        
            this.gameObject.GetComponent<SpriteRenderer>().sprite = normal;
        
    }

}
