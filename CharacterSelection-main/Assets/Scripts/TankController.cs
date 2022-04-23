using UnityEngine;

public class TankController 
{
    private TankModel tankModel;

    private TankView tankview;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankview = _tankView;

        tankModel.SetTankController(this);
        tankview.SetTankController(this);

        GameObject.Instantiate(tankview.gameObject);
    }

}
