using System.Collections;
using System;
using UnityEngine;

public class GetTileSize : MonoBehaviour
{
    float widht;
    float height;
    float size;
    SpriteRenderer spriteRenderer;
    Sprite targetSprite;

    GridCodeMonkey<int> grid;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        targetSprite = spriteRenderer.sprite;
        ScaleSpriteToCameraFullResolution();
        SetWidthHeight();

        //Debug.Log("name " + name);


        grid = new GridCodeMonkey<int>(22, 12, 1f, new Vector3(-11, -6), (GridCodeMonkey<int> g, int x, int y) => new int());

    }

    private void SetWidthHeight()
    {
        float pixelsPerUnits = targetSprite.pixelsPerUnit;
        widht = spriteRenderer.bounds.size.x * pixelsPerUnits;
        height = spriteRenderer.bounds.size.y * pixelsPerUnits;
        size = spriteRenderer.bounds.size.x * spriteRenderer.bounds.size.y;
        Debug.Log("width:" + widht + " height:" + height + " size:" + size);
    }

    private void ScaleSpriteToCameraFullResolution()
    {
        float screenHeight = Camera.main.orthographicSize * 2f;
        float screenWidth = screenHeight / Screen.height * Screen.width;
        float width = screenWidth / spriteRenderer.sprite.bounds.size.x;
        float height = screenHeight / spriteRenderer.sprite.bounds.size.y;
        transform.localScale = new Vector3(width, height, 1f);
    }

}
