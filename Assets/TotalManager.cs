using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalManager : MonoBehaviour
{
    public List<cWord> words;
    
    //public TextObjectGenerator textObjGenerator;
    public TextObjectGenB textObjectGenB;

    private bool isActivatedWord;
    private cWord activeWord;

    //public WordDisplay showingWord;

    // Start is called before the first frame update
    void Start()
    {
        //string sA = cWordDB_A.Beatitudes[0];
        //Debug.Log(sA);

        isActivatedWord = false;

        /* 2020.06.15.JO 타이머 기반으로 워드 생성하기 위해 삭제. 
        AddWord();
        AddWord();
        AddWord();
        */


    }

    public void AddWord()
    {
        // Text 오브젝트로 단어 내용을 보여주기 위해서 추가하고 변경..
        //cWord word = new cWord(cWordDB_A.GetRandomWord());
        //cWord word = new cWord(cWordDB_A.GetRandomWord(), textObjGenerator.GenerateTextObject());
        
        // 순서대로 단어를 보여주기 위해. 7/20
        
        string oneWord = cWordDB_A.GetWordInOrder();

        if( oneWord != null )
        {
            cWord word = new cWord(oneWord, textObjectGenB.GenerateTextObject() );
            
            Debug.Log(word.targetWord);
            
            words.Add(word);

        }else // If the sentence is ended.
        {
            // Do nothing. 
            Debug.Log("End of the sentence!");
        }


        /*
        //cWord word = new cWord(cWordDB_A.GetRandomWord(), textObjectGenB.GenerateTextObject());        

        Debug.Log(word.targetWord);

        words.Add(word);
        */        
    }

    public void TypeLetter(char _letter)
    {
        
        if( isActivatedWord == true )
        {
            // Check if letter was next, remove it from the word.
            if( _letter == activeWord.GetTheNextChar() )
            {
                activeWord.TypeItOut();

            }else
            {
                // 2020.06.11.ZOMAN 
                // 초고수 Brackeys 도 실수하네.. 이거 없으면 버그..
                // 마구마구 치다가 제대로 쳐보려면, 첫글자 가 마구마구에 걸렸었을 때,
                // 아무리 제대로 쳐도 해당 단어가 사라지지 않은 버그 fix. 
                isActivatedWord = false;
            }

        }else
        {

            //foreach(string candidateWord in words)
            foreach(cWord candidateWord in words)
            {
                //if( _letter == candidateWord[0])
                if( _letter == candidateWord.GetTheNextChar() )
                {
                    activeWord = candidateWord;
                    isActivatedWord = true;
                    
                    candidateWord.TypeItOut();
                    break;
                }

            }
        }

        if( isActivatedWord && activeWord.TypingIsCompleted() )
        {
            isActivatedWord = false;
            words.Remove(activeWord);
        }
    }

    private void Update()
    {


        /*
        Move to the another new class to handle keyboard input individually.
        */
    }


}
