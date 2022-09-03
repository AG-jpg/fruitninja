using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruta : MonoBehaviour
{

    public GameObject prefabFrutaCortada;

    public void CrearFrutaCortada()
    {
        GameObject inst = (GameObject)Instantiate(prefabFrutaCortada, transform.position, transform.rotation);

        Rigidbody[] rbsCortados = inst.transform.GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody r in rbsCortados)
        {
            r.transform.rotation = Random.rotation;
            r.AddExplosionForce(Random.Range(500,1000), transform.position, 5f);
        }

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CrearFrutaCortada();
        }
    }
}
