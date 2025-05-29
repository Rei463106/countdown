using UnityEngine;
//UIを操作する用の文
using UnityEngine.UI;

public class Timemanagers : MonoBehaviour
{
   
    //制限時間
    [SerializeField] int timeLimit;
    //タイマーテキストの操作用
    //他のところで使う場合、パブリックにしておく
    [SerializeField]public Text timerText;
    //経過時間
    float timerTime;
    //残り時間判定用（他のところで使わないなら書かなくて良い）
    // 残り時間（静的フィールドで共有可能）
    public static int remaining;
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
        //他のところから使いたい場合、直接指定した方が良い。
        Timemanagers.remaining = timeLimit - (int)timerTime;
        //timerTextを更新！
        //$を使うと文字列内に変数や式を埋め込むことができる
        //remaining.ToString("D3"):
        //この部分は、remainingという整数値を3桁に整形し、足りない桁を0で埋める働きをする。
        timerText.text = $"のこり:{remaining.ToString("D3")}";

        //0以下の時はずっとTimeUP!と表示し続ける
        if (remaining <= 0)
        {
            timerText.text = "TimeUP!!";
        }

    }
   
}
