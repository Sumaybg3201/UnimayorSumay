using UnityEngine;

public class Spinner : MonoBehaviour
{
    public void SpinLeft()
    {
        // Rota en el eje Z positivo usando 60 * Time.deltaTime
        transform.Rotate(0f, 0f, 60f * Time.deltaTime);
    }

    public void SpinRight()
    {
        // Rota en el eje Z negativo
        transform.Rotate(0f, 0f, -60f * Time.deltaTime);
    }
}