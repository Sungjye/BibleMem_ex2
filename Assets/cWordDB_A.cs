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

    public static string[] Deuteronomy_C8_KRV ={
        "너를", "낮추시며", "너로", "주리게", "하시며",
        "또", "너도", "알지", "못하며", "네", "조상들도", "알지", "못하던", 
        "만나를", "네게", "먹이신", "것은",
        "사람이", "떡으로만", "사는", "것이", "아니요",
        "여호와의", "입에서", "나오는", "모든", "말씀으로", "사는", "줄을",
        "너로", "알게하려", "하심이니라."
    };

    public static string[] Deuteromony_C8_NASB ={
        "HashSet", "humbled", "you", "and", "let", "you", "be", "hungry,",
        "and", "fed", "you", "with", "manna", "which", "you", "did", "not", "know,", 
        "nor", "did", "your", "fathers", "know,",
        "that", "He", "might", "make", "you", "understand",  
        "that", "man", "does", "not", "live", "by", "bread", "alone,",
        "but", "man", "lives", "by", "everything", "that", "proceeds", "out", "of", "the", "mouth", "of", "the", "Lord."
    };

    public static string[] targetWordSet = Deuteromony_C8_NASB; //Luke_C9; //Beatitudes;

    public static string GetRandomWord()
    {
        int randomIndex;

        randomIndex = Random.Range(0, targetWordSet.Length);

        return targetWordSet[randomIndex];
    }

}
