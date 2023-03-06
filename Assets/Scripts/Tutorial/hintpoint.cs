using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hintpoint : MonoBehaviour
{
    public static hintpoint instance;
    public bool check = false;

    void Awake()
    {
        hintpoint.instance = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            check = true;
        }
    }
}
