using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char2DController : MonoBehaviour
{
    public float MovementSpeed = 5;
    public float JumpForce = 20;
    public Rigidbody2D _rigidbody; //da wir rigidbody häufig brauchen, speichern wir eine referenz, wenn der Character erstellt wird start()
    void Start()
    // Start is called before the first frame update
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        //get input from out player
        var horizontalMove = Input.GetAxisRaw("Horizontal") * MovementSpeed; //Left oder A = -1, Right oder D = 1 FÜR TASTATUR/CONTROLLER INPUT
        // neuer Vector3 mit der x-Achse als input value
        //Time.fixedDeltaTime is the Time elapsed since the last time this function was called
        //so we move the same amount, independent from how often this function was called
        transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime;

        // Flip the Character
        Vector3 characterScale = transform.localScale;
        if(Input.GetAxisRaw("Horizontal") < 0){
            characterScale.x = -1;
        } else if(Input.GetAxisRaw("Horizontal") > 0){
            characterScale.x = 1;
        } else if (Input.GetAxisRaw("Vertical") < 0){   //crouch NOT FINISHED
            characterScale.y = 0.5f;
        } else if(!(Input.GetAxisRaw("Vertical") < 0)){
            characterScale.y = 1;
        }
        transform.localScale = characterScale;

        //default input system to detect Jump Input
        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.1f){ //y-axis Geschwindigkeit verwenden, um nur einen Sprung zuzulassen
            //"add a force in the y-axis" on the rigidbody", "The force we want to aplly is an impulse
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
        //if(Input.GetButtonDown("down")){
        //    characterScale.x = -10;
        //}
    }
}
