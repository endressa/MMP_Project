using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingBlock : MonoBehaviour
{
    public bool visible;
    private Vector3 myPosition;
    public GameObject myCharacter;
    void Start()
    {
        myPosition = transform.position;    //save the position of the DisappearingBlock
        if (visible)
            {
            gameObject.transform.SetPositionAndRotation(new Vector3(1000, 1000, 1000), new Quaternion());   //just tp it far away lol
            Debug.Log("bye");
            visible = !visible;
            }else{
                transform.position = myPosition;    //set the position to the saved Position
                visible = !visible;
                Debug.Log("hey");
            }
        myCharacter = GameObject.Find("Char1");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Mathf.Abs(myCharacter.GetComponent<Rigidbody2D>().velocity.y) < 0.1f){
            Debug.Log("True");
        } else {
            Debug.Log("False");
        }
        //Debug.Log(Mathf.Abs(myCharacter.GetComponent<Rigidbody2D>().velocity.y));
        TogglePlatform();
    }

    void TogglePlatform(){
        if(Input.GetButtonDown("Jump"))
         // &&Mathf.Abs(myCharacter.GetComponent<Rigidbody2D>().velocity.y) < 0.1f)
         {
            if (visible){
            gameObject.transform.SetPositionAndRotation(new Vector3(1000, 1000, 1000), new Quaternion());   //just tp it far away lol
            //Debug.Log("bye");
            visible = !visible;
            } else{
                transform.position = myPosition;    //set the position to the saved Position
                visible = !visible;
                //Debug.Log("hey");
            }
        }
    }
}
