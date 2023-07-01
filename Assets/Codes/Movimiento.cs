using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    Animator animacion;
    bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animacion = gameObject.GetComponent<Animator>();

        if (Input.GetKey("right"))
        {
            animacion.SetBool("correr", true);
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + .1f, gameObject.transform.position.y, gameObject.transform.position.z);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0); //voltear personaje visto en clase
        }
        else if(Input.GetKey("left"))
        {
            animacion.SetBool("correr", true);
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - .1f, gameObject.transform.position.y, gameObject.transform.position.z);
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0); // voltear personaje visto en clase
        }
/*        else if(Input.GetKey("up"))
        {
            animacion.SetBool("brincar", true);
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + .1f, gameObject.transform.position.z);
        }*/
        else
        {
            animacion.SetBool("brincar", false);
            animacion.SetBool("correr", false);
        }
        ManageJump();
    }

    void ManageJump()
    {
        if (gameObject.transform.position.y <= 15)
        {
            canJump = true;
        }

        if (Input.GetKey("up") && canJump && gameObject.transform.position.y < 15)
        {
            animacion.SetBool("brincar", true);
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + .15f, gameObject.transform.position.z);
        } 
        else
        {
            canJump = false;
            
            if (gameObject.transform.position.y > 15) // si esta en el aire que caiga
            {
                gameObject.transform.Translate(0, -50f * Time.deltaTime, 0);
            }
        }
    }
}
