using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRend : MonoBehaviour
{
    [SerializeField] private float tabHeight;
    [SerializeField] private float tabWidth;

    private SpriteRenderer sprRend;

    // Start is called before the first frame update
    void Start()
    {
       // sprRend = GetComponent<SpriteRenderer>();
        sprRend = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
        sprRend.drawMode = SpriteDrawMode.Sliced;

        sprRend.size = new Vector2(tabHeight, tabHeight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
