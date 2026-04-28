using Meta.WitAi;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateVoice : MonoBehaviour
{
    [SerializeField] private Wit wit;
    [SerializeField] private InputActionReference activateVoiceAction;

    private void OnEnable()
    {
        if (activateVoiceAction != null)
        {
            activateVoiceAction.action.performed += OnTriggerPressed;
            activateVoiceAction.action.Enable();
        }
    }

    private void Update()
    {
        if (wit == null)
        {
            wit = GetComponent<Wit>();
        }
    }

    private void OnDisable()
    {
        if (activateVoiceAction != null)
        {
            activateVoiceAction.action.performed -= OnTriggerPressed;
            activateVoiceAction.action.Disable();
        }
    }

    private void OnTriggerPressed(InputAction.CallbackContext context)
    {
        if (context.performed && wit != null)
        {
            Debug.Log("Voice activated!");
            wit.Activate();
        }
    }
}
