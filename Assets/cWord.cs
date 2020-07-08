using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // 이걸 해야 리스트의 형으로 선언할 수 있다. 
public class cWord
{    
    public string targetWord;

    private int letterIndex;

    // Text 오브젝트로 단어 내용을 보여주기 위해서 추가하고 변경..
    private WordDisplay wordDisplay;
    

    //public cWord(string _word)

/*
    public cWord(string _word)
    {
        targetWord = _word;

        letterIndex = 0;

        //wordDisplay = _display; // 넘어온 텍스트 보여주기 관련 구조체+메서드 덩어리를 여기로 화살표 연결하고..
        //wordDisplay.SetWord(targetWord);

    }
*/
    public cWord(string _word, WordDisplay _display)
    {
        targetWord = _word;

        letterIndex = 0;

        wordDisplay = _display; // 넘어온 텍스트 보여주기 관련 구조체+메서드 덩어리를 여기로 화살표 연결하고..
        wordDisplay.SetWord(targetWord);

    }

    public char GetChar(int _index)
    {

        if( _index <= targetWord.Length) return targetWord[_index];
        else return 'X';

    }

    public char GetTheNextChar()
    {
        //return 'X';
        return targetWord[letterIndex];

    }

    public void TypeItOut()
    {
        letterIndex++;

        // 화면에서 해당 글자를 안보이게 하기. Remove the letter on the screen.
        wordDisplay.RemoveLetter();

    }

    public bool TypingIsCompleted()
    {
        bool _result;

        if( letterIndex >= targetWord.Length ) _result = true;
        else _result = false;

        if( _result )
        {
            // 화면에서 단어 전체를 안보이게 하기. Remove the word on screen.
            wordDisplay.RemoveWord();
        }

        return _result;
    }

}
