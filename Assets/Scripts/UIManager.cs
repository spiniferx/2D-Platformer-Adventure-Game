using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Canvas PauseMenu;
    public static int score;
    public Text scoreText;
    public static AudioSource coinSound;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        PauseMenu.enabled = false;
        coinSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + score;
    }

   

    public void pauseMenu()
    {
        Time.timeScale = 0;
        PauseMenu.enabled = true;
    }

    public void resume()
    {
        Time.timeScale = 1;
        PauseMenu.enabled = false;
    }
    public void restart()
    {
        Time.timeScale = 1;
        GameManager.lifeCount = 3;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void backToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("menu");
    }
}
