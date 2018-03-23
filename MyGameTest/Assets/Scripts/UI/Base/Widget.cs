using System.Reflection;
using UnityEngine;

namespace Hades.UI.Base
{
    public class Widget<T> : MonoBehaviourEx where T:Widget<T>
    {
        public static T Create(string path = "")
        {
            if (path == "")
            {
                path = "Prefabs/";
                path += typeof(T).Namespace;
                path += "/" + typeof(T).Name;
                path = path.Replace('.','/');
                path = path.Replace("/Hades/","/");
            }
            GameObject go = Resources.Load(path) as GameObject;
            T compment= Instantiate(go).AddComponent<T>();
            return compment;
        }

        public void PushLayout()
        {
            Layout.PushLayout(this);
        }

        public static void SinkWidget()
        {


        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}