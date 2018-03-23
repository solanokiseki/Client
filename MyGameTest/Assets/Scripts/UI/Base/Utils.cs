using UnityEngine;
using System.Collections;
namespace Hades.UI.Base
{
    static public class Utils
    {
        static public void SetParent(Transform parent, Transform child)
        {
            child.SetParent(parent);
            RectTransform rt = child as RectTransform;
            rt.anchoredPosition3D = Vector3.zero;
            rt.localRotation =Quaternion.identity;
            rt.localScale = Vector3.one;
        }

        static public T FindComponentInChild<T>(this Transform tf,string path)
        {
            Transform tfchild = tf.Find(path);
            T t = tfchild.GetComponent<T>();
            return t;
        }
    }
}