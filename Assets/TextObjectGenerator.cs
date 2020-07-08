using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextObjectGenerator : MonoBehaviour
{
    public GameObject wordPrefeb;
    public Transform mainCanvas; // 이걸 해줘야 화면에 보인다. 

    public WordDisplay GenerateTextObject()
    {
        // (Horizontal) 랜덤한 위치에 텍스트 오브젝트를 표시하기 위해. 
        Vector3 randomPosition = new Vector3(Random.Range(-2.5f, 2.5f), 5f);

        //GameObject _textObject = Instantiate(wordPrefeb); // 처음의 인스턴시에잇.

        // 이렇게 인스턴시에잇 해줘야 화면, 즉 캔버스에 보인다. 
        //GameObject _textObject = Instantiate(wordPrefeb, mainCanvas);

        // 이렇게 인스턴시에잇 해줘야 위치를 지정해서 뿌릴 수 있다. 
        GameObject _textObject = Instantiate(wordPrefeb, randomPosition, Quaternion.identity, mainCanvas);
        
        WordDisplay _wordDisplay = _textObject.GetComponent<WordDisplay>();


        // To change the falling speed. 2020.06.15.SJ
        float randomSpeed = Random.Range(0.5f, 2f);
        _wordDisplay.fallingSpeed = randomSpeed;

        return _wordDisplay;
    }
    
}
