using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvents : MonoBehaviour
{
    //private void OnMouseEnter()
    //{
    //    Debug.Log(name + "�̃R���C�_�[�͈͂Ƀ}�E�X������܂����B");
    //}

    //private void OnMouseOver()
    //{
    //    Debug.Log(name + "�̃R���C�_�[�͈͂Ƀ}�E�X�����葱���Ă��܂��B");
    //}

    //private void OnMouseExit()
    //{
    //    Debug.Log(name + "�̃R���C�_�[�͈͂���}�E�X���o�܂����B");
    //}

    private void OnMouseDown()
    {
        Debug.Log(name + "�̃R���C�_�[�͈͂Ń}�E�X����������܂����B");
    }
    private void OnMouseDrag()
    {
        Debug.Log(name + "�̃R���C�_�[�͈͂Ń}�E�X���h���b�O���J�n���܂����B");
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log(name + "�̃R���C�_�[�͈͂Ń}�E�X����������܂����B");
    }
    private void OnMouseUp()
    {
        Debug.Log(name + "����}�E�X����������܂����B");
    }
}
