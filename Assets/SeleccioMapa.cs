using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeleccioMapa : MonoBehaviour
{
    public void CambiarMapa(int numeroMapa)
    {
        SceneManager.LoadScene(numeroMapa);
    }
}
