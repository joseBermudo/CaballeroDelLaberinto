using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mapas_controller : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeScene(string sceneName)
{
    SceneManager.LoadScene(sceneName);
}
}
