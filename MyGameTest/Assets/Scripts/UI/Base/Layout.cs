using UnityEngine;
using System.Collections.Generic;
using System.Collections;
namespace Hades.UI.Base
{
    public class Layout
    {
        List<Component> _widgets = new List<Component>();

         public void SinkWidget<T>(T widget) where T : Component
        {

        }
         public void PushLayout(Component widget)
        {
            if (_widgets.Contains(widget))
            {
                return;
            }
            System.Type tp = widget.GetType();
            GameObject go = new GameObject(tp.Name+"Layout");
            RectTransform rt = go.AddComponent<RectTransform>();

            Utils.SetParent(UIRoot.GetUILayer(UIRoot.UIRootLayer.UL_MIDDLE), go.transform);
            rt.anchorMax = Vector2.one;
            rt.anchorMin = Vector2.zero;
            rt.pivot = Vector2.one * 0.5f;
            rt.anchoredPosition3D = Vector3.zero;
            rt.offsetMin = Vector2.zero;
            rt.offsetMax = Vector2.zero;
            Utils.SetParent(go.transform, widget.transform);
            _widgets.Add(widget);
        }

    }
}