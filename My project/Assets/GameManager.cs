using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int TilesCount;
    private int TotalTiles;
    public GameObject LevelComplete;
    public GameObject RetryScreen;
    private string[] scenePaths;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        TilesCount = 0;
        TotalTiles = 0;
        scenePaths = new string[4] { "Level1", "Level2", "Level3", "Level4"};
        i = 0;
    }

    public void SetTotalTiles(int Tiles)
    {
        TotalTiles = Tiles;
    }

    public void IncrementTileCount()
    {
        if (TilesCount < TotalTiles)
        {
            TilesCount++;
            print(TilesCount.ToString() + "Total left: " + TotalTiles.ToString());

            if (TilesCount == TotalTiles)
            {
                NextLevel();
               // Invoke("EndGame", 3.0f);
            }
        }

    }

    public void NextLevel()
    {
        //Invoke("LevelCompleteScreen", 2.0f);
        LevelCompleteScreen();
        Invoke("nextLevel", 3.0f);
    }

    private void LevelCompleteScreen()
    {
        LevelComplete.SetActive(true);

    }

    private void nextLevel()
    {
        if (SceneManager.GetSceneByBuildIndex(0) == SceneManager.GetActiveScene())
        {
            i = 1;
        }

        if (SceneManager.GetSceneByBuildIndex(1) == SceneManager.GetActiveScene())
        {
            i = 2;
        }

        if (SceneManager.GetSceneByBuildIndex(2) == SceneManager.GetActiveScene())
        {
            i = 3;
        }

        if (SceneManager.GetSceneByBuildIndex(3) == SceneManager.GetActiveScene())
        {
            Invoke("EndGame", 3.0f);
        }

        print("entered game manager");
        print(scenePaths[i]);
        SceneManager.LoadScene(scenePaths[i], LoadSceneMode.Single);
    }

    private void EndGame()
    {
        print("EndGame");
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }

    public void Retry()
    {
        print("Restarted level");
        Retry_Screen();

    }
    private void Retry_Screen()
    {
        RetryScreen.SetActive(true);
        Invoke("RestartLevel", 3.0f);
    }


    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
