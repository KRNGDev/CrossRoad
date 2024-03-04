using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float desplazamiento = 0.1f;
    private int intervalo = 10;
    private float movimietos = 0f;
    private bool isMoving = false;
    public GameObject explosion;
    public GameObject jugadorAplastado;
    public Transform posicionPlayer;
    public GameObject botonreset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving && Input.GetKeyDown(KeyCode.RightArrow))
        {
            StartCoroutine(Movimiento("derecha"));

        }
        if (!isMoving && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartCoroutine(Movimiento("izquierda"));
        }
        if (!isMoving && Input.GetKeyDown(KeyCode.UpArrow))
        {
            StartCoroutine(Movimiento("adelante"));
        }
        if (!isMoving && Input.GetKeyDown(KeyCode.DownArrow))
        {
            StartCoroutine(Movimiento("atras"));
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        Instantiate(jugadorAplastado, posicionPlayer.position, posicionPlayer.rotation);
        Instantiate(explosion, posicionPlayer.position, posicionPlayer.rotation);
        botonreset.SetActive(true);

    }

    IEnumerator Movimiento(string direccion)
    {

        isMoving = true;
        while (movimietos < intervalo)
        {
            switch (direccion)
            {
                case "derecha":
                    transform.Translate(Vector3.right * desplazamiento);
                    //movimietos-=0.05f;
                    break;
                case "izquierda":
                    transform.Translate(Vector3.left * desplazamiento);
                    //movimietos+=0.1f;
                    break;
                case "adelante":
                    transform.Translate(Vector3.forward * desplazamiento);
                    break;
                case "atras":
                    transform.Translate(Vector3.back * desplazamiento);
                    break;
                default:
                    Debug.LogError("Dirección de movimiento no reconocida.");
                    break;
            }
            movimietos += 1;


            yield return null;
        }
        movimietos = 0f;
        isMoving = false;
    }
}
