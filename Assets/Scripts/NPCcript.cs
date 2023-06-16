using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCcript : MonoBehaviour
{
    public Canvas canvas;
    public List<TMPro.TextMeshProUGUI> listText;

    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (currentIndex < listText.Count - 1)
            {
                listText[currentIndex].gameObject.SetActive(false);
                currentIndex++;
                listText[currentIndex].gameObject.SetActive(true);
            }
            else
            {
                canvas.gameObject.SetActive(false);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            canvas.gameObject.SetActive(true);
            currentIndex = 0;
            foreach (var text in listText)
            {
                text.gameObject.SetActive(false);
            }
            listText[currentIndex].gameObject.SetActive(true);
        }
    }
}
