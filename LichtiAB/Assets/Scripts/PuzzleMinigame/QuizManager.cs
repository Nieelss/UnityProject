using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic; // Ensure you have this namespace

[System.Serializable]
public class Question
{
    public string questionText;
    public string[] answers;
    public int correctAnswerIndex;
}

public class QuizManager : MonoBehaviour
{
    public Text questionText;
    public Button[] answerButtons;
    public Text feedbackText;
    public Question[] questions;

    private int currentQuestionIndex = 0;

    void Start()
    {
        DisplayQuestion();
    }

    void DisplayQuestion()
    {
        feedbackText.text = "";
        Question question = questions[currentQuestionIndex];
        questionText.text = question.questionText;
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].GetComponentInChildren<Text>().text = question.answers[i];
            int index = i; // Capture the index for the listener
            answerButtons[i].onClick.RemoveAllListeners();
            answerButtons[i].onClick.AddListener(() => CheckAnswer(index));
        }
    }

    void CheckAnswer(int index)
    {
        if (index == questions[currentQuestionIndex].correctAnswerIndex)
        {
            feedbackText.text = "Correct!";
            // Proceed to next question or end quiz
            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Length)
            {
                DisplayQuestion();
            }
            else
            {
                EndQuiz();
            }
        }
        else
        {
            feedbackText.text = "Incorrect. Try again.";
        }
    }

    void EndQuiz()
    {
        feedbackText.text = "Quiz Completed!";
        Debug.Log("Player receives a spaceship part!");
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(2); // Wait for 2 seconds
        SceneManager.UnloadSceneAsync("QuizScene");
    }
}
