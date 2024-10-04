using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public Renderer fondo; 
    public string nombreEscenaInicial;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Inicio.");
        SceneManager.LoadScene(nombreEscenaInicial);
    }

    // Update is called once per frame
    void Update()
    {
        //fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0, 0.015f) * Time.deltaTime; 
    }
    
}
