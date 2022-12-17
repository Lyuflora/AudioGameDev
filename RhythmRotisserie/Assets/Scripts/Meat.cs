using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meat : MonoBehaviour
{
    private Image meat;
    public Image surface;

    //public SpriteRenderer meatRenderer;
    //public Sprite meatSprite;

    public Color32 raw;
    public Color32 cooked;
    public Color32 overcooked;

    public Color32 cookedSurface;
    public Color32 overcookedSurface;
    private void Awake()
    {
        meat = GetComponent<Image>();
        ShowSurface(false);
    }
    void Start()
    {

    }
    public void MeatReset()
    {
        meat.color = raw;
        ShowSurface(false);
    }
    public void MeatCooked()
    {
        meat.color = cooked;
        surface.color = cookedSurface;
    }
    public void MeatOvercooked()
    {
        meat.color= overcooked;
        surface.color = overcookedSurface;
    }
    public void ShowSurface(bool isVisible)
    {
        surface.enabled = isVisible;
    }
}
