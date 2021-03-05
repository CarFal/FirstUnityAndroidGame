using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//With this namespace you can access the SceneManager
using UnityEngine.UI;
//Allows us to access the UI Elements

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score;

    public Text scoreText;
    public GameObject gameStartUI;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart() {
        SceneManager.LoadScene("Game");
    }

    public void ScoreUp() {
        score++;
        //increase the value of score by 1
        scoreText.text = score.ToString();
    }

    public void GameStart() {
        gameStartUI.SetActive(false);
        scoreText.gameObject.SetActive(true);
    }
}
