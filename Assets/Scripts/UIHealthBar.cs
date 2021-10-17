using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHealthBar : MonoBehaviour
{
    public Image mask;
    float originalSize;

    // Start is called before the first frame update
    void Start()
    {
        originalSize = mask.rectTransform.rect.width;



    }
    public void SetValue(float value)
    {

mask.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, originalSize * value);
    }
}
