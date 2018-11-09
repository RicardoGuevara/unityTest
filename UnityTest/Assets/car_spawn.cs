using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_spawn : MonoBehaviour {

    public GameObject auto1,
                      auto2;
    public Transform origen;    // base pos / rotation
    
    // Use this for initialization
    void Start () {
        //Invoke("create_auto", 3f);
    }

    void Update () {
        StartCoroutine(delay_and_create(gen_random_delay()));
    }

    private bool isCoroutineExecuting = false;

    IEnumerator delay_and_create(float time)
    {
        if (isCoroutineExecuting)
            yield break;

        isCoroutineExecuting = true;

        yield return new WaitForSeconds(time);

        //gen_trafic();
        Instantiate(auto1, origen.position, origen.rotation);

        isCoroutineExecuting = false;
    }

    float gen_random_delay()
    {
        return Random.Range(0.5f,5f);
    }

    void gen_trafic()
    {
        int model = Random.Range(1, 3);

        switch (model)
        {
            case 1:
                Instantiate(auto1, origen.position, origen.rotation);
                break;
            case 2:
                Instantiate(auto2, origen.position, origen.rotation);
                break;
        }
    }

}
