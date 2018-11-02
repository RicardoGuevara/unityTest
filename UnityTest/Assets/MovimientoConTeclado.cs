using UnityEngine;
using System.Collections;

public class MovimientoConTeclado : MonoBehaviour
{
    public int m_velocidad;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))

            transform.Translate(Time.deltaTime * m_velocidad, 0, 0);

        if (Input.GetKey(KeyCode.A))

            transform.Translate(Time.deltaTime * 0, 0, 0.1f);

        if (Input.GetKey(KeyCode.S))

            transform.Translate(-Time.deltaTime * m_velocidad, 0, 0);

        if (Input.GetKey(KeyCode.D))

            transform.Translate(Time.deltaTime, 0, -0.1f);

    }
}

