using UnityEngine;

public class TankController 
{
    private Rigidbody rb;

    private TankModel tankModel;
    private TankView tankview;



    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankview = GameObject.Instantiate<TankView>(_tankView);
        rb = tankview.GetRigidbody();

        tankModel.SetTankController(this);
        tankview.SetTankController(this);

        tankview.ChangeColor(tankModel.color);
    }

    public void Move(float movement, float moveSpeed)
    {
        rb.velocity = tankview.transform.forward * movement * moveSpeed ;
    }

    public void Rotate(float rotate, float rotateSpeed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
