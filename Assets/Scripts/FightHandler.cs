using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

public class FightHandler : MonoBehaviour
{
    public TextAsset all;
    public string Text;
    public static string question;
    public Text answer1;
    public Text answer2;
    public Text answer3;
    public Text answer4;
    public Text questionText;
    public static Dictionary<string, string[]> task;
    public string True;
    
    public Canvas dicisionsCanvas;

    public Canvas quizCanvas;

    // Start is called before the first frame update
    void Start()
    {
        quizCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame


    public void ButFight()
    {
        GenerateTask();
        ChangeCanvasToFight();
    }

    private void ChangeCanvasToDicison()
    {
        quizCanvas.gameObject.SetActive(false);
        dicisionsCanvas.gameObject.SetActive(true);
    }
    private void ChangeCanvasToFight()
    {
        quizCanvas.gameObject.SetActive(true);
        dicisionsCanvas.gameObject.SetActive(false);
    }
    
    public void GenerateTask()
    {
        task = new Dictionary<string, string[]>();
        Text = all.text;
        var splitTasks = Text.Split("|");
        for (var i = 0; i < splitTasks.Length; i++)
        {
            var taskSplit = splitTasks[i].Split("/");
            var answers = taskSplit[1].Split(";");
            task.Add(taskSplit[0],answers);
        }
        
        var keysArray = task.Keys.ToArray();
        var randomIndex = Random.Range(0, keysArray.Length);
        var randomTask = task[keysArray[randomIndex]];
        var questionTexts = keysArray[randomIndex];
        True = randomTask[0];
        var shuffledAnswers = ArrayExtensions.Shuffle(randomTask);
        question = questionTexts;
        answer1.text =shuffledAnswers[0];
        answer2.text =shuffledAnswers[1];
        answer3.text =shuffledAnswers[2];
        answer4.text =shuffledAnswers[3];
        questionText.text = question;
    }
}
