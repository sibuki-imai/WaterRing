using UnityEngine;

[CreateAssetMenu(fileName = "LineData", menuName = "Game/LineData")]
public class LineData : ScriptableObject
{
    public Vector2 a = new Vector2(-2f, 1f);
    public Vector2 b = new Vector2(2f, 3f);

    public float tolerance = 0.2f;
}
