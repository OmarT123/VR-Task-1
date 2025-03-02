using UnityEngine;
using UnityEngine.UI;

public class ChangeImageColor : MonoBehaviour
{
    public Image image;
    public Color color1 = Color.red;
    public Color color2 = Color.blue;

    public void ChangeColor()
    {
        if (image.color == color1)
        {
            image.color = color2;
        }
        else
        {
            image.color = color1;
        }
    }
}
