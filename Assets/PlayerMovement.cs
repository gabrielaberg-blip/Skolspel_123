using UnityEngine;
using UnityEngine.InputSystem;

public class Script : MonoBehaviour
{
    [SerializeField] private InputActionReference controls;
    [SerializeField] private float speed;
    [SerializeField] private float smoothness;

    private float currentSpeedX = 0f;
    private float currentSpeedY = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = controls.action.ReadValue<Vector2>();      

        input *= speed * Time.deltaTime;

        currentSpeedX = Mathf.Lerp(currentSpeedX, input.x, smoothness * Time.deltaTime);
        currentSpeedY = Mathf.Lerp(currentSpeedY, input.y, smoothness * Time.deltaTime);

        transform.Translate(currentSpeedX, 0, currentSpeedY, Space.Self);
    }
}
