using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electronSwitch : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public int spriteNumb = 1;
    // Start is called before the first frame update
    void Awake()
    {
        spriteNumb = Random.Range(1, 4);
        ChangeSprite(spriteNumb);
    }

    void ChangeSprite(int sprite)
    {
                switch(sprite)
        {
            case 1:              
                spriteRenderer.sprite = sprite1;
                break;
            case 2: 
                spriteRenderer.sprite = sprite2;
                break;
            case 3:
                spriteRenderer.sprite = sprite3;
                break;
            case 4:
                spriteRenderer.sprite = sprite4;
                break;
        }
    }
}
