using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadStartMenu()
    { SceneManager.LoadScene(0); }

    public void LoadMainGame()
    { 
        SceneManager.LoadScene("Gameplay");
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGameOver()
    { StartCoroutine(GameOver()); }
       
    public void QuitGame()
    { Application.Quit(); }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Game Over");
    }

}
