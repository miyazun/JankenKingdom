using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChnageScene(String name)
    {
        SceneManager.LoadScene(name);
    }

}
