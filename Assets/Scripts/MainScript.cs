using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;
[RequireComponent(typeof(Dropdown))]

public abstract class MainScript : MonoBehaviour
{
   
    public Dropdown _dropdown;
    public abstract void Dropdown(Dropdown dropdown);
   

}
