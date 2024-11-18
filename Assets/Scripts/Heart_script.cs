using UnityEngine;

public class Heart_script : MonoBehaviour
{
    public float beatSpeed;  // Speed of the heartbeat
    public float maxScale; // Maximum scale during "beat"
    public float minScale; // Minimum scale during "rest"

    private Transform tf;
    private Vector3 originalScale;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = GetComponent<Transform>();
        originalScale = tf.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        float scale = Mathf.Lerp(minScale, maxScale, (Mathf.Sin(Time.time * beatSpeed) + 1) / 2);
        tf.localScale = originalScale * scale;
    }
}
