using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    //Menus
    public GameObject menuPrincipal;
    public GameObject menuOpciones;

    // Start is called before the first frame update
    void Start()
    {
        mostrarMenuPrincipal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mostrarMenuPrincipal()
    {
        //Menus desactivados
        menuPrincipal.SetActive(true);

        //Menu Activado
        menuOpciones.SetActive(false);
    }

    public void mostrarMenuOpciones()
    {
        //Menus desactivados
        menuPrincipal.SetActive(false);

        //Menu Activado
        menuOpciones.SetActive(true);
    }


    public void ChangeScene(string sceneName)
{
    SceneManager.LoadScene(sceneName);
}

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }


}
