using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersAndButtons : MonoBehaviour
{
    Animator _playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        _playerAnimator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        //Press the up arrow button to reset the trigger and set another one
        if (Input.GetKeyDown(KeyCode.W))
        {
            //Reset the "Crouch" trigger
            _playerAnimator.ResetTrigger("RunForward");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Reset the "Crouch" trigger
            _playerAnimator.ResetTrigger("RunBackward");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Reset the "Crouch" trigger
            _playerAnimator.ResetTrigger("RunLeft");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //Reset the "Crouch" trigger
            _playerAnimator.ResetTrigger("RunRight");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Reset the "Jump" trigger
            _playerAnimator.ResetTrigger("Jump");
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            //Send the message to the Animator to activate the trigger parameter named "Crouch"
            _playerAnimator.SetTrigger("Crouch");
        }


    }
}
