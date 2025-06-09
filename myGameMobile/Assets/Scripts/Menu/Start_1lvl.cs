using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Start_1lvl : MonoBehaviour
{
    public Button level1_button;
    public Button level2_button;
    public Button level3_button;
    public Button level4_button;
    public Button level5_button;
    int level_complete;

    void Start()
    {
        level_complete = PlayerPrefs.GetInt("LevelComplete");
        level2_button.interactable = false;
        level3_button.interactable = false;
        level4_button.interactable = false;
        level5_button.interactable = false;

        switch (level_complete)
        {
            case 1:
                {
                    level2_button.interactable = true;
                    break;
                }
            case 2:
                {
                    level2_button.interactable = true;
                    level3_button.interactable = true;
                    break;
                }
            case 3:
                {
                    level2_button.interactable = true;
                    level3_button.interactable = true;
                    level4_button.interactable = true;
                    break;
                }
            case 4:
                {
                    level2_button.interactable = true;
                    level3_button.interactable = true;
                    level4_button.interactable = true;
                    level5_button.interactable = true;
                    break;
                }
        }
    }

    public void Loadto(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Reset()
    {
        level2_button.interactable = false;
        level3_button.interactable = false;
        level4_button.interactable = false;
        level5_button.interactable = false;
        PlayerPrefs.DeleteAll();
    }

    public void onClickStart()
    {
        SceneManager.LoadScene("Lvl1", LoadSceneMode.Single);
    }
}
