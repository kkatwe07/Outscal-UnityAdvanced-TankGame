using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotateSpeed;

    public TankModel(float _movement, float _rotate)
    {
        movementSpeed = _movement;
        rotateSpeed = _rotate;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
