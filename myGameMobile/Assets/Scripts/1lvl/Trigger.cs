using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    int score = 21;
    List<GameObject> deleted_cubes = new List<GameObject>();
    public Text score_text;

    void Start()
    {
        score_text.text = "" + score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            score--;
            Destroy(other.gameObject);
            score_text.text = "" + score.ToString();
        }

        if (score < 20)
        {
            LevelController.instance.isEndGame();
        }
    }

}
