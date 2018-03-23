using UnityEngine;
using UnityEngine.UI;
using System.Collections;
namespace Hades.UI.Base
{
    public class UIRoot : Widget<UIRoot>
    {
        public enum UIRootLayer
        {
            UL_TOP,
            UL_MIDDLE,
            UL_BOTTOM
        }
        static Transform _top;
        static Transform _middle;
        static Transform _bottom;

        public void Init()
        {
            _top = transform.Find("Canvas/Top");
            _middle = transform.Find("Canvas/Middle");
            _bottom = transform.Find("Canvas/Bottom");
        }

       static public Transform GetUILayer(UIRootLayer ul)
        {
            switch (ul)
            {
                case UIRootLayer.UL_TOP:
                    return _top;
                case UIRootLayer.UL_MIDDLE:
                    return _middle;
                case UIRootLayer.UL_BOTTOM:
                    return _bottom;
                default:
                    return null;
            }
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