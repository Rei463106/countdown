using UnityEngine;
//UIを操作する用の文
using UnityEngine.UI;

public class Timemanagers : MonoBehaviour
{

    //制限時間
    [SerializeField] int timeLimit;
    //タイマーテキストの操作用
    [SerializeField] public Text timerText;
    //経過時間
    float timerTime;
    //残り時間判定用
    public static int remaining;
    public bool isWorking = true;   // 動いているか
  
    void Start()
    {

    }

    
    void Update()
    {
        if (!isWorking)
        {
            //空の結果を返す
            return;
        }

        //フレームごとの経過時間をtime変数に追加
        timerTime += Time.deltaTime;
        //timertimeをint型にし制限時間から引き、代入(残り時間)
        Timemanagers.remaining = timeLimit - (int)timerTime;
        timerText.text = $"のこり:{remaining.ToString("D3")}";

        //0以下の時はずっとTimeUP!と表示し続ける
        if (remaining <= 0)
        {
            timerText.text = "TimeUP!!";
        }

    }

}
