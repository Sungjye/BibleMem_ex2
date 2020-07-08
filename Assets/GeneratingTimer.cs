using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2020.06.15.SJJO
public class GeneratingTimer : MonoBehaviour
{

    public TotalManager totalManager;


    private float nextTimeToGenerate = 0f;
    public float timeDelay = 2.5f; // to see the changes.

    private void Update()
    {
        
        // 한번 보고 순서 의식 없이 코딩했는데, Brackeys 와 동일한 순서라니. 
        // 뭔가 뿌듯하다면 자존심 상함? 그래도 코딩 감이 살아나고 있다는 정황?!
        if( Time.time >= nextTimeToGenerate )
        {
            totalManager.AddWord();

            nextTimeToGenerate = Time.time + timeDelay;

            timeDelay = timeDelay*0.99f; // 굳이 이런 쪼으는 게임성 필요 있나. 아직은. 
        }

    }
}
