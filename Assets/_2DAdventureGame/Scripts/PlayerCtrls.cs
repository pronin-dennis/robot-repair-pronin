using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public InputAction MoveAction;
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
        MoveAction.Enable();
    }

    void Update()
    {
       Vector2 move = MoveAction.ReadValue<Vector2>();
       Debug.Log(move);
       Vector2 position = (Vector2)transform.position + move * 3.0f * Time.deltaTime;
       transform.position = position;
    }
}
