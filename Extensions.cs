using UnityEngine;
using UnityEngine.UI;

public static class Extensions
{
    public static bool IsNullOrEmpty(this string str)
    {
        return string.IsNullOrEmpty(str);
    }


    #region Transform

    public static void SetX(this Transform transform, float x)
    {
        var position = transform.position;
        position = new Vector3(x, position.y, position.z);
        transform.position = position;
    }

    public static void SetY(this Transform transform, float y)
    {
        var position = transform.position;
        position = new Vector3(position.x, y, position.z);
        transform.position = position;
    }

    public static void SetZ(this Transform transform, float z)
    {
        var position = transform.position;
        position = new Vector3(position.x, position.y, z);
        transform.position = position;
    }

    #endregion


    #region User Interface

    public static void SetAlpha(this MaskableGraphic graphic, float alpha)
    {
        var color = graphic.color;
        color.a = alpha;
        graphic.color = color;
    }

    #endregion
}