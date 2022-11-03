using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class InputActionMgr : MonoBehaviour
{
    public  InputActionProperty startGame;
    public  Transform           computer;
    public  Transform           player;
    private bool                isPressedOnce = false;


    // Update is called once per frame
    void FixedUpdate ()
    {
        if (!isPressedOnce && startGame.action.IsPressed() && ((computer.position.z - player.position.z) < 1))
        {           
            SceneManager.LoadScene("Phase-2");
            isPressedOnce = true;
        }
    }
}
