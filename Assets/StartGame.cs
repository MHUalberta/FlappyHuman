using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] private InputActionReference startButton;
    [SerializeField] private AudioManager audio;


    private CharacterController _characterController;
    private Vector3 _playerVelocity;

    private void OnEnable() => startButton.action.performed += StartFlapping;

    private void OnDisable() => startButton.action.performed -= StartFlapping;

    private void StartFlapping(InputAction.CallbackContext obj)
    {
        SceneManager.LoadScene("MyScene");
    }
}