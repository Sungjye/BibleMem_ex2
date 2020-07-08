using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
// 우선, 성경 암송을 위한 로직을 넣기 위한 텍스트 오브젝트 제너레이터. 2020.06.18
// 

public class TextObjectGenB : MonoBehaviour
{
    public GameObject wordPrefeb;
    public Transform mainCanvas; // 이걸 해줘야 화면에 보인다. 


    public WordDisplay GenerateTextObject()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-3f, 2.5f), 5f);
        //Vector3 randomPosition = new Vector3(Random.Range(-1f, 1f), 5f);

        GameObject _textObject = Instantiate(wordPrefeb, randomPosition, Quaternion.identity, mainCanvas);

        WordDisplay _wordDisplay = _textObject.GetComponent<WordDisplay>();

        // To change the falling speed. 2020.06.15.SJ
        float randomSpeed = Random.Range(0.5f, 0.7f);
        _wordDisplay.fallingSpeed = randomSpeed;

        // To set the y position. 2020.06.18.SJ
        float stopPosition = Random.Range(-1f, 2f);
        _wordDisplay.itsHeight = stopPosition;

        return _wordDisplay;
    }


}
