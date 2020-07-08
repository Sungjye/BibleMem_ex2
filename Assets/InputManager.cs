using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public TotalManager totalManager;
    // Update is called once per frame
    void Update()
    {

        /* 톱 매니저 업데이트에 있어도 잘동작한다. 
        // 키보드 입력이라면, 이것도 참조. https://unity-programmer.tistory.com/9
        if(Input.GetKeyDown(KeyCode.A))
        foreach(char _c in Input.inputString)
        {
            Debug.Log(_c);
            TypeLetter(_c);
        }
        */


        foreach(char _c in Input.inputString)
        {
            Debug.Log($"[Input: {_c}]");
            totalManager.TypeLetter(_c);
        }



    }
}
