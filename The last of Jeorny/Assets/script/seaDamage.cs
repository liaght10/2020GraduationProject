using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seaDamage : MonoBehaviour
{
    public Slider HPSlider;
    static public bool isSea = false;
    public Text WarningText;

    // Start is called before the first frame update
    void Start()
    {
        WarningText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (HPSlider.value < 0.5f)
        {
            WarningText.enabled = true;
        }
        else if (HPSlider.value >= 0.5f)
        {
            WarningText.enabled = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag=="sea" && HPSlider.value > 0)
        {
            isSea = true;
            Player.isGround = false;
            HPSlider.value -= .00003f; // n값으로 설정 후 레벨에 따라 닳는 데미지가 다르게  // 아예 스크립트를 하나 만들어서 계산식 클래스 만들기
        }
        /*   
        if (HPSlider.value <= 0)
        {
            isGameOver = true;
        }*/

    }

    private void OnTriggerExit(Collider other2)
    {
       
        {
            isSea = false;
        }
    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "island")
        {
            HPSlider.value += .00036f;
        }
    }

}
