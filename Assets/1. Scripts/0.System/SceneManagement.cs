    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public enum SceneList
    {
        SampleScene, TestScene1, TestScene2
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void LoadScene(SceneList scene)
    {
        SceneManager.LoadScene((int) scene);
    }
}
