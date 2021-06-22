using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerBlock : MonoBehaviour
{
    public bool visible;
    public float interval;
    private float timer;
    private Vector3 myPosition;
    void Start()
    {
        timer = 0;
        myPosition = transform.position;    //save the position of the TimerBlock
        if (visible)
            {
            gameObject.transform.SetPositionAndRotation(new Vector3(1000, 1000, 1000), new Quaternion());   //just tp it far away lol
            visible = !visible;
            }else{
                transform.position = myPosition;    //set the position to the saved Position
                visible = !visible;
                SoundManager.PlaySound("Change_TimerBlock");
            }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > interval){
            if (visible)
            {
            gameObject.transform.SetPositionAndRotation(new Vector3(1000, 1000, 1000), new Quaternion());   //just tp it far away lol
            visible = !visible;
            timer = 0;
            SoundManager.PlaySound("Change_TimerBlock");
            }else{
                transform.position = myPosition;    //set the position to the saved Position
                visible = !visible;
                timer = 0;
                //SoundManager.PlaySound("Change_TimerBlock");
            }
        }
    }
}
