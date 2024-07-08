using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 starPos;
    private float repeatWidth;
    void Start() //inicializamos las variables
    {
        starPos = transform.position; //Aquí decimos que starPos es igual a el valor del componente "transform" equivalente a la posición. y almacenamos esa posición inicial
        repeatWidth = GetComponent<BoxCollider>().size.x/2; // Aquí decimos que repeatWidth es igual el tamaño del del componente BoxCollider en X y dividirlo en 2, para hallar la mitad para saber cuándo reiniciar la posición

    }

    // Update is called once per frame
    void Update()
    {
        // Si la posición actual del objeto es menor que la posición inicial menos la mitad del ancho,
        // significa que el objeto se ha desplazado completamente fuera de la vista (o del área deseada),
        // por lo que lo reiniciamos a su posición inicial para crear un efecto de repetición.
        if(transform.position.x < starPos.x - repeatWidth)
        {
            transform.position=starPos; // Reiniciamos la posición del objeto a su posición inicial
        }
    }
}
