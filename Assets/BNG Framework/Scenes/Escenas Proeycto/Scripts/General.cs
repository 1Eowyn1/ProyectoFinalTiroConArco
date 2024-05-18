using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class General : MonoBehaviour
{
    public int scoreTotal = 0;
    public TextMeshPro scoreText;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") || OVRInput.GetDown(OVRInput.Button.One))
        {
            SceneManager.LoadScene("Inicio");
        }
    }

    public void AddScore(int score)
    {
        scoreTotal += score;
        scoreText.text = "Score" + scoreTotal;
    }
}
