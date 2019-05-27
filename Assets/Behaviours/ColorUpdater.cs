using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ColorUpdater : MonoBehaviour
{
    private IList<Material> _childMaterials;

    void Start()
    {
        _childMaterials = GetComponentsInChildren<MeshRenderer>()
            .Select(x => x.material).ToList();
    }

    public void SetColor(Color color)
    {
        foreach (var childMaterial in _childMaterials)
        {
            childMaterial.color = color;
        }
    }
}
