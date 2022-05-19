using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnter2DFloor : MonoBehaviour
{
    public Texture2D tex;

    void Awake()
    {
        SpriteRenderer sr = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
        transform.position = new Vector3(0.0f, -2.0f, 0.0f);

        Sprite sp = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
        sr.sprite = sp;

        gameObject.AddComponent<BoxCollider2D>();
    }
}
