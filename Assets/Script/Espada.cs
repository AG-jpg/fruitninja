using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        EspadaalMouse();
    }

    private void EspadaalMouse()
    {
        var mousePosicion = Input.mousePosition;
        mousePosicion.z = 10;

        rb.position = Camera.main.ScreenToWorldPoint(mousePosicion);
    }
}
