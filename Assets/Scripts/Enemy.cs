using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{



    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player" && GameManager.lifeCount >= 1)
        {
            GameManager.lifeCount--;
            Debug.Log("Player Collided");
            //add waiting function

            //respawn at checkpoint
            gm.respawn();

        }
        else if(collision.gameObject.tag=="Player" && GameManager.lifeCount==0)
        {
            //show gameover Canva
            gm.gameOver();
        }
    }
}
