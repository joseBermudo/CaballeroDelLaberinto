using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScr : MonoBehaviour
{

   public static Estados estado;
   public GameObject menuPausa;
   
   void Start(){
    estado = Estados.Juego;
    
   }

   void Update(){
    if(estado == Estados.Juego){
        menuPausa.SetActive(false);
        Cursor.visible = false; 
       Cursor.lockState = CursorLockMode.Locked;  
    }else if(estado == Estados.Pausa){
         Cursor.visible = true; 
         Cursor.lockState = CursorLockMode.None;   
        menuPausa.SetActive(true);
    }else if(estado == Estados.Victoria){
     Cursor.visible = true; 
     Cursor.lockState = CursorLockMode.None; 
     SceneManager.LoadScene("Victoria");
    }else if(estado == Estados.Derrota){
     Cursor.visible = true; 
     Cursor.lockState = CursorLockMode.None; 
     SceneManager.LoadScene("Derrota");
    }
   } 
  

   public static void SetJuego(){
        estado = Estados.Juego;
   }

   public static void SetPausa(){
        estado = Estados.Pausa;
   }

   public static void SetVictoria(){
        estado = Estados.Victoria;
   }

   public static void SetDerrota(){
        estado = Estados.Derrota;
   }

   public void GotToMenuPrincipal(){
     SceneManager.LoadScene("MenuPriOp");
   }

   public enum Estados{
        Juego,
        Pausa,
        Victoria,
        Derrota
   }
}
