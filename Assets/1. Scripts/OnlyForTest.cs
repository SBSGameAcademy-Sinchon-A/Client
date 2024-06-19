using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyForTest : MonoBehaviour
{
    public GameObject testObject;

    void Start()
    {
    }

    void Update()
    {
        // Scene Management Test
        if (Input.GetKeyDown(KeyCode.F9))
        {
            testObject.GetComponent<SceneManagement>().LoadScene(SceneManagement.SceneList.SampleScene);
        }
        else if (Input.GetKeyDown(KeyCode.F10))
        {
            testObject.GetComponent<SceneManagement>().LoadScene(SceneManagement.SceneList.TestScene1);
        }
        else if (Input.GetKeyDown(KeyCode.F11))
        {
            testObject.GetComponent<SceneManagement>().LoadScene(SceneManagement.SceneList.TestScene2);
        }
    }
}
