using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{

    public static LevelController instance = null; //открываем доступ к левел контроллеру с любой части скрипта 

    int scene_index_level;
    int level_complete;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        scene_index_level = SceneManager.GetActiveScene().buildIndex;
        level_complete = PlayerPrefs.GetInt("LevelComplete");
    }

    public void isEndGame()
    {
        if(scene_index_level == 5) 
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
        else 
        {
            if (level_complete < scene_index_level)
            {
                PlayerPrefs.SetInt("LevelComplete", scene_index_level);
            }
            Invoke("NextLevel", 1f);
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(scene_index_level + 1);
    }

    void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
