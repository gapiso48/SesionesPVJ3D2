using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class controlador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            this.GetComponent<Animator>().SetBool("salto",true);
        }
        if (Input.GetKeyUp(KeyCode.Space)){
            this.GetComponent<Animator>().SetBool("salto",false);
        }
    }
}
