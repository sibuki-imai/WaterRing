using UnityEngine;

public static class LineMath
{
    // 点と線分の距離
    public static float DistancePointToLine(Vector3 p, Vector3 a, Vector3 b)
    {
        Vector3 ap = p - a;
        Vector3 ab = b - a;

        float dot = Vector3.Dot(ap, ab.normalized);
        Vector3 closest = a + ab.normalized * dot;

        return Vector3.Distance(p, closest);
    }

    // 線分の長さ
    public static float Length(Vector2 a, Vector2 b)
    {
        return (b - a).magnitude;
    }

    // 線分の角度（UI の回転用）
    public static float Angle(Vector2 a, Vector2 b)
    {
        Vector2 ab = b - a;
        return Mathf.Atan2(ab.y, ab.x) * Mathf.Rad2Deg;
    }

    // 線分の中点（UI の位置用）
    public static Vector2 MidPoint(Vector2 a, Vector2 b)
    {
        return (a + b) * 0.5f;
    }
}

