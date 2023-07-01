using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform juanito;
    public float separacion = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // x, y, z
        transform.position = new Vector3(juanito.position.x + separacion,
                                        juanito.position.y,
                                        transform.position.z);
    }
}
