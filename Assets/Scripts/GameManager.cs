using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int buildSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GameSceneBuildIndex()
    {
        buildSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    public void ReLoad()
    {
        GameSceneBuildIndex();
        SceneManager.LoadScene(buildSceneIndex);
    }
    public void NextLevel()
    {
        buildSceneIndex++;
        SceneManager.LoadScene(buildSceneIndex);
    }
}
