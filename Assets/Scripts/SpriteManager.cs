using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeOpacity()
    {
        // Получаем текущий цвет спрайта
        Color spriteColor = spriteRenderer.color;

        // Изменяем только альфа-канал цвета
        spriteColor.a =(float)0.5;

        // Применяем новый цвет спрайта
        spriteRenderer.color = spriteColor;
    }
}
