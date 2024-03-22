using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

[System.Serializable]
public class DataJSON : System.Object
{

    [SerializeField]
    public string nombre_juego;
    [SerializeField]
    public string nombre_jugador;
    [SerializeField]
    public int nivel;
    [SerializeField]
    public int salud;
    [SerializeField]
    public string correo;
    [SerializeField]
    public Vector3 playerLocation;
    [SerializeField]
    public List<string> preguntas;
    [SerializeField]
    public string colorPref;

    public DataJSON()
    {
    }

}