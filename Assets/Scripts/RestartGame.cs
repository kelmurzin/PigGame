﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartGame : MonoBehaviour
{
    public void RestartScene() => SceneManager.LoadScene(0, LoadSceneMode.Single);
}
