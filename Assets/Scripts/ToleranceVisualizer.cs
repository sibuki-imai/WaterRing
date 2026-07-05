using UnityEngine;

public class ToleranceVisualizer : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // 緑の帯
    public LineData line;

    void Start()
    {
        Vector2 a = line.a;
        Vector2 b = line.b;

        float length = LineMath.Length(a, b);
        float angle = LineMath.Angle(a, b);
        Vector2 mid = LineMath.MidPoint(a, b);

        // 位置（ワールド座標）
        transform.position = mid;

        // 回転（ワールド座標）
        transform.rotation = Quaternion.Euler(0, 0, angle);

        // スケール（ワールド座標）
        transform.localScale = new Vector3(length, line.tolerance * 2f, 1f);
    }
}
