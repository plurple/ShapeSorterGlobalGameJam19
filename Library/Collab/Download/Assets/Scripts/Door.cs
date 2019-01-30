using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public ShapeType shapeType;
    public Material buttonColour;


    // Use this for initialization
    void Start()
    {
        IgnoreShapeType(shapeType);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void IgnoreShapeType(ShapeType type)
    {
        var shapes = FindObjectsOfType<Shape>();

        foreach (var shape in shapes)
        {
            if (shape.Type == type)
            {
                Physics.IgnoreCollision(shape.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
            }
            else
            {
                Physics.IgnoreCollision(shape.gameObject.GetComponent<Collider>(), GetComponent<Collider>(), false);
            }
        }
    }
}
