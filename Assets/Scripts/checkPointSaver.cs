using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkPointSaver : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 lastCheckpoint;

    void Start()
    {
        lastCheckpoint = this.transform.position;
    }
        // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider c){
        Debug.Log(c.name);
        if (c.gameObject.tag == "checkPoint"){
            Debug.Log("CheckPoint!!");
            lastCheckpoint = this.transform.position;
            confirmar();
        }
        if (c.gameObject.tag == "trampa"){
            Debug.Log("Desaparece!!");
            this.GetComponent<CharacterController>().enabled=false;

            this.gameObject.transform.position = lastCheckpoint;
            this.GetComponent<CharacterController>().enabled=true;
        }
        if (c.gameObject.tag == "portal"){
            Debug.Log("Portal!!");
            SceneManager.LoadScene("Scene02b", LoadSceneMode.Additive);
        }
    }

    public void confirmar(){
        GameObject.Find("GameManager").GetComponent<GameManager>().actualizarUbicacion(lastCheckpoint);
    }

}
