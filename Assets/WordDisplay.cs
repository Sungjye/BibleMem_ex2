using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This the cript which is attatched to 'the text game object'. 
// Text game objects would be generated whenever it were triggeredj.

public class WordDisplay : MonoBehaviour
{
    public Text showingText;

    public float fallingSpeed = 1f;

    public float itsHeight = 0f; // 2020.06.18.SJ

    public void SetWord(string _text)
    {
        showingText.text = _text;
    }

    public void RemoveLetter()
    {
        // public string Remove (int startIndex, int count); 다른 매서드 이지만, 인자는 통일성을 가졌군.
        showingText.text = showingText.text.Remove(0, 1); 
        showingText.color = Color.cyan;

    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        // 여기서 나오는, <게임 움직임 스러운 것>에서 매우 중요한, 델타 타임의 개념!! 이거 빼봐라, 어떤 희한한 결과가 나오는지!
        // 구글링하면 나오지만, DeltaTime 의 개념은, 프레임레이트에 관계없이 game object의 일정한 이동을 하기 위해. 

        
        //Debug.Log(itsHeight + gameObject.transform.position.x);

        if( gameObject.transform.position.y < itsHeight ) 
        {

            return;
        }


        transform.Translate(0f, -fallingSpeed * Time.deltaTime, 0f);

    }
}
