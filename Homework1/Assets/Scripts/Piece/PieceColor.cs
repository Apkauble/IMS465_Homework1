using UnityEngine;

public class PieceColor : MonoBehaviour
{
    [SerializeField]
    private Sprite blueColor;
    [SerializeField]
    private Sprite redColor;
    [SerializeField]
    private Sprite greenColor;
    [SerializeField]
    private Sprite purpleColor;
    [SerializeField]
    private Sprite goldColor;
    [SerializeField]
    private Sprite greyColor;
    [SerializeField]
    private Sprite brownColor;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        ChooseColor();
    }

    private void ChooseColor()
    {
        //TODO
        // set spriteRenderer.sprite to a random sprite that is present above
        Sprite[] sprites = new Sprite[7];
        sprites[0] = blueColor;
        sprites[1] = redColor;
        sprites[2] = greenColor;
        sprites[3] = purpleColor;
        sprites[4] = goldColor;
        sprites[5] = greyColor;
        sprites[6] = brownColor;

        int rand = UnityEngine.Random.Range(0, 6);

        spriteRenderer.sprite = sprites[rand];
    }
}
