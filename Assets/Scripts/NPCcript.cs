using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCcript : MonoBehaviour
{
    public Canvas canvas;
    public TMPro.TextMeshProUGUI firstText;
    public TMPro.TextMeshProUGUI secondText;

    private bool isFirstTextDisplayed = true;

    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Проверьте, нажата ли клавиша Enter
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // Проверьте, если первый текст уже отображается
            if (isFirstTextDisplayed)
            {
                // Скройте первый текст и отобразите второй текст
                firstText.gameObject.SetActive(false);
                secondText.gameObject.SetActive(true);
                isFirstTextDisplayed = false;
            }
            else
            {
                // Если уже отображается второй текст, скройте канвас
                canvas.gameObject.SetActive(false);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            // При соприкосновении с игроком, отобразите канвас и первый текст
            canvas.gameObject.SetActive(true);
            firstText.gameObject.SetActive(true);
            secondText.gameObject.SetActive(false);
            isFirstTextDisplayed = true;
        }
    }
}
