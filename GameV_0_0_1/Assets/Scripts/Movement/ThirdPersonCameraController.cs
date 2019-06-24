using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    #region Fields
    public float rotationSpeed = 1;
    public Transform Target, Player;
    float mouseX, mouseY;
    GameManager _gameManager;

    [SerializeField]
    ThirdPersonCharacterController _controller;
    #endregion

    #region Properties
    #endregion

    #region Methods
    private void Start()
    {
        HideMouse();
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void LateUpdate()
    {
        CamControl();
    }

    void CamControl()
    {
        if (_gameManager.ActivateCombat == false)
        {

            mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
            mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
            mouseY = Mathf.Clamp(mouseY, -35, 60);

            transform.LookAt(Target);


            if (Input.GetKey(KeyCode.LeftShift) || (_controller.Ver == 0 && _controller.Hor == 0))
            {
                Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
            }
            else
            {
                Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
                Player.rotation = Quaternion.Euler(0, mouseX, 0);
            }
        }
    }

    public void HideMouse()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    #endregion
}
