using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

  bool gameEndScreen = false; 
  public float restartdelay = 1f;

  public GameObject completeLevelUI;

  public void CompleteLevel ()
  {

      completeLevelUI.SetActive(true);

  }

  public void EndGame()
  {
    if (gameEndScreen == false)
    {
          gameEndScreen = true;
          Debug.Log("Game Over");
          Invoke ("Restart", restartdelay);

    }
  }

  void Restart ()
  {
    SceneManager.LoadScene ("firstgamelol");
  }
}
