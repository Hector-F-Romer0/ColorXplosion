using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEscena : MonoBehaviour
{
    public GameObject bombaPrefab;
    public GameObject bombaGenerada;
    public int tiempoSpawn;

    // Start is called before the first frame update
    void Start()
    {
        tiempoSpawn = 0;
        InvokeRepeating("generarBombas", 0f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
        //generarBombas();
    }

    public void generarBombas()
    {
        Debug.Log(tiempoSpawn);
        bombaGenerada = Instantiate(bombaPrefab);
    }
}
