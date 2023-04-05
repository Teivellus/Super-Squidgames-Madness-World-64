using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TriggerDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider collision)
    {
        //Easy!
        if (collision.gameObject.name == "Player") {
            Debug.Log("Wowsers");
        } else {
            Debug.Log("You are not the player, get out");
            collision.gameObject.GetComponent<Rigidbody>().AddForce(collision.gameObject.transform.up * 100);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        
    }
}
