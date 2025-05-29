using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UIを操作する用の文
using UnityEngine.UI;

public class timemanager : MonoBehaviour
{
    //制限時間
    [SerializeField] int timeLimit;
    //タイマーテキストの操作用
    [SerializeField] Text timerText;
    //経過時間
    float timerTime;
    //タイマーが0になったのかを判断するやつ
   // public bool isTimeUp;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //フレームごとの経過時間をtime変数に追加
        //経過時間が1秒、2秒…
        timerTime += Time.deltaTime;
        //timertimeをint型にし制限時間から引き、代入(残り時間)
        int remaining= timeLimit - (int)timerTime;
        //timerTextを更新！
        //$を使うと文字列内に変数や式を埋め込むことができる
        //remaining.ToString("D3"):
        //この部分は、remainingという整数値を3桁に整形し、足りない桁を0で埋める働きをする。
        timerText.text =$"のこり:{remaining.ToString("D3")}";

        //0以下の時はずっとTimeUP!と表示し続ける
        if (remaining <= 0)
        {

           
            timerText.text = "TimeUP!!";
        }
    }
}
