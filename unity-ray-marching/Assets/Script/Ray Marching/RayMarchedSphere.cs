﻿/******************************************************************************/
/*
  Project - Unity Ray Marching
            https://github.com/TheAllenChou/unity-ray-marching
  
  Author  - Ming-Lun "Allen" Chou
  Web     - http://AllenChou.net
  Twitter - @TheAllenChou
*/
/******************************************************************************/

using UnityEngine;

[ExecuteInEditMode]
public class RayMarchedSphere : RayMarchedShape
{
  [Min(0.0f)]
  public float Radius = 0.5f;

  protected override SdfShape Shape
  {
    get
    {
      return SdfShape.Sphere(transform.position, Radius);
    }
  }

  public override Aabb Bounds
  {
    get
    {
      return 
        new Aabb
        (
          transform.position - Radius * Vector3.one, 
          transform.position + Radius * Vector3.one
        );
    }
  }
}

