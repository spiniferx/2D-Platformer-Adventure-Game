using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int lifeCount=3;
    public Canvas gameOverCanvas;
    public GameObject currentCheckpoint;
    public GameObject player;
    public GameObject[] lifeSprites;
    public GameObject particleRespawn;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.enabled = false;
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameOver()
    {
     //   Debug.Log("gameOver called");
        gameOverCanvas.enabled = true;
    }

    public void respawn()
    {
        lifeSprites[i].SetActive(false);
      //  Debug.Log("respawn called");
        player.transform.position = currentCheckpoint.transform.position;
        Instantiate(particleRespawn, player.transform.position, Quaternion.identity);
        i++;
    }
}
