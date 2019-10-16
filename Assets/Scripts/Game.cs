using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    #region Singleton
    public static Game Instance = null;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    
 public Camera cam;
    public Renderer background;
    // Start is called before the first frame update
    public Vector3 GetAdjustedPosition(Vector3 incomingPos)
    {
        Vector3 size = background.bounds.size;
        Vector3 halfSize = size * .5f;
        if (incomingPos.x > halfSize.x)
            incomingPos.x = halfSize.x;
        if (incomingPos.y > halfSize.y)
            incomingPos.y = halfSize.y;

        if (incomingPos.x < -halfSize.x)
            incomingPos.x = -halfSize.x;
        if (incomingPos.y < -halfSize.y)
            incomingPos.y = -halfSize.y;
        return incomingPos;
    }
    public Vector3 GetRandomPosition()
    {
        Vector3 size = background.bounds.size;
        Vector3 halfSize = size * .5f;
        float x = Random.Range(-1f, 1f) * halfSize.x;
        float y = Random.Range(-1f, 1f) * halfSize.y;
        return new Vector3(x, y);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
