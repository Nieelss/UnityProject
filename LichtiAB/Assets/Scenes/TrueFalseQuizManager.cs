using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

[System.Serializable]
public class TrueFalseQuestion
{
    public string questionText;
    public bool isTrue;
}

public class TrueFalseQuizManager : MonoBehaviour
{
    public Text questionText;
    public Button trueButton;
    public Button falseButton;
    public Text feedbackText;
    public TrueFalseQuestion[] questions;

    private int currentQuestionIndex = 0;

    void Start()
    {
        DisplayQuestion();
    }

    void DisplayQuestion()
    {
        feedbackText.text = "";
        TrueFalseQuestion question = questions[currentQuestionIndex];
        questionText.text = question.questionText;

        trueButton.onClick.RemoveAllListeners();
        falseButton.onClick.RemoveAllListeners();

        trueButton.onClick.AddListener(() => CheckAnswer(true));
        falseButton.onClick.AddListener(() => CheckAnswer(false));
    }

    void CheckAnswer(bool answer)
    {
        if (answer == questions[currentQuestionIndex].isTrue)
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
        Debug.Log("Loading NextScene...");
       SceneManager.UnloadSceneAsync("TrueFalseQuizScene");
    }
}
