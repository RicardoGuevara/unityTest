using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
    public GameObject a;
    public GameObject Capsula;

    public void Boton() {
        a.SetActive(false);

        Vector3 temp = new Vector3(60f, 2, 0f);
        Capsula.transform.position += temp;
    }
    public void Boton2() {
        a.SetActive(false);
        Vector3 temp = new Vector3(20f, 1.65f, 118.56f);
        Capsula.transform.position += temp;
    }
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
