using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Collections;

public class StageControls :MonoBehaviour
{

    void start() { }

    void Update() { }

    public void PressPlay()
    {
        SceneManager.LoadScene(3);
    }
}
