using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMaterial_menu : MonoBehaviour
{
    public bool changeMaterialMenu_isActive;
    public GameObject changeMaterialMenu;

    public GameObject pauseGameMenu;
    public bool pauseGame_isActive = false;

    public Material material1;
    public Material material2;
    public Material material3;
    public Material material4;
    public Material material5;
    public void Resume()
    {
        changeMaterialMenu.SetActive(false);
        pauseGameMenu.SetActive(false);

        Time.timeScale = 1f;
        changeMaterialMenu_isActive = false;
    }
    public void Open_changeMaterialMenu()
    {
        changeMaterialMenu.SetActive(true);
        pauseGameMenu.SetActive(false);
        Time.timeScale = 0f;
        changeMaterialMenu_isActive = true;
    }

    public GameObject sphere;
    public void OnClick_change_material1()
    {
        sphere.GetComponent<MeshRenderer>().material = material1;
    }

    public void OnClick_change_material2()
    {
        sphere.GetComponent<MeshRenderer>().material = material2;
    }

    public void OnClick_change_material3()
    {
        sphere.GetComponent<MeshRenderer>().material = material3;
    }

    public void OnClick_change_material4()
    {
        sphere.GetComponent<MeshRenderer>().material = material4;
    }

    public void OnClick_change_material5()
    {
        sphere.GetComponent<MeshRenderer>().material = material5;
    }
}
