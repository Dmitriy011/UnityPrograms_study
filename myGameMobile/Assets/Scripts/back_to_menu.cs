using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_to_menu : MonoBehaviour
{
    public void onClickStart()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
