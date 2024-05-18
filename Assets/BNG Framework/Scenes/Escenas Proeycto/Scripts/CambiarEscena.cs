using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
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
}
