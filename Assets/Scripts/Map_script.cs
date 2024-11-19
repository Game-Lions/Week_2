using UnityEngine;

public class Map_script : MonoBehaviour
{
    void Start()
    {
        Camera.main.orthographicSize = Screen.height / (float)Screen.width * 5f;
    }
}
