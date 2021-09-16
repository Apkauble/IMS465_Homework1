using UnityEngine;

public class GameManager : MonoBehaviour
{
    public const float ROW_HEIGHT = 0.48f;
    public const int PIECE_COUNT_PER_ROW = 13;
    public const float PIECE_LENGTH = 0.96f;
    public const int TOTAL_ROWS = 10;

    [SerializeField]
    private Transform pieces = null;

    [SerializeField]
    private GameObject piecePrefab = null;

    [SerializeField]
    private EdgeCollider2D border;


    //TODO
    //Using const data defined above "Instantiate" new pieces to fill the view with
    void Awake()
    {
        float ypos = 0;
        for(int i = 0; i < TOTAL_ROWS; i++)
        {
            float xpos = -6;
            for(int j = 0; j < PIECE_COUNT_PER_ROW; j++)
            {
                Instantiate(piecePrefab, new Vector3(xpos, ypos, 0), Quaternion.identity);
                xpos += PIECE_LENGTH;
            }
            ypos += ROW_HEIGHT;
        }
    }
}
