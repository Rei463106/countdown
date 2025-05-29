using UnityEngine;

public class timesix : MonoBehaviour
{
    private bool isClicked = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame



    void Update()
    {
        // クリックされているかつ、残り時間が6秒の時に処理を実行
        if (isClicked && Timemanagers.remaining == 6)
        {
            Debug.Log("ゲームクリア！");
            //textのようなUI系はSelializeFieldが一番良い
            //この下を修正しないとダメかも…
            //6秒になってボタンを押したら画面にゲームクリアと表示したい…
            Timemanagers timerManager = FindObjectOfType<Timemanagers>();

            if (timerManager != null)
            {
                timerManager.timerText.text = "ゲームクリア！"; // UIに表示
            }

            isClicked = false; // フラグをリセットして再実行を防止
        }
    }



    private void OnMouseDown()
    {
        isClicked = true;
    }
}
