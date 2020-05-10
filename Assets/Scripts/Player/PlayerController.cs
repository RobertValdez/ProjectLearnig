using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool _canJump;

    // Start is called before the first frame update
    void Start() {
       
    }

    // Update is called once per frame
    void Update() {

        float moveX = Input.GetAxis("Horizontal");
 //    float moveY = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(moveX,0);
        if (move.x < 0f)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce((move * 105f) * Time.deltaTime);
            gameObject.GetComponent<Animator>().SetBool("Moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
         if (move.x > 0f)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce((move * 105f) * Time.deltaTime);
            gameObject.GetComponent<Animator>().SetBool("Moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
           
        } 

        Debug.Log(move);

       /*  if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-100 * Time.deltaTime,0));
            
            //Activa la animacion del Movimiento
            gameObject.GetComponent<Animator>().SetBool("Moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            //gameObject.transform.Translate(-3f * Time.deltaTime, 0, 0);
        } */

        /* if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(100 * Time.deltaTime, 0));

            //Activa la animacion del Movimiento
            gameObject.GetComponent<Animator>().SetBool("Moving", true);

            //Cambia la postura en la que se dirige el Personaje o Objeto
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            /*gameObject.transform.Translate(3f * Time.deltaTime, 0, 0);*/
      //  } /

        if (!Input.GetKey("left") && !Input.GetKey("right"))
        {
            //Desactiva la animacion del Movimiento
            gameObject.GetComponent<Animator>().SetBool("Moving", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && _canJump == true)
        {
            _canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 30f));
            //gameObject.transform.Translate(3f * Time.deltaTime, 0, 0);
        }
       // gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.20f * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.transform.tag == "Ground")
        {
            //Solo si el Personaje Toca (colisiona) con la tierra, podrá volver a saltar
            _canJump = true; //Puede Saltar
        }else if (collision.transform.tag == "GroundWin")
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 30f));
            CamFollow.CameraScriptActive = false;
        }
    }
}
