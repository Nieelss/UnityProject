using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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
    private int firstGuessIndex, secondGuessIndex;
    void Start(){
        GetButtons();
        AddListeners();
        AddGamePuzzle();
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

           //firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;
           btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];
        }else if(!secondGuess){
             secondGuess = true;
           secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

           //secondGuessPuzzle = gamePuzzles[secondGuessIndex].name;
           btns[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];
        }
    }
}
      
   

