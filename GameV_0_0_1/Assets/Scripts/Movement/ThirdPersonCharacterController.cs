using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
    #region Fields
    public float speed;
    #endregion

    #region Properties
    #endregion

    #region Methods
    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 playerMovement = new Vector3(hor, 0.0f, ver) * speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }
    #endregion
}
