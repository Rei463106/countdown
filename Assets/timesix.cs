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
        // �N���b�N����Ă��邩�A�c�莞�Ԃ�6�b�̎��ɏ��������s
        if (isClicked && Timemanagers.remaining == 6)
        {
            Debug.Log("�Q�[���N���A�I");
            //text�̂悤��UI�n��SelializeField����ԗǂ�
            //���̉����C�����Ȃ��ƃ_�������c
            //6�b�ɂȂ��ă{�^�������������ʂɃQ�[���N���A�ƕ\���������c
            Timemanagers timerManager = FindObjectOfType<Timemanagers>();

            if (timerManager != null)
            {
                timerManager.timerText.text = "�Q�[���N���A�I"; // UI�ɕ\��
            }

            isClicked = false; // �t���O�����Z�b�g���čĎ��s��h�~
        }
    }



    private void OnMouseDown()
    {
        isClicked = true;
    }
}
