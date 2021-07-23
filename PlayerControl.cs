using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private CharacterController ch_controller;
    private MobileController mContr;

    //параметры геймплея для персонажа
    public float jumpPower; //сила прыжка
    public float speedMove; //скорость персонажа
    public float speedRun; //скорость полета
    private Vector3 moveVector; // направление движения персонажа
    private float gravityForce; //гравитация персонажа

    private void Start()
    {
        ch_controller = GetComponent<CharacterController>();
        mContr = GameObject.FindGameObjectWithTag("Joystick").GetComponent<MobileController>();
        AudioManager.MusicBegin();
    }

    private void Update()
    {
        CharacterMove();
        GamingGravity();
    }

    private void CharacterMove() //метод перемещения персонажа
    {
        //перемещение по поверхности
        moveVector = Vector3.zero;
        moveVector.x = mContr.Horizontal() * speedMove;
        moveVector.z = speedRun * speedMove;

        moveVector.y = gravityForce;

        ch_controller.Move(moveVector * Time.deltaTime); //метод передвижения по направлению

    }

    //метод гравитации
    private void GamingGravity()
    {
        if (!ch_controller.isGrounded)
        {
            gravityForce -= 65f * Time.deltaTime; //установка коэффициента гравитации
        }
        else
        {
            gravityForce = -1;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravityForce = jumpPower;
        }
    }

    public void OnJumpButtonDown()
    {
        gravityForce = jumpPower;
    }


}
