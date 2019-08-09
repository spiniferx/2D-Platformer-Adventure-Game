using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    // Start is called before the first frame update

    private GameManager gm1;
    void Start()
    {
        gm1 = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           // Debug.Log("checkpoint updated");
            gm1.currentCheckpoint.transform.position = gameObject.transform.position;
        }
    }
}
