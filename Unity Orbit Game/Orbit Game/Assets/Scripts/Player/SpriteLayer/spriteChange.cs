using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public int spriteNumb = 1;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            spriteNumb ++;
            if(spriteNumb > 4) 
                spriteNumb = 1;
            ChangeSprite(spriteNumb);
        }
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
