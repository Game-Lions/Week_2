using UnityEngine;
using UnityEngine.InputSystem;

public class diamond_script : MonoBehaviour
{
    private SpriteRenderer sr;
    public InputActionReference vanish;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
    }

    private void OnEnable()
    {
        vanish.action.started += vash;
    }
    private void OnDisable()
    {
        vanish.action.started -= vash;
    }

    private void vash(InputAction.CallbackContext obj)
    {
        sr.enabled = !sr.enabled;
    }
}
