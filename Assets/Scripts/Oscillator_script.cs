using System.Diagnostics;
using Unity.Mathematics;
using UnityEngine;

public class Oscillator_script : MonoBehaviour
{
    private Rigidbody2D rb;
    Stopwatch time = new Stopwatch();  // Time for the equsion

    public float swingHight;      // The final wanted speed
    public float swingsPerSecond;     // The total time it takes to reach the max speed
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        time.Start();
    }

    // Update is called once per frame
    void Update()
    {
        rb.rotation = swingHight * math.sin((float)time.Elapsed.TotalSeconds * (math.PI / swingsPerSecond));
    }
}