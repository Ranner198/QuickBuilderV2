using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile{

    private Sprite sprite {get {return sprite;} set {sprite = value;}}
    private int layer {get {return layer;} set {layer = value;}}
    private BoxCollider2D boxCollider {get {return boxCollider;} set {boxCollider = value;}}
    private Vector2 position;

    //Default Construtor
    Tile() {}

    Tile(Sprite sprite)
    {
        this.sprite = sprite;
    }

    Tile (Sprite sprite, int layer)
    {
        this.sprite = sprite;
        this.layer = layer;
    }

    Tile(Sprite sprite, int layer, Vector2 position)
    {
        this.sprite = sprite;
        this.layer = layer;
        this.position = position;
    }
}
