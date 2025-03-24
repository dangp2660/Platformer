using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScences : MonoBehaviour
{
    [SerializeField] private string name;
    public void SwitchScence()
    {
        SceneManager.LoadScene(name);   
    }
}
