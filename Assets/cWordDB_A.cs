using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This class is in charge of a handling for a word.
public class cWordDB_A
{


    public static string[] Beatitudes = {
        "Blessed", "are", "the", "poor", "in", "spirit,", 
        "for", "theirs", "is", "the", "kingdom", "of", "heaven.",
        "Blessed", "are", "those", "who", "mourn,", 
        "for", "they", "shall", "be", "comforted.",

        "Amen"
    };

    public static string[] FirstJohn_C5V2 ={
         "This", "is", "how", "we", "know", "that", 
         "we", "love",
         "the", "children", "of", "God:", "by", 
         "loving", "God", "and", "carrying", "out", 
         "his", "commands."
    };
    /* NASB 
    By this we know that we love the children of God, when we love God and [e]observe His commandments. 
    */

    public static string[] Luke_C9 ={
        "너희의", "이름이", "하늘에", "기록된", "것으로", "기뻐하여라", 

        "아멘"
    };


    public static string[] targetWordSet = Luke_C9; //Beatitudes;

    public static string GetRandomWord()
    {
        int randomIndex;

        randomIndex = Random.Range(0, targetWordSet.Length);

        return targetWordSet[randomIndex];
    }

}
