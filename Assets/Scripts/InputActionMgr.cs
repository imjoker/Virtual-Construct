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

    // Update is called once per frame
    void FixedUpdate ()
    {
        if (startGame.action.IsPressed() && ((computer.position.z - player.position.z) < 3))
        {
            SceneManager.LoadScene("Phase-2");
        }
    }
}
