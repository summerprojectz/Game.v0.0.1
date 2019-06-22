using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
    #region Fields
    public float speed;
    GameManager _gameManager;
    float _hor, _ver;
    #endregion

    #region Properties
    public float Hor
    {
        get { return _hor; }
    }

    public float Ver
    {
        get { return _ver; }
    }
    #endregion

    #region Methods
    private void Start()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        _hor = 0;
        _ver = 0;
        if (_gameManager.ActivateCombat == false)
        {
            _hor = Input.GetAxis("Horizontal");
            _ver = Input.GetAxis("Vertical");

            Vector3 playerMovement = new Vector3(_hor, 0.0f, _ver) * speed * Time.deltaTime;
            transform.Translate(playerMovement, Space.Self);
        }
    }
    #endregion
}
