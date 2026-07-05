using UnityEngine;
public class RingController : MonoBehaviour
{
    public LineData line; // 共通データ

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void FloatRing()
    {
        rb.AddForce(new Vector2(30f, 250f));
    }

    public void TryFloatRing()
    {
        // ボールの位置（ワールド座標）
        Vector3 p = transform.position;

        // ラインの端点（ワールド座標）
        Vector3 a = line.a;
        Vector3 b = line.b;

        // ワールド座標同士で距離計算
        float distance = LineMath.DistancePointToLine(p, a, b);

        if (distance < line.tolerance)
        {
            FloatRing();
        }
        else
        {
            Debug.Log($"斜めライン外: 距離 {distance}");
        }
    }

}
