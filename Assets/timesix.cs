using UnityEngine;

public class timesix : MonoBehaviour
{
    private bool isClicked = false;

    void Start()
    {

    }





    void Update()
    {
        // クリックされているかつ、残り時間が6秒の時に処理を実行
        if (isClicked && Timemanagers.remaining == 6)
        {
            Debug.Log("ゲームクリア！");
            //textのようなUI系はSelializeFieldが一番良い


            Timemanagers timerManager = FindObjectOfType<Timemanagers>();

            if (timerManager != null)
            {
                timerManager.timerText.text = "ゲームクリア！";
                timerManager.isWorking = false;
            }

            isClicked = false; // フラグをリセットして再実行を防止
        }
    }



    private void OnMouseDown()
    {
        isClicked = true;
    }
}
