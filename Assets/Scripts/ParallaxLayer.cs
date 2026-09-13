using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
    public Transform target;
    public float factor = 0.1f;
    public float clampTop = 17f;
    public float clampBottom = -16f;
    
    void Update()
    {
        float x = target.position.x;
        float y = 0f;
        
        if (target.position.y > clampTop)
        {
            y = target.position.y - clampTop;
        } else if (target.position.y < clampBottom)
        {
            y = target.position.y - clampBottom;
        }
        
        transform.position = new Vector3(x - (x * factor) % 1, y, 0f);
    }
}
