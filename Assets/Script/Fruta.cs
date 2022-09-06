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

        Destroy(inst.gameObject, 5);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Espada e = collision.GetComponent<Espada>();

        if(!e)
        {
            return;
        }
        else

        CrearFrutaCortada();
    }
}
