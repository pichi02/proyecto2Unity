using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
