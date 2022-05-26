using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotateSpeed;
    public TankTypes tanktype;
    public Material color;

    public TankModel(float _movement, float _rotate, TankTypes tank, Material _color)
    {
        movementSpeed = _movement;
        rotateSpeed = _rotate;
        tanktype = tank;
        color = _color;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
