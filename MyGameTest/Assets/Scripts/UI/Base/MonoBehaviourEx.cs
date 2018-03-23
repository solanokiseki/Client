using UnityEngine;
using System.Collections;
namespace Hades.UI.Base
{
    public class MonoBehaviourEx : MonoBehaviour
    {

        public RectTransform RectTransform()
        {
            return transform as RectTransform;
        }
        public T FindComponent<T>(string path)
        {
            Transform tf = transform.Find(path);
            if (tf==null)
            {
                Debug.Log("找不到 " + path);
                return default(T);
            }
            return tf.GetComponent<T>();

        }
    }
}