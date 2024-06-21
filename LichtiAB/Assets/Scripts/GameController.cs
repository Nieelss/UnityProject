using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{   
    [SerializeField]
    private Sprite bgImage;
    public Sprite[] sprites;
    public List<Sprite> gamePuzzles = new List<Sprite>();
    public List<Button> btns = new List<Button>();
    private bool firstGuess, secondGuess;
    private int countguesses;
    private int countCorrectguesses;
    private int gameGuesses;
    private string firstGuessName, secondGuessName;
    private int firstGuessIndex;
    private int secondGuessIndex;
    private string firstGuessPuzzle, secondGuessPuzzle;
    
    void Start(){
        GetButtons();
        AddListeners();
        AddGamePuzzle();
        Shuffle (gamePuzzles);
        gameGuesses = gamePuzzles.Count / 2;
       
    }
    void Awake(){
        sprites = Resources.LoadAll<Sprite> ("Images/Aschaffenburg");
    }
    
    void GetButtons(){
        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");
        for(int i = 0; i < objects.Length; i++) {
            btns.Add(objects[i].GetComponent<Button>());
            btns[i].image.sprite = bgImage;
        }
    }
    void AddGamePuzzle(){
        int looper = btns.Count;
        int index = 0;

        for(int i = 0; i < looper; i++){
            if(index == looper / 2){
               index = 0;
            }
           gamePuzzles.Add(sprites[index]);
            index++;
            
        }
    }
    void AddListeners(){
        foreach(Button btn in btns){
            btn.onClick.AddListener(() => PickAPuzzle());
        }
    }
    public void PickAPuzzle(){
        string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        Debug.Log("You are Clicking A Button named " + name);

        if(!firstGuess){
            firstGuess = true;
           firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

           firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;
           btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];
        }else if(!secondGuess){
             secondGuess = true;
           secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

           secondGuessPuzzle = gamePuzzles[secondGuessIndex].name;
           btns[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];
           StartCoroutine(CheckifThePuzzlesMatch());
        }
    }
    IEnumerator CheckifThePuzzlesMatch(){
        yield return new WaitForSeconds(1f);

        if(firstGuessPuzzle == secondGuessPuzzle && firstGuessIndex != secondGuessIndex){

             yield return new WaitForSeconds(.5f);

            btns[firstGuessIndex].interactable = false;
            btns[secondGuessIndex].interactable = false;

            btns[firstGuessIndex].image.color = new Color(0, 0, 0, 0);
            btns[secondGuessIndex].image.color = new Color(0, 0, 0, 0);

            CheckIfTheGameIsFinished();
        } else {

             yield return new WaitForSeconds(.5f);

            btns[firstGuessIndex].image.sprite = bgImage;
            btns[secondGuessIndex].image.sprite = bgImage;
        }
        yield return new WaitForSeconds(.5f);

        firstGuess = secondGuess = false;
       
    }
    void CheckIfTheGameIsFinished(){
        countCorrectguesses++;
        if(countCorrectguesses == gameGuesses){
           //FindObjectOfType<SceneController>().ReturnToMainScene();
            Debug.Log("Game Finished");
            Debug.Log("It took you " + countguesses + "to finish the Puzzle");
             SceneManager.UnloadSceneAsync("MiniGame");
        }

    }
    void Shuffle(List<Sprite> list) {
        for(int i = 0; i < list.Count; i++){
            Sprite temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
}
      
   

