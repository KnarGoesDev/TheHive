using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class game : MonoBehaviour
{
    
    [SerializeField] public  TMP_Text QueenField;
    [SerializeField] public  TMP_Text CandidateField;
    [SerializeField] public  Breed BreedGenerator;
    public Button m_YourFirstButton;
    private float cycle = 5f;
    public Scrollbar ProgressBar;
    private List<float> QueenStats= new List<float>();
    Breed theCandidate;
    Breed theQueen; 
    // Start is called before the first frame update

    void Promote(){
        theQueen = theCandidate;
        theCandidate = new Breed (0f);
         QueenStats = theQueen.GetStats();
    }
   

    void NewBourn(){
    theCandidate = new Breed(theQueen.GetScore());
   }
   

    void Awake(){
        theCandidate = new Breed(0f);
        theQueen = new Breed(10f);
        QueenStats = theQueen.GetStats();
   }


    void Start()
    {
        
        m_YourFirstButton.onClick.AddListener(Promote);

        
    }

    // Update is called once per frame
    void Update()
    {   
        ProgressBar.size = (Time.fixedTime%cycle)/cycle;
        if (Time.fixedTime%cycle == 0f){
            NewBourn();
            
            Debug.Log(QueenStats[1]);
            
        }
        
        QueenField.text = theQueen.GetScore().ToString("0.00");
        CandidateField.text = theCandidate.GetScore().ToString("0.00");
        
    }

    

}


