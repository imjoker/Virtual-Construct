using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;


public class InputActionMgr : MonoBehaviour
{
    public  InputActionProperty startGame;
    public  Transform           computer;
    public  Transform           player;

    // Update is called once per frame
    void Update ()
    {
        if (startGame.action.IsPressed() && ((computer.position.z - player.position.z) < 3))
        {
            SceneManager.LoadScene("Phase-2");
        }
    }
}
