using UnityEngine;

public class rotater_script : MonoBehaviour
{
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime); // Rotates 50 degrees per second around Z-axis
    }
}
