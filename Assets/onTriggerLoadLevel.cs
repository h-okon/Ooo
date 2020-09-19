using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class onTriggerLoadLevel : MonoBehaviour
{
    [SerializeField] private string newLevel;

    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("balal");
        if(other.CompareTag("kulka"))
        {
            SceneManager.LoadScene(newLevel);
        }
    }

}