using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvents : MonoBehaviour
{
    //private void OnMouseEnter()
    //{
    //    Debug.Log(name + "のコライダー範囲にマウスが入りました。");
    //}

    //private void OnMouseOver()
    //{
    //    Debug.Log(name + "のコライダー範囲にマウスが入り続けています。");
    //}

    //private void OnMouseExit()
    //{
    //    Debug.Log(name + "のコライダー範囲からマウスが出ました。");
    //}

    private void OnMouseDown()
    {
        Debug.Log(name + "のコライダー範囲でマウス左が押されました。");
    }
    private void OnMouseDrag()
    {
        Debug.Log(name + "のコライダー範囲でマウス左ドラッグを開始しました。");
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log(name + "のコライダー範囲でマウス左が離されました。");
    }
    private void OnMouseUp()
    {
        Debug.Log(name + "からマウス左が離されました。");
    }
}
