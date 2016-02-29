using UnityEngine;
using System.Collections;

public class ClassBotton : ClassGeneric
{
    private Queue colors;

    void Awake()
    {
        colors = new Queue();

        colors.Enqueue("Green");
        colors.Enqueue("Red");
        colors.Enqueue("Yellow");
        colors.Enqueue("Blue");
    }

    public string Colors
    {
        get
        {
            string color = this.colors.Dequeue() as string;
            this.colors.Enqueue(color);
            return color;
        }
    }
}
