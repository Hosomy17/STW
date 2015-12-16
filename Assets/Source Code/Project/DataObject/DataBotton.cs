using UnityEngine;
using System.Collections;

public class DataBotton : DataObjectGeneric
{
    private Queue colors;

    void Awake()
    {
        colors = new Queue();

        colors.Enqueue("Blue");
        colors.Enqueue("Green");
        colors.Enqueue("Red");
        colors.Enqueue("Yellow");
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
