using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameManager : MonoBehaviour
{
    public DataJSON misDatos;
    public Text textoTitulo;
    public Text textoPlayer;
    public GameObject panelUI;
    public InputField textoJugador;
    public GameObject jugador;
    // Start is called before the first frame update
    void Start()
    {
        string filePat = Application.streamingAssetsPath + "/" + "data1.json";

        if (File.Exists(filePat))
        {
            string s = File.ReadAllText(filePat);
            misDatos = JsonUtility.FromJson<DataJSON>(s);
            Debug.Log(s);
            Debug.Log(misDatos);
            Debug.Log(misDatos.nombre_juego);
            /*misDatos.preguntas.Add("Nueva pregunta 1");
            misDatos.preguntas.Add("Nueva pregunta 2");
            misDatos.preguntas.Add("Nueva pregunta 3");
            misDatos.preguntas.Add("Nueva pregunta 4");*/

            s = JsonUtility.ToJson(misDatos, true);
            Debug.Log(s);
            File.WriteAllText(filePat, s);
        }
        cargaDatos();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)){
            panelUI.SetActive(true);
        }
    }

    void cargaDatos(){
        //GameObject.Find("t_titulo").GetComponent<Text>().text = misDatos.nombre_juego;
        textoTitulo.text = misDatos.nombre_juego;
        textoPlayer.text = misDatos.nombre_jugador;
        jugador.transform.position = misDatos.playerLocation;
    }
    public void guardaDatos(){
        misDatos.nombre_jugador = textoJugador.text;
        string filePat = Application.streamingAssetsPath + "/" + "data1.json";
        string s = JsonUtility.ToJson(misDatos, true);
        File.WriteAllText(filePat, s);
    }

    public void actualizarUbicacion(Vector3 newLocation){
        misDatos.playerLocation = newLocation;
    }

    public void guardaArchivo(){
        string filePat = Application.streamingAssetsPath + "/" + "data1.json";
        string s = JsonUtility.ToJson(misDatos, true);
        File.WriteAllText(filePat, s);
    }
}
