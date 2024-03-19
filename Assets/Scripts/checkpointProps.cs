using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class checkpointProps : MonoBehaviour
{
    // Start is called before the first frame update
    public int indice;
    public string pregunta;
    public GameObject panelPregunta;
    public Text contenedorPregunta;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider c){
        if (c.gameObject.tag == "Player"){
            pregunta = GameObject.Find("GameManager").GetComponent<GameManager>().misDatos.preguntas[indice];
            panelPregunta.SetActive(true);
            contenedorPregunta.text = pregunta;
            this.GetComponent<AudioSource>().Play();
        }
    }
}
