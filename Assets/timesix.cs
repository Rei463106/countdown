using UnityEngine;

public class timesix : MonoBehaviour
{
    private bool isClicked = false;

    void Start()
    {

    }





    void Update()
    {
        // �N���b�N����Ă��邩�A�c�莞�Ԃ�6�b�̎��ɏ��������s
        if (isClicked && Timemanagers.remaining == 6)
        {
            Debug.Log("�Q�[���N���A�I");
            //text�̂悤��UI�n��SelializeField����ԗǂ�


            Timemanagers timerManager = FindObjectOfType<Timemanagers>();

            if (timerManager != null)
            {
                timerManager.timerText.text = "�Q�[���N���A�I";
                timerManager.isWorking = false;
            }

            isClicked = false; // �t���O�����Z�b�g���čĎ��s��h�~
        }
    }



    private void OnMouseDown()
    {
        isClicked = true;
    }
}
