using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainSceneScript : MainScript
{
    private void Awake()
    {
        _dropdown = GetComponent<Dropdown>();
    }
    public override void Dropdown(Dropdown dropdown)
    {

        if (dropdown.value == 1)
        {
            SceneManager.LoadScene("Earth", LoadSceneMode.Single);
        }
    }
}
