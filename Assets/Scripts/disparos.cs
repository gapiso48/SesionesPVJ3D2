using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparos : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject arma;
    public GameObject cargador;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)){
            GameObject a = Instantiate(arma,cargador.transform.position, cargador.transform.rotation,cargador.transform);
            a.SetActive(true);
        }
    }
}
