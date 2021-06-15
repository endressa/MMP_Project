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
    }

    // Update is called once per frame
    void Update()
    {
        TogglePlatform();
    }

    void TogglePlatform()
    {
    if(Input.GetButtonDown("Jump")){ //&& Mathf.Abs(_rigidbody.velocity.y) < 0.001f){
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
            
        }
    }
}
