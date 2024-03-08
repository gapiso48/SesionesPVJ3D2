using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveController : MonoBehaviour
{
    public Vector3 vectorRotacion;
    public float speed;
// Start is called before the first frame update
    void Start()
    {
        Debug.Log("Posici�n de " + this.name + " es " + this.transform.position);
        Debug.Log("Posici�n local de " + this.name + " es " + this.transform.localPosition);
        Debug.Log("Rotaci�n de " + this.name + " es " + this.transform.eulerAngles);
        vectorRotacion = this.transform.localEulerAngles;
        speed=30f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
            vectorRotacion = new Vector3(0,speed*Time.deltaTime,0);
            //this.transform.localEulerAngles =vectorRotacion;
            this.transform.Rotate(vectorRotacion,Space.Self);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            vectorRotacion = - new Vector3(0,speed*Time.deltaTime,0);
            //this.transform.localEulerAngles =vectorRotacion;
            this.transform.Rotate(vectorRotacion,Space.Self);
        }
    }
}
