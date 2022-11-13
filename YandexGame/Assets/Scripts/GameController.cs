using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject _menu;

    public void Play()
    {
       _menu.SetActive(false);
    }
}
