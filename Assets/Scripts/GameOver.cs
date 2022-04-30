using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public Text secondsSurvivedUI;
    public GameObject gameOverImage;
    void Start()
    {
        FindObjectOfType<Player>().OnPlayerDeath += OnGameOver;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void starNewScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void OnGameOver()
    {
        secondsSurvivedUI.text = "you survived: " + Mathf.Round( Time.timeSinceLevelLoad)+" seconds";
        secondsSurvivedUI.gameObject.SetActive(true);
        gameOverImage.SetActive(true);
        Invoke("starNewScene", 2);
    }
}
